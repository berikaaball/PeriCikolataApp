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
        private void KutuGetir()
        {
            string sec = "Select KutuId from KutularTablosu";
            CBoxKutuNo.DataSource = VtIslem.VeriGetir(sec);
            CBoxKutuNo.ValueMember = "KutuId";
        }
        private void KutuSil16()
        {
            string Komut = "Delete from 16liKutulama where KutulamaId = @KutulamaId";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@KutulamaId", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            VtIslem.KomutCalistir(Komut);
            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Kutu silindi.");
                VeriDoldur();
            }
            else
            {
                MessageBox.Show("Kutu silinemedi.Lütfen tekrar deneyiniz.");
            }
            VeriDoldur();
        }
        private void KutuSil24()
        {
            string Komut = "Delete from 24luKutulama where KutulamaId = @KutulamaId";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@KutulamaId", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            VtIslem.KomutCalistir(Komut);
            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Kutu silindi.");
                VeriDoldur();
            }
            else
            {
                MessageBox.Show("Kutu silinemedi.Lütfen tekrar deneyiniz.");
            }
            VeriDoldur();
        }

        private void KutuSil30()
        {
            string Komut = "Delete from 30luKutulama where KutulamaId = @KutulamaId";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@KutulamaId", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            VtIslem.KomutCalistir(Komut);
            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Kutu silindi.");
                VeriDoldur();
            }
            else
            {
                MessageBox.Show("Kutu silinemedi.Lütfen tekrar deneyiniz.");
            }
            VeriDoldur();
        }

        private void KutuSil32()
        {
            string Komut = "Delete from 32liKutulama where KutulamaId = @KutulamaId";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@KutulamaId", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            VtIslem.KomutCalistir(Komut);
            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Kutu silindi.");
                VeriDoldur();
            }
            else
            {
                MessageBox.Show("Kutu silinemedi.Lütfen tekrar deneyiniz.");
            }
            VeriDoldur();
        }
        private void KutuSil48()
        {
            string Komut = "Delete from 48liKutulama where KutulamaId = @KutulamaId";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@KutulamaId", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            VtIslem.KomutCalistir(Komut);
            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Kutu silindi.");
                VeriDoldur();
            }
            else
            {
                MessageBox.Show("Kutu silinemedi.Lütfen tekrar deneyiniz.");
            }
            VeriDoldur();
        }
        private void VeriDoldur()
        {
            string sec = "Select KutulamaId,KutuId,KutulamaTarih,CikolataSecimi,KutuKonum from KutulamaTablosu";
            dataGridView1.DataSource = VtIslem.VeriGetir(sec);
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
        private void KutuEkle16()
        {
            if (listBox1.SelectedItems.Count < 4)
            {
                MessageBox.Show("Lütfen en az 4 ürün seçin.");
                return;
            }

            string Komut = "Insert Into 16liKutulama (KutuId,Urun1No,Urun1Adet,Urun2No,Urun2Adet,Urun3No,Urun3Adet,Urun4No,Urun4Adet)" +
                "VALUES (@KutuId,@Urun1No,@Urun1Adet,@Urun2No,@Urun2Adet,@Urun3No,@Urun3Adet,@Urun4No,@Urun4Adet)";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@KutuId", CBoxKutuNo.SelectedValue);

            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                VtIslem.command.Parameters.AddWithValue($"@Urun{i + 1}No", listBox1.SelectedItems[i].ToString());
                VtIslem.command.Parameters.AddWithValue($"@Urun{i + 1}Adet", 4);
            }

            for (int i = listBox1.SelectedItems.Count; i < 5; i++)
            {
                VtIslem.command.Parameters.AddWithValue($"@Urun{i + 1}No", DBNull.Value);
                VtIslem.command.Parameters.AddWithValue($"@Urun{i + 1}Adet", 0);
            }

            //VtIslem.command.Parameters.AddWithValue("@Urun1No",listBox1.SelectedItem.ToString());
            //VtIslem.command.Parameters.AddWithValue("@Urun1Adet", 4);
            //VtIslem.command.Parameters.AddWithValue("@Urun2No", listBox1.SelectedItem.ToString());
            //VtIslem.command.Parameters.AddWithValue("@Urun2Adet", 4);
            //VtIslem.command.Parameters.AddWithValue("@Urun3No", listBox1.SelectedItem.ToString());
            //VtIslem.command.Parameters.AddWithValue("@Urun3Adet", 4);
            //VtIslem.command.Parameters.AddWithValue("@Urun4No", listBox1.SelectedItem.ToString());
            //VtIslem.command.Parameters.AddWithValue("@Urun4Adet", 4);

            VtIslem.KomutCalistir(Komut);
            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Kutu kaydedildi.");
                VeriDoldur();
                listView1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Kutu kaydedilemedi. Lütfen tekrar deneyin.");
            }
            VeriDoldur();
        }
        private void KutuEkle24()
        {
            if (listBox1.SelectedItems.Count < 6)
            {
                MessageBox.Show("Lütfen en az 6 ürün seçin.");
                return;
            }
            string Komut = "Insert Into 24luKutulama (KutuId,Urun1No,Urun1Adet,Urun2No,Urun2Adet,Urun3No,Urun3Adet,Urun4No,Urun4Adet,Urun5No,Urun5Adet,Urun6No,Urun6Adet)" +
               "VALUES (@KutuId,@Urun1No,@Urun1Adet,@Urun2No,@Urun2Adet,@Urun3No,@Urun3Adet,@Urun4No,@Urun4Adet,@Urun5No,@Urun5Adet,@Urun6No,@Urun6Adet)";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@KutuId", CBoxKutuNo.SelectedValue);

            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                VtIslem.command.Parameters.AddWithValue($"@Urun{i + 1}No", listBox1.SelectedItems[i].ToString());
                VtIslem.command.Parameters.AddWithValue($"@Urun{i + 1}Adet", 4);
            }
            VtIslem.KomutCalistir(Komut);
            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Kutu kaydedildi.");
                VeriDoldur();
                listView1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Kutu kaydedilemedi. Lütfen tekrar deneyin.");
            }
            VeriDoldur();
        }

        private void KutuEkle30()
        {
            string secilenEkstra = "";
           
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

            if (listBox1.SelectedItems.Count < 5)
            {
                MessageBox.Show("Lütfen en az 5 ürün seçin.");
                return;
            }
            string Komut = "Insert Into Ekstrali30luKutulama (KutuId,Urun1No,Urun1Adet,Urun2No,Urun2Adet,Urun3No,Urun3Adet,Urun4No,Urun4Adet,Urun5No,Urun5Adet)" +
               "VALUES (@KutuId,@Urun1No,@Urun1Adet,@Urun2No,@Urun2Adet,@Urun3No,@Urun3Adet,@Urun4No,@Urun4Adet,@Urun5No,@Urun5Adet)";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@KutuId", CBoxKutuNo.SelectedValue);

            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                VtIslem.command.Parameters.AddWithValue($"@Urun{i + 1}No", listBox1.SelectedItems[i].ToString());
                VtIslem.command.Parameters.AddWithValue($"@Urun{i + 1}Adet", 4);
            }
            VtIslem.KomutCalistir(Komut);
            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Kutu kaydedildi.");
                VeriDoldur();
                listView1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Kutu kaydedilemedi. Lütfen tekrar deneyin.");
            }
            VeriDoldur();
        }

        private void KutuEkle32()
        {
            if (listBox1.SelectedItems.Count < 8)
            {
                MessageBox.Show("Lütfen en az 8 ürün seçin.");
                return;
            }
            string Komut = "Insert Into 32liKutulama (KutuId,Urun1No,Urun1Adet,Urun2No,Urun2Adet,Urun3No,Urun3Adet,Urun4No,Urun4Adet,Urun5No,Urun5Adet,Urun6No,Urun6Adet,Urun7No,Urun7Adet,Urun8No,Urun8Adet)" +
               "VALUES (@KutuId,@Urun1No,@Urun1Adet,@Urun2No,@Urun2Adet,@Urun3No,@Urun3Adet,@Urun4No,@Urun4Adet,@Urun5No,@Urun5Adet,@Urun6No,@Urun6Adet,@Urun7No,@Urun7Adet,@Urun8No,@Urun8Adet)";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@KutuId", CBoxKutuNo.SelectedValue);

            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                VtIslem.command.Parameters.AddWithValue($"@Urun{i + 1}No", listBox1.SelectedItems[i].ToString());
                VtIslem.command.Parameters.AddWithValue($"@Urun{i + 1}Adet", 4);
            }
            VtIslem.KomutCalistir(Komut);
            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Kutu kaydedildi.");
                VeriDoldur();
                listView1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Kutu kaydedilemedi. Lütfen tekrar deneyin.");
            }
            VeriDoldur();
        }
        private void KutuEkle48()
        {
            if (listBox1.SelectedItems.Count < 8)
            {
                MessageBox.Show("Lütfen en az 8 ürün seçin.");
                return;
            }
            string Komut = "Insert Into 48liKutulama (KutuId,Urun1No,Urun1Adet,Urun2No,Urun2Adet,Urun3No,Urun3Adet,Urun4No,Urun4Adet,Urun5No,Urun5Adet,Urun6No,Urun6Adet,Urun7No,Urun7Adet,Urun8No,Urun8Adet)" +
               "VALUES (@KutuId,@Urun1No,@Urun1Adet,@Urun2No,@Urun2Adet,@Urun3No,@Urun3Adet,@Urun4No,@Urun4Adet,@Urun5No,@Urun5Adet,@Urun6No,@Urun6Adet,@Urun7No,@Urun7Adet,@Urun8No,@Urun8Adet)";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@KutuId", CBoxKutuNo.SelectedValue);

            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                VtIslem.command.Parameters.AddWithValue($"@Urun{i + 1}No", listBox1.SelectedItems[i].ToString());
                VtIslem.command.Parameters.AddWithValue($"@Urun{i + 1}Adet", 4);
            }
            VtIslem.KomutCalistir(Komut);
            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Kutu kaydedildi.");
                VeriDoldur();
                listView1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Kutu kaydedilemedi. Lütfen tekrar deneyin.");
            }
            VeriDoldur();
        }
        private void KutuEkleBtn_Click(object sender, EventArgs e)
        {
            byte kutuNo = Convert.ToByte(CBoxKutuNo.SelectedIndex.ToString());
            string secilenCiko = CBCikolataSecim.SelectedIndex.ToString();
            DateTime kutulamaTarih = DTPKutulama.Value;
            string konum = CBoxNereye.SelectedIndex.ToString();

            if (CBoxKutuNo.SelectedIndex==0)
            {
                KutuEkle16();
            }
            else if (CBoxKutuNo.SelectedIndex == 1)
            {
                KutuEkle16();
            }
            else if (CBoxKutuNo.SelectedIndex == 2)
            {
                KutuEkle24();
            }
            else if (CBoxKutuNo.SelectedIndex == 3)
            {
                KutuEkle24();
            }
            else if (CBoxKutuNo.SelectedIndex == 4)
            {
                KutuEkle32();
            }
            else if (CBoxKutuNo.SelectedIndex == 5)
            {
                KutuEkle32();
            }
            else if (CBoxKutuNo.SelectedIndex == 6)
            {
                KutuEkle48();
            }
            else if (CBoxKutuNo.SelectedIndex == 7)
            {
                KutuEkle48();
            }
            else if (CBoxKutuNo.SelectedIndex == 8)
            {
                KutuEkle30();
            }
            else if (CBoxKutuNo.SelectedIndex == 9)
            {
                KutuEkle30();
            }
           
            string Komut = "INSERT INTO KutulamaTablosu (KutuId,KutulamaTarih,CikolataSecimi,KutuKonum)" +
                    " VALUES (@KutuId,@KutulamaTarih,@CikolataSecimi,@KutuKonum)";
                    VtIslem.command.Parameters.Clear();
                    VtIslem.command.Parameters.AddWithValue("@KutuId",kutuNo);
                    VtIslem.command.Parameters.AddWithValue("@KutulamaTarih",kutulamaTarih);
                    VtIslem.command.Parameters.AddWithValue("@CikolataSecimi",secilenCiko);
                    VtIslem.command.Parameters.AddWithValue("@KutuKonum",konum);
                VtIslem.KomutCalistir(Komut);
              
                if (Periparam.affectedRows > 0)
                {
                    MessageBox.Show("Kutu kaydedildi.");

                    CBCikolataSecim.Text = "";
                    listBox1.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Kutu kaydedilemedi. Lütfen tekrar deneyin.");
                }
            VeriDoldur();
        }
        public int GetMaxItems(string secilenKutu)
        {
            switch (CBoxKutuNo.SelectedIndex)
            {
                case 0:
                    return 4; // 16'lı kutu
                case 1:
                    return 4;
                case 2:
                    return 6;  // 24'lü kutu
                case 3:
                    return 6; 
                case 4:
                    return 5;// 30'lu kutu
                case 5:
                    return 5;
                case 6:
                    return 8;// 32'li kutu
                case 7:
                    return 8;
                case 8:
                    return 8;// 48'li kutu
                default:
                    return 8;
            }
        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CBoxKutuNo.SelectedItem == null)
            {
                MessageBox.Show("Lütfen önce bir kutu seçiniz.");
                return;
            }
            string secilenKutu = CBoxKutuNo.SelectedItem.ToString();
            int maxItems = GetMaxItems(secilenKutu);

            if (listView1.Items.Count >= maxItems)
            {
                MessageBox.Show($"Bu kutuya en fazla {maxItems} çikolata ekleyebilirsiniz.");
                return;
            }
            string secilenCikolata = listBox1.SelectedItem.ToString();
            ListViewItem item = new ListViewItem(secilenCikolata);
            listView1.Items.Add(item);
        }
        private void CBoxKutuNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();

         if (CBoxKutuNo.SelectedIndex == 8 || CBoxKutuNo.SelectedIndex == 9)
         {
             panel1.Visible = true;
         }
        
        }
        private void Kutular_Load(object sender, EventArgs e)
        {
            listBox1.ItemHeight = 10;
            VeriDoldur();
            KutuGetir();
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili kutuyu \nsilmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                switch (CBoxKutuNo.SelectedIndex) 
                { 
                    case 0: KutuSil16(); break;
                    case 1: KutuSil24(); break;
                    case 2: KutuSil32(); break;
                    case 3: KutuSil48(); break;
                    case 4: KutuSil30(); break;
                }
            }
        }
        private void CBoxNereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxNereye.SelectedItem.ToString() == "Dükkan")
            {
                KullaniciGiris kullanicifrm = new KullaniciGiris();
                kullanicifrm.Show();
                string sec = "Select KullaniciAdi,KullaniciSifresi from KullaniciBilgileri";
                VtIslem.KomutCalistir(sec);
            }
            //else
            //{
            //    MessageBox.Show("Dükkan için sadece belirli kullanıcı kutulama yapabilir.", "Bilgi",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}
