using System.Windows.Forms;
using Client.UserControls;

namespace Client
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlTournaments = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.searchBar1 = new Client.UserControls.SearchBar();
            this.mainNavbar1 = new Client.UserControls.MainNavbar();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTournaments
            // 
            this.pnlTournaments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTournaments.AutoScroll = true;
            this.pnlTournaments.BackColor = System.Drawing.Color.Transparent;
            this.pnlTournaments.Location = new System.Drawing.Point(29, 140);
            this.pnlTournaments.Margin = new System.Windows.Forms.Padding(20);
            this.pnlTournaments.Name = "pnlTournaments";
            this.pnlTournaments.Size = new System.Drawing.Size(1004, 493);
            this.pnlTournaments.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPageTitle.Font = new System.Drawing.Font("Poppins Black", 16F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblPageTitle.Location = new System.Drawing.Point(3, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(102, 48);
            this.lblPageTitle.TabIndex = 2;
            this.lblPageTitle.Text = "label1";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Poppins Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(675, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(164, 42);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Izmeni šahistu";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.47679F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.47678F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.97755F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.06886F));
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPageTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchBar1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1004, 48);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Poppins Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(845, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Dodaj šahistu";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // searchBar1
            // 
            this.searchBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBar1.BackColor = System.Drawing.Color.Transparent;
            this.searchBar1.Location = new System.Drawing.Point(363, 3);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(281, 42);
            this.searchBar1.TabIndex = 4;
            // 
            // mainNavbar1
            // 
            this.mainNavbar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainNavbar1.BackColor = System.Drawing.Color.Transparent;
            this.mainNavbar1.Location = new System.Drawing.Point(0, 0);
            this.mainNavbar1.Name = "mainNavbar1";
            this.mainNavbar1.Size = new System.Drawing.Size(1064, 58);
            this.mainNavbar1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1062, 631);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlTournaments);
            this.Controls.Add(this.mainNavbar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.MainNavbar mainNavbar1;
        private System.Windows.Forms.FlowLayoutPanel pnlTournaments;
        private Label lblPageTitle;
        private Button btnEdit;
        private TableLayoutPanel tableLayoutPanel1;
        private SearchBar searchBar1;
        private Button btnAdd;

        public MainNavbar MainNavbar { get => mainNavbar1; set => mainNavbar1 = value; }
        public FlowLayoutPanel PnlContainer { get => pnlTournaments; set => pnlTournaments = value; }
        public Label LblPageTitle { get => lblPageTitle; set => lblPageTitle = value; }
        public Button BtnAdd { get => btnAdd; set => btnAdd = value; }
        public SearchBar SearchBar { get => searchBar1; set => searchBar1 = value; }
        public Button BtnEdit { get => btnEdit; set => btnEdit = value; }
    }
}