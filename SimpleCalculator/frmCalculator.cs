using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btonHesapla_Click(object sender, EventArgs e)
        {
            double sonuc=0;
            double sayi1, sayi2;
            string secenek;

            if (tboxSayi1.Text != "" && tboxSayi2.Text != "")
            {
                // esas kontrol ve işlem bölümü

                sayi1 = Convert.ToDouble(tboxSayi1.Text);
                sayi2 = Convert.ToDouble(tboxSayi2.Text);

                secenek = cboxOperator.Text; // combodan seçilen işlem kodu (+,-,*,%)

                switch (secenek)
                {
                    case "+": // toplama
                        sonuc = sayi1 + sayi2;
                        break;

                    case "-": // çıkarma
                        sonuc = sayi1 - sayi2;
                        break;

                    case "*": // çarpma
                        sonuc = sayi1 * sayi2;
                        break;

                    case "/": // bölme

                        if (sayi2 != 0)
                        {

                            sonuc = sayi1 / sayi2;
                        }
                        else
                        {
                            MessageBox.Show("Sıfıra bölme olmaz....");
                        }

                        break;

                    default:
                        break;
                }

            }
            else
            {
                // hata versin içini doldurması istensin...

                MessageBox.Show("Lütfen değerleri boş bırakmayınız...");

            }

            label3.Text = "İşlem sonucu = " + sonuc.ToString();
            label3.Visible = true;




            //MessageBox.Show("İşlemin sonucu = " +toplam.ToString());


        }

        private void tboxSayi2_Enter(object sender, EventArgs e)
        {
            // bu komponentin içine düştüğümde...


            //MessageBox.Show("Şu an bu komponentteyim");

            //tboxSayi2.BackColor = Color.Blue;
        }

        private void tboxSayi1_Enter(object sender, EventArgs e)
        {
            //tboxSayi1.BackColor = Color.Red;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            // Form ekrana ilk gelirken yapılacak işlemler....

            cboxOperator.SelectedIndex = 0; // ilk değeri göstersin

            label3.Visible = false;

        }
    }
}
