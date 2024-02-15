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
    public partial class FrmEditGames : Form
    {
        public FrmEditGames()
        {
            InitializeComponent();
            this.MouseDown += EditGamesGUIController.Instance.DragForm;
            this.FormClosed += EditGamesGUIController.Instance.FormClosed;
            this.Load += EditGamesGUIController.Instance.InitForm;
            this.GamesModal.BtnAdd.Click += EditGamesGUIController.Instance.EditButtonClicked;
            this.GamesModal.BtnSave.Click += EditGamesGUIController.Instance.SaveButtonClicked;
        }
    }
}
