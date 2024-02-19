using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.UserControls;
using Common.Domain;

namespace Client.GUIControllers
{
    public class MainGUIController
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static MainGUIController instance;
        Tournament currentTournament = null;

        public static MainGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainGUIController();
                }
                return instance;
            }
        }

        private MainGUIController()
        {
        }

        private FrmMain frmMain;

        enum State
        {
            Tournaments,
            Players,
            Games
        }

        State pageState = State.Tournaments;

        internal void ShowFrmMain()
        {
            frmMain = new FrmMain();
            frmMain.AutoSize = true;
            frmMain.ShowDialog();
        }

        internal void InitForm(object sender, EventArgs e)
        {
            frmMain.BackColor = ColorTranslator.FromHtml("#1a202c");
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            frmMain.PnlContainer, new object[] { true });
            ShowAllTournaments();
        }

        internal void DragForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(frmMain.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        internal void FormClosed(object sender, EventArgs e)
        {
            Communication.Instance.Disconnect();
            Communication.Instance.Stop();
        }

        internal void TournamentLinkClicked(object sender, EventArgs e)
        {
            if (pageState != State.Tournaments)
            {
                pageState = State.Tournaments;
                ShowAllTournaments();
            }
        }

        internal void PlayersLinkClicked(object sender, EventArgs e)
        {
            if (pageState != State.Players)
            {
                pageState = State.Players;
                ShowAllPlayers();
            }
        }

        internal void AddButtonClicked(object sender, EventArgs e)
        {
            if (pageState == State.Tournaments)
            {
                CreateTournamentGUIController.Instance.ShowFrmCreateTournament();
                ShowAllTournaments();
            }
            else if (pageState == State.Players)
            {
                CreatePlayerGUIController.Instance.ShowFrmCreatePlayer();
                ShowAllPlayers();
            }
            else if (pageState == State.Games)
            {
                CreateGamesGUIController.Instance.ShowFrmCreateGames(currentTournament);
                ShowGames(currentTournament);
            }
        }

        internal void EditButtonClicked(object sender, EventArgs e)
        {
            if (pageState == State.Games)
            {
                EditGamesGUIController.Instance.ShowFrmEditGames(currentTournament);
                ShowGames(currentTournament);
            }
        }

        internal void ShowAllTournaments()
        {
            var tournaments_resp = Communication.Instance.GetAllTournaments();

            if (tournaments_resp.Exception != null)
            {
                MessageBox.Show("Greška prilikom dobijanja turnira");
            }

            if (tournaments_resp.Result == null)
            {
                return;
            }

            ShowTournaments((List<Tournament>)tournaments_resp.Result);
        }

        internal void SearchButtonClick(object sender, EventArgs e)
        {
            if (pageState == State.Tournaments)
            {
                SearchTournaments();
            }
            else if (pageState == State.Players)
            {
                SearchPlayers();
            }
        }

        internal void SearchTournaments()
        {
            string search = frmMain.SearchBar.TbSearch.Text;
            var tournaments_resp = Communication.Instance.SearchTournaments(search);

            if (tournaments_resp.Exception != null)
            {
                MessageBox.Show("Greška prilikom dobijanja turnira");
            }

            if (tournaments_resp.Result == null)
            {
                return;
            }

            ShowTournaments((List<Tournament>)tournaments_resp.Result);
        }

        internal void ShowAllPlayers()
        {
            var players_resp = Communication.Instance.GetAllPlayers();

            if (players_resp.Exception != null)
            {
                MessageBox.Show("Greška prilikom dobijanja šahista");
            }


            if (players_resp.Result == null)
            {
                return;
            }

            ShowPlayers((List<Player>)players_resp.Result);
        }

        internal void SearchPlayers()
        {
            string search = frmMain.SearchBar.TbSearch.Text;
            var players_resp = Communication.Instance.SearchPlayers(search);

            if (players_resp.Exception != null)
            {
                MessageBox.Show("Greška prilikom dobijanja šahista");
            }


            if (players_resp.Result == null)
            {
                return;
            }

            ShowPlayers((List<Player>)players_resp.Result);
        }

        internal void ShowTournaments(List<Tournament> tournaments)
        {
            frmMain.LblPageTitle.Text = "Turniri";
            frmMain.BtnAdd.Text = "Dodaj turnir";
            frmMain.BtnAdd.Visible = true;
            frmMain.BtnEdit.Visible = false;
            frmMain.SearchBar.Visible = true;

            frmMain.PnlContainer.Controls.Clear();

            if(tournaments.Count == 0)
            {
                Label emptyLabel = new Label();
                emptyLabel.Font = frmMain.BtnAdd.Font;
                emptyLabel.Text = "Nema turnira koji ispunjavaju zadati kriterijum";
                emptyLabel.AutoSize = true;
                emptyLabel.ForeColor = Color.White;
                frmMain.PnlContainer.Controls.Add(emptyLabel);
                return;
            }

            foreach (Tournament t in tournaments)
            {
                TournamentCard card = new TournamentCard();
                card.LblName.Text = t.Name;
                card.LblDates.Text = String.Join("\r\n", t.Date.Split(' '));
                card.LblLocation.Text = t.Location.Name;
                try
                {
                    card.PbTournament.LoadAsync(t.ImageURL);
                }
                catch (Exception)
                {
                }
                card.PnlShadow.BackColor = Color.FromArgb(30, 0, 0, 0);
                card.TournamentId = t.Id;
                card.BtnChangeTournament.Click += (object sender, EventArgs e) =>
                {
                    EditTournamentGUIController.Instance.ShowFrmEditTournament(t);
                    ShowAllTournaments();
                };
                card.BtnShowGames.Click += (object sender, EventArgs e) =>
                {
                    pageState = State.Games;
                    currentTournament = t;
                    ShowGames(t);
                };
                card.BtnDelete.Click += (object sender, EventArgs e) =>
                {
                    Communication.Instance.DeleteTournament(t);
                    MessageBox.Show("Uspešno izbrisan turnir");
                    ShowAllTournaments();
                };


                frmMain.PnlContainer.Controls.Add(card);
            }
        }

        internal void ShowPlayers(List<Player> players)
        {
            frmMain.LblPageTitle.Text = "Šahisti";
            frmMain.BtnAdd.Text = "Dodaj šahistu";
            frmMain.BtnAdd.Visible = true;
            frmMain.BtnEdit.Visible = false;

            frmMain.SearchBar.Visible = true;

            frmMain.PnlContainer.Controls.Clear();

            if (players.Count == 0)
            {
                Label emptyLabel = new Label();
                emptyLabel.Font = frmMain.BtnAdd.Font;
                emptyLabel.Text = "Nema šahista koji ispunjavaju zadati kriterijum";
                emptyLabel.AutoSize = true;
                emptyLabel.ForeColor = Color.White;
                frmMain.PnlContainer.Controls.Add(emptyLabel);
                return;
            }

            foreach (Player p in players)
            {
                PlayerCard card = new PlayerCard();
                card.LblName.Text = p.Name + " " + p.Surname;
                card.LblELO.Text = p.ELO.ToString();
                card.LblLocation.Text = p.Location.Name;
                card.LblTitle.Text = p.Title;


                try
                {
                    card.PbPlayer.LoadAsync(p.ImageURL);
                }
                catch (Exception)
                {
                }

                card.PnlShadow.BackColor = Color.FromArgb(30, 0, 0, 0);
                card.BtnEditPlayer.Click += (object sender, EventArgs e) =>
                {
                    EditPlayerGUIController.Instance.ShowFrmEditPlayer(p);
                    ShowAllPlayers();
                };

                frmMain.PnlContainer.Controls.Add(card);
            }
        }

        internal void ShowGames(Tournament tournament)
        {
            var games_resp = Communication.Instance.GetAllGames(tournament);
            List<Game> games;

            if (games_resp.Exception != null)
            {
                MessageBox.Show("Greška prilikom dobijanja partija");
            }


            if (games_resp.Result == null)
            {
                return;
            }

            frmMain.LblPageTitle.Text = "Partije";
            frmMain.BtnAdd.Text = "Dodaj partije";
            frmMain.BtnAdd.Visible = true;
            frmMain.BtnEdit.Text = "Izmeni partije";
            frmMain.BtnEdit.Visible = true;
            frmMain.SearchBar.Visible = false;

            games = (List<Game>)games_resp.Result;
            frmMain.PnlContainer.Controls.Clear();

            if (games.Count == 0)
            {
                Label emptyLabel = new Label();
                emptyLabel.Font = frmMain.BtnAdd.Font;
                emptyLabel.Text = "Ne postoje partije za izabrani turnir";
                emptyLabel.AutoSize = true;
                emptyLabel.ForeColor = Color.White;
                frmMain.PnlContainer.Controls.Add(emptyLabel);
                return;
            }

            foreach (Game g in games)
            {
                GameCard card = new GameCard();
                card.LblWhite.Text = g.White.Name + " " + g.White.Surname;
                card.LblBlack.Text = g.Black.Name + " " + g.Black.Surname;
                card.LblDate.Text = g.Date;
                card.LblOpening.Text = g.Opening;
                card.LblResult.Text = g.Result;
                card.LblRound.Text = "Runda " + g.Round;
                card.LblTournament.Text = g.Tournament.Name;

                card.PnlShadow.BackColor = Color.FromArgb(30, 0, 0, 0);

                card.BtnShow.Click += (object sender, EventArgs e) =>
                {
                    GameGUIController.Instance.ShowFrmGame(g);
                };

                frmMain.PnlContainer.Controls.Add(card);
            }
        }
    }
}
