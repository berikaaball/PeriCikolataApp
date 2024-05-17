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
    public partial class AySonuVeriler : Form
    {
        public AySonuVeriler()
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
            DataTable verigoster = new DataTable();
            adapter = new SqlDataAdapter(sec, connectionString);
            adapter.Fill(verigoster);
            return verigoster;
        }

        #endregion

        private void UrtmGrBtn_Click(object sender, EventArgs e)
        {
            string sec = "Select UretimId,UrunId,Uretimtarihi,UretimMiktari,UretimTutari from UretimTablosu " +
                "where UretimTarihi = '"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+"' ";
            dataGridView1.DataSource = VeriGetir(sec);

            dataGridView1.Columns[0].HeaderText = "Üretim No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Ürün No";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Üretim Tarihi";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "Üretim Miktarı";
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "Üretim Tutarı";
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            
        }

        private void StsGrBtn_Click(object sender, EventArgs e)
        {
            string sec = "Select SatisId,KutulamaId,SatisTuru,SatisMiktari,SatisTutari,SatisTarihi from SatisTablosu " +
                "where SatisTarihi = '"+dateTimePicker1.Value.ToString("yyyy-MM-dd") +"'";
            dataGridView1.DataSource = VeriGetir(sec);

            dataGridView1.Columns[0].HeaderText = "Satış No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Kutulama No";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Satış Türü";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "Satış Miktarı";
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "Satış Tutarı";
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderText = "Satış Tarihi";
            dataGridView1.Columns[5].Width = 90;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }

        private void MlytBtn_Click(object sender, EventArgs e)
        {
            string sec = "Select AlimNo,MalId,MalSKT,AlimMiktari,OdemeTuru,AlimTutari,AlimTarihi from AlimTablosu " +
                "where AlimTarihi= '"+ dateTimePicker1.Value.ToString("dd-MM-yyyy") + "'";
            dataGridView1.DataSource = VeriGetir(sec);
            //
            dataGridView1.Columns[0].HeaderText = "Alım No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Mal Adı";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Alım Miktarı";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "Ödeme Türü";
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "Alım Tutarı";
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderText = "Alım Tarihi";
            dataGridView1.Columns[5].Width = 90;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
