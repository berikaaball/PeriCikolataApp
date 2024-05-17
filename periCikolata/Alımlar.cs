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
    public partial class Alımlar : Form
    {
       
        public Alımlar()
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
            DataTable alimgoster = new DataTable();
            adapter = new SqlDataAdapter(sec, connectionString);
            adapter.Fill(alimgoster);
            return alimgoster;
        }
        private void VeriDoldur()
        {
            string sec = "Select AlimNo,MalId,MalSKT,AlimMiktari,OdemeTuru,AlimTutari,AlimTarihi from AlimTablosu";
            dataGridView1.DataSource = VeriGetir(sec);
        }

        private void BaslikGoster()
        {
            dataGridView1.Columns[0].HeaderText = "Alım No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Mal Adı";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Mal SKT";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "Alım Miktarı";
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "Ödeme Türü";
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderText = "Alım Tutarı";
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns[6].HeaderText = "Alım Tarihi";
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }


        #endregion

        private void BtnAlimEkle_Click(object sender, EventArgs e)
        {

            int malNo = Convert.ToInt16(CBoxMalNo.SelectedIndex.ToString());
            DateTime skt = DTPMalSKT.Value;
            int alimMiktar = Convert.ToInt16(TBoxAlimMiktar.Text);
            string odemeTuru = CBoxOdemeTuru.SelectedItem.ToString();
            decimal tutar = decimal.Parse(TBoxAlimTutari.Text);
            DateTime alinanTarih = DTPAlimTarih.Value;
           
                string Komut = "INSERT INTO AlimTablosu (MalId,MalSKT,AlimMiktari,OdemeTuru,AlimTutari,AlimTarihi)" +
                    " VALUES (@MalId,@MalSKT,@AlimMiktari,@OdemeTuru,@AlimTutari,@AlimTarihi)";
                {
                command.Parameters.AddWithValue("@MalId", malNo);
                command.Parameters.AddWithValue("@MalSKT",skt);
                command.Parameters.AddWithValue("@AlimMiktari",alimMiktar);
                command.Parameters.AddWithValue("@OdemeTuru",odemeTuru);
                command.Parameters.AddWithValue("@AlimTutari", tutar);
                command.Parameters.AddWithValue("@AlimTarihi", alinanTarih);

                KomutCalistir(Komut);

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Mal eklendi.");
                        TBoxAlimNo.Clear();
                        CBoxMalNo.SelectedIndex = 0;
                        TBoxAlimMiktar.Clear();
                        CBoxOdemeTuru.SelectedIndex = 0;
                        TBoxAlimTutari.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Alım eklenemedi. Lütfen tekrar deneyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            VeriDoldur();
        }

        private void BtnAlimSil_Click(object sender, EventArgs e)
        {
            string Komut = "Delete from AlimTablosu where AlimNo = @AlimNo";
            KomutCalistir(Komut);

            if (affectedRows > 0)
            {
                MessageBox.Show("Alım silindi.");
                TBoxAlimNo.Clear();
                CBoxMalNo.Items.Clear();
                DTPMalSKT.Text = "";
                TBoxAlimMiktar.Clear();
                CBoxOdemeTuru.Items.Clear();
                TBoxAlimTutari.Clear();
                DTPAlimTarih.Text = "";

            }
            else
            {
                MessageBox.Show("Alım silinemedi. Lütfen tekrar deneyin.");
            }
        }

        private void BtnAlimGuncelle_Click(object sender, EventArgs e)
        {
            string Komut = "Update AlimTablosu set AlimNo='" + Convert.ToInt16(TBoxAlimNo.Text) + "', MalId='" + CBoxMalNo.SelectedIndex +
              "', MalSKT='" + DTPMalSKT.Value + "', AlimMiktari='" + Convert.ToInt16(TBoxAlimMiktar.Text) + "'," +
              "OdemeTuru='" + CBoxOdemeTuru.SelectedItem.ToString() + "',AlimTutari= '" + decimal.Parse(TBoxAlimTutari.Text) + "',AlimTarihi= '" + DTPAlimTarih.Value + "'";
            KomutCalistir(Komut);

            if (affectedRows > 0)
            {
                MessageBox.Show("Alım güncellendi.");
                TBoxAlimNo.Clear();
                TBoxAlimMiktar.Clear();
                TBoxAlimTutari.Clear();
                DTPAlimTarih.Text = "";
                DTPMalSKT.Text = "";
                CBoxMalNo.Items.Clear();
                CBoxOdemeTuru.Items.Clear();

            }
            else
            {
                MessageBox.Show("Alım güncellenemedi. Lütfen tekrar deneyin.");
            }
        }

        private void Alımlar_Load(object sender, EventArgs e)
        {
            VeriDoldur();
            BaslikGoster();
            BtnAlimGuncelle.Enabled = false;
            BtnAlimSil.Enabled = false;
            
        }
    }
    
}