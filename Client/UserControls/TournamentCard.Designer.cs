using System.Windows.Forms;

namespace Client.UserControls
{
    partial class TournamentCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentCard));
            this.pbTournament = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangeTournament = new System.Windows.Forms.Button();
            this.btnShowGames = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDates = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTournament)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTournament
            // 
            this.pbTournament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTournament.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbTournament.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbTournament.ErrorImage")));
            this.pbTournament.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbTournament.InitialImage")));
            this.pbTournament.Location = new System.Drawing.Point(0, 0);
            this.pbTournament.Name = "pbTournament";
            this.pbTournament.Size = new System.Drawing.Size(299, 152);
            this.pbTournament.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTournament.TabIndex = 0;
            this.pbTournament.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.btnChangeTournament);
            this.panel1.Controls.Add(this.btnShowGames);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.lblDates);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 263);
            this.panel1.TabIndex = 1;
            // 
            // btnChangeTournament
            // 
            this.btnChangeTournament.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeTournament.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnChangeTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeTournament.Font = new System.Drawing.Font("Poppins Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnChangeTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.btnChangeTournament.Location = new System.Drawing.Point(154, 206);
            this.btnChangeTournament.Name = "btnChangeTournament";
            this.btnChangeTournament.Size = new System.Drawing.Size(131, 45);
            this.btnChangeTournament.TabIndex = 6;
            this.btnChangeTournament.Text = "Izmeni turnir";
            this.btnChangeTournament.UseVisualStyleBackColor = false;
            // 
            // btnShowGames
            // 
            this.btnShowGames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowGames.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnShowGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowGames.Font = new System.Drawing.Font("Poppins Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnShowGames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.btnShowGames.Location = new System.Drawing.Point(12, 206);
            this.btnShowGames.Name = "btnShowGames";
            this.btnShowGames.Size = new System.Drawing.Size(131, 45);
            this.btnShowGames.TabIndex = 5;
            this.btnShowGames.Text = "Prikaži turnir";
            this.btnShowGames.UseVisualStyleBackColor = false;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocation.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(153, 139);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(122, 33);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Azerbejdžan";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDates
            // 
            this.lblDates.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDates.ForeColor = System.Drawing.Color.White;
            this.lblDates.Location = new System.Drawing.Point(12, 127);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(135, 58);
            this.lblDates.TabIndex = 3;
            this.lblDates.Text = "23.6.2023.\r\n22.7.2023.";
            this.lblDates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(188, 74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(54, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(299, 49);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "84th Tata Steel Masters";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 409);
            this.panel2.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btnDelete.FlatAppearance.BorderSize = 4;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(249, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(35, 35);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // TournamentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbTournament);
            this.Controls.Add(this.panel2);
            this.Name = "TournamentCard";
            this.Size = new System.Drawing.Size(312, 426);
            ((System.ComponentModel.ISupportInitialize)(this.pbTournament)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTournament;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnChangeTournament;
        private System.Windows.Forms.Button btnShowGames;
        private System.Windows.Forms.Panel panel2;
        private Button btnDelete;

        public PictureBox PbTournament { get => pbTournament; set => pbTournament = value; }
        public Panel PnlBody { get => panel1; set => panel1 = value; }
        public Label LblName { get => lblName; set => lblName = value; }
        public Label LblLocation { get => lblLocation; set => lblLocation = value; }
        public Label LblDates { get => lblDates; set => lblDates = value; }
        public PictureBox PictureBox3 { get => pictureBox3; set => pictureBox3 = value; }
        public PictureBox PictureBox2 { get => pictureBox2; set => pictureBox2 = value; }
        public Button BtnChangeTournament { get => btnChangeTournament; set => btnChangeTournament = value; }
        public Button BtnShowGames { get => btnShowGames; set => btnShowGames = value; }
        public Panel PnlShadow { get => panel2; set => panel2 = value; }
        public Button BtnDelete { get => btnDelete; set => btnDelete = value; }
    }
}
