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
    internal class EditGameGUIController
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static EditGameGUIController instance;

        public static EditGameGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EditGameGUIController();
                }
                return instance;
            }
        }

        private EditGameGUIController()
        {
        }

        private FrmEditGame frmEditGame;
        private Tournament currentTournament;
        private Game game;

        internal void ShowFrmEditGame(Game game, Tournament currentTournament)
        {
            this.currentTournament = currentTournament;
            this.game = game;
            frmEditGame = new FrmEditGame();
            frmEditGame.AutoSize = true;
            frmEditGame.ShowDialog();
        }

        internal void InitForm(object sender, EventArgs e)
        {
            InitCreatePanel();
            frmEditGame.GameModal.LblTitle.Text = "Izmeni partiju";
            frmEditGame.GameModal.BtnSave.Text = "Izmeni";
            frmEditGame.GameModal.LblError.Text = "";
            frmEditGame.GameModal.NumRunda.Minimum = 1;
            frmEditGame.GameModal.NumRunda.Maximum = currentTournament.Rounds;
            frmEditGame.GameModal.TbFEN.Text = game.Pgn;
            frmEditGame.GameModal.TbOtvaranje.Text = game.Opening;
            frmEditGame.GameModal.TbRezultat.Text = game.Result;
            frmEditGame.GameModal.DtDatum.Value = DateTime.Parse(game.Date);
            frmEditGame.GameModal.NumRunda.Value = game.Round;
            frmEditGame.GameModal.CbBeli.SelectedValue = game.White;
            frmEditGame.GameModal.CbCrni.SelectedValue = game.Black;
        }

        internal void InitCreatePanel()
        {
            frmEditGame.GameModal.PnlShadow.BackColor = Color.FromArgb(60, 0, 0, 0);
            var players = (List<Player>)Communication.Instance.GetAllPlayers().Result;
            frmEditGame.GameModal.CbBeli.DataSource = players;
            frmEditGame.GameModal.CbBeli.DisplayMember = "FullName";
            frmEditGame.GameModal.CbBeli.ValueMember = "Self";
            players = (List<Player>)Communication.Instance.GetAllPlayers().Result;
            frmEditGame.GameModal.CbCrni.DataSource = players;
            frmEditGame.GameModal.CbCrni.DisplayMember = "FullName";
            frmEditGame.GameModal.CbCrni.ValueMember = "Self";
        }

        internal void DragForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(frmEditGame.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        internal void FormClosed(object sender, EventArgs e)
        {

        }


        internal void CreateButtonClicked(object sender, EventArgs e)
        {
            frmEditGame.GameModal.LblError.Text = "";

            if (frmEditGame.GameModal.TbOtvaranje.Text == "" || frmEditGame.GameModal.TbRezultat.Text == "" || frmEditGame.GameModal.TbFEN.Text == "")
            {
                frmEditGame.GameModal.LblError.Text = "Polja ne smeju biti prazna";
                return;
            }

            if (frmEditGame.GameModal.CbBeli.SelectedItem == frmEditGame.GameModal.CbCrni.SelectedItem)
            {
                frmEditGame.GameModal.LblError.Text = "Beli i crni šahista moraju biti različiti";
                return;
            }

            if (frmEditGame.GameModal.DtDatum.Value < DateTime.Parse(currentTournament.Date.Split(' ')[0]) || frmEditGame.GameModal.DtDatum.Value > DateTime.Parse(currentTournament.Date.Split(' ')[1]))
            {
                frmEditGame.GameModal.LblError.Text = "Datum partije mora biti izmedju početka i završetka turnira";
                return;
            }

            game.Opening = frmEditGame.GameModal.TbOtvaranje.Text;
            game.Result = frmEditGame.GameModal.TbRezultat.Text;
            game.Pgn = frmEditGame.GameModal.TbFEN.Text;
            game.White = (Player)frmEditGame.GameModal.CbBeli.SelectedItem;
            game.Black = (Player)frmEditGame.GameModal.CbCrni.SelectedItem;
            game.Round = (int)frmEditGame.GameModal.NumRunda.Value;
            game.Date = frmEditGame.GameModal.DtDatum.Value.ToString("yyyy-MM-dd");
            frmEditGame.Close();

            //Session.games.Add(game);
        }
    }
}
