using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLTextBox
{
    public partial class Form1 : Form
    {


        Random rnd = new Random();

        int rastgeleSayi;
        double rastgeleOndalikSayi;
        double gercekSayi;

        public Form1()
        {
            InitializeComponent();
        }



        private void IslemYap()
        {

        }

        private void MesajVer(string prmMesaj)
        {

        }

        private double SayiUret()
        {
           
            // rastgele ondalıklı sayıların oluşturulduğu yer

            rastgeleSayi = rnd.Next(1, 10); // 1...10 arası tam sayı üret
            rastgeleOndalikSayi = rnd.NextDouble(); // sadece ondalıklı sayı üret

            return gercekSayi = rastgeleSayi + rastgeleOndalikSayi;
        }

        private void btnSayiUret_Click_1(object sender, EventArgs e)
        {
            txtSayilar.Text = txtSayilar.Text + SayiUret().ToString() + "\r\n"; // \r textbox içine yazılacak olan satırın
            
        }
    }
}
