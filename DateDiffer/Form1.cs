using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateDiffer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(dtPStart.Text);
            DateTime endDate = Convert.ToDateTime(dtPEnd.Text);

            TimeSpan sonuc = endDate.Subtract(startDate); // iki tarih arası fark eş değeri endDate - startDate

            string Year = Convert.ToString(Math.Round(sonuc.TotalDays / 365, 4)) + " : Yıl veya";

            string Month = Convert.ToString(Math.Round(sonuc.TotalDays / 30, 2)) + " : Ay veya";

            string Day = Convert.ToString(Math.Round(sonuc.TotalDays, 2)) + " : Gün veya";

            string Hour = Convert.ToString(Math.Round(sonuc.TotalHours ,2)) + " : Saat veya";

            string Minute = Convert.ToString(Math.Round(sonuc.TotalMinutes, 2)) + " : Dakika veya";

            lstBResult.Items.Clear();

            lstBResult.Items.Add(Year);
            lstBResult.Items.Add(Month);
            lstBResult.Items.Add(Day);
            lstBResult.Items.Add(Hour);
            lstBResult.Items.Add(Minute);
            nn
        }
    }
}
