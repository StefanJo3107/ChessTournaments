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
    public partial class MainNavbar : UserControl
    {
        public MainNavbar()
        {
            InitializeComponent();
            lnkTurniri.LinkClicked += MainGUIController.Instance.TournamentLinkClicked;
            lnkIgraci.LinkClicked += MainGUIController.Instance.PlayersLinkClicked;
            lnkOdjava.LinkClicked += (object sender, LinkLabelLinkClickedEventArgs e) => { ((Form)this.TopLevelControl).Close(); };
        }
    }
}
