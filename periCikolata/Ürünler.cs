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
    public partial class Ürünler : Form
    {
       
        public Ürünler()
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
            DataTable urungoster = new DataTable();
            adapter = new SqlDataAdapter(sec, connectionString);
            adapter.Fill(urungoster);
            return urungoster;
        }
        private void VeriDoldur()
        {
            string sec = "Select UrunId,UrunAdi,UrunDolgusu,UrunMeyvesi from UrunlerTablosu";
            dataGridView1.DataSource = VeriGetir(sec);
        }

        private void BaslikGoster()
        {
            dataGridView1.Columns[0].HeaderText = "Ürün No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Ürün Adı";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Ürün Dolgusu";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "Ürün Meyvesi";
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }
        #endregion

        private void BtnUrunSil_Click(object sender, EventArgs e)
        {
            string Komut = "Delete from UrunlerTablosu where UrunId = @UrunId)";
            KomutCalistir(Komut);

            if (affectedRows > 0)
            {
                MessageBox.Show("Ürün silindi.");
                TBoxUrunNo.Clear();
                TBoxUrunAdi.Clear();
                CBoxDolgu.Items.Clear();
                CBoxMeyve.Items.Clear();

            }
            else
            {
                MessageBox.Show("Ürün silinemedi. Lütfen tekrar deneyin.");
            }
        }

        private void BtnUrunGuncelle_Click(object sender, EventArgs e)
        {
            string Komut = "Update UrunlerTablosu set UrunId='" + Convert.ToByte(TBoxUrunNo.Text) + "', UrunAdi='" + TBoxUrunAdi.Text +
                "', UrunDolgusu='" + CBoxDolgu.SelectedItem + "', UrunMeyvesi='" + CBoxMeyve.SelectedItem + "'";
            KomutCalistir(Komut);

            if (affectedRows > 0)
            {
                MessageBox.Show("Ürün güncellendi.");
                TBoxUrunNo.Clear();
                TBoxUrunAdi.Clear();
                CBoxDolgu.Items.Clear();
                CBoxMeyve.Items.Clear();
            }
            else
            {
                MessageBox.Show("Ürün güncellenemedi. Lütfen tekrar deneyin.");
            }
        }

        private void BtnUrunEkle_Click_1(object sender, EventArgs e)
        {
            string urunAdi = TBoxUrunAdi.Text;
            string dolgu = CBoxDolgu.SelectedItem.ToString();
            string meyve = CBoxMeyve.SelectedItem.ToString();
            string Komut = "INSERT INTO UrunlerTablosu (UrunAdi,UrunDolgusu,UrunMeyvesi)" +
                    " VALUES (@UrunAdi,@UrunDolgusu,@UrunMeyvesi)";
            {
                command.Parameters.AddWithValue("@UrunAdi", urunAdi);
                command.Parameters.AddWithValue("@UrunDolgusu", dolgu);
                command.Parameters.AddWithValue("@UrunMeyvesi", meyve);

                KomutCalistir(Komut);

                if (affectedRows > 0)
                {
                    MessageBox.Show("Ürün kaydedildi.");
                    VeriDoldur();
                    TBoxUrunNo.Clear();
                    TBoxUrunAdi.Clear();
                    CBoxDolgu.SelectedItem = null;
                    CBoxMeyve.SelectedItem = null;

                }
                else
                {
                    MessageBox.Show("Ürün kaydedilemedi. Lütfen tekrar deneyin.");
                }
            }
        }

        private void Ürünler_Load(object sender, EventArgs e)
        {
            VeriDoldur();
            BaslikGoster();
            BtnUrunGuncelle.Enabled= false;
            BtnUrunSil.Enabled= false;
        }
    }
}