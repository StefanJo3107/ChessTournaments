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
    internal class EditPlayerGUIController
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static EditPlayerGUIController instance;

        public static EditPlayerGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EditPlayerGUIController();
                }
                return instance;
            }
        }

        private EditPlayerGUIController()
        {
        }

        private FrmEditPlayer frmEditPlayer;
        private Player currentPlayer;

        internal void ShowFrmEditPlayer(Player player)
        {
            frmEditPlayer = new FrmEditPlayer();
            frmEditPlayer.AutoSize = true;
            currentPlayer = player;
            frmEditPlayer.ShowDialog();
        }

        internal void InitForm(object sender, EventArgs e)
        {
            InitCreatePanel();
            frmEditPlayer.PlayerModal.LblTitle.Text = "Izmeni šahistu";
            frmEditPlayer.PlayerModal.BtnSave.Text = "Izmeni";
            frmEditPlayer.PlayerModal.LblError.Text = "";
            frmEditPlayer.PlayerModal.TbIme.Text = currentPlayer.Name;
            frmEditPlayer.PlayerModal.TbPrezime.Text = currentPlayer.Surname;
            frmEditPlayer.PlayerModal.TbSlika.Text = currentPlayer.ImageURL;
            frmEditPlayer.PlayerModal.NumELO.Value = currentPlayer.ELO;
            frmEditPlayer.PlayerModal.CbLokacija.SelectedValue = currentPlayer.Location;
            if(Enum.TryParse(currentPlayer.Title, out FIDETitle title))
            {
                frmEditPlayer.PlayerModal.CbTitula.SelectedItem = title;
            }
        }

        internal void InitCreatePanel()
        {
            frmEditPlayer.PlayerModal.PnlShadow.BackColor = Color.FromArgb(60, 0, 0, 0);
            frmEditPlayer.PlayerModal.CbLokacija.DataSource = (List<Location>)Communication.Instance.GetAllLocations().Result;
            frmEditPlayer.PlayerModal.CbLokacija.DisplayMember = "Name";
            frmEditPlayer.PlayerModal.CbLokacija.ValueMember = "Self";
            frmEditPlayer.PlayerModal.CbTitula.DataSource = Enum.GetValues(typeof(FIDETitle));
        }

        internal void DragForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(frmEditPlayer.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        internal void FormClosed(object sender, EventArgs e)
        {

        }


        internal void EditButtonClicked(object sender, EventArgs e)
        {
            frmEditPlayer.PlayerModal.LblError.Text = "";

            if (frmEditPlayer.PlayerModal.TbIme.Text == "" || frmEditPlayer.PlayerModal.TbPrezime.Text == "" || frmEditPlayer.PlayerModal.TbSlika.Text == "")
            {
                frmEditPlayer.PlayerModal.LblError.Text = "Polja ne smeju biti prazna";
                return;
            }


            Player player = new Player
            {
                Name = frmEditPlayer.PlayerModal.TbIme.Text,
                Surname = frmEditPlayer.PlayerModal.TbPrezime.Text,
                ELO = (int)frmEditPlayer.PlayerModal.NumELO.Value,
                Title = ((FIDETitle)frmEditPlayer.PlayerModal.CbTitula.SelectedValue).ToString(),
                ImageURL = frmEditPlayer.PlayerModal.TbSlika.Text,
                Location = (Location)frmEditPlayer.PlayerModal.CbLokacija.SelectedValue,
                Id = currentPlayer.Id
            };

            Response response = Communication.Instance.EditPlayer(player);
            if (response.Exception == null && response.Result != null && (bool)response.Result == true)
            {
                MessageBox.Show("Uspešno izmenjen šahista");
                frmEditPlayer.Close();
            }
            else
            {
                frmEditPlayer.PlayerModal.LblError.Text = "Greška prilikom izmene šahiste";
            }
        }
    }
}
