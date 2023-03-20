namespace SimpleCalculator
{
    partial class frmCalculator
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
            this.tboxSayi1 = new System.Windows.Forms.TextBox();
            this.tboxSayi2 = new System.Windows.Forms.TextBox();
            this.btonHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btonExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxOperator = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxSayi1
            // 
            this.tboxSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxSayi1.Location = new System.Drawing.Point(239, 39);
            this.tboxSayi1.Name = "tboxSayi1";
            this.tboxSayi1.Size = new System.Drawing.Size(75, 38);
            this.tboxSayi1.TabIndex = 0;
            this.tboxSayi1.Enter += new System.EventHandler(this.tboxSayi1_Enter);
            // 
            // tboxSayi2
            // 
            this.tboxSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxSayi2.Location = new System.Drawing.Point(239, 93);
            this.tboxSayi2.Name = "tboxSayi2";
            this.tboxSayi2.Size = new System.Drawing.Size(75, 38);
            this.tboxSayi2.TabIndex = 1;
            this.tboxSayi2.Enter += new System.EventHandler(this.tboxSayi2_Enter);
            // 
            // btonHesapla
            // 
            this.btonHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btonHesapla.Location = new System.Drawing.Point(125, 252);
            this.btonHesapla.Name = "btonHesapla";
            this.btonHesapla.Size = new System.Drawing.Size(138, 76);
            this.btonHesapla.TabIndex = 2;
            this.btonHesapla.Text = "Hesapla";
            this.btonHesapla.UseVisualStyleBackColor = true;
            this.btonHesapla.Click += new System.EventHandler(this.btonHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "1.sayıyı giriniz : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "2.sayıyı giriniz :";
            // 
            // btonExit
            // 
            this.btonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btonExit.Location = new System.Drawing.Point(335, 444);
            this.btonExit.Name = "btonExit";
            this.btonExit.Size = new System.Drawing.Size(110, 49);
            this.btonExit.TabIndex = 5;
            this.btonExit.Text = "Çıkış";
            this.btonExit.UseVisualStyleBackColor = true;
            this.btonExit.Click += new System.EventHandler(this.btonExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(58, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // cboxOperator
            // 
            this.cboxOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxOperator.FormattingEnabled = true;
            this.cboxOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboxOperator.Location = new System.Drawing.Point(239, 170);
            this.cboxOperator.Name = "cboxOperator";
            this.cboxOperator.Size = new System.Drawing.Size(121, 39);
            this.cboxOperator.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(98, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "İşleminiz :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 505);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxOperator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btonExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonHesapla);
            this.Controls.Add(this.tboxSayi2);
            this.Controls.Add(this.tboxSayi1);
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxSayi1;
        private System.Windows.Forms.TextBox tboxSayi2;
        private System.Windows.Forms.Button btonHesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btonExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxOperator;
        private System.Windows.Forms.Label label4;
    }
}

