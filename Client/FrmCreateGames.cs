using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.GUIControllers;

namespace Client
{
    public partial class FrmCreateGames : Form
    {
        public FrmCreateGames()
        {
            InitializeComponent();
            this.MouseDown += CreateGamesGUIController.Instance.DragForm;
            this.FormClosed += CreateGamesGUIController.Instance.FormClosed;
            this.Load += CreateGamesGUIController.Instance.InitForm;
            this.GamesModal.BtnAdd.Click += CreateGamesGUIController.Instance.AddButtonClicked;
            this.GamesModal.BtnSave.Click += CreateGamesGUIController.Instance.CreateButtonClicked;
        }
    }
}
