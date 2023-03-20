using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox02
{
    public partial class frmListBox02 : Form
    {
        Random rnd = new Random();
        int toplam;

        public frmListBox02()
        {
            InitializeComponent();
        }

        private void frmListBox02_Load(object sender, EventArgs e)
        {
            // ekrana ilk geldiğinde

            EkranTemizle();
            
            
        }

        private void btnSayiUret_Click(object sender, EventArgs e)
        {
            // anca ve anca
            if (txtAdet.Text != "")
            { 
                // işleme girsin
                if (txtAltSinir.Text !="" && txtUstSinir.Text != "")
                {

                    lstBSonuc.Items.Clear();

                    for (int i = 0; i < int.Parse(txtAdet.Text); i++)
                    {
                       
                        int rastgeleSayi = rnd.Next(int.Parse(txtAltSinir.Text),int.Parse(txtUstSinir.Text));

                        lstBSonuc.Items.Add(rastgeleSayi.ToString());

                        toplam += rastgeleSayi;
                    }


                    lblMesaj.Visible = true;

                    lblMesaj.Text = $"{int.Parse(txtAltSinir.Text)} ile {int.Parse(txtUstSinir.Text)} arasında {int.Parse(txtAdet.Text)} sayı üretilmiştir....";
                    lblMesaj2.Text= "" + toplam;

                    EkranTemizle();

                }

            }
            else
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = "Adet bilgisini giriniz";
            }

         
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void EkranTemizle()
        {


            txtAdet.Text = "";
            txtAltSinir.Clear();
            txtUstSinir.Clear();

            txtAdet.Select();
        }


    }
}
