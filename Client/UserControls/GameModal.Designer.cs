using System.Windows.Forms;

namespace Client.UserControls
{
    partial class GameModal
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
            this.tbOtvaranje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numRunda = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBeli = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCrni = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFEN = new System.Windows.Forms.TextBox();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.tbRezultat = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlShadow = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numRunda)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbOtvaranje
            // 
            this.tbOtvaranje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.tbOtvaranje.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOtvaranje.ForeColor = System.Drawing.Color.White;
            this.tbOtvaranje.Location = new System.Drawing.Point(33, 115);
            this.tbOtvaranje.Name = "tbOtvaranje";
            this.tbOtvaranje.Size = new System.Drawing.Size(301, 37);
            this.tbOtvaranje.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otvaranje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Runda";
            // 
            // numRunda
            // 
            this.numRunda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.numRunda.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRunda.ForeColor = System.Drawing.Color.White;
            this.numRunda.Location = new System.Drawing.Point(33, 305);
            this.numRunda.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRunda.Name = "numRunda";
            this.numRunda.Size = new System.Drawing.Size(301, 37);
            this.numRunda.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(357, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Datum";
            // 
            // cbBeli
            // 
            this.cbBeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.cbBeli.Font = new System.Drawing.Font("Poppins", 10F);
            this.cbBeli.ForeColor = System.Drawing.Color.White;
            this.cbBeli.FormattingEnabled = true;
            this.cbBeli.Location = new System.Drawing.Point(363, 207);
            this.cbBeli.Name = "cbBeli";
            this.cbBeli.Size = new System.Drawing.Size(167, 38);
            this.cbBeli.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(357, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 36);
            this.label6.TabIndex = 13;
            this.label6.Text = "Beli";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(534, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 36);
            this.label7.TabIndex = 15;
            this.label7.Text = "Crni";
            // 
            // cbCrni
            // 
            this.cbCrni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.cbCrni.Font = new System.Drawing.Font("Poppins", 10F);
            this.cbCrni.ForeColor = System.Drawing.Color.White;
            this.cbCrni.FormattingEnabled = true;
            this.cbCrni.Location = new System.Drawing.Point(540, 207);
            this.cbCrni.Name = "cbCrni";
            this.cbCrni.Size = new System.Drawing.Size(167, 38);
            this.cbCrni.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.lblTitle.Font = new System.Drawing.Font("Poppins Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblTitle.Location = new System.Drawing.Point(3, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(735, 50);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "label8";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbFEN);
            this.panel1.Controls.Add(this.dtDatum);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbCrni);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.tbRezultat);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.numRunda);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbBeli);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 471);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(358, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 36);
            this.label3.TabIndex = 20;
            this.label3.Text = "FEN";
            // 
            // tbFEN
            // 
            this.tbFEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.tbFEN.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFEN.ForeColor = System.Drawing.Color.White;
            this.tbFEN.Location = new System.Drawing.Point(363, 305);
            this.tbFEN.Multiline = true;
            this.tbFEN.Name = "tbFEN";
            this.tbFEN.Size = new System.Drawing.Size(344, 37);
            this.tbFEN.TabIndex = 23;
            // 
            // dtDatum
            // 
            this.dtDatum.CalendarFont = new System.Drawing.Font("Poppins", 8F);
            this.dtDatum.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDatum.Location = new System.Drawing.Point(363, 115);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(344, 37);
            this.dtDatum.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Rezultat";
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.LightCoral;
            this.lblError.Location = new System.Drawing.Point(0, 425);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(738, 46);
            this.lblError.TabIndex = 18;
            this.lblError.Text = "label8";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRezultat
            // 
            this.tbRezultat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.tbRezultat.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRezultat.ForeColor = System.Drawing.Color.White;
            this.tbRezultat.Location = new System.Drawing.Point(33, 207);
            this.tbRezultat.Name = "tbRezultat";
            this.tbRezultat.Size = new System.Drawing.Size(301, 37);
            this.tbRezultat.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnSave.Location = new System.Drawing.Point(281, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 48);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "button1";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // pnlShadow
            // 
            this.pnlShadow.Location = new System.Drawing.Point(19, 16);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(737, 469);
            this.pnlShadow.TabIndex = 19;
            // 
            // GameModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOtvaranje);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlShadow);
            this.Name = "GameModal";
            this.Size = new System.Drawing.Size(797, 492);
            ((System.ComponentModel.ISupportInitialize)(this.numRunda)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOtvaranje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numRunda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBeli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCrni;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlShadow;
        private Label label2;
        private TextBox tbRezultat;
        private Label label3;
        private TextBox tbFEN;
        private DateTimePicker dtDatum;

        public TextBox TbOtvaranje { get => tbOtvaranje; set => tbOtvaranje = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public NumericUpDown NumRunda { get => numRunda; set => numRunda = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public ComboBox CbBeli { get => cbBeli; set => cbBeli = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public ComboBox CbCrni { get => cbCrni; set => cbCrni = value; }
        public Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public Panel Panel1 { get => panel1; set => panel1 = value; }
        public Button BtnSave { get => btnSave; set => btnSave = value; }
        public Label LblError { get => lblError; set => lblError = value; }
        public Panel PnlShadow { get => pnlShadow; set => pnlShadow = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public TextBox TbRezultat { get => tbRezultat; set => tbRezultat = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public TextBox TbFEN { get => tbFEN; set => tbFEN = value; }
        public DateTimePicker DtDatum { get => dtDatum; set => dtDatum = value; }
    }
}
