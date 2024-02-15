using System.Windows.Forms;

namespace Client.UserControls
{
    partial class ChessBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChessBoard));
            this.chessGrid = new System.Windows.Forms.DataGridView();
            this.lblBlackName = new System.Windows.Forms.Label();
            this.lblBlackTitle = new System.Windows.Forms.Label();
            this.lblWhiteTitle = new System.Windows.Forms.Label();
            this.lblWhiteName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOpening = new System.Windows.Forms.Label();
            this.lblTournament = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblBlack = new System.Windows.Forms.Label();
            this.lblWhite = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chessGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chessGrid
            // 
            this.chessGrid.AllowUserToAddRows = false;
            this.chessGrid.AllowUserToDeleteRows = false;
            this.chessGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chessGrid.ColumnHeadersVisible = false;
            this.chessGrid.Location = new System.Drawing.Point(0, 70);
            this.chessGrid.Margin = new System.Windows.Forms.Padding(0);
            this.chessGrid.MultiSelect = false;
            this.chessGrid.Name = "chessGrid";
            this.chessGrid.ReadOnly = true;
            this.chessGrid.RowHeadersVisible = false;
            this.chessGrid.RowHeadersWidth = 51;
            this.chessGrid.RowTemplate.Height = 24;
            this.chessGrid.Size = new System.Drawing.Size(500, 500);
            this.chessGrid.TabIndex = 0;
            // 
            // lblBlackName
            // 
            this.lblBlackName.AutoSize = true;
            this.lblBlackName.BackColor = System.Drawing.Color.Transparent;
            this.lblBlackName.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackName.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblBlackName.Location = new System.Drawing.Point(59, 9);
            this.lblBlackName.Name = "lblBlackName";
            this.lblBlackName.Size = new System.Drawing.Size(137, 30);
            this.lblBlackName.TabIndex = 1;
            this.lblBlackName.Text = "Alireza Firouzja";
            // 
            // lblBlackTitle
            // 
            this.lblBlackTitle.AutoSize = true;
            this.lblBlackTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBlackTitle.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackTitle.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblBlackTitle.Location = new System.Drawing.Point(62, 35);
            this.lblBlackTitle.Name = "lblBlackTitle";
            this.lblBlackTitle.Size = new System.Drawing.Size(41, 30);
            this.lblBlackTitle.TabIndex = 2;
            this.lblBlackTitle.Text = "GM";
            // 
            // lblWhiteTitle
            // 
            this.lblWhiteTitle.AutoSize = true;
            this.lblWhiteTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblWhiteTitle.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhiteTitle.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblWhiteTitle.Location = new System.Drawing.Point(62, 598);
            this.lblWhiteTitle.Name = "lblWhiteTitle";
            this.lblWhiteTitle.Size = new System.Drawing.Size(41, 30);
            this.lblWhiteTitle.TabIndex = 5;
            this.lblWhiteTitle.Text = "GM";
            // 
            // lblWhiteName
            // 
            this.lblWhiteName.AutoSize = true;
            this.lblWhiteName.BackColor = System.Drawing.Color.Transparent;
            this.lblWhiteName.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhiteName.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblWhiteName.Location = new System.Drawing.Point(59, 573);
            this.lblWhiteName.Name = "lblWhiteName";
            this.lblWhiteName.Size = new System.Drawing.Size(137, 30);
            this.lblWhiteName.TabIndex = 4;
            this.lblWhiteName.Text = "Alireza Firouzja";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.lblOpening);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblTournament);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.lblRound);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.lblBlack);
            this.panel1.Controls.Add(this.lblWhite);
            this.panel1.Location = new System.Drawing.Point(507, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 378);
            this.panel1.TabIndex = 7;
            // 
            // lblOpening
            // 
            this.lblOpening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOpening.AutoEllipsis = true;
            this.lblOpening.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpening.ForeColor = System.Drawing.Color.White;
            this.lblOpening.Location = new System.Drawing.Point(67, 246);
            this.lblOpening.Name = "lblOpening";
            this.lblOpening.Size = new System.Drawing.Size(377, 33);
            this.lblOpening.TabIndex = 21;
            this.lblOpening.Text = "GM";
            this.lblOpening.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTournament
            // 
            this.lblTournament.AutoEllipsis = true;
            this.lblTournament.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournament.ForeColor = System.Drawing.Color.White;
            this.lblTournament.Location = new System.Drawing.Point(67, 177);
            this.lblTournament.Name = "lblTournament";
            this.lblTournament.Size = new System.Drawing.Size(377, 33);
            this.lblTournament.TabIndex = 19;
            this.lblTournament.Text = "GM";
            this.lblTournament.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRound
            // 
            this.lblRound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRound.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblRound.ForeColor = System.Drawing.Color.Gray;
            this.lblRound.Location = new System.Drawing.Point(293, 10);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(207, 42);
            this.lblRound.TabIndex = 17;
            this.lblRound.Text = "Magnus Carlsen";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(5, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(207, 42);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Magnus Carlsen";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.Font = new System.Drawing.Font("Poppins Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblResult.Location = new System.Drawing.Point(214, 62);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(83, 113);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "1/2 - 1/2";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlack
            // 
            this.lblBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlack.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlack.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblBlack.Location = new System.Drawing.Point(309, 62);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(190, 113);
            this.lblBlack.TabIndex = 14;
            this.lblBlack.Text = "Magnus Carlsen";
            this.lblBlack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWhite
            // 
            this.lblWhite.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhite.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblWhite.Location = new System.Drawing.Point(5, 62);
            this.lblWhite.Name = "lblWhite";
            this.lblWhite.Size = new System.Drawing.Size(195, 113);
            this.lblWhite.TabIndex = 13;
            this.lblWhite.Text = "Leineir Dominguez Perez";
            this.lblWhite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirst.BackgroundImage")));
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(126, 296);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(60, 60);
            this.btnFirst.TabIndex = 25;
            this.btnFirst.UseVisualStyleBackColor = false;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Transparent;
            this.btnLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLast.BackgroundImage")));
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Location = new System.Drawing.Point(316, 296);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(60, 60);
            this.btnLast.TabIndex = 24;
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(255, 296);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 60);
            this.btnNext.TabIndex = 23;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.BackgroundImage")));
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(192, 296);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(60, 60);
            this.btnPrevious.TabIndex = 22;
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(11, 237);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(11, 168);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 573);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ChessBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblWhiteTitle);
            this.Controls.Add(this.lblWhiteName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBlackTitle);
            this.Controls.Add(this.lblBlackName);
            this.Controls.Add(this.chessGrid);
            this.Name = "ChessBoard";
            this.Size = new System.Drawing.Size(1017, 626);
            ((System.ComponentModel.ISupportInitialize)(this.chessGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView chessGrid;
        private Label lblBlackName;
        private Label lblBlackTitle;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblWhiteTitle;
        private Label lblWhiteName;
        private Panel panel1;
        private Label lblRound;
        private Label lblDate;
        private Label lblResult;
        private Label lblBlack;
        private Label lblWhite;
        private Button btnFirst;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Label lblOpening;
        private PictureBox pictureBox3;
        private Label lblTournament;
        private PictureBox pictureBox4;

        public DataGridView ChessGrid { get => chessGrid; set => chessGrid = value; }
        public Label LblBlackName { get => lblBlackName; set => lblBlackName = value; }
        public Label LblBlackTitle { get => lblBlackTitle; set => lblBlackTitle = value; }
        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
        public PictureBox PictureBox2 { get => pictureBox2; set => pictureBox2 = value; }
        public Label LblWhiteTitle { get => lblWhiteTitle; set => lblWhiteTitle = value; }
        public Label LblWhiteName { get => lblWhiteName; set => lblWhiteName = value; }
        public Panel Panel1 { get => panel1; set => panel1 = value; }
        public Label LblRound { get => lblRound; set => lblRound = value; }
        public Label LblDate { get => lblDate; set => lblDate = value; }
        public Label LblResult { get => lblResult; set => lblResult = value; }
        public Label LblBlack { get => lblBlack; set => lblBlack = value; }
        public Button BtnFirst { get => btnFirst; set => btnFirst = value; }
        public Button BtnLast { get => btnLast; set => btnLast = value; }
        public Button BtnNext { get => btnNext; set => btnNext = value; }
        public Button BtnPrevious { get => btnPrevious; set => btnPrevious = value; }
        public Label LblOpening { get => lblOpening; set => lblOpening = value; }
        public PictureBox PictureBox3 { get => pictureBox3; set => pictureBox3 = value; }
        public Label LblTournament { get => lblTournament; set => lblTournament = value; }
        public PictureBox PictureBox4 { get => pictureBox4; set => pictureBox4 = value; }
        public Label LblWhite { get => lblWhite; set => lblWhite = value; }
    }
}
