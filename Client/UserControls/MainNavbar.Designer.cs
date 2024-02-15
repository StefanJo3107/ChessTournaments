using System.Windows.Forms;

namespace Client.UserControls
{
    partial class MainNavbar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lnkTurniri = new System.Windows.Forms.LinkLabel();
            this.lnkIgraci = new System.Windows.Forms.LinkLabel();
            this.lnkOdjava = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.windowControls1 = new Client.UserControls.WindowControls();
            this.logo1 = new Client.UserControls.Logo();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkTurniri
            // 
            this.lnkTurniri.ActiveLinkColor = System.Drawing.Color.SandyBrown;
            this.lnkTurniri.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnkTurniri.AutoSize = true;
            this.lnkTurniri.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkTurniri.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkTurniri.LinkColor = System.Drawing.Color.NavajoWhite;
            this.lnkTurniri.Location = new System.Drawing.Point(176, 11);
            this.lnkTurniri.Name = "lnkTurniri";
            this.lnkTurniri.Size = new System.Drawing.Size(85, 36);
            this.lnkTurniri.TabIndex = 2;
            this.lnkTurniri.TabStop = true;
            this.lnkTurniri.Text = "Turniri";
            // 
            // lnkIgraci
            // 
            this.lnkIgraci.ActiveLinkColor = System.Drawing.Color.SandyBrown;
            this.lnkIgraci.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnkIgraci.AutoSize = true;
            this.lnkIgraci.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkIgraci.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkIgraci.LinkColor = System.Drawing.Color.NavajoWhite;
            this.lnkIgraci.Location = new System.Drawing.Point(267, 11);
            this.lnkIgraci.Name = "lnkIgraci";
            this.lnkIgraci.Size = new System.Drawing.Size(76, 36);
            this.lnkIgraci.TabIndex = 3;
            this.lnkIgraci.TabStop = true;
            this.lnkIgraci.Text = "Igrači";
            // 
            // lnkOdjava
            // 
            this.lnkOdjava.ActiveLinkColor = System.Drawing.Color.SandyBrown;
            this.lnkOdjava.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnkOdjava.AutoSize = true;
            this.lnkOdjava.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkOdjava.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkOdjava.LinkColor = System.Drawing.Color.NavajoWhite;
            this.lnkOdjava.Location = new System.Drawing.Point(349, 11);
            this.lnkOdjava.Name = "lnkOdjava";
            this.lnkOdjava.Size = new System.Drawing.Size(92, 36);
            this.lnkOdjava.TabIndex = 4;
            this.lnkOdjava.TabStop = true;
            this.lnkOdjava.Text = "Odjava";
            this.lnkOdjava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lnkIgraci, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lnkTurniri, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lnkOdjava, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.windowControls1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.logo1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(618, 58);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // windowControls1
            // 
            this.windowControls1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowControls1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.windowControls1.Location = new System.Drawing.Point(447, 5);
            this.windowControls1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.windowControls1.Name = "windowControls1";
            this.windowControls1.Size = new System.Drawing.Size(168, 42);
            this.windowControls1.TabIndex = 1;
            // 
            // logo1
            // 
            this.logo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo1.Location = new System.Drawing.Point(3, 3);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(167, 52);
            this.logo1.TabIndex = 0;
            // 
            // MainNavbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainNavbar";
            this.Size = new System.Drawing.Size(953, 58);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Logo logo1;
        private WindowControls windowControls1;
        private System.Windows.Forms.LinkLabel lnkTurniri;
        private System.Windows.Forms.LinkLabel lnkIgraci;
        private System.Windows.Forms.LinkLabel lnkOdjava;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        public TableLayoutPanel TableLayoutPanel { get => tableLayoutPanel1; set => tableLayoutPanel1 = value; }
    }
}
