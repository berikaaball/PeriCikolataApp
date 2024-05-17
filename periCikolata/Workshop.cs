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
    public partial class Workshop : Form
    {
        public Workshop()
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
            DataTable etkinlikgoster = new DataTable();
            adapter = new SqlDataAdapter(sec, connectionString);
            adapter.Fill(etkinlikgoster);
            return etkinlikgoster;
        }
        private void VeriDoldur()
        {
            string sec = "Select EtkinlikId,EtkinlikAdi,Kapasite,Tarih,Adres from Workshop";
            dataGridView1.DataSource = VeriGetir(sec);
        }

        private void BaslikGoster()
        {
            dataGridView1.Columns[0].HeaderText = "Etkinlik No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Etkinlik Adı";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Kapasite";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "Tarih";
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "Adres";
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }

        #endregion

        private void EtkKaydetBtn_Click_1(object sender, EventArgs e)
        {
            string etkadi = EtkAdTBox.Text;
            DateTime etktarih = dateTimePicker1.Value;
            int kapasite = Convert.ToInt16(KapasiteTBox.Text);
            string adres = AdresTBox.Text;

                string Komut = "INSERT INTO Workshop (EtkinlikAdi,Tarih,Kapasite,Adres)" +
                    " VALUES (@EtkinlikAdi,@Tarih,@Kapasite,@Adres)";
                using (SqlCommand command = new SqlCommand(Komut, connection))
                {
                    command.Parameters.AddWithValue("@EtkinlikAdi", etkadi);
                    command.Parameters.AddWithValue("@Tarih", etktarih);
                    command.Parameters.AddWithValue("@Adres", adres);
                    command.Parameters.AddWithValue("@Kapasite", kapasite);

                KomutCalistir(Komut);

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Etkinlik kaydedildi.");
                        EtkNoTBox.Clear();
                        EtkAdTBox.Clear();
                        KapasiteTBox.Clear();
                        AdresTBox.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Etkinlik kaydedilemedi. Lütfen tekrar deneyin.");
                    }
                }
        }

        private void BtnEtkinlikSil_Click(object sender, EventArgs e)
        {
            string Komut = "Delete from Workshop where EtkinlikId = @EtkinlikId)";
            KomutCalistir(Komut);

            if (affectedRows > 0)
            {
                MessageBox.Show("Workshop silindi.");
                AdresTBox.Clear();
                EtkAdTBox.Clear();
                EtkNoTBox.Clear();
                KapasiteTBox.Clear();
            }
            else
            {
                MessageBox.Show("Workshop silinemedi. Lütfen tekrar deneyin.");
            }
        }

        private void BtnEtkinlikGuncelle_Click(object sender, EventArgs e)
        {
            string Komut = "Update Workshop set EtkinlikAdi='" + EtkAdTBox.Text +
               "', Tarih='" + dateTimePicker1.Value + "', Adres='" + AdresTBox.Text + "'," +
               "Kapasite='" + Convert.ToInt16(KapasiteTBox.Text) + "'";
            KomutCalistir(Komut);

            if (affectedRows > 0)
            {
                MessageBox.Show("Workshop güncellendi.");
                AdresTBox.Clear();
                EtkAdTBox.Clear();
                EtkNoTBox.Clear();
                KapasiteTBox.Clear();
            }
            else
            {
                MessageBox.Show("Workshop güncellenemedi. Lütfen tekrar deneyin.");
            }
        }

        private void Workshop_Load(object sender, EventArgs e)
        {
            VeriDoldur();
            BaslikGoster();
            BtnEtkinlikGuncelle.Enabled = false;
            BtnEtkinlikSil.Enabled = false;
        }
    }
}
