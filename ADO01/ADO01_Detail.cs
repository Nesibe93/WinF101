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
            string vs_SQLTest;

            // Bu form her iki işe de yarayacağı için
            // hangi modda olduğumu anlamam lazım
            switch (Mode)
            {
                // Bazı SQL Injectionları engellemek açısından ve
                // daha sade bir komut satırı olması için
                // parametrik kullanım tercih edildi
                case "U":


                default:
                    break;
            }
        }
    }
}
