using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace periCikolata
{
    public partial class Satışlar : Form
    {
        public Satışlar()
        {
            InitializeComponent();
        }

        #region Bağlantı Tanımlamaları

        static string connectionString = "Data Source=DESKTOP-RORVUON\\SQLEXPRESS;Initial Catalog=PeriCikolata;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        int affectedRows;

        #endregion

        #region Bağlantı Olayları

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
        private DataTable VeriGetir(string sec)
        {
            DataTable satisgoster = new DataTable();
            adapter = new SqlDataAdapter(sec, connectionString);
            adapter.Fill(satisgoster);
            return satisgoster;
        }
        private void VeriDoldur()
        {
            string sec = "Select SatisId,KutulamaId,SatisTuru,SatisMiktari,SatisTutari,SatisTarihi from SatisTablosu";
            dataGridView1.DataSource = VeriGetir(sec);
        }

        private void BaslikGoster()
        {
            dataGridView1.Columns[0].HeaderText = "Satış No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Kutulama No";
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Satış Türü";
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "Satış Miktarı";
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "Satış Tutarı";
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderText = "Satış Tarihi";
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }
        #endregion

        private void BtnSatisEkle_Click(object sender, EventArgs e)
        {
            byte kutulamaNo = Convert.ToByte(TBoxKutulama.Text);
            string satisTuru = CBoxSatisTuru.SelectedItem.ToString();
            byte satisMiktar = Convert.ToByte(TBoxSatisMiktar.Text);
            decimal satisTutari = decimal.Parse(TBoxSatisTutari.Text);
            DateTime satisTarihi = DTPSatis.Value;
          
            string Komut = "INSERT INTO SatisTablosu (KutulamaId,SatisTuru,SatisMiktari,SatisTutari,SatisTarihi)" +
                " VALUES (@KutulamaId,@SatisTuru,@SatisMiktari,@SatisTutari,@SatisTarihi)";

            command.Parameters.AddWithValue("@KutulamaId", kutulamaNo);
            command.Parameters.AddWithValue("@SatisTuru", satisTuru);
            command.Parameters.AddWithValue("@SatisMiktari", satisMiktar);
            command.Parameters.AddWithValue("@SatisTutari", satisTutari);
            command.Parameters.AddWithValue("@SatisTarihi", satisTarihi);

            KomutCalistir(Komut);

            if (affectedRows > 0)
            {
                MessageBox.Show("Satış eklendi.");

            }
            else
            {
                MessageBox.Show("Satış eklenemedi. Lütfen tekrar deneyin.");
            }
            VeriDoldur();
        }
    
        private void BtnSatisSil_Click(object sender, EventArgs e)
        {
            string Komut = "Delete from SatisTablosu where SatisId = @SatisId)";

            KomutCalistir(Komut);

            if (affectedRows > 0)
            {
                MessageBox.Show("Satış silindi.");
                TBoxKutulama.Clear();
                TBoxSatisMiktar.Clear();
                TBoxSatisNo.Clear();
                TBoxSatisTutari.Clear();
                CBoxSatisTuru.Items.Clear();
            }
            else
            {
                MessageBox.Show("Satış silinemedi. Lütfen tekrar deneyin.");
            }
        }

        private void BtnSatisGuncelle_Click(object sender, EventArgs e)
        {
            string Komut = "Update SatisTablosu set SatisId='" + Convert.ToByte(TBoxSatisNo.Text) + "', SatisTuru='" + CBoxSatisTuru.SelectedItem.ToString() +
              "', KutulamaId='" + Convert.ToByte(TBoxKutulama.Text) + "', SatisTuru='" + CBoxSatisTuru.SelectedItem.ToString() + "'," +
              "SatisMiktari='" + Convert.ToByte(TBoxSatisMiktar.Text) + "',SatisMiktari='" + decimal.Parse(TBoxSatisTutari.Text) + "',SatisTarihi='" + DTPSatis.Value + "'";
            KomutCalistir(Komut);

            if (affectedRows > 0)
            {
                MessageBox.Show("Satış güncellendi.");
                TBoxKutulama.Clear();
                TBoxSatisMiktar.Clear();
                TBoxSatisNo.Clear();
                TBoxSatisTutari.Clear();
                CBoxSatisTuru.Items.Clear();


            }
            else
            {
                MessageBox.Show("Satış güncellenemedi. Lütfen tekrar deneyin.");
            }
        }

        private void Satışlar_Load(object sender, EventArgs e)
        {
            VeriDoldur();
            BaslikGoster();
            BtnSatisGuncelle.Enabled = false;
            BtnSatisSil.Enabled = false;

        }
    }
}
