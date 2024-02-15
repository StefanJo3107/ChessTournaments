using System.Windows.Forms;

namespace Client.UserControls
{
    partial class GameCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameCard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblOpening = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblBlack = new System.Windows.Forms.Label();
            this.lblTournament = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWhite = new System.Windows.Forms.Label();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.lblOpening);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblRound);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.lblBlack);
            this.panel1.Controls.Add(this.lblTournament);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblWhite);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 366);
            this.panel1.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Poppins Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.btnShow.Location = new System.Drawing.Point(157, 307);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(152, 45);
            this.btnShow.TabIndex = 15;
            this.btnShow.Text = "Prikaži partiju";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // lblOpening
            // 
            this.lblOpening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOpening.AutoEllipsis = true;
            this.lblOpening.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpening.ForeColor = System.Drawing.Color.White;
            this.lblOpening.Location = new System.Drawing.Point(234, 256);
            this.lblOpening.Name = "lblOpening";
            this.lblOpening.Size = new System.Drawing.Size(234, 33);
            this.lblOpening.TabIndex = 14;
            this.lblOpening.Text = "GM";
            this.lblOpening.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(324, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // lblRound
            // 
            this.lblRound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRound.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblRound.ForeColor = System.Drawing.Color.Gray;
            this.lblRound.Location = new System.Drawing.Point(254, 0);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(207, 42);
            this.lblRound.TabIndex = 12;
            this.lblRound.Text = "Magnus Carlsen";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(3, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(207, 42);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Magnus Carlsen";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.Font = new System.Drawing.Font("Poppins Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblResult.Location = new System.Drawing.Point(196, 52);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(73, 113);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "1/2 - 1/2";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlack
            // 
            this.lblBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlack.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlack.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblBlack.Location = new System.Drawing.Point(275, 52);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(190, 113);
            this.lblBlack.TabIndex = 9;
            this.lblBlack.Text = "Magnus Carlsen";
            this.lblBlack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTournament
            // 
            this.lblTournament.AutoEllipsis = true;
            this.lblTournament.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournament.ForeColor = System.Drawing.Color.White;
            this.lblTournament.Location = new System.Drawing.Point(12, 256);
            this.lblTournament.Name = "lblTournament";
            this.lblTournament.Size = new System.Drawing.Size(211, 33);
            this.lblTournament.TabIndex = 8;
            this.lblTournament.Text = "GM";
            this.lblTournament.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(91, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblWhite
            // 
            this.lblWhite.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhite.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblWhite.Location = new System.Drawing.Point(3, 52);
            this.lblWhite.Name = "lblWhite";
            this.lblWhite.Size = new System.Drawing.Size(195, 113);
            this.lblWhite.TabIndex = 0;
            this.lblWhite.Text = "Leineir Dominguez Perez";
            this.lblWhite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlShadow
            // 
            this.pnlShadow.Location = new System.Drawing.Point(12, 14);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(470, 365);
            this.pnlShadow.TabIndex = 2;
            // 
            // GameCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlShadow);
            this.Name = "GameCard";
            this.Size = new System.Drawing.Size(481, 385);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWhite;
        private System.Windows.Forms.Panel pnlShadow;
        private PictureBox pictureBox1;
        private Label lblTournament;
        private Label lblResult;
        private Label lblBlack;
        private Button btnShow;
        private PictureBox pictureBox2;
        private Label lblRound;
        private Label lblDate;
        private Label lblOpening;

        public Panel Panel1 { get => panel1; set => panel1 = value; }
        public Label LblWhite { get => lblWhite; set => lblWhite = value; }
        public Panel PnlShadow { get => pnlShadow; set => pnlShadow = value; }
        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
        public Label LblTournament { get => lblTournament; set => lblTournament = value; }
        public Label LblResult { get => lblResult; set => lblResult = value; }
        public Label LblBlack { get => lblBlack; set => lblBlack = value; }
        public Button BtnShow { get => btnShow; set => btnShow = value; }
        public PictureBox PictureBox2 { get => pictureBox2; set => pictureBox2 = value; }
        public Label LblRound { get => lblRound; set => lblRound = value; }
        public Label LblDate { get => lblDate; set => lblDate = value; }
        public Label LblOpening { get => lblOpening; set => lblOpening = value; }
    }
}
