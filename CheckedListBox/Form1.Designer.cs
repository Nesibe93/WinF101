namespace CheckedListBox
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
            this.chckdLCars = new System.Windows.Forms.CheckedListBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lstBSelectedCars = new System.Windows.Forms.ListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chckdLCars
            // 
            this.chckdLCars.FormattingEnabled = true;
            this.chckdLCars.Items.AddRange(new object[] {
            "Volvo XC70",
            "Volkswagen Beetle (1974)",
            "Ford Bronco",
            "Bugatti Veyron",
            "Mercedes 230.4",
            "Renault Altair"});
            this.chckdLCars.Location = new System.Drawing.Point(44, 73);
            this.chckdLCars.Name = "chckdLCars";
            this.chckdLCars.Size = new System.Drawing.Size(151, 109);
            this.chckdLCars.TabIndex = 0;
            this.chckdLCars.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chckdLCars_ItemCheck);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Red;
            this.btnCikis.Location = new System.Drawing.Point(326, 233);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(87, 44);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // lstBSelectedCars
            // 
            this.lstBSelectedCars.FormattingEnabled = true;
            this.lstBSelectedCars.Location = new System.Drawing.Point(289, 73);
            this.lstBSelectedCars.Name = "lstBSelectedCars";
            this.lstBSelectedCars.Size = new System.Drawing.Size(151, 108);
            this.lstBSelectedCars.TabIndex = 3;
            // 
            // btnAktar
            // 
            this.btnAktar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktar.ForeColor = System.Drawing.Color.Red;
            this.btnAktar.Location = new System.Drawing.Point(208, 115);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(75, 28);
            this.btnAktar.TabIndex = 4;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 334);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.lstBSelectedCars);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.chckdLCars);
            this.Name = "Form1";
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chckdLCars;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ListBox lstBSelectedCars;
        private System.Windows.Forms.Button btnAktar;
    }
}

