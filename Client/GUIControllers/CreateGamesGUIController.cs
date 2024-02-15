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
    internal class CreateGamesGUIController
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static CreateGamesGUIController instance;

        public static CreateGamesGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CreateGamesGUIController();
                }
                return instance;
            }
        }

        private CreateGamesGUIController()
        {
        }

        private FrmCreateGames frmCreateGames;
        private Tournament currentTournament;

        internal void ShowFrmCreateGames(Tournament currentTournament)
        {
            this.currentTournament = currentTournament;
            frmCreateGames = new FrmCreateGames();
            frmCreateGames.AutoSize = true;
            frmCreateGames.ShowDialog();
        }

        internal void InitForm(object sender, EventArgs e)
        {
            InitCreatePanel();
            frmCreateGames.GamesModal.LblTitle.Text = "Kreiraj partije";
            frmCreateGames.GamesModal.BtnSave.Text = "Kreiraj";
            frmCreateGames.GamesModal.BtnAdd.Text = "Dodaj";
            frmCreateGames.GamesModal.LblError.Text = "";
        }

        internal void InitCreatePanel()
        {
            Session.games.Clear();
            PopulateListbox();
        }

        internal void DragForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(frmCreateGames.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        internal void FormClosed(object sender, EventArgs e)
        {

        }

        internal void AddButtonClicked(object sender, EventArgs e)
        {
            CreateGameGUIController.Instance.ShowFrmCreateGame(currentTournament);
        }

        internal void PopulateListbox()
        {
            frmCreateGames.GamesModal.LbGames.DataSource = null;
            frmCreateGames.GamesModal.LbGames.DataSource = Session.games;
            frmCreateGames.GamesModal.LbGames.DisplayMember = "Summary";
        }

        internal void CreateButtonClicked(object sender, EventArgs e)
        {
            Response response = Communication.Instance.CreateGames(Session.games.ToList());
            if (response.Exception == null && response.Result != null && (bool)response.Result == true)
            {
                MessageBox.Show("Uspešno kreirane partije");
                frmCreateGames.Close();
            }
            else
            {
                frmCreateGames.GamesModal.LblError.Text = "Greška prilikom kreiranja partija";
            }
        }
    }
}
