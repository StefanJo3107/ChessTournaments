using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.GUIControllers;
using FontAwesome.Sharp;

namespace Client
{
    public partial class FrmAuth : Form
    {

        public FrmAuth()
        {
            InitializeComponent();
            this.Load += AuthGUIController.Instance.InitForm;
            this.MouseDown += AuthGUIController.Instance.DragForm;
            this.FormClosed += AuthGUIController.Instance.FormClosed;
        }

    }
}
