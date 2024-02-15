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
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();
            this.MouseDown += GameGUIController.Instance.DragForm;
            this.FormClosed += GameGUIController.Instance.FormClosed;
            this.Load += GameGUIController.Instance.InitForm;
        }
    }
}
