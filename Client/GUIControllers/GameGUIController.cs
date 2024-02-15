using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Client.UserControls;
using Common.Domain;

namespace Client.GUIControllers
{
    public class GameGUIController
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static GameGUIController instance;

        public static GameGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameGUIController();
                }
                return instance;
            }
        }

        private GameGUIController()
        {
        }

        private FrmGame frmGame;
        private Game currentGame;
        private int currentMove = 0;

        internal void ShowFrmGame(Game game)
        {
            frmGame = new FrmGame();
            frmGame.AutoSize = true;
            currentGame = game;
            frmGame.ShowDialog();
        }

        internal void InitForm(object sender, EventArgs e)
        {
            currentMove = 0;
            frmGame.ChessBoard.ChessGrid.RowCount = 8;
            frmGame.ChessBoard.ChessGrid.BorderStyle = BorderStyle.None;
            frmGame.ChessBoard.ChessGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            frmGame.ChessBoard.ChessGrid.AllowUserToResizeColumns = false;
            frmGame.ChessBoard.ChessGrid.AllowUserToResizeRows = false;
            frmGame.ChessBoard.ChessGrid.ClearSelection();
            frmGame.ChessBoard.ChessGrid.ScrollBars = ScrollBars.None;

            for (int i = 0; i < 8; i++)
            {
                DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
                iconColumn.DefaultCellStyle.NullValue = null;
                frmGame.ChessBoard.ChessGrid.Columns.Insert(i, iconColumn);
                for (int j = 0; j < 8; j++)
                {
                    frmGame.ChessBoard.ChessGrid[i, j].Style.BackColor = (i + j) % 2 == 0 ? ColorTranslator.FromHtml("#ffd599") : ColorTranslator.FromHtml("#b16e41");
                    frmGame.ChessBoard.ChessGrid[i, j].OwningColumn.Width = frmGame.ChessBoard.ChessGrid.Width / 8 + 1;
                    frmGame.ChessBoard.ChessGrid[i, j].OwningRow.Height = frmGame.ChessBoard.ChessGrid.Height / 8 + 1;
                }
            }

            ParsePosition();

            frmGame.ChessBoard.LblBlack.Text = currentGame.Black.Name + " " + currentGame.Black.Surname;
            frmGame.ChessBoard.LblBlackName.Text = currentGame.Black.Name + " " + currentGame.Black.Surname;
            frmGame.ChessBoard.LblBlackTitle.Text = currentGame.Black.Title;
            frmGame.ChessBoard.LblWhite.Text = currentGame.White.Name + " " + currentGame.White.Surname;
            frmGame.ChessBoard.LblWhiteName.Text = currentGame.White.Name + " " + currentGame.White.Surname;
            frmGame.ChessBoard.LblWhiteTitle.Text = currentGame.White.Title;
            frmGame.ChessBoard.LblDate.Text = currentGame.Date;
            frmGame.ChessBoard.LblOpening.Text = "Otvaranje: "+currentGame.Opening;
            frmGame.ChessBoard.LblResult.Text = currentGame.Result;
            frmGame.ChessBoard.LblTournament.Text = "Turnir: "+currentGame.Tournament.Name;
            frmGame.ChessBoard.LblRound.Text = "Runda " + currentGame.Round;
            frmGame.ChessBoard.BtnFirst.Click += (object s, EventArgs ev) =>
            {
                currentMove = 0;
                ParsePosition();
            };

            frmGame.ChessBoard.BtnLast.Click += (object s, EventArgs ev) =>
            {
                currentMove = currentGame.Pgn.Split('\n').Length - 1;
                ParsePosition();
            };

            frmGame.ChessBoard.BtnNext.Click += (object s, EventArgs ev) =>
            {
                if (currentMove < currentGame.Pgn.Split('\n').Length - 1)
                {
                    currentMove++;
                    ParsePosition();
                }
            };

            frmGame.ChessBoard.BtnPrevious.Click += (object s, EventArgs ev) =>
            {
                if (currentMove > 0)
                {
                    currentMove--;
                    ParsePosition();
                }
            };

        }

        public void ParsePosition()
        {
            try
            {
                List<string> fens = currentGame.Pgn.Split('\n').ToList();
                List<string> rows = fens[currentMove].Split('/').ToList();
                for (int i = 0; i < 8; i++)
                {
                    string curr = rows[i];
                    int currColumn = 0;
                    for (int j = 0; j < curr.Length; j++)
                    {
                        bool succ = int.TryParse(curr[j].ToString(), out int num);
                        if (succ)
                        {
                            int k = 0;
                            while (k < num)
                            {
                                frmGame.ChessBoard.ChessGrid[currColumn, i].Value = null;
                                currColumn++;
                                k++;
                            }
                        }
                        else
                        {
                            if (curr[j] == 'r')
                            {
                                frmGame.ChessBoard.ChessGrid[currColumn, i].Value = Client.Properties.Resources.black_rook21;
                            }
                            else if (curr[j] == 'n')
                            {
                                frmGame.ChessBoard.ChessGrid[currColumn, i].Value = Client.Properties.Resources.black_knigh21;
                            }
                            else if (curr[j] == 'b')
                            {
                                frmGame.ChessBoard.ChessGrid[currColumn, i].Value = Client.Properties.Resources.black_bishop21;
                            }
                            else if (curr[j] == 'p')
                            {
                                frmGame.ChessBoard.ChessGrid[currColumn, i].Value = Client.Properties.Resources.black_pawn21;
                            }
                            else if (curr[j] == 'k')
                            {
                                frmGame.ChessBoard.ChessGrid[currColumn, i].Value = Client.Properties.Resources.black_king21;
                            }
                            else if (curr[j] == 'q')
                            {
                                frmGame.ChessBoard.ChessGrid[currColumn, i].Value = Client.Properties.Resources.black_queen21;
                            }
                            else if (curr[j] == 'R')
                            {
                                frmGame.ChessBoard.ChessGrid[currColumn, i].Value = Client.Properties.Resources.white_rook21;
                            }
                            else if (curr[j] == 'N')
                            {
                                frmGame.ChessBoard.ChessGrid[currColumn, i].Value = Client.Properties.Resources.white_knight21;
                            }
                            else if (curr[j] == 'B')
                            {
                                frmGame.ChessBoard.ChessGrid[currColumn, i].Value = Client.Properties.Resources.white_bishop21;
                            }
                            else if (curr[j] == 'P')
                            {
                                frmGame.ChessBoard.ChessGrid[currColumn, i].Value = Client.Properties.Resources.white_pawn21;
                            }
                            else if (curr[j] == 'K')
                            {
                                frmGame.ChessBoard.ChessGrid[currColumn, i].Value = Client.Properties.Resources.white_king21;
                            }
                            else if (curr[j] == 'Q')
                            {
                                frmGame.ChessBoard.ChessGrid[currColumn, i].Value = Client.Properties.Resources.white_queen21;
                            }
                            else if (curr[j] == ' ')
                            {
                                return;
                            }
                            currColumn++;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error parsing FEN");
                frmGame.Close();
            }
        }

        internal void DragForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(frmGame.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        internal void FormClosed(object sender, EventArgs e)
        {
        }
    }
}
