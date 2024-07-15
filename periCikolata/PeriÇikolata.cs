using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace periCikolata
{
    public partial class PeriÇikolata : Form
    {
        public PeriÇikolata()
        {
            InitializeComponent();
        }
        private void BtnUretimEkle_Click(object sender, EventArgs e)
        {
           Üretimler uretimfrm = new Üretimler(); 
            uretimfrm.Show();
        }
        private void BtnAlimEkle_Click(object sender, EventArgs e)
        {
            Alımlar alimfrm = new Alımlar();
            alimfrm.Show();
        }
        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            Ürünler urunfm = new Ürünler();
            urunfm.Show();  
        }
        private void BtnKutulamaEkle_Click(object sender, EventArgs e)
        {
            Kutular kutufrm = new Kutular();
            kutufrm.Show();
        }
        private void BtnSatisEkle_Click(object sender, EventArgs e)
        {
            Satışlar satisfrm = new Satışlar();
            satisfrm.Show();
        }
        private void BtnWorkshop_Click(object sender, EventArgs e)
        {
            Workshop workfrm = new Workshop();
            workfrm.Show();
        }
        private void BtnAySonu_Click(object sender, EventArgs e)
        {
            AySonuVeriler aysonufrm = new AySonuVeriler();
            aysonufrm.Show();
        }
        private void BtnMusteriEkle_Click(object sender, EventArgs e)
        {
            MüşteriKayıt musterifrm = new MüşteriKayıt();
            musterifrm.Show();
        }
        private void PeriÇikolata_Load(object sender, EventArgs e)
        {
            //connection.Open();
        }
        private void BtnMalEkle_Click(object sender, EventArgs e)
        {
            Mallar malfrm = new Mallar();
            malfrm.Show();
        }
        private void BtnStok_Click(object sender, EventArgs e)
        {
            Stok stokfrm = new Stok();
            stokfrm.Show();
        }
    }
}
    
    

