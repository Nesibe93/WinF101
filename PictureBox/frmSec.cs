using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{

    
    public partial class frmSec : Form
    {
        public frmSec()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Diğer Yöntem - Globalde değişken tanımlıyoruz

            //openFileDialog1.Title = "Lütfen Resim Seçiniz ..";
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    dosyaYolu = openFileDialog1.FileName;
            //}

            //Form1 form = new Form1();
            //form.dosyaYol = dosyaYolu;
            //form.ShowDialog();
            //this.Close();





            openfdSec.Title = "Lütfen resim dosyasını seçiniz...";

            if (openfdSec.ShowDialog() == DialogResult.OK) // openfdSec Diyalogu açıldı ve OK tuşuyla geri dönüldü ise
            {
                frmPictureBox frmPictureBox = new frmPictureBox();
                

                foreach (Control c in frmPictureBox.Controls)
                {
                    if (c.Name == "lblFileName")
                    {
                        c.Text = openfdSec.FileName;
                    }

                    // ?? Gidilecek olan formdaki düzenlemesini yapacağım kontrolü direkt olarak nasıl öğrenebilirim

                    frmPictureBox.ShowDialog();
                }

            }

            



        }
    }
}
