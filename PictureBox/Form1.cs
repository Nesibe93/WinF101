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

  
    public partial class frmPictureBox : Form
    {
        // Global Değişkenler
        int formYukseklik, formGenislik,pctrbGenislik, pctrbYukseklik;

        
        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void frmPictureBox_KeyDown(object sender, KeyEventArgs e)
        {

            int x, y;

            x = pctrbPicture.Location.X; // image ın ekrandaki x koordinatı
            y = pctrbPicture.Location.Y; // image ın ekrandaki y koordinatı

            // MessageBox.Show("Koordinatlar : x " + x.ToString() + y.ToString());

            switch (e.KeyCode)
            {
                case Keys.Left: // Sol ok tuşu

                    x -= 10;

                    if (x < 0)
                    {
                        x += 10;
                    }

                    break;

                case Keys.Right: // Sağ ok tuşu

                    x += 10;

                    if (pctrbGenislik + x > formGenislik)
                    {
                        x += 10;
                    }

                    break;

                case Keys.Up: // Yukarı ok tuşu

                    y -= 10;

                    if (y < 0)
                    {
                        y += 10;
                    }

                    break;

                case Keys.Down: // Aşağı ok tuşu

                    y += 10;

                    if (pctrbYukseklik + y > formYukseklik)
                    {
                        y += 10;
                    }

                    break;
            }

            pctrbPicture.Location = new Point(x, y);
        }

        private void frmPictureBox_Load(object sender, EventArgs e)
        {
            //form açıldığında(0,0) lokasyonuna taşıyorum
            pctrbPicture.Location = new Point(0, 0);

            frmPictureBox frmPictureBox = new frmPictureBox();

            formGenislik = frmPictureBox.Width;
            formYukseklik = frmPictureBox.Height;

            pctrbGenislik = frmPictureBox.Width;
            pctrbYukseklik = frmPictureBox.Height;

            MessageBox.Show(" Form Genişlik : " + frmPictureBox.Width.ToString() + " Yükseklik : " + frmPictureBox.Height.ToString());

            pctrbPicture.ImageLocation = lblFileName.Text;


        }
    }
}
