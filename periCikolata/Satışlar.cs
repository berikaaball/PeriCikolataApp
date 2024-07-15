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
        #endregion
        #region Bağlantı Olayları
        private void SatisSil()
        {
            string Komut = "Delete from SatisTablosu where SatisNo = @SatisNo";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@SatisNo", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            VtIslem.KomutCalistir(Komut);

            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Satış silindi.");
                VeriDoldur();
            }
            else
            {
                MessageBox.Show("Satış silinemedi. Lütfen tekrar deneyin.");
            }
            VeriDoldur();
        }
        private void VeriDoldur()
        {
            string sec = "Select SatisId,KutulamaId,SatisTuru,SatisMiktari,SatisTutari,SatisTarihi from SatisTablosu";
            dataGridView1.DataSource = VtIslem.VeriGetir(sec);
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
            int kutulamaNo = Convert.ToInt16(TBoxKutulama.Text);
            string satisTuru = CBoxSatisTuru.SelectedItem.ToString();
            int satisMiktar = Convert.ToInt16(TBoxSatisMiktar.Text);
            decimal satisTutari = decimal.Parse(TBoxSatisTutari.Text);
            DateTime satisTarihi = DTPSatis.Value;
          
            string Komut = "INSERT INTO SatisTablosu (KutulamaId,SatisTuru,SatisMiktari,SatisTutari,SatisTarihi)" +
                " VALUES (@KutulamaId,@SatisTuru,@SatisMiktari,@SatisTutari,@SatisTarihi)";

            VtIslem.command.Parameters.Clear();
           VtIslem.command.Parameters.AddWithValue("@KutulamaId", kutulamaNo);
            VtIslem.command.Parameters.AddWithValue("@SatisTuru", satisTuru);
            VtIslem.command.Parameters.AddWithValue("@SatisMiktari", satisMiktar);
            VtIslem.command.Parameters.AddWithValue("@SatisTutari", satisTutari);
            VtIslem.command.Parameters.AddWithValue("@SatisTarihi", satisTarihi);
            VtIslem.KomutCalistir(Komut);

            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Satış eklendi.");
                TBoxKutulama.Clear();
                TBoxSatisMiktar.Clear();
                TBoxSatisNo.Clear();
                TBoxSatisTutari.Clear();
                CBoxSatisTuru.Items.Clear();
            }
            else
            {
                MessageBox.Show("Satış eklenemedi. Lütfen tekrar deneyin.");
            }
            VeriDoldur();
        }
        private void BtnSatisGuncelle_Click(object sender, EventArgs e)
        {
            string Komut = "Update SatisTablosu set SatisTuru='" + CBoxSatisTuru.SelectedItem.ToString() +
              "', KutulamaId='" + Convert.ToInt16(TBoxKutulama.Text) + "', SatisTuru='" + CBoxSatisTuru.SelectedItem.ToString() + "'," +
              "SatisMiktari='" + Convert.ToInt16(TBoxSatisMiktar.Text) + "',SatisMiktari='" + decimal.Parse(TBoxSatisTutari.Text) + "',SatisTarihi='" + DTPSatis.Value + "' Where SatisId='" + Convert.ToByte(TBoxSatisNo.Text) + "'";
            VtIslem.KomutCalistir(Komut);

            if (Periparam.affectedRows > 0)
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
            VeriDoldur();
        }
        private void Satışlar_Load(object sender, EventArgs e)
        {
            VeriDoldur();
            BaslikGoster();
            BtnSatisGuncelle.Enabled = false;
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnSatisEkle.Enabled = false;
            BtnSatisGuncelle.Enabled = true;
            TBoxSatisNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TBoxKutulama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            CBoxSatisTuru.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TBoxSatisMiktar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TBoxSatisTutari.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            DTPSatis.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Satış İşlemini \nSilmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SatisSil();
            }
        }
    }
}
