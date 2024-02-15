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

namespace Client.UserControls
{
    public partial class LoginPanel : UserControl
    {


        public LoginPanel()
        {
            InitializeComponent();
            this.Load += AuthGUIController.Instance.InitLoginPanel;
            this.btnLogin.Click += AuthGUIController.Instance.LoginButtonClicked;
            this.lblLink.LinkClicked += AuthGUIController.Instance.LinkClicked;
        }

        
    }
}
