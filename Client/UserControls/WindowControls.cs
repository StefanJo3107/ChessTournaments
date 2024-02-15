using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class WindowControls : UserControl
    {
        public WindowControls()
        {
            InitializeComponent();
        }

        private void WindowControls_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            Form currentForm = (Form)this.TopLevelControl;
            if (currentForm.WindowState != FormWindowState.Maximized)
            {
                currentForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                currentForm.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).WindowState = FormWindowState.Minimized;
        }
    }
}
