using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaBilgiFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            string renk = txtRenk.Text;
            string kapiSayisi = txtKapiSayisi.Text;
            string pencereSayisi = txtPencereSayisi.Text;
            string yakitTuketimi = txtYakitTuketimi.Text;

            // Girilen bilgileri MessageBox'ta göster
            MessageBox.Show($"Marka: {marka}\nModel: {model}\nRenk: {renk}\nKapı Sayısı: {kapiSayisi}\nPencere Sayısı: {pencereSayisi}\n100 km'de Yaktığı Yakıt: {yakitTuketimi} Litre", "Araba Bilgileri");
        }
    }
}

