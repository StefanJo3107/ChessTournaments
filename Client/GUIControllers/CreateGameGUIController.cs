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
    internal class CreateGameGUIController
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static CreateGameGUIController instance;

        public static CreateGameGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CreateGameGUIController();
                }
                return instance;
            }
        }

        private CreateGameGUIController()
        {
        }

        private FrmCreateGame frmCreateGame;
        private Tournament currentTournament;

        internal void ShowFrmCreateGame(Tournament currentTournament)
        {
            this.currentTournament = currentTournament;
            frmCreateGame = new FrmCreateGame();
            frmCreateGame.AutoSize = true;
            frmCreateGame.ShowDialog();
        }

        internal void InitForm(object sender, EventArgs e)
        {
            InitCreatePanel();
            frmCreateGame.GameModal.LblTitle.Text = "Kreiraj partiju";
            frmCreateGame.GameModal.BtnSave.Text = "Kreiraj";
            frmCreateGame.GameModal.LblError.Text = "";
            frmCreateGame.GameModal.NumRunda.Minimum = 1;
            frmCreateGame.GameModal.NumRunda.Maximum = currentTournament.Rounds;
        }

        internal void InitCreatePanel()
        {
            frmCreateGame.GameModal.PnlShadow.BackColor = Color.FromArgb(60, 0, 0, 0);
            var players = (List<Player>)Communication.Instance.GetAllPlayers().Result;
            frmCreateGame.GameModal.CbBeli.DataSource = players;
            frmCreateGame.GameModal.CbBeli.DisplayMember = "FullName";
            frmCreateGame.GameModal.CbBeli.ValueMember = "Self";
            players = (List<Player>)Communication.Instance.GetAllPlayers().Result;
            frmCreateGame.GameModal.CbCrni.DataSource = players;
            frmCreateGame.GameModal.CbCrni.DisplayMember = "FullName";
            frmCreateGame.GameModal.CbCrni.ValueMember = "Self";
        }

        internal void DragForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(frmCreateGame.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        internal void FormClosed(object sender, EventArgs e)
        {

        }


        internal void CreateButtonClicked(object sender, EventArgs e)
        {
            frmCreateGame.GameModal.LblError.Text = "";

            if (frmCreateGame.GameModal.TbOtvaranje.Text == "" || frmCreateGame.GameModal.TbRezultat.Text == "" || frmCreateGame.GameModal.TbFEN.Text == "")
            {
                frmCreateGame.GameModal.LblError.Text = "Polja ne smeju biti prazna";
                return;
            }

            if (frmCreateGame.GameModal.CbBeli.SelectedItem == frmCreateGame.GameModal.CbCrni.SelectedItem)
            {
                frmCreateGame.GameModal.LblError.Text = "Beli i crni šahista moraju biti različiti";
                return;
            }

            if (frmCreateGame.GameModal.DtDatum.Value < DateTime.Parse(currentTournament.Date.Split(' ')[0]) || frmCreateGame.GameModal.DtDatum.Value > DateTime.Parse(currentTournament.Date.Split(' ')[1]))
            {
                frmCreateGame.GameModal.LblError.Text = "Datum partije mora biti izmedju početka i završetka turnira";
                return;
            }

            Game game = new Game
            {
                Opening = frmCreateGame.GameModal.TbOtvaranje.Text,
                Result = frmCreateGame.GameModal.TbRezultat.Text,
                Pgn = frmCreateGame.GameModal.TbFEN.Text,
                White = (Player)frmCreateGame.GameModal.CbBeli.SelectedItem,
                Black = (Player)frmCreateGame.GameModal.CbCrni.SelectedItem,
                Round = (int)frmCreateGame.GameModal.NumRunda.Value,
                Date = frmCreateGame.GameModal.DtDatum.Value.ToString("yyyy-MM-dd"),
                Tournament = currentTournament
            };

            Session.games.Add(game);
        }
    }
}
