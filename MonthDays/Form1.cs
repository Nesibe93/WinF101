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
        DateTimeFormatInfo formatTR = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat;// Datetime kültürünü getirmesini istedik. Bu değişkene türkçe tarih formatı atandı
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

            int yil = Convert.ToInt32((DateTime.Now.Year)); // Default tarihin yıl bilgisine ulaştık
            
            nmrcUDYear.Value = yil; // value property
            for (int i = 0 ; i < 12; i++) // 12 ay olduğu için 12 yazdık
            {

            }
        }
    }
}
