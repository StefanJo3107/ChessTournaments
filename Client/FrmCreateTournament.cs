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
    public partial class FrmCreateTournament : Form
    {
        public FrmCreateTournament()
        {
            InitializeComponent();
            this.MouseDown += CreateTournamentGUIController.Instance.DragForm;
            this.FormClosed += CreateTournamentGUIController.Instance.FormClosed;
            this.Load += CreateTournamentGUIController.Instance.InitForm;
            TournamentForm.BtnSave.Click += CreateTournamentGUIController.Instance.CreateButtonClicked;

        }
    }
}
