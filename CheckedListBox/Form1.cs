using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void chckdLCars_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int checkedOptionIndex; // Tıklanılan ve check haline gelen seçeneğin indexi
            string checkedContentText; // içeriğindeki text bilgi

            // Öncelikle seçilen elemanın indexini öğrenmem lazım.
            checkedOptionIndex = e.Index;

            //ondan sonrada içindeki yazan texti öğreneyim
            checkedContentText = chckdLCars.Items[checkedOptionIndex].ToString();

            // Listboxta elemanın var olup olmadığı kontrolü
            if (lstBSelectedCars.Items.IndexOf(checkedContentText) > -1)
                return; // -1 burda araştırdığım textin olduğunu gösterir.Bu yüzden hiç bir işlem yapmadan metoddan çık git.

            // eğer listbox ımda seçili değer yoksa demekki eklicem
            // checked Listbox ın çalışma prensibine göre acaba seçtiğim satırın checkini işaretledi mi kontrolünü yapmam lazım.

            bool contentChecked = chckdLCars.GetItemChecked(checkedOptionIndex);
            //yukarıda açıklama ışığında bir lojik değişkenle bunu anlayacağım.
            //yani üzerinde durduğum satırı seçip seçmediğimi (check boxını) anlıcam

            if (contentChecked==false) //
            {

            }
          }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            lstBSelectedCars.Items.Clear(); // Öncelikle listbox ın içeriğini siliyor

            // daha sonra checked
        }
    }
}
