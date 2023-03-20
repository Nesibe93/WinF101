namespace MLTextBox
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
            this.txtSayilar = new System.Windows.Forms.TextBox();
            this.btnSayiUret = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSayilar
            // 
            this.txtSayilar.Location = new System.Drawing.Point(127, 83);
            this.txtSayilar.Multiline = true;
            this.txtSayilar.Name = "txtSayilar";
            this.txtSayilar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSayilar.Size = new System.Drawing.Size(118, 121);
            this.txtSayilar.TabIndex = 0;
            // 
            // btnSayiUret
            // 
            this.btnSayiUret.Location = new System.Drawing.Point(127, 210);
            this.btnSayiUret.Name = "btnSayiUret";
            this.btnSayiUret.Size = new System.Drawing.Size(118, 50);
            this.btnSayiUret.TabIndex = 1;
            this.btnSayiUret.Text = "Sayı Üret";
            this.btnSayiUret.UseVisualStyleBackColor = true;
            this.btnSayiUret.Click += new System.EventHandler(this.btnSayiUret_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSayiUret);
            this.Controls.Add(this.txtSayilar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayilar;
        private System.Windows.Forms.Button btnSayiUret;
        private System.Windows.Forms.Label label1;
    }
}

