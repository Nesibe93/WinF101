namespace ListBox
{
    partial class frmListBox
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
            this.lstbSayilar = new System.Windows.Forms.ListBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.cmbSayiList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbSayilar
            // 
            this.lstbSayilar.FormattingEnabled = true;
            this.lstbSayilar.Location = new System.Drawing.Point(221, 161);
            this.lstbSayilar.Name = "lstbSayilar";
            this.lstbSayilar.Size = new System.Drawing.Size(120, 95);
            this.lstbSayilar.TabIndex = 10;
            this.lstbSayilar.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(137, 112);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(56, 20);
            this.txtAdet.TabIndex = 9;
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.Location = new System.Drawing.Point(219, 88);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(122, 67);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "Listeyi Oluştur";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // cmbSayiList
            // 
            this.cmbSayiList.FormattingEnabled = true;
            this.cmbSayiList.Location = new System.Drawing.Point(220, 61);
            this.cmbSayiList.Name = "cmbSayiList";
            this.cmbSayiList.Size = new System.Drawing.Size(121, 21);
            this.cmbSayiList.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(84, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(151, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sayılar";
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbSayilar);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.cmbSayiList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmListBox";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbSayilar;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ComboBox cmbSayiList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

