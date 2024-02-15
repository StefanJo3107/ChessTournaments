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
    internal class CreateTournamentGUIController
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static CreateTournamentGUIController instance;

        public static CreateTournamentGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CreateTournamentGUIController();
                }
                return instance;
            }
        }

        private CreateTournamentGUIController()
        {
        }

        private FrmCreateTournament frmCreateTournament;

        internal void ShowFrmCreateTournament()
        {
            frmCreateTournament = new FrmCreateTournament();
            frmCreateTournament.AutoSize = true;
            frmCreateTournament.ShowDialog();
        }

        internal void InitForm(object sender, EventArgs e)
        {
            InitCreatePanel();
            frmCreateTournament.TournamentForm.LblTitle.Text = "Kreiraj turnir";
            frmCreateTournament.TournamentForm.BtnSave.Text = "Kreiraj";
            frmCreateTournament.TournamentForm.LblError.Text = "";
        }

        internal void InitCreatePanel()
        {
            frmCreateTournament.TournamentForm.PnlShadow.BackColor = Color.FromArgb(60, 0, 0, 0);
            frmCreateTournament.TournamentForm.CbLokacija.DataSource = (List<Location>)Communication.Instance.GetAllLocations().Result;
            frmCreateTournament.TournamentForm.CbLokacija.DisplayMember = "Name";
            frmCreateTournament.TournamentForm.CbLokacija.ValueMember = "Self";
            frmCreateTournament.TournamentForm.CbTip.DataSource = (List<TournamentType>)Communication.Instance.GetAllTournamentTypes().Result;
            frmCreateTournament.TournamentForm.CbTip.DisplayMember = "Name";
            frmCreateTournament.TournamentForm.CbTip.ValueMember = "Self";
        }

        internal void DragForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(frmCreateTournament.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        internal void FormClosed(object sender, EventArgs e)
        {

        }


        internal void CreateButtonClicked(object sender, EventArgs e)
        {
            frmCreateTournament.TournamentForm.LblError.Text = "";

            if (frmCreateTournament.TournamentForm.TbNaziv.Text == "" || frmCreateTournament.TournamentForm.TbSlika.Text == "")
            {
                frmCreateTournament.TournamentForm.LblError.Text = "Polja ne smeju biti prazna";
                return;
            }

            if (frmCreateTournament.TournamentForm.DtPocetak.Value > frmCreateTournament.TournamentForm.DtZavrsetak.Value)
            {
                frmCreateTournament.TournamentForm.LblError.Text = "Datum početka mora biti pre datuma završetka";
                return;
            }

            Tournament tournament = new Tournament
            {
                Name = frmCreateTournament.TournamentForm.TbNaziv.Text,
                ImageURL = frmCreateTournament.TournamentForm.TbSlika.Text,
                Rounds = (int)frmCreateTournament.TournamentForm.NumRunde.Value,
                Location = (Location)frmCreateTournament.TournamentForm.CbLokacija.SelectedValue,
                TournamentType = (TournamentType)frmCreateTournament.TournamentForm.CbTip.SelectedValue,
                Date = frmCreateTournament.TournamentForm.DtPocetak.Value.ToString("yyyy-MM-dd") + " " + frmCreateTournament.TournamentForm.DtZavrsetak.Value.ToString("yyyy-MM-dd")
            };

            Response response = Communication.Instance.CreateTournament(tournament);
            if (response.Exception == null && response.Result != null && (bool)response.Result == true)
            {
                MessageBox.Show("Uspešno kreiran turnir");
                frmCreateTournament.Close();
            }
            else
            {
                frmCreateTournament.TournamentForm.LblError.Text = "Greška prilikom kreiranja turnira";
            }
        }
    }
}
