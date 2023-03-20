using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtAdet.Select();
            cmbSayiList.Enabled = false;
        }

        private void btnList_Click_1(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                cmbSayiList.Items.Add(i + ". sayı");
            }
            cmbSayiList.Enabled=true;   
            cmbSayiList.SelectedIndex=0;
            txtAdet.Text = "";
        }

        private void cmbSayiList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
