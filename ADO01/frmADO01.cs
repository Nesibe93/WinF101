using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO01
{

    public partial class frmADO01 : Form
    {
        // Global kısım
        // Aşağıdaki değişken Veritabanına bağlanabilmek için gerekli olan bağlantı cümleciğidir.Şu makinaya ..şu databaseden bağlanmak istiyorum

        string constring = @"Data Source=DESKTOP-V653CLI\SQLEXPRESS01;Initial Catalog=Northwind;Integrated Security=True"; // slash varsa string gibi anlaması için başına "@" koyuyoruz

        public frmADO01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmADO01_Load(object sender, EventArgs e)
        {
            //form ilk ekrana geldiğinde DataGrid otomatik dolu gelsin.
            PrepareGrid(); // DataGridimi hazırlıyorum...
        }

        // 
        private void PrepareGrid()
        {
            datagwCustomers.AutoGenerateColumns = false; // datagrid in otomatik olarak database tablosuna bakıp gridin kolonlarını yaratmasını istemiyorum. Manuel


        }
    }
}
