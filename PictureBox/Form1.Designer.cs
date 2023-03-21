namespace PictureBox
{
    partial class frmPictureBox
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
            this.pctrbPicture = new System.Windows.Forms.PictureBox();
            this.lblFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrbPicture
            // 
            this.pctrbPicture.Location = new System.Drawing.Point(256, 111);
            this.pctrbPicture.Name = "pctrbPicture";
            this.pctrbPicture.Size = new System.Drawing.Size(278, 194);
            this.pctrbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctrbPicture.TabIndex = 0;
            this.pctrbPicture.TabStop = false;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFileName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFileName.Location = new System.Drawing.Point(24, 407);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(37, 13);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "          ";
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.pctrbPicture);
            this.Name = "frmPictureBox";
            this.Text = "PictureBox";
            this.Load += new System.EventHandler(this.frmPictureBox_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPictureBox_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrbPicture;
        private System.Windows.Forms.Label lblFileName;
    }
}

