using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace periCikolata
{
    public partial class Kutular : Form
    {
       
        public Kutular()
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
            DataTable kutugoster = new DataTable();
            adapter = new SqlDataAdapter(sec, connectionString);
            adapter.Fill(kutugoster);
            return kutugoster;
        }
        private void VeriDoldur()
        {
            string sec = "Select KutulamaId,KutuId,KutulamaTarih,CikolataSecimi,KutuKonum from KutulamaTablosu";
            dataGridView1.DataSource = VeriGetir(sec);
        }
        private void BaslikGoster()
        {
            dataGridView1.Columns[0].HeaderText = "Kutulama No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Kutu Tipi";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Kutulama Tarihi";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "Çikolata Türü";
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "Nereye Yapıldığı";
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }


        #endregion

        private void KutuEkleBtn_Click(object sender, EventArgs e)
        {
            byte kutuNo = Convert.ToByte(CBoxKutuNo.SelectedIndex.ToString());
            string secilenCiko = CikoScmCBox.SelectedIndex.ToString();
            DateTime kutulamaTarih = DTPKutulama.Value;
            string secilenEkstra = "";
            string urunIcerik = listBox1.SelectedItems.ToString();
            string konum = CBoxNereye.SelectedIndex.ToString();

            //if (CBoxNereye.SelectedText == "Dükkan")
            //{
            //    KullaniciGiris kullanicifrm = new KullaniciGiris();
            //    kullanicifrm.Show();
            //    string sec = "Select KullaniciAdi,KullaniciSifresi from KullaniciBilgileri";
            //    KomutCalistir(sec);
                
            //}
           
            
                //MessageBox.Show("Dükkan için sadece belirli kullanıcı kutulama yapabilir.", "Bilgi",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (KonfetiRBtn.Checked)
            {
                secilenEkstra = KonfetiRBtn.Text;
            }
            else if (DrajeRBtn.Checked)
            {
                secilenEkstra = DrajeRBtn.Text;
            }
            else if (CakilRBtn.Checked)
            {
                secilenEkstra = CakilRBtn.Text;
            }
            else if (YokRBtn.Checked)
            {
                secilenEkstra = YokRBtn.Text;
            }
            else
            {
                MessageBox.Show("Lütfen Kutu Ekstrası için bir seçim yapınız.");
                return;
            }

            string Komut = "INSERT INTO KutulamaTablosu (KutuId,KutulamaTarih,CikolataSecimi,KutuKonum)" +
                    " VALUES (@KutuId,@KutulamaTarih,@CikolataSecimi,@KutuKonum)";
            {
                    command.Parameters.AddWithValue("@KutuId",kutuNo);
                    command.Parameters.AddWithValue("@KutulamaTarih",kutulamaTarih);
                    command.Parameters.AddWithValue("@CikolataSecimi",secilenCiko);
                    command.Parameters.AddWithValue("@KutuKonum",konum);

                KomutCalistir(Komut);
              
                if (affectedRows > 0)
                {
                    MessageBox.Show("Kutu kaydedildi.");

                    CikoScmCBox.Text = "";
                    listBox1.Items.Clear();
                    secilenEkstra = "";

                }
                else
                {
                    MessageBox.Show("Kutu kaydedilemedi. Lütfen tekrar deneyin.");
                }
            }
          
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string secilenCikolata = listBox1.SelectedItem.ToString();
            ListViewItem item = new ListViewItem(secilenCikolata);
            listView1.Items.Add(item);
        }

        private void BtnKutuSil_Click(object sender, EventArgs e)
        {
            string Komut = "Delete from Kutular where KutulamaId=@KutulamaId";
            KomutCalistir(Komut);
           
            if (affectedRows > 0)
            {
                MessageBox.Show("Kutu silindi.");
                CikoScmCBox.Text = "";
                listBox1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Kutu silinemedi. Lütfen tekrar deneyin.");
            }
        }

        private void BtnKutuGuncelle_Click(object sender, EventArgs e)
        {
            string Komut = "Update Kutular Set KutulamaId='" + Convert.ToByte(TBoxKutulamaNo.Text) + "' KutuId='" + Convert.ToByte(CBoxKutuNo.SelectedItem) +"'" +
                "KutulamaTarih='" + DTPKutulama.Value + "' CikolataSecimi='" + CikoScmCBox.SelectedIndex.ToString() + "' KutuKonum='" + CBoxNereye.SelectedIndex.ToString() + "'";
            KomutCalistir(Komut);

            if (affectedRows > 0)
            {
                MessageBox.Show("Kutu güncellendi.");

            }
            else
            {
                MessageBox.Show("Kutu güncellenemedi. Lütfen tekrar deneyin.");
            }
        }

        private void CBoxKutuNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //16'lı Siyah
            //16'lı Yeşil
            //'lü Mavi
            //24'lü Pembe
            //24'lü Siyah
            //32'li Yeşil
            //32'li Siyah
            //48'li Mavi
            //48'li Pembe

            if (CBoxKutuNo.SelectedItem.ToString() == "16'lı Siyah")
            {
                if (listBox1.SelectedItems.Count < 5)
                {
                    while (listBox1.SelectedItems.Count > 5) 
                    {
                        
                    }
                }
            }
            else
            {
               
            }
        }

        private void Kutular_Load(object sender, EventArgs e)
        {
            listBox1.ItemHeight = 10;
        }
    }
}
