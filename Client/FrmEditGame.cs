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
    public partial class FrmEditGame : Form
    {
        public FrmEditGame()
        {
            InitializeComponent();
            this.MouseDown += EditGameGUIController.Instance.DragForm;
            this.FormClosed += EditGameGUIController.Instance.FormClosed;
            this.Load += EditGameGUIController.Instance.InitForm;
            this.GameModal.BtnSave.Click += EditGameGUIController.Instance.CreateButtonClicked;
        }
    }
}
