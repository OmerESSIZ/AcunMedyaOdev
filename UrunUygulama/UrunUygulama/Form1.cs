using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace UrunUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // JSON dosyasının yolu
                string jsonPath = Path.Combine(Application.StartupPath, "urunler.json");

                // JSON dosyasını oku
                string jsonString = File.ReadAllText(jsonPath);

                // JSON verisini deserialize et (nesneye dönüştür)
                List<Urun> urunler = JsonSerializer.Deserialize<List<Urun>>(jsonString);

                // ListBox'ı temizle
                listBoxUrunler.Items.Clear();

                // Ürünleri ListBox'a ekle
                foreach (Urun urun in urunler)
                {
                    listBoxUrunler.Items.Add($"Ürün: {urun.UrunAdi} - Fiyat: {urun.Fiyat} TL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

    }
}
