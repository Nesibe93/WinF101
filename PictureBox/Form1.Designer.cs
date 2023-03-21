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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPictureBox));
            this.pctrbPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrbPicture
            // 
            this.pctrbPicture.Image = ((System.Drawing.Image)(resources.GetObject("pctrbPicture.Image")));
            this.pctrbPicture.Location = new System.Drawing.Point(177, 43);
            this.pctrbPicture.Name = "pctrbPicture";
            this.pctrbPicture.Size = new System.Drawing.Size(467, 293);
            this.pctrbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctrbPicture.TabIndex = 0;
            this.pctrbPicture.TabStop = false;
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctrbPicture);
            this.Name = "frmPictureBox";
            this.Text = "PictureBox";
            this.Load += new System.EventHandler(this.frmPictureBox_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPictureBox_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrbPicture;
    }
}

