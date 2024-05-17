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
    public partial class MüşteriKayıt : Form
    {
        public MüşteriKayıt()
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
            DataTable musterigoster = new DataTable();
            adapter = new SqlDataAdapter(sec, connectionString);
            adapter.Fill(musterigoster);
            return musterigoster;
        }
        private void VeriDoldur()
        {
            string sec = "Select MusteriNo,MusteriAdi,MusteriSoyadi,MusteriSirketi,MusteriTelefon from MusteriBilgileri";
            dataGridView1.DataSource = VeriGetir(sec);
        }

        private void BaslikGoster()
        {
            dataGridView1.Columns[0].HeaderText = "Müşteri No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Müşteri Soyadı";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "Müşteri Şirketi";
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "Telefon No";
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            
        }
        #endregion

        private void MüşteriKayıt_Load(object sender, EventArgs e)
        {
            VeriDoldur();
            BaslikGoster();
            BtnMusteriGuncelle.Enabled = false;
            BtnSil.Enabled = false;
        }

        private void BtnMusteriEkle_Click(object sender, EventArgs e)
        {
            string ad = TBoxMusteriAdi.Text;
            string soyad = TBoxSoyad.Text;
            string sirket = TBoxFirmaAdi.Text;
            //int telefon;
            //if (int.TryParse(TBoxTelefon.Text,out telefon))
            //{
                
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.");
            //}

            string Komut = "Insert Into MusteriBilgileri (MusteriAdi,MusteriSoyadi,MusteriSirketi,MusteriTelefon) Values " +
                "(@MusteriAdi,@MusteriSoyadi,@MusteriSirketi,@MusteriTelefon)";
            command.Parameters.AddWithValue("MusteriAdi", ad);
            command.Parameters.AddWithValue("MusteriSoyadi", soyad);
            command.Parameters.AddWithValue("MusteriSirketi", sirket);
            //command.Parameters.AddWithValue("MusteriTelefon", telefon);

            KomutCalistir(Komut);

            if (affectedRows > 0)
            {
                MessageBox.Show("Müşteri eklendi.","Bilgi",MessageBoxButtons.OK);
                TBoxMusteriNo.Text = "";
                TBoxMusteriAdi.Text = "";
                TBoxSoyad.Text = "";
                TBoxFirmaAdi.Text = "";
                TBoxTelefon.Text = "";
            }
            else
            {
                MessageBox.Show("Müşteri eklenemedi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            VeriDoldur();
        }

        private void BtnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            string Komut = "Update MusteriBilgileri Set MusteriAdi= '"+TBoxMusteriAdi.Text+"'," +
                " MusteriSoyadi= '"+TBoxSoyad.Text+"', MusteriSirketi = '"+TBoxFirmaAdi.Text+"'," +
                " MusteriTelefon= '"+Convert.ToInt16(TBoxTelefon.Text)+"' ";
            KomutCalistir(Komut);

            if (affectedRows > 0)
            {
                MessageBox.Show("Müşteri güncellendi.","Bilgi",MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Müşteri güncellenemedi. Lütfen tekrar deneyin.","Bilgi",MessageBoxButtons.OK);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            string Komut = "Delete from MusteriBilgileri where MusteriNo=@MusteriNo";
            KomutCalistir(Komut);

            if (affectedRows > 0)
            {
                MessageBox.Show("Müşteri silindi.");
                TBoxMusteriNo.Text = "";
                TBoxMusteriAdi.Text = "";
                TBoxSoyad.Text = "";
                TBoxFirmaAdi.Text = "";
                TBoxTelefon.Text = "";
            }
        }
    }
}