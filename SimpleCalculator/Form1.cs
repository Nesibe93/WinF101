using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleCalculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //int toplam;
            //int sayi1, sayi2;

            //if (txtSayi1.Text == "") // içi boşsa
            //{
            //    MessageBox.Show("Değer boş bırakıldığı için Sayı 1 e 0 değeri atanmıştır...");
            //    sayi1 = 0;
            //}
            //else
            //{
            //    sayi1 = int.Parse(txtSayi1.Text);
            //}
            //if (txtSayi2.Text == "")
            //{
            //    MessageBox.Show("Değer boş bırakıldığı için Sayı 2 ye 0 değeri atanmıştır...");
            //    sayi2 = 0;
            //}
            //else
            //{
            //    sayi2 = int.Parse(txtSayi2.Text);
            //}

            //if (txtSayi1.Text != "" && txtSayi2.Text !="") // içi boş değilse işlemi yap
            //{ 
            //    sayi1 = int.Parse(txtSayi1.Text);
            //    sayi2 = int.Parse(txtSayi2.Text);

            //    toplam = sayi1 + sayi2;

            //    label1.Text = ("İşlem Sonucu : " + toplam.ToString());
            //    label1.Visible = true;

            //    txtSayi1.Clear();
            //    txtSayi2.Clear();

            //    txtSayi1.Focus();
            //}
            //else
            //{
            //    // hata versin.
            //    MessageBox.Show("Lütfen değerleri boş bırakmayınız...");
            //}



            double sonuc = 0;
            double sayi1, sayi2;
            string secenek;

            if (txtSayi1.Text != "" && txtSayi2.Text != "")
            {
                // esas kontrol ve işlem bölümü

                sayi1 = Convert.ToDouble(txtSayi1.Text);
                sayi2 = Convert.ToDouble(txtSayi2.Text);

                secenek = cmbIslem.Text; // combodan seçilen işlem kodu (+,-,*,%)

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

            label1.Text = "İşlem sonucu = " + sonuc.ToString();
            label1.Visible = true;



            // *Feritin kodları * btnHesapla *
            //if (txtSayi1.Text != "" && txtSayi2.Text != "")
            //{
            //    int sayi1, sayi2;
            //    string secenek = comboBox1.Text; // combobox'daki değeri okuyor
            //    double Topla = double.Parse(txtSayi1.Text) + double.Parse(txtSayi2.Text);
            //    double Cikar = double.Parse(txtSayi1.Text) - double.Parse(txtSayi2.Text);
            //    double Carp = double.Parse(txtSayi1.Text) * double.Parse(txtSayi2.Text);
            //    double Bol = double.Parse(txtSayi1.Text) / double.Parse(txtSayi2.Text);

                //    // Diğer yöntem
                //    //sayi1 = double.Parse(txtSayi1.Text);
                //    //sayi2 = double.Parse(txtSayi2.Text);
                //    switch (secenek) // secenek icin calıs..
                //    {
                //        case "+": // Eğer secenekten gelen değer + ise 

                //            MessageBox.Show($"İşlem Sonucu : {Topla.ToString()}", "Toplama İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            txtSayi1.Clear();
                //            txtSayi2.Clear();
                //            //lblSonuc.Text = ($"İşlem Sonucu : {Topla.ToString()}");
                //            break;

                //        case "-": // Eğer secenekten gelen değer - ise 
                //            MessageBox.Show($"İşlem Sonucu : {Cikar.ToString()}", "Çıkarma İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            txtSayi1.Clear();
                //            txtSayi2.Clear();
                //            //lblSonuc.Text = ($"İşlem Sonucu : {Cikar.ToString()}");

                //            break;

                //        case "*": // Eğer secenekten gelen değer * ise 
                //            MessageBox.Show($"İşlem Sonucu : {Carp.ToString()}", "Çarpma İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            txtSayi1.Clear();
                //            txtSayi2.Clear();
                //            //lblSonuc.Text = ($"İşlem Sonucu : {Carp.ToString()}");

                //            break;

                //        case "/": // Eğer secenekten gelen değer / ise 

                //            MessageBox.Show($"İşlem Sonucu : {Bol.ToString()}", "Bölme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            txtSayi1.Clear();
                //            txtSayi2.Clear();
                //            //lblSonuc.Text = ($"İşlem Sonucu : {Bol.ToString()}");
                //            break;
            //   else
            //{
            //    MessageBox.Show("Lütfen Sayı 1 ve Sayı 2 için değer giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}



        }

                private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSayi2_Enter(object sender, EventArgs e)
        {
            //// bu komponentin içine düştüğümde..
            //MessageBox.Show("Şuanda bu componentteyim");
            
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            // Form ekrana ilk gelirken yapılacak işlemler....

            cmbIslem.SelectedIndex = 0; // ilk değeri göstersin

            label1.Visible = false;
        }
    }
}
