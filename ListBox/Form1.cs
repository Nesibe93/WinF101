using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lstbSayilar.Items.Clear();

            int adet = Convert.ToInt32(txtAdet.Text);

            for (int i = 1; i <= adet; i++)
            {
                string sayitext = txtAdet.Text;
                lstbSayilar.Items.Add(sayitext);
            }
           
            lstbSayilar.SelectedIndex = 0;
            txtAdet.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAdet.Select();
        }
    }
}
