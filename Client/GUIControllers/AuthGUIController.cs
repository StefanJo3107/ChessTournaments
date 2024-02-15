using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.UserControls;
using Common.Communication;
using Common.Domain;

namespace Client.GUIControllers
{
    public class AuthGUIController
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static AuthGUIController instance;

        public static AuthGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AuthGUIController();
                }
                return instance;
            }
        }

        private AuthGUIController()
        {
        }

        private FrmAuth frmAuth;

        enum State
        {
            Login,
            Register
        }

        State pageState = State.Login;

        internal void ShowFrmAuth()
        {
            Communication.Instance.Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmAuth = new FrmAuth();
            frmAuth.AutoSize = true;
            Application.Run(frmAuth);
        }

        internal void InitForm(object sender, EventArgs e)
        {
            frmAuth.BackColor = ColorTranslator.FromHtml("#1a202c");
            frmAuth.LoginPanel.BackColor = ColorTranslator.FromHtml("#161b25");
            frmAuth.PnlShadow.BackColor = Color.FromArgb(60, 0, 0, 0);
        }

        internal void DragForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(frmAuth.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        internal void FormClosed(object sender, EventArgs e)
        {
            Communication.Instance.Disconnect();
            Communication.Instance.Stop();
        }

        internal void InitLoginPanel(object sender, EventArgs e)
        {
            frmAuth.LoginPanel.TbUsername.BackColor = ColorTranslator.FromHtml("#1a202c");
            frmAuth.LoginPanel.TbPassword.BackColor = ColorTranslator.FromHtml("#1a202c");
            frmAuth.LoginPanel.LblGreska.Text = "";
        }

        internal void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAuth.LoginPanel.LblGreska.Text = "";
            frmAuth.LoginPanel.TbUsername.Text = "";
            frmAuth.LoginPanel.TbPassword.Text = "";

            if (pageState == State.Login)
            {
                pageState = State.Register;
                frmAuth.LoginPanel.LblPoruka.Text = "Imaš nalog?";
                frmAuth.LoginPanel.LblLink.Text = "Prijavi se";
                frmAuth.LoginPanel.LblNaslov.Text = "Registruj se";
                frmAuth.LoginPanel.BtnLogin.Text = "Registruj se";
            }
            else
            {
                pageState = State.Login;
                frmAuth.LoginPanel.LblPoruka.Text = "Nemaš nalog?";
                frmAuth.LoginPanel.LblLink.Text = "Registruj se";
                frmAuth.LoginPanel.LblNaslov.Text = "Prijavi se";
                frmAuth.LoginPanel.BtnLogin.Text = "Prijavi se";
            }
        }

        internal void LoginButtonClicked(object sender, EventArgs e)
        {
            frmAuth.LoginPanel.LblGreska.Text = "";

            if(pageState == State.Login)
            {
                Login(sender, e);
            }
            else
            {
                Register(sender, e);
            }
        }   

        internal void Login(object sender, EventArgs e)
        {
            User user = new User
            {
                Username = frmAuth.LoginPanel.TbUsername.Text,
                Password = frmAuth.LoginPanel.TbPassword.Text,
            };

            if (user.Username == "" || user.Password == "")
            {
                frmAuth.LoginPanel.LblGreska.Text = "Polja ne smeju biti prazna";
                return;
            }

            Response response = Communication.Instance.Login(user);
            if (response.Exception == null && response.Result != null)
            {
                frmAuth.Visible = false;
                Session.activeUser = user;
                MainGUIController.Instance.ShowFrmMain();
                frmAuth.Close();
            }
            else
            {
                frmAuth.LoginPanel.LblGreska.Text = "Greška prilikom prijave";
            }
        }

        internal void Register(object sender, EventArgs e)
        {
            User user = new User
            {
                Username = frmAuth.LoginPanel.TbUsername.Text,
                Password = frmAuth.LoginPanel.TbPassword.Text,
            };

            if (user.Username == "" || user.Password == "")
            {
                frmAuth.LoginPanel.LblGreska.Text = "Polja ne smeju biti prazna";
                return;
            }

            Response response = Communication.Instance.Register(user);
            if (response.Exception == null && response.Result != null)
            {
                frmAuth.Visible = false;
                MainGUIController.Instance.ShowFrmMain();
            }
            else
            {
                frmAuth.LoginPanel.LblGreska.Text = "Neispravni kredencijali";
            }
        }
    }
}

