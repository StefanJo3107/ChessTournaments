using System.Windows.Forms;

namespace Client.UserControls
{
    partial class LoginPanel
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.lblGreska = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNaslov.Font = new System.Drawing.Font("Poppins Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblNaslov.Location = new System.Drawing.Point(0, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(376, 63);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Prijavi se";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tbUsername
            // 
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsername.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.White;
            this.tbUsername.Location = new System.Drawing.Point(34, 120);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(312, 37);
            this.tbUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(29, 81);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(158, 36);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Korisničko ime";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(28, 170);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 36);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Lozinka";
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(33, 209);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(312, 37);
            this.tbPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btnLogin.FlatAppearance.BorderSize = 3;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnLogin.Location = new System.Drawing.Point(95, 273);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(184, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Prijavi se";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblPoruka
            // 
            this.lblPoruka.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoruka.ForeColor = System.Drawing.Color.White;
            this.lblPoruka.Location = new System.Drawing.Point(33, 371);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(168, 36);
            this.lblPoruka.TabIndex = 6;
            this.lblPoruka.Text = "Nemaš nalog?";
            this.lblPoruka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLink
            // 
            this.lblLink.ActiveLinkColor = System.Drawing.Color.SandyBrown;
            this.lblLink.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblLink.LinkColor = System.Drawing.Color.NavajoWhite;
            this.lblLink.Location = new System.Drawing.Point(195, 371);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(151, 36);
            this.lblLink.TabIndex = 7;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Registruj se";
            this.lblLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGreska
            // 
            this.lblGreska.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreska.ForeColor = System.Drawing.Color.LightCoral;
            this.lblGreska.Location = new System.Drawing.Point(33, 330);
            this.lblGreska.Name = "lblGreska";
            this.lblGreska.Size = new System.Drawing.Size(312, 41);
            this.lblGreska.TabIndex = 8;
            this.lblGreska.Text = "Pogrešni kredencijali";
            this.lblGreska.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lblGreska);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblNaslov);
            this.Name = "LoginPanel";
            this.Size = new System.Drawing.Size(376, 429);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.Label lblGreska;
        private System.Windows.Forms.Label lblPassword;

        public Label LblNaslov { get => lblNaslov; set => lblNaslov = value; }
        public TextBox TbUsername { get => tbUsername; set => tbUsername = value; }
        public Label LblUsername { get => lblUsername; set => lblUsername = value; }
        public TextBox TbPassword { get => tbPassword; set => tbPassword = value; }
        public Button BtnLogin { get => btnLogin; set => btnLogin = value; }
        public Label LblPoruka { get => lblPoruka; set => lblPoruka = value; }
        public LinkLabel LblLink { get => lblLink; set => lblLink = value; }
        public Label LblGreska { get => lblGreska; set => lblGreska = value; }
        public Label LblPassword { get => lblPassword; set => lblPassword = value; }
    }
}
