namespace ListBox02
{
    partial class frmListBox02
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
            this.txtAltSinir = new System.Windows.Forms.TextBox();
            this.txtUstSinir = new System.Windows.Forms.TextBox();
            this.lstBSonuc = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSayiUret = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMesaj2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAltSinir
            // 
            this.txtAltSinir.BackColor = System.Drawing.Color.Moccasin;
            this.txtAltSinir.Location = new System.Drawing.Point(243, 117);
            this.txtAltSinir.Margin = new System.Windows.Forms.Padding(4);
            this.txtAltSinir.Name = "txtAltSinir";
            this.txtAltSinir.Size = new System.Drawing.Size(50, 24);
            this.txtAltSinir.TabIndex = 0;
            // 
            // txtUstSinir
            // 
            this.txtUstSinir.BackColor = System.Drawing.Color.Moccasin;
            this.txtUstSinir.Location = new System.Drawing.Point(243, 156);
            this.txtUstSinir.Margin = new System.Windows.Forms.Padding(4);
            this.txtUstSinir.Name = "txtUstSinir";
            this.txtUstSinir.Size = new System.Drawing.Size(50, 24);
            this.txtUstSinir.TabIndex = 1;
            // 
            // lstBSonuc
            // 
            this.lstBSonuc.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lstBSonuc.FormattingEnabled = true;
            this.lstBSonuc.ItemHeight = 19;
            this.lstBSonuc.Location = new System.Drawing.Point(212, 188);
            this.lstBSonuc.Margin = new System.Windows.Forms.Padding(4);
            this.lstBSonuc.Name = "lstBSonuc";
            this.lstBSonuc.Size = new System.Drawing.Size(116, 156);
            this.lstBSonuc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(162, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alt Sınır :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(156, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Üst Sınır :";
            // 
            // btnSayiUret
            // 
            this.btnSayiUret.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSayiUret.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayiUret.Location = new System.Drawing.Point(328, 103);
            this.btnSayiUret.Margin = new System.Windows.Forms.Padding(4);
            this.btnSayiUret.Name = "btnSayiUret";
            this.btnSayiUret.Size = new System.Drawing.Size(87, 53);
            this.btnSayiUret.TabIndex = 5;
            this.btnSayiUret.Text = "Random Sayı Üret";
            this.btnSayiUret.UseVisualStyleBackColor = false;
            this.btnSayiUret.Click += new System.EventHandler(this.btnSayiUret_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(162, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 60);
            this.label3.TabIndex = 6;
            this.label3.Text = "Üretilecek Adet : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMesaj.Location = new System.Drawing.Point(229, 392);
            this.lblMesaj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(45, 19);
            this.lblMesaj.TabIndex = 7;
            this.lblMesaj.Text = "         ";
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.LightCoral;
            this.btnCikis.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(510, 372);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(91, 56);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.BackColor = System.Drawing.Color.Moccasin;
            this.txtAdet.Location = new System.Drawing.Point(243, 70);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(50, 24);
            this.txtAdet.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(144, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mesaj :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(144, 421);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "Toplam :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMesaj2
            // 
            this.lblMesaj2.AutoSize = true;
            this.lblMesaj2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMesaj2.Location = new System.Drawing.Point(229, 431);
            this.lblMesaj2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMesaj2.Name = "lblMesaj2";
            this.lblMesaj2.Size = new System.Drawing.Size(45, 19);
            this.lblMesaj2.TabIndex = 12;
            this.lblMesaj2.Text = "         ";
            // 
            // frmListBox02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(683, 525);
            this.Controls.Add(this.lblMesaj2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSayiUret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBSonuc);
            this.Controls.Add(this.txtUstSinir);
            this.Controls.Add(this.txtAltSinir);
            this.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListBox02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmListBox02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAltSinir;
        private System.Windows.Forms.TextBox txtUstSinir;
        private System.Windows.Forms.ListBox lstBSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSayiUret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMesaj2;
    }
}

