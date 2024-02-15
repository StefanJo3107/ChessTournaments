using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.UserControls;
using Common.Communication;
using Common.Domain;

namespace Client.GUIControllers
{
    internal class CreatePlayerGUIController
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static CreatePlayerGUIController instance;

        public static CreatePlayerGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CreatePlayerGUIController();
                }
                return instance;
            }
        }

        private CreatePlayerGUIController()
        {
        }

        private FrmCreatePlayer frmCreatePlayer;

        internal void ShowFrmCreatePlayer()
        {
            frmCreatePlayer = new FrmCreatePlayer();
            frmCreatePlayer.AutoSize = true;
            frmCreatePlayer.ShowDialog();
        }

        internal void InitForm(object sender, EventArgs e)
        {
            InitCreatePanel();
            frmCreatePlayer.PlayerModal.LblTitle.Text = "Kreiraj šahistu";
            frmCreatePlayer.PlayerModal.BtnSave.Text = "Kreiraj";
            frmCreatePlayer.PlayerModal.LblError.Text = "";
        }

        internal void InitCreatePanel()
        {
            frmCreatePlayer.PlayerModal.PnlShadow.BackColor = Color.FromArgb(60, 0, 0, 0);
            frmCreatePlayer.PlayerModal.CbLokacija.DataSource = (List<Location>)Communication.Instance.GetAllLocations().Result;
            frmCreatePlayer.PlayerModal.CbLokacija.DisplayMember = "Name";
            frmCreatePlayer.PlayerModal.CbLokacija.ValueMember = "Self";
            frmCreatePlayer.PlayerModal.CbTitula.DataSource = Enum.GetValues(typeof(FIDETitle));
        }

        internal void DragForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(frmCreatePlayer.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        internal void FormClosed(object sender, EventArgs e)
        {

        }


        internal void CreateButtonClicked(object sender, EventArgs e)
        {
            frmCreatePlayer.PlayerModal.LblError.Text = "";

            if (frmCreatePlayer.PlayerModal.TbIme.Text == "" || frmCreatePlayer.PlayerModal.TbPrezime.Text == "" || frmCreatePlayer.PlayerModal.TbSlika.Text == "")
            {
                frmCreatePlayer.PlayerModal.LblError.Text = "Polja ne smeju biti prazna";
                return;
            }


            Player player = new Player
            {
                Name = frmCreatePlayer.PlayerModal.TbIme.Text,
                Surname = frmCreatePlayer.PlayerModal.TbPrezime.Text,
                ELO = (int)frmCreatePlayer.PlayerModal.NumELO.Value,
                Title = ((FIDETitle)frmCreatePlayer.PlayerModal.CbTitula.SelectedValue).ToString(),
                ImageURL = frmCreatePlayer.PlayerModal.TbSlika.Text,
                Location = (Location)frmCreatePlayer.PlayerModal.CbLokacija.SelectedValue,
            };

            Response response = Communication.Instance.CreatePlayer(player);
            if (response.Exception == null && response.Result != null && (bool)response.Result == true)
            {
                MessageBox.Show("Uspešno kreiran šahista");
                frmCreatePlayer.Close();
            }
            else
            {
                frmCreatePlayer.PlayerModal.LblError.Text = "Greška prilikom kreiranja šahiste";
            }
        }
    }
}
