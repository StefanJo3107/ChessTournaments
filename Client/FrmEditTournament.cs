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
    public partial class FrmEditTournament : Form
    {
        public FrmEditTournament()
        {
            InitializeComponent();
            this.MouseDown += EditTournamentGUIController.Instance.DragForm;
            this.FormClosed += EditTournamentGUIController.Instance.FormClosed;
            this.Load += EditTournamentGUIController.Instance.InitForm;
            TournamentForm.BtnSave.Click += EditTournamentGUIController.Instance.EditButtonClicked;
        }
    }
}
