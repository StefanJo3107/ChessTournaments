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
    internal class EditTournamentGUIController
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static EditTournamentGUIController instance;

        public static EditTournamentGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EditTournamentGUIController();
                }
                return instance;
            }
        }

        private EditTournamentGUIController()
        {
        }

        private FrmEditTournament frmEditTournament;
        private Tournament currentTournament;

        internal void ShowFrmEditTournament(Tournament tournament)
        {
            frmEditTournament = new FrmEditTournament();
            currentTournament = tournament;
            frmEditTournament.AutoSize = true;
            frmEditTournament.ShowDialog();
        }

        internal void InitForm(object sender, EventArgs e)
        {
            InitEditPanel();
            frmEditTournament.TournamentForm.LblTitle.Text = "Izmeni turnir";
            frmEditTournament.TournamentForm.BtnSave.Text = "Izmeni";
            frmEditTournament.TournamentForm.LblError.Text = "";
            frmEditTournament.TournamentForm.TbNaziv.Text = currentTournament.Name;
            frmEditTournament.TournamentForm.TbSlika.Text = currentTournament.ImageURL;
            frmEditTournament.TournamentForm.NumRunde.Value = currentTournament.Rounds;
            frmEditTournament.TournamentForm.DtPocetak.Value = DateTime.Parse(currentTournament.Date.Split(' ')[0]);
            frmEditTournament.TournamentForm.DtZavrsetak.Value = DateTime.Parse(currentTournament.Date.Split(' ')[1]);
        }

        internal void InitEditPanel()
        {
            frmEditTournament.TournamentForm.PnlShadow.BackColor = Color.FromArgb(60, 0, 0, 0);
            frmEditTournament.TournamentForm.CbLokacija.DataSource = (List<Location>)Communication.Instance.GetAllLocations().Result;
            frmEditTournament.TournamentForm.CbLokacija.DisplayMember = "Name";
            frmEditTournament.TournamentForm.CbLokacija.ValueMember = "Self";
            frmEditTournament.TournamentForm.CbLokacija.SelectedValue = currentTournament.Location;
            frmEditTournament.TournamentForm.CbTip.DataSource = (List<TournamentType>)Communication.Instance.GetAllTournamentTypes().Result;
            frmEditTournament.TournamentForm.CbTip.DisplayMember = "Name";
            frmEditTournament.TournamentForm.CbTip.ValueMember = "Self";
            frmEditTournament.TournamentForm.CbTip.SelectedValue = currentTournament.TournamentType;
        }

        internal void DragForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(frmEditTournament.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        internal void FormClosed(object sender, EventArgs e)
        {

        }


        internal void EditButtonClicked(object sender, EventArgs e)
        {
            frmEditTournament.TournamentForm.LblError.Text = "";

            if (frmEditTournament.TournamentForm.TbNaziv.Text == "" || frmEditTournament.TournamentForm.TbSlika.Text == "")
            {
                frmEditTournament.TournamentForm.LblError.Text = "Polja ne smeju biti prazna";
                return;
            }

            if (frmEditTournament.TournamentForm.DtPocetak.Value > frmEditTournament.TournamentForm.DtZavrsetak.Value)
            {
                frmEditTournament.TournamentForm.LblError.Text = "Datum početka mora biti pre datuma završetka";
                return;
            }

            Tournament tournament = new Tournament
            {
                Id = currentTournament.Id,
                Name = frmEditTournament.TournamentForm.TbNaziv.Text,
                ImageURL = frmEditTournament.TournamentForm.TbSlika.Text,
                Rounds = (int)frmEditTournament.TournamentForm.NumRunde.Value,
                Location = (Location)frmEditTournament.TournamentForm.CbLokacija.SelectedValue,
                TournamentType = (TournamentType)frmEditTournament.TournamentForm.CbTip.SelectedValue,
                Date = frmEditTournament.TournamentForm.DtPocetak.Value.ToString("yyyy-MM-dd") + " " + frmEditTournament.TournamentForm.DtZavrsetak.Value.ToString("yyyy-MM-dd")
            };

            Response response = Communication.Instance.EditTournament(tournament);
            if (response.Exception == null && response.Result != null && (bool)response.Result == true)
            {
                MessageBox.Show("Uspešno izmenjen turnir");
                frmEditTournament.Close();
            }
            else
            {
                frmEditTournament.TournamentForm.LblError.Text = "Greška prilikom izmene turnira";
            }
        }
    }
}
