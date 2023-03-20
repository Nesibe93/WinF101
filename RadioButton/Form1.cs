using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnIslemYap_Click_1(object sender, EventArgs e)
        {

            /* Feritin Notları - btnIslemYap
             * 
             *  int sonuc = int.Parse(lblSonucDegeri.Text); // lblSonucDegeri nin değerini bulup sonuc                                                      değişkenine atıyoruz..
            if (rdbArttir.Checked) // rdbArttir ismindeki radiobutton seçilimi (Checked)
            {
                sonuc += (int)nudMiktar.Value; // sonuc degiskenine nudmiktardan gelen değeri ekle
                lblSonucDegeri.Text = sonuc.ToString(); // lblSonuc değerinin yeni değerine sonuç değerini                                          gönder..
            }
            else if (rdbAzalt.Checked) //rdbAzalt ismindeki radiobutton seçili ise (Checked)
            {
                sonuc -= (int)nudMiktar.Value;  // sonuc degiskeninden nudmiktardan gelen değeri çıkar
                lblSonucDegeri.Text = sonuc.ToString();// lblSonuc değerinin yeni değerine sonuç değerini                                          gönder..

             */
            int sonuc;

            sonuc = int.Parse(lblSayi.Text);

            if (rdbArtir.Checked)
            {
                sonuc = (int)(sonuc + nmrUpDown.Value);

                lblSayi.Text = sonuc.ToString();
            }
            else
            {
                if (rdbAzalt.Checked)
                {
                    sonuc = (int)(sonuc - nmrUpDown.Value);

                    lblSayi.Text = sonuc.ToString();
                }
            }
        }
    }
}
