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
    public partial class FrmCreateGame : Form
    {
        public FrmCreateGame()
        {
            InitializeComponent();
            this.MouseDown += CreateGameGUIController.Instance.DragForm;
            this.FormClosed += CreateGameGUIController.Instance.FormClosed;
            this.Load += CreateGameGUIController.Instance.InitForm;
            this.GameModal.BtnSave.Click += CreateGameGUIController.Instance.CreateButtonClicked;
        }
    }
}
