using System.Windows.Forms;
using Client.UserControls;

namespace Client
{
    partial class FrmAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuth));
            this.logo1 = new Client.UserControls.Logo();
            this.windowControls1 = new Client.UserControls.WindowControls();
            this.loginPanel1 = new Client.UserControls.LoginPanel();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // logo1
            // 
            this.logo1.Location = new System.Drawing.Point(12, 6);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(229, 58);
            this.logo1.TabIndex = 1;
            // 
            // windowControls1
            // 
            this.windowControls1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowControls1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.windowControls1.Location = new System.Drawing.Point(323, 12);
            this.windowControls1.Name = "windowControls1";
            this.windowControls1.Size = new System.Drawing.Size(142, 45);
            this.windowControls1.TabIndex = 0;
            // 
            // loginPanel1
            // 
            this.loginPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginPanel1.Location = new System.Drawing.Point(48, 112);
            this.loginPanel1.Name = "loginPanel1";
            this.loginPanel1.Size = new System.Drawing.Size(376, 429);
            this.loginPanel1.TabIndex = 2;
            // 
            // pnlShadow
            // 
            this.pnlShadow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlShadow.Location = new System.Drawing.Point(65, 123);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(374, 431);
            this.pnlShadow.TabIndex = 3;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(478, 590);
            this.Controls.Add(this.loginPanel1);
            this.Controls.Add(this.logo1);
            this.Controls.Add(this.windowControls1);
            this.Controls.Add(this.pnlShadow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.WindowControls windowControls1;
        private UserControls.Logo logo1;
        private UserControls.LoginPanel loginPanel1;
        private System.Windows.Forms.Panel pnlShadow;

        public WindowControls WindowControls { get => windowControls1; set => windowControls1 = value; }
        public Logo Logo { get => logo1; set => logo1 = value; }
        public LoginPanel LoginPanel { get => loginPanel1; set => loginPanel1 = value; }
        public Panel PnlShadow { get => pnlShadow; set => pnlShadow = value; }
    }
}

