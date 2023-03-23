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
            this.datagwProducts = new System.Windows.Forms.DataGridView();
            this.grpbQuery = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cmbQSupplier = new System.Windows.Forms.ComboBox();
            this.cmbQCategory = new System.Windows.Forms.ComboBox();
            this.txtQProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabpDetail = new System.Windows.Forms.TabPage();
            this.tabcProducts.SuspendLayout();
            this.tabpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagwProducts)).BeginInit();
            this.grpbQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(812, 483);
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
            this.tabcProducts.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabcProducts.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabcProducts.Location = new System.Drawing.Point(12, 12);
            this.tabcProducts.Name = "tabcProducts";
            this.tabcProducts.SelectedIndex = 0;
            this.tabcProducts.Size = new System.Drawing.Size(881, 471);
            this.tabcProducts.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabcProducts.TabIndex = 1;
            this.tabcProducts.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabcProducts_DrawItem);
            // 
            // tabpData
            // 
            this.tabpData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabpData.Controls.Add(this.datagwProducts);
            this.tabpData.Controls.Add(this.grpbQuery);
            this.tabpData.ForeColor = System.Drawing.Color.Blue;
            this.tabpData.Location = new System.Drawing.Point(4, 26);
            this.tabpData.Name = "tabpData";
            this.tabpData.Padding = new System.Windows.Forms.Padding(3);
            this.tabpData.Size = new System.Drawing.Size(873, 441);
            this.tabpData.TabIndex = 0;
            this.tabpData.Text = "General";
            this.tabpData.UseVisualStyleBackColor = true;
            // 
            // datagwProducts
            // 
            this.datagwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagwProducts.Location = new System.Drawing.Point(6, 183);
            this.datagwProducts.Name = "datagwProducts";
            this.datagwProducts.Size = new System.Drawing.Size(861, 256);
            this.datagwProducts.TabIndex = 1;
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
            this.cmbQSupplier.Size = new System.Drawing.Size(196, 25);
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
            this.txtQProductName.Size = new System.Drawing.Size(196, 23);
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
            // tabpDetail
            // 
            this.tabpDetail.Location = new System.Drawing.Point(4, 26);
            this.tabpDetail.Name = "tabpDetail";
            this.tabpDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabpDetail.Size = new System.Drawing.Size(873, 441);
            this.tabpDetail.TabIndex = 1;
            this.tabpDetail.Text = "Detail";
            this.tabpDetail.UseVisualStyleBackColor = true;
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
    }
}