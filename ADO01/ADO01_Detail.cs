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
    public partial class frmADO01_Detail : Form
    {
        public string Mode; // bu değişken public yani başka bir formdan değeri belirlenecek türden
        string constring = @"Data Source=DESKTOP-V653CLI\SQLEXPRESS01;Initial Catalog=Northwind;Integrated Security=True";

        public frmADO01_Detail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // formu kapatacak
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string vs_SQLText = " ";

            // Bu form her iki işe de yarayacağı için
            // hangi modda olduğumu anlamam lazım
            switch (Mode)
            {
                // Bazı SQL Injectionları engellemek açısından ve
                // daha sade bir komut satırı olması için
                // parametrik kullanım tercih edildi
                case "U":
                    vs_SQLText = "UPDATE Customers SET ";
                  //  vs_SQLTest += "CompanyName = '" + txtCompanyName.Text + "'";
                    vs_SQLText += "CompanyName = @CompanyName,";
                    vs_SQLText += "ContactName = @ContactName,";
                    vs_SQLText += "Country = @Country ";
                    vs_SQLText += "WHERE CustomerID = @CustomerID ";
                    // SQL text oluşturuldu..Parametreli
                    break;

                case "I":
                    vs_SQLText = "INSERT INTO Customers (CustomerID,CompanyName,ContactName,Country) Values (@CustomerID,@CompanyName,@ContactName,@Country)";
                    break;

                default:
                    break;
            }
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(vs_SQLText, con))
                {
                    // Şimdi sıra parametreli doldurmakta
                    cmd.Parameters.AddWithValue("CustomerID",
                        txtCustomerID.Text);
                    cmd.Parameters.AddWithValue("CompanyName",
                        txtCompanyName.Text);
                    cmd.Parameters.AddWithValue("ContactName",
                        txtContactName.Text);
                    cmd.Parameters.AddWithValue("Country",
                        txtCountry.Text);
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open(); // Tanımlamış olduğum connection açılıyor
                        cmd.ExecuteNonQuery(); // çalıştırıyor..Sql textimi sql server tarafına gönderiyor
                        MessageBox.Show("Bilgileriniz Güncellenmiştir..");
                        this.Close();
                    }
                    catch (Exception message)
                    {
                        MessageBox.Show(message.ToString());
                        throw;
                    }
                }
            }
        }
    }
}
