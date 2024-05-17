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
        #region Bağlantı Tanımlamaları

        static string connectionString = "Data Source=DESKTOP-RORVUON\\SQLEXPRESS;Initial Catalog=PeriCikolata;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand();
        int affectedRows;

        #endregion

        private void KomutCalistir(string Komut)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.Connection = connection;
                command.CommandText = Komut;
                affectedRows = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantıda bir problem oluştu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }


        }

        //public Ürünler UrunEkle;
        //public Üretimler UretimEkle;
        //public kullaniciGiris Giris;
        //public Alımlar AlimEkle;
        //public Kutular KutulamaEkle;
        //public Satışlar SatisEkle;
        //public Workshop Workshop;
        //public AySonuVeriler AySonuVeriler;

        public PeriÇikolata()
        {
            InitializeComponent();
        }

        //public PeriÇikolata afrm;
        //public Ürünler urunfrm;
        //public Maliyet maliyetfrm;
        //public Satışlar satisfrm;
        //public Workshop worksfrm;
        //public Kutular kutufrm;

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
            connection.Open();
        }
    }
    }
    
    

