﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO01
{
    public partial class frmProducts : Form
    {
        // Global kısım
        // Aşağıdaki değişken Veritabanına bağlanabilmek için gerekli olan bağlantı cümleciğidir.Şu makinaya ..şu databaseden bağlanmak istiyorum
        string constring = @"Data Source=DESKTOP-V653CLI\SQLEXPRESS01;Initial Catalog=Northwind;Integrated Security=True";
        string vs_SQLCommand = ""; // SQL Komutlarını içerecek
        string vs_SQLQuery = ""; // SQL Query texti içerecek
        string Mode = "";

        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrepareGrid()
        {
            datagwProducts.AutoGenerateColumns = true; // datagrid in otomatik olarak database tablosuna bakıp gridin kolonlarını yaratmasını istemiyorum. Manuel
            // Eğer DataGridin en baş taraftaki kolonu 'RowHeader' görmek istemiyorsam

            datagwProducts.RowHeadersVisible = false;

            // DatagRiddeki kolonları tek tek dolaşmak yerine tek bir satırı ayrıştırma
            datagwProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // DataGriddeki kolonları DataGridin genişliğine göre ayarlama
            datagwProducts.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // DataGridin üzerinde elle oynamayı yasaklama 
            datagwProducts.ReadOnly = true;

            // DataGridin üzerinde kullanıcının satır eklemesini ve silmesini yasaklama
            datagwProducts.AllowUserToAddRows = false;
            datagwProducts.AllowUserToDeleteRows = false;

            // DataGridin satırlarının yüksekliğini ve genişliğini yasaklama
            datagwProducts.AllowUserToResizeRows = false;
        }

        private void BindGrid()
        {
            // DataGrid i dolduran bölüm
            // C# ın using kalıbı. ...bunu kullanarak demek

            using (SqlConnection con = new SqlConnection(constring)) // con isminde bir nesne yarat(SqlConnection kütüphanesinden). yaratırken de constringden yararlan.
            {
                #region SQL Sorgu
                //                SELECT ProductID, ProductName, Suppliers.CompanyName,Categories.CategoryName,UnitsInStock,Discontinued FROM Products
                //INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID
                //INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID
                //WHERE ProductID > 0
                #endregion

                vs_SQLCommand = "SELECT ProductID, ProductName, Suppliers.CompanyName,Categories.CategoryName,UnitsInStock,Discontinued FROM Products ";
                vs_SQLCommand = vs_SQLCommand + "INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID ";
                vs_SQLCommand += "INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID ";
                   vs_SQLCommand += "WHERE ProductID > 0";
                

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con)) // con nesnesini kullarak SQL komutunu oluştur
                {
                    // aşağıda cmd nesnesini kullanabileceğim veri geliş/gidişini ayarlayan bir DataAdapter oluşturuyoruz
                    cmd.CommandType = CommandType.Text; // text şeklinde

                    using (SqlDataAdapter sqlda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dataSet = new DataSet())
                        {
                            sqlda.Fill(dataSet); // Adaptörüm yarattığı dataSeti doldursun
                            datagwProducts.DataSource = dataSet.Tables[0]; // dataSet oluştu..içine table taşındı ve DataGridin içinde görülebilir hale geldi
                        }
                    }
                }
            }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            PrepareGrid();
            BindGrid();
            GetCategory();
        }

        private void GetCategory()
        {
            // SQL tarafındaki Category Tablosundan sorgulamada kullanabilmek için sadece CategoryID ve CategoryName alanlarını almalıyım

            vs_SQLCommand = "SELECT CategoryID,CategoryName FROM Categories";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sqlda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dataSet = new DataSet())
                        {
                            sqlda.Fill(dataSet); // adaptörün yarattığı DataSeti doldursun

                            // comboboxın ilk satırında -- Hepsi -- yazsın

                            // data tablolarında olmayan bir satırı oluşturmak için kullanılan bir class var(DataRow classı) combo içine ilk olarak onun gözükmesini sağlıyacağım

                            DataRow newRow = dataSet.Tables[0].NewRow();
                            newRow = "";







                            cmbQCategory.DataSource = dataSet.Tables[0];
                            cmbQCategory.ValueMember = "CategoryID";
                            cmbQCategory.DisplayMember = "CategoryName";
                        }
                      
                    }
                }
            }
        }

        private void tabcProducts_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Sekmenin arka planını ve yazı rengini belirleyin
            Brush backBrush = new SolidBrush(Color.LightBlue);
            Brush foreBrush = new SolidBrush(Color.Black);

            // Sekme başlığı metnini alın
            string tabText = this.tabcProducts.TabPages[e.Index].Text;

           
            // Metnin boyutunu alın
            SizeF textSize = e.Graphics.MeasureString(tabText, this.Font);

            // Metni çizin
            e.Graphics.FillRectangle(backBrush, e.Bounds);
            e.Graphics.DrawString(tabText, this.Font, foreBrush,
                e.Bounds.Left + (e.Bounds.Width - textSize.Width) / 2,
                e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2);

            // Sekmenin başlığı fontunu kalın olarak ayarlayın
            Font tabFont = new Font(this.Font, FontStyle.Bold);
            //tabFont = this.tabcProducts.Font;

            // Fırçaları serbest bırakın
            backBrush.Dispose();
            foreBrush.Dispose();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            vs_SQLQuery = "";
            if (txtQProductName.Text != "") // adam textbox a bir şey girmiş mi
            {

            }
        }
    }
}
