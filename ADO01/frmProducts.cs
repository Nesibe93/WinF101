using System;
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

        string vs_SQLCommandAna = ""; // SQL komutlarımı içerecek
        string vs_SQLCommand = ""; // combo için
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

        private void BindGrid(string prmSQLText)
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

                //vs_SQLCommand = "SELECT ProductID, ProductName, Suppliers.CompanyName,Categories.CategoryName,UnitsInStock,Discontinued FROM Products ";
                //vs_SQLCommand = vs_SQLCommand + "INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID ";
                //vs_SQLCommand += "INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID ";
                //   vs_SQLCommand += "WHERE ProductID > 0";
                

                using (SqlCommand cmd = new SqlCommand(prmSQLText, con)) // con nesnesini kullanarak SQL komutunu oluştur
                {
                    // aşağıda cmd nesnesini kullanabileceğim veri geliş/gidişini ayarlayan bir DataAdapter oluşturuyoruz
                    cmd.CommandType = CommandType.Text; // text şeklinde

                    using (SqlDataAdapter sqlda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dataSet = new DataSet())
                        {
                            sqlda.Fill(dataSet);
                            // Adaptörüm yarattığı dataSeti doldursun
                            datagwProducts.DataSource = dataSet.Tables[0]; // dataSet oluştu..içine table taşındı ve DataGridin içinde görülebilir hale geldi
                        }
                    }
                }
            }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            PrepareGrid();

            vs_SQLCommandAna = "SELECT ProductID, ProductName, Suppliers.CompanyName,Categories.CategoryName,UnitsInStock,Discontinued FROM Products ";
            vs_SQLCommandAna = vs_SQLCommandAna + "INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID ";
            vs_SQLCommandAna += "INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID ";
            vs_SQLCommandAna += "WHERE ProductID > 0 ";


            BindGrid(vs_SQLCommandAna);
            GetCategory();
            GetSuppliers();
        }

        private void GetCategory()
        {
            // SQL tarafındaki Category Tablosundan sorgulamada kullanabilmek için sadece CategoryID ve CategoryName alanlarını almalıyım

            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "SELECT CategoryID,CategoryName FROM Categories";

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
                            newRow["CategoryID"]= 0;
                            newRow["CategoryName"]= "---HEPSI---";
                            dataSet.Tables[0].Rows.InsertAt(newRow, 0);


                            cmbQCategory.DataSource = dataSet.Tables[0];
                            cmbQCategory.ValueMember = "CategoryID";
                            cmbQCategory.DisplayMember = "CategoryName";
                        }
                      
                    }
                }
            }
        }

        private void GetSuppliers()
        {
            // SQL tarafındaki Category Tablosundan sorgulamada kullanabilmek için sadece CategoryID ve CategoryName alanlarını almalıyım

            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "SELECT SupplierID,CompanyName FROM Suppliers";

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
                            newRow["SupplierID"] = 0;
                            newRow["CompanyName"] = "---HEPSI---";
                            dataSet.Tables[0].Rows.InsertAt(newRow, 0);


                            cmbQSupplier.DataSource = dataSet.Tables[0];
                            cmbQSupplier.ValueMember = "SupplierID";
                            cmbQSupplier.DisplayMember = "CompanyName";
                        }

                    }
                }
            }
        }

        #region TabControl
        // TabControl drawmode->ownerdrawfixed'da sekmelerin ismi gözükmüyor.Çiziyoruz
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

            // Fırçaları serbest bırakın
            backBrush.Dispose();
            foreBrush.Dispose();
        }

        #endregion

        private void btnQuery_Click(object sender, EventArgs e)
        {
            vs_SQLQuery = "";
            if (txtQProductName.Text != "") // adam textbox a bir şey girmiş mi
            {
                vs_SQLQuery += "AND ProductName LIKE '%" + 
                    txtQProductName.Text + "%'";
            }

            // Not: Category combosundaki değişimi eğer 

            if (cmbQCategory.SelectedIndex > 0)
            {
                vs_SQLQuery += "AND Products.CategoryID =" + cmbQCategory.SelectedValue;
                
            }

            if (cmbQSupplier.SelectedIndex > 0)
            {
                vs_SQLQuery += "AND Products.SupplierID=" + cmbQSupplier.SelectedValue;
            }


            BindGrid(vs_SQLCommandAna + vs_SQLQuery);

        }

    }
}
