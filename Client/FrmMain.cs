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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Load += MainGUIController.Instance.InitForm;
            this.MouseDown += MainGUIController.Instance.DragForm;
            this.FormClosed += MainGUIController.Instance.FormClosed;
            this.mainNavbar1.TableLayoutPanel.MouseDown += MainGUIController.Instance.DragForm;
            this.btnAdd.Click += MainGUIController.Instance.AddButtonClicked;
            this.btnEdit.Click += MainGUIController.Instance.EditButtonClicked;
            this.searchBar1.BtnSearch.Click += MainGUIController.Instance.SearchButtonClick;
        }
    }
}
