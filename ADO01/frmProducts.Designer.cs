namespace ADO01
{
    partial class frmProducts
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tabcProducts = new System.Windows.Forms.TabControl();
            this.tabpData = new System.Windows.Forms.TabPage();
            this.tabpDetail = new System.Windows.Forms.TabPage();
            this.grpbQuery = new System.Windows.Forms.GroupBox();
            this.datagwProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbQCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbQSupplier = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.tabcProducts.SuspendLayout();
            this.tabpData.SuspendLayout();
            this.grpbQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(660, 489);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabcProducts
            // 
            this.tabcProducts.Controls.Add(this.tabpData);
            this.tabcProducts.Controls.Add(this.tabpDetail);
            this.tabcProducts.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabcProducts.Location = new System.Drawing.Point(12, 12);
            this.tabcProducts.Name = "tabcProducts";
            this.tabcProducts.SelectedIndex = 0;
            this.tabcProducts.Size = new System.Drawing.Size(733, 475);
            this.tabcProducts.TabIndex = 1;
            // 
            // tabpData
            // 
            this.tabpData.Controls.Add(this.datagwProducts);
            this.tabpData.Controls.Add(this.grpbQuery);
            this.tabpData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tabpData.Location = new System.Drawing.Point(4, 26);
            this.tabpData.Name = "tabpData";
            this.tabpData.Padding = new System.Windows.Forms.Padding(3);
            this.tabpData.Size = new System.Drawing.Size(725, 445);
            this.tabpData.TabIndex = 0;
            this.tabpData.Text = "General";
            this.tabpData.UseVisualStyleBackColor = true;
            // 
            // tabpDetail
            // 
            this.tabpDetail.Location = new System.Drawing.Point(4, 26);
            this.tabpDetail.Name = "tabpDetail";
            this.tabpDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabpDetail.Size = new System.Drawing.Size(725, 339);
            this.tabpDetail.TabIndex = 1;
            this.tabpDetail.Text = "Detail";
            this.tabpDetail.UseVisualStyleBackColor = true;
            // 
            // grpbQuery
            // 
            this.grpbQuery.Controls.Add(this.btnQuery);
            this.grpbQuery.Controls.Add(this.cmbQSupplier);
            this.grpbQuery.Controls.Add(this.cmbQCategory);
            this.grpbQuery.Controls.Add(this.txtQProductName);
            this.grpbQuery.Controls.Add(this.label3);
            this.grpbQuery.Controls.Add(this.label2);
            this.grpbQuery.Controls.Add(this.label1);
            this.grpbQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grpbQuery.Location = new System.Drawing.Point(6, 6);
            this.grpbQuery.Name = "grpbQuery";
            this.grpbQuery.Size = new System.Drawing.Size(713, 171);
            this.grpbQuery.TabIndex = 0;
            this.grpbQuery.TabStop = false;
            this.grpbQuery.Text = "Sorgu Seçenekleri";
            // 
            // datagwProducts
            // 
            this.datagwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagwProducts.Location = new System.Drawing.Point(6, 183);
            this.datagwProducts.Name = "datagwProducts";
            this.datagwProducts.Size = new System.Drawing.Size(713, 256);
            this.datagwProducts.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı : ";
            // 
            // txtQProductName
            // 
            this.txtQProductName.Location = new System.Drawing.Point(92, 30);
            this.txtQProductName.Name = "txtQProductName";
            this.txtQProductName.Size = new System.Drawing.Size(196, 23);
            this.txtQProductName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(0, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori : ";
            // 
            // cmbQCategory
            // 
            this.cmbQCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQCategory.FormattingEnabled = true;
            this.cmbQCategory.Location = new System.Drawing.Point(92, 59);
            this.cmbQCategory.Name = "cmbQCategory";
            this.cmbQCategory.Size = new System.Drawing.Size(133, 25);
            this.cmbQCategory.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(0, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tedarikçi: ";
            // 
            // cmbQSupplier
            // 
            this.cmbQSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQSupplier.FormattingEnabled = true;
            this.cmbQSupplier.Location = new System.Drawing.Point(92, 90);
            this.cmbQSupplier.Name = "cmbQSupplier";
            this.cmbQSupplier.Size = new System.Drawing.Size(196, 25);
            this.cmbQSupplier.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.ForeColor = System.Drawing.Color.Black;
            this.btnQuery.Location = new System.Drawing.Point(9, 135);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(76, 30);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "Sorgula";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 546);
            this.Controls.Add(this.tabcProducts);
            this.Controls.Add(this.btnClose);
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.tabcProducts.ResumeLayout(false);
            this.tabpData.ResumeLayout(false);
            this.grpbQuery.ResumeLayout(false);
            this.grpbQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagwProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabcProducts;
        private System.Windows.Forms.TabPage tabpData;
        private System.Windows.Forms.DataGridView datagwProducts;
        private System.Windows.Forms.GroupBox grpbQuery;
        private System.Windows.Forms.TabPage tabpDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQProductName;
        private System.Windows.Forms.ComboBox cmbQCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbQSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuery;
    }
}