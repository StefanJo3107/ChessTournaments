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
    public partial class FrmEditPlayer : Form
    {
        public FrmEditPlayer()
        {
            InitializeComponent();
            this.MouseDown += EditPlayerGUIController.Instance.DragForm;
            this.FormClosed += EditPlayerGUIController.Instance.FormClosed;
            this.Load += EditPlayerGUIController.Instance.InitForm;
            PlayerModal.BtnSave.Click += EditPlayerGUIController.Instance.EditButtonClicked;

        }
    }
}
