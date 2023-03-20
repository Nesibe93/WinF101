using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComboBox; // referans ile projeye dahil edilen diğer proje...Öncesinde projeye add...referans ile // atanıyor
using ListBox;
// Çağırdığı alt programdan çıkış yapıldığında sadece close yapsın. ana programı da sonlandırmasın...

namespace Menu2ndForm
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            SystemExit();
        }

        private void SystemExit()
        {
            Application.Exit();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemExit();
        }

        private void Form2Open_Click(object sender, EventArgs e)
        {
            // Formlar da aslında bir class

            // ikinci formu açabilmek için yapman gereken şey açmak istediğim formu örneklemek olacaktır

            frmForm2 frmForm2 = new frmForm2();  // Örnekledim
            frmForm2.ShowDialog(); // ekranda açtım
        }

        private void Form3Open_Click(object sender, EventArgs e)
        {
            frmForm3 frmForm3= new frmForm3();  
            frmForm3.ShowDialog();
        }

     

        private void frmAna_Load(object sender, EventArgs e)
        {

        }


        private void comboBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ComboBox.Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox.frmListBox form1 = new frmListBox();
            form1.ShowDialog();
        }
    }
}
