namespace MonthDays
{
    partial class frmMonthDays
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
            this.nmrcUDYear = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lstGünler = new System.Windows.Forms.ListBox();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUDYear)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrcUDYear
            // 
            this.nmrcUDYear.Location = new System.Drawing.Point(161, 56);
            this.nmrcUDYear.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.nmrcUDYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmrcUDYear.Name = "nmrcUDYear";
            this.nmrcUDYear.Size = new System.Drawing.Size(120, 20);
            this.nmrcUDYear.TabIndex = 0;
            this.nmrcUDYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yıl : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ay : ";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(191, 128);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(248, 284);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(44, 36);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lstGünler
            // 
            this.lstGünler.FormattingEnabled = true;
            this.lstGünler.Location = new System.Drawing.Point(161, 157);
            this.lstGünler.Name = "lstGünler";
            this.lstGünler.Size = new System.Drawing.Size(131, 121);
            this.lstGünler.TabIndex = 6;
            // 
            // cmbAy
            // 
            this.cmbAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Location = new System.Drawing.Point(160, 94);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(121, 21);
            this.cmbAy.TabIndex = 7;
            // 
            // frmMonthDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 374);
            this.Controls.Add(this.cmbAy);
            this.Controls.Add(this.lstGünler);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrcUDYear);
            this.Name = "frmMonthDays";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMonthDays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUDYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrcUDYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ListBox lstGünler;
        private System.Windows.Forms.ComboBox cmbAy;
    }
}

