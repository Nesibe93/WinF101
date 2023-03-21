using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthDays
{
    public partial class frmMonthDays : Form
    {
        DateTimeFormatInfo formatTR = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat;// Datetime kültür bilgisini getirmesini istedik. Bu değişkene türkçe tarih formatı atandı

        public frmMonthDays()
        {
            InitializeComponent();
        }

        private void frmMonthDays_Load(object sender, EventArgs e)
        {
            // Form ekrana gelirken
            // 1. nmrcUDYear kontrolünün içindeki gösterilecek bilgiyi günümüzün yılı olarak göstersin
            //2. cmbAy isimli combobox ın otomatik olarak ay adlarıyla doldurulsun..Ay adları değiştirilemesin.
            //

            int yil = Convert.ToInt32(DateTime.Now.Year); // Default tarihin yıl bilgisine ulaştık
            
            nmrcUDYear.Value = yil; // value property
            for (int i = 0 ; i < 12; i++) // 12 ay olduğu için 12 yazdık
            {
                cmbAy.Items.Add(formatTR.MonthNames[i]); // ayların adlarını alıcaz  
            }




        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lstGünler.Items.Clear();

            int yil = Convert.ToInt32(nmrcUDYear.Value); // Yıl bilgisi
            int ay = cmbAy.SelectedIndex + 1; // 0 dan başladığı için + 1 dedik
            // NumericUpDown ve combobox tan seçilen opsiyonlara göre benim bir tarih bilgisi olarak programa anlatmam gerekir.
            DateTime tarih = new DateTime(yil,ay,1); // diyelim Ocak 2023 için 1 ocak 2023 diye bellekte bir tarih bilgisi oluşturduk.Elimde artık tarih türünde bir bilgi var..

            // seçilen ayda kaç tane gün var onu öğrenmem lazım
            int totalDaysCount = DateTime.DaysInMonth(yil, ay);

            for (int i = 1 ; i <= totalDaysCount; i++)
            {
                lstGünler.Items.Add(tarih.Day + " " + " " + cmbAy.Text + " " + formatTR.DayNames[(int)tarih.DayOfWeek]);

                tarih = tarih.AddDays(1); // Birer gün olarak ilk tarihten son güne kadar dönmesi için
            }
        }
    }
}
