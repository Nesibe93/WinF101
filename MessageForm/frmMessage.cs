using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageForm
{
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message;

            message = tboxMessage.Text;

            //MessageBox.Show("Ali veli 49 50"); // aslında burada parametre göndermişim


            MessageBox.Show(message); // aslında burada parametre göndermişim

            tboxMessage.Text = "";
            tboxMessage.Clear();

        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
