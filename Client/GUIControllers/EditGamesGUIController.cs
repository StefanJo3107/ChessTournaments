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
    internal class EditGamesGUIController
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static EditGamesGUIController instance;

        public static EditGamesGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EditGamesGUIController();
                }
                return instance;
            }
        }

        private EditGamesGUIController()
        {
        }

        private FrmEditGames frmEditGames;
        private Tournament currentTournament;

        internal void ShowFrmEditGames(Tournament currentTournament)
        {
            this.currentTournament = currentTournament;
            frmEditGames = new FrmEditGames();
            frmEditGames.AutoSize = true;
            frmEditGames.ShowDialog();
        }

        internal void InitForm(object sender, EventArgs e)
        {
            InitCreatePanel();
            frmEditGames.GamesModal.LblTitle.Text = "Izmeni partije";
            frmEditGames.GamesModal.BtnSave.Text = "Sačuvaj";
            frmEditGames.GamesModal.BtnAdd.Text = "Izmeni";
            frmEditGames.GamesModal.LblError.Text = "";
        }

        internal void InitCreatePanel()
        {
            Session.games.Clear();
            PopulateListbox();
        }

        internal void DragForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(frmEditGames.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        internal void FormClosed(object sender, EventArgs e)
        {

        }

        internal void EditButtonClicked(object sender, EventArgs e)
        {
            EditGameGUIController.Instance.ShowFrmEditGame(Session.games[frmEditGames.GamesModal.LbGames.SelectedIndex], currentTournament);
            RepopulateListbox();
        }

        internal void PopulateListbox()
        {
            List<Game> games = (List<Game>)Communication.Instance.GetAllGames(currentTournament).Result;
            Session.games = new System.ComponentModel.BindingList<Game>(games);
            frmEditGames.GamesModal.LbGames.DataSource = null;
            frmEditGames.GamesModal.LbGames.DataSource = Session.games;
            frmEditGames.GamesModal.LbGames.DisplayMember = "Summary";
        }

        internal void RepopulateListbox()
        {
            frmEditGames.GamesModal.LbGames.DataSource = null;
            frmEditGames.GamesModal.LbGames.DataSource = Session.games;
            frmEditGames.GamesModal.LbGames.DisplayMember = "Summary";
        }

        internal void SaveButtonClicked(object sender, EventArgs e)
        {
            Response response = Communication.Instance.EditGames(Session.games.ToList());
            if (response.Exception == null && response.Result != null && (bool)response.Result == true)
            {
                MessageBox.Show("Uspešno izmenjene partije");
                frmEditGames.Close();
            }
            else
            {
                frmEditGames.GamesModal.LblError.Text = "Greška prilikom izmene partija";
            }
        }
    }
}
