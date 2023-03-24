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
            this.btnDelete = new System.Windows.Forms.Button();
            this.datagwProducts = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpbQuery = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cmbQSupplier = new System.Windows.Forms.ComboBox();
            this.cmbQCategory = new System.Windows.Forms.ComboBox();
            this.txtQProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tabpDetail = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.chckbDiscontinued = new System.Windows.Forms.CheckBox();
            this.numUpdUnitInStock = new System.Windows.Forms.NumericUpDown();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.tabcProducts.SuspendLayout();
            this.tabpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagwProducts)).BeginInit();
            this.grpbQuery.SuspendLayout();
            this.tabpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdUnitInStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(808, 521);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabcProducts
            // 
            this.tabcProducts.Controls.Add(this.tabpData);
            this.tabcProducts.Controls.Add(this.tabpDetail);
            this.tabcProducts.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabcProducts.Location = new System.Drawing.Point(12, 12);
            this.tabcProducts.Name = "tabcProducts";
            this.tabcProducts.SelectedIndex = 0;
            this.tabcProducts.Size = new System.Drawing.Size(881, 508);
            this.tabcProducts.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabcProducts.TabIndex = 1;
            // 
            // tabpData
            // 
            this.tabpData.Controls.Add(this.btnDelete);
            this.tabpData.Controls.Add(this.datagwProducts);
            this.tabpData.Controls.Add(this.btnUpdate);
            this.tabpData.Controls.Add(this.grpbQuery);
            this.tabpData.Controls.Add(this.btnEkle);
            this.tabpData.ForeColor = System.Drawing.Color.Blue;
            this.tabpData.Location = new System.Drawing.Point(4, 26);
            this.tabpData.Name = "tabpData";
            this.tabpData.Padding = new System.Windows.Forms.Padding(3);
            this.tabpData.Size = new System.Drawing.Size(873, 478);
            this.tabpData.TabIndex = 0;
            this.tabpData.Text = "General";
            this.tabpData.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDelete.FlatAppearance.BorderSize = 5;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Location = new System.Drawing.Point(219, 445);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // datagwProducts
            // 
            this.datagwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagwProducts.Location = new System.Drawing.Point(6, 183);
            this.datagwProducts.Name = "datagwProducts";
            this.datagwProducts.Size = new System.Drawing.Size(861, 256);
            this.datagwProducts.TabIndex = 1;
            this.datagwProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagwProducts_CellDoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUpdate.FlatAppearance.BorderSize = 5;
            this.btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Location = new System.Drawing.Point(129, 445);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpbQuery
            // 
            this.grpbQuery.BackColor = System.Drawing.Color.Silver;
            this.grpbQuery.Controls.Add(this.btnQuery);
            this.grpbQuery.Controls.Add(this.cmbQSupplier);
            this.grpbQuery.Controls.Add(this.cmbQCategory);
            this.grpbQuery.Controls.Add(this.txtQProductName);
            this.grpbQuery.Controls.Add(this.label3);
            this.grpbQuery.Controls.Add(this.label2);
            this.grpbQuery.Controls.Add(this.label1);
            this.grpbQuery.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpbQuery.Location = new System.Drawing.Point(6, 6);
            this.grpbQuery.Name = "grpbQuery";
            this.grpbQuery.Size = new System.Drawing.Size(861, 171);
            this.grpbQuery.TabIndex = 0;
            this.grpbQuery.TabStop = false;
            this.grpbQuery.Text = "Sorgu Seçenekleri";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnQuery.ForeColor = System.Drawing.Color.Black;
            this.btnQuery.Location = new System.Drawing.Point(9, 135);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(76, 30);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "Sorgula";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cmbQSupplier
            // 
            this.cmbQSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQSupplier.FormattingEnabled = true;
            this.cmbQSupplier.Location = new System.Drawing.Point(92, 90);
            this.cmbQSupplier.Name = "cmbQSupplier";
            this.cmbQSupplier.Size = new System.Drawing.Size(174, 25);
            this.cmbQSupplier.TabIndex = 2;
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
            // txtQProductName
            // 
            this.txtQProductName.Location = new System.Drawing.Point(92, 30);
            this.txtQProductName.Name = "txtQProductName";
            this.txtQProductName.Size = new System.Drawing.Size(174, 23);
            this.txtQProductName.TabIndex = 1;
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
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEkle.FlatAppearance.BorderSize = 5;
            this.btnEkle.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEkle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEkle.Location = new System.Drawing.Point(48, 445);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // tabpDetail
            // 
            this.tabpDetail.Controls.Add(this.btnSave);
            this.tabpDetail.Controls.Add(this.chckbDiscontinued);
            this.tabpDetail.Controls.Add(this.numUpdUnitInStock);
            this.tabpDetail.Controls.Add(this.cmbSupplier);
            this.tabpDetail.Controls.Add(this.label5);
            this.tabpDetail.Controls.Add(this.Label9);
            this.tabpDetail.Controls.Add(this.label8);
            this.tabpDetail.Controls.Add(this.label6);
            this.tabpDetail.Controls.Add(this.label4);
            this.tabpDetail.Controls.Add(this.cmbCategory);
            this.tabpDetail.Controls.Add(this.txtProductName);
            this.tabpDetail.Location = new System.Drawing.Point(4, 26);
            this.tabpDetail.Name = "tabpDetail";
            this.tabpDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabpDetail.Size = new System.Drawing.Size(873, 478);
            this.tabpDetail.TabIndex = 1;
            this.tabpDetail.Text = "Detail";
            this.tabpDetail.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(134, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // chckbDiscontinued
            // 
            this.chckbDiscontinued.AutoSize = true;
            this.chckbDiscontinued.Location = new System.Drawing.Point(135, 169);
            this.chckbDiscontinued.Name = "chckbDiscontinued";
            this.chckbDiscontinued.Size = new System.Drawing.Size(15, 14);
            this.chckbDiscontinued.TabIndex = 6;
            this.chckbDiscontinued.UseVisualStyleBackColor = true;
            // 
            // numUpdUnitInStock
            // 
            this.numUpdUnitInStock.Location = new System.Drawing.Point(135, 127);
            this.numUpdUnitInStock.Name = "numUpdUnitInStock";
            this.numUpdUnitInStock.Size = new System.Drawing.Size(142, 23);
            this.numUpdUnitInStock.TabIndex = 5;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(134, 90);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(143, 25);
            this.cmbSupplier.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Product Name :";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(14, 166);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(112, 17);
            this.Label9.TabIndex = 2;
            this.Label9.Text = "UnitInStock :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "UnitInStock :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Supplier :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Category :";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(134, 59);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(143, 25);
            this.cmbCategory.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(134, 30);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(143, 23);
            this.txtProductName.TabIndex = 0;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 561);
            this.Controls.Add(this.tabcProducts);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.tabcProducts.ResumeLayout(false);
            this.tabpData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagwProducts)).EndInit();
            this.grpbQuery.ResumeLayout(false);
            this.grpbQuery.PerformLayout();
            this.tabpDetail.ResumeLayout(false);
            this.tabpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdUnitInStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabcProducts;
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
        public System.Windows.Forms.TabPage tabpData;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chckbDiscontinued;
        private System.Windows.Forms.NumericUpDown numUpdUnitInStock;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
    }
}