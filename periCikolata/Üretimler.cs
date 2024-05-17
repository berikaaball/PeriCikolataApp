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
    public partial class Üretimler : Form
    {
       
        public Üretimler()
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
            DataTable uretimgoster = new DataTable();
            adapter = new SqlDataAdapter(sec, connectionString);
            adapter.Fill(uretimgoster);
            return uretimgoster;
        }
        private void VeriDoldur()
        {
            string sec = "Select UretimId,UrunId,Uretimtarihi,UretimMiktari,UretimTutari from UretimTablosu";
            dataGridView1.DataSource = VeriGetir(sec);
        }

        private void BaslikGoster()
        {
            dataGridView1.Columns[0].HeaderText = "Üretim No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Ürün No";
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Üretim Tarihi";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "Üretim Miktarı";
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "Üretim Tutarı";
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "C2";
        }
        #endregion

        private void BtnUretimEkle_Click(object sender, EventArgs e)
        {
            byte urunNo = Convert.ToByte(TBoxUrunNo.Text);
            byte uretimMiktar = Convert.ToByte(TBoxUretimMiktar.Text);
            decimal uretimTutari = decimal.Parse(TBoxUretimTutar.Text);
            DateTime uretimTarih = DTPUretim.Value;

            if (TBoxUretimMiktar.Text.Trim() !="" & TBoxUretimTutar.Text.Trim() !="" & TBoxUrunNo.Text.Trim() !="")
            {
                string Komut = "INSERT INTO UretimTablosu (UrunId,UretimTarihi,UretimMiktari,UretimTutari)" +
                    " VALUES (@UrunId,@UretimTarihi,@UretimMiktari,@UretimTutari)";
                KomutCalistir(Komut);
                {
                    command.Parameters.AddWithValue("@UrunId", urunNo);
                    command.Parameters.AddWithValue("@UretimTarihi", uretimTarih);
                    command.Parameters.AddWithValue("@UretimMiktari", uretimMiktar);
                    command.Parameters.AddWithValue("@UretimTutari", uretimTutari);

                    KomutCalistir(Komut);
                   
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Üretim eklendi.");
                        TBoxUrunNo.Clear();
                        TBoxUretimNo.Clear();
                        TBoxUretimMiktar.Clear();
                        TBoxUretimTutar.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Üretim eklenemedi. Lütfen tekrar deneyin.");
                    }

                }
            }
            else
            {
                MessageBox.Show("Tüm alanların dolu olduğundan emin olunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnUretimiSil_Click(object sender, EventArgs e)
        {
            string Komut = "Delete from UretimTablosu where UrunId = @UrunId AND UretimId=@UretimId AND UretimTarihi=@UretimTarihi AND UretimMiktari=@UretimMiktari AND UretimTutari=@UretimTutari)";
            KomutCalistir(Komut);
            
            if (affectedRows > 0)
            {
                MessageBox.Show("Üretim silindi.");
                TBoxUrunNo.Clear();
                TBoxUretimNo.Clear();
                TBoxUretimMiktar.Clear();
                TBoxUretimTutar.Clear();
            }
            else
            {
                MessageBox.Show("Üretim silinemedi. Lütfen tekrar deneyin.");
            }
        }

        private void BtnUretimGuncelle_Click(object sender, EventArgs e)
        {
            string Komut = "Update UretimTablosu set UrunId='" + Convert.ToByte(TBoxUrunNo.Text) + "', UretimId='" + Convert.ToByte(TBoxUretimNo.Text) +
                "', UretimTarihi='" + DTPUretim.Text + "', UretimMiktari='" + Convert.ToByte(TBoxUretimMiktar.Text) + "'," +
                "UretimTutari='" + decimal.Parse(TBoxUretimTutar.Text) + "'";
            KomutCalistir(Komut);

            if (affectedRows > 0)
            {
                MessageBox.Show("Üretim güncellendi.");
                TBoxUrunNo.Clear();
                TBoxUretimNo.Clear();
                TBoxUretimMiktar.Clear();
                TBoxUretimTutar.Clear();

                
            }
            else
            {
                MessageBox.Show("Üretim güncellenemedi. Lütfen tekrar deneyin.");
            }
        }

        private void Üretimler_Load(object sender, EventArgs e)
        {
            VeriDoldur();
            BaslikGoster();
            BtnUretimGuncelle.Enabled= false;
            BtnUretimiSil.Enabled= false;
        }
    }
}
