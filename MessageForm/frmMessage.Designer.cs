namespace MessageForm
{
    partial class frmMessage
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
            this.btonMessage = new System.Windows.Forms.Button();
            this.tboxMessage = new System.Windows.Forms.TextBox();
            this.btonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btonMessage
            // 
            this.btonMessage.Location = new System.Drawing.Point(51, 132);
            this.btonMessage.Name = "btonMessage";
            this.btonMessage.Size = new System.Drawing.Size(131, 23);
            this.btonMessage.TabIndex = 0;
            this.btonMessage.Text = "Mesajı Göster";
            this.btonMessage.UseVisualStyleBackColor = true;
            this.btonMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // tboxMessage
            // 
            this.tboxMessage.Location = new System.Drawing.Point(51, 36);
            this.tboxMessage.Name = "tboxMessage";
            this.tboxMessage.Size = new System.Drawing.Size(169, 20);
            this.tboxMessage.TabIndex = 1;
            // 
            // btonExit
            // 
            this.btonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonExit.Location = new System.Drawing.Point(214, 205);
            this.btonExit.Name = "btonExit";
            this.btonExit.Size = new System.Drawing.Size(75, 23);
            this.btonExit.TabIndex = 2;
            this.btonExit.Text = "Çıkış";
            this.btonExit.UseVisualStyleBackColor = true;
            this.btonExit.Click += new System.EventHandler(this.btonExit_Click);
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 240);
            this.ControlBox = false;
            this.Controls.Add(this.btonExit);
            this.Controls.Add(this.tboxMessage);
            this.Controls.Add(this.btonMessage);
            this.Name = "frmMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesaj Kutusu Örneği";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonMessage;
        private System.Windows.Forms.TextBox tboxMessage;
        private System.Windows.Forms.Button btonExit;
    }
}

