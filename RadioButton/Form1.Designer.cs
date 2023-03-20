namespace RadioButton
{
    partial class Form1
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
            this.btnIslemYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbArtir = new System.Windows.Forms.RadioButton();
            this.rdbAzalt = new System.Windows.Forms.RadioButton();
            this.nmrUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSayi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIslemYap
            // 
            this.btnIslemYap.Location = new System.Drawing.Point(213, 107);
            this.btnIslemYap.Name = "btnIslemYap";
            this.btnIslemYap.Size = new System.Drawing.Size(75, 23);
            this.btnIslemYap.TabIndex = 0;
            this.btnIslemYap.Text = "İşlem Yap";
            this.btnIslemYap.UseVisualStyleBackColor = true;
            this.btnIslemYap.Click += new System.EventHandler(this.btnIslemYap_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sonuç :";
            // 
            // rdbArtir
            // 
            this.rdbArtir.AutoSize = true;
            this.rdbArtir.Location = new System.Drawing.Point(132, 81);
            this.rdbArtir.Name = "rdbArtir";
            this.rdbArtir.Size = new System.Drawing.Size(46, 17);
            this.rdbArtir.TabIndex = 2;
            this.rdbArtir.Text = "Arttır";
            this.rdbArtir.UseVisualStyleBackColor = true;
            // 
            // rdbAzalt
            // 
            this.rdbAzalt.AutoSize = true;
            this.rdbAzalt.Location = new System.Drawing.Point(132, 104);
            this.rdbAzalt.Name = "rdbAzalt";
            this.rdbAzalt.Size = new System.Drawing.Size(48, 17);
            this.rdbAzalt.TabIndex = 3;
            this.rdbAzalt.Text = "Azalt";
            this.rdbAzalt.UseVisualStyleBackColor = true;
            // 
            // nmrUpDown
            // 
            this.nmrUpDown.Location = new System.Drawing.Point(213, 81);
            this.nmrUpDown.Name = "nmrUpDown";
            this.nmrUpDown.Size = new System.Drawing.Size(120, 20);
            this.nmrUpDown.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Miktar";
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Location = new System.Drawing.Point(171, 143);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(13, 13);
            this.lblSayi.TabIndex = 6;
            this.lblSayi.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 279);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmrUpDown);
            this.Controls.Add(this.rdbAzalt);
            this.Controls.Add(this.rdbArtir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIslemYap);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIslemYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbArtir;
        private System.Windows.Forms.RadioButton rdbAzalt;
        private System.Windows.Forms.NumericUpDown nmrUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSayi;
    }
}

