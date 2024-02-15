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
    public partial class FrmCreatePlayer : Form
    {
        public FrmCreatePlayer()
        {
            InitializeComponent();
            this.MouseDown += CreatePlayerGUIController.Instance.DragForm;
            this.FormClosed += CreatePlayerGUIController.Instance.FormClosed;
            this.Load += CreatePlayerGUIController.Instance.InitForm;
            PlayerModal.BtnSave.Click += CreatePlayerGUIController.Instance.CreateButtonClicked;

        }
    }
}
