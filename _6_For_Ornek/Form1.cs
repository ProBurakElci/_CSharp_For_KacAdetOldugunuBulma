using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _6_For_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private int sayac;

        private void btnDoldur_Click(object sender, EventArgs e)
        {
            lsbSayilar.Items.Clear(); // Yeniden doldurmadan önce listBox'ı temizle
            for (int i = 0; i < 500; i++)
            {
                lsbSayilar.Items.Add(rnd.Next(1, 51));
            }
        }

        private void btnKactane_Click(object sender, EventArgs e)
        {
            int AranacakSayi = int.Parse(txtAranacak.Text);
            int sayac = 0; // Her seferinde sayacı sıfırla

            for (int i = 0; i < lsbSayilar.Items.Count; i++)
            {
                if ((int)lsbSayilar.Items[i] == AranacakSayi)
                {
                    sayac++;
                }
            }

            MessageBox.Show(AranacakSayi + " sayısından " + sayac + " adet var");
        }

        private void txtAranacak_TextChanged(object sender, EventArgs e)
        {
            // TextBox her değiştiğinde sayacı ve listBox'ı temizle
            sayac = 0;
            lsbSayilar.Items.Clear();
        }
    }
}
