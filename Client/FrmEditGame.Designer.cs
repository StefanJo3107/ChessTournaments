using Client.UserControls;

namespace Client
{
    partial class FrmEditGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateGame));
            this.logo1 = new Client.UserControls.Logo();
            this.windowControls1 = new Client.UserControls.WindowControls();
            this.gameModal1 = new Client.UserControls.GameModal();
            this.SuspendLayout();
            // 
            // logo1
            // 
            this.logo1.BackColor = System.Drawing.Color.Transparent;
            this.logo1.Location = new System.Drawing.Point(-2, -1);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(218, 58);
            this.logo1.TabIndex = 0;
            // 
            // windowControls1
            // 
            this.windowControls1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowControls1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.windowControls1.Location = new System.Drawing.Point(654, 5);
            this.windowControls1.Name = "windowControls1";
            this.windowControls1.Size = new System.Drawing.Size(144, 45);
            this.windowControls1.TabIndex = 1;
            // 
            // gameModal1
            // 
            this.gameModal1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameModal1.BackColor = System.Drawing.Color.Transparent;
            this.gameModal1.Location = new System.Drawing.Point(26, 92);
            this.gameModal1.Name = "gameModal1";
            this.gameModal1.Size = new System.Drawing.Size(772, 492);
            this.gameModal1.TabIndex = 2;
            // 
            // FrmCreateGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.gameModal1);
            this.Controls.Add(this.windowControls1);
            this.Controls.Add(this.logo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreateGame";
            this.Text = "FrmTournamentModal";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Logo logo1;
        private UserControls.WindowControls windowControls1;
        private GameModal gameModal1;

        public GameModal GameModal { get => gameModal1; set => gameModal1 = value; }
    }
}