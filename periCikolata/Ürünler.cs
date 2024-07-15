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
        #region Bağlantı Olayları
        private void UrunSil()
        {
            string Komut = "Delete from UrunlerTablosu where UrunId = @UrunId";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@UrunId",dataGridView1.CurrentRow.Cells[0].Value.ToString());
            VtIslem.KomutCalistir(Komut);
            if(Periparam.affectedRows > 0)
            {
                MessageBox.Show("Ürün silindi.");
                VeriDoldur();
            }
            else
            {
                MessageBox.Show("Ürün silinemedi.Lütfen tekrar deneyiniz.");
            }
            VeriDoldur();
        }
        private void VeriDoldur()
        {
            string sec = "Select UrunId,UrunAdi,UrunDolgusu,UrunMeyvesi from UrunlerTablosu";
            dataGridView1.DataSource = VtIslem.VeriGetir(sec);
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
            string Komut = "Delete from UrunlerTablosu where UrunId = '"+TBoxUrunNo.Text+"'";
            VtIslem.KomutCalistir(Komut);

            if (Periparam.affectedRows > 0)
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
            VeriDoldur();
            BtnUrunEkle.Enabled = true;
        }
        private void BtnUrunGuncelle_Click(object sender, EventArgs e)
        {
            string Komut = "Update UrunlerTablosu set  UrunAdi='" + TBoxUrunAdi.Text +
                "', UrunDolgusu='" + CBoxDolgu.SelectedItem.ToString() + "', UrunMeyvesi='" + CBoxMeyve.SelectedItem.ToString() + "' Where UrunId='" + Convert.ToInt16(TBoxUrunNo.Text) + "'";
            VtIslem.KomutCalistir(Komut);

            if (Periparam.affectedRows > 0)
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
            VeriDoldur();
            BtnUrunEkle.Enabled= true;
            BtnUrunGuncelle.Enabled= false;
        }
        private void BtnUrunEkle_Click_1(object sender, EventArgs e)
        {
            string urunAdi = TBoxUrunAdi.Text;
            string dolgu = CBoxDolgu.SelectedItem.ToString();
            string meyve = CBoxMeyve.SelectedItem.ToString();
            string Komut = "INSERT INTO UrunlerTablosu (UrunAdi,UrunDolgusu,UrunMeyvesi)" +
                    " VALUES (@UrunAdi,@UrunDolgusu,@UrunMeyvesi)";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@UrunAdi", urunAdi);
            VtIslem.command.Parameters.AddWithValue("@UrunDolgusu", dolgu);
            VtIslem.command.Parameters.AddWithValue("@UrunMeyvesi", meyve);

            VtIslem.KomutCalistir(Komut);

                if (Periparam.affectedRows > 0)
                {
                    MessageBox.Show("Ürün kaydedildi.");
                    VeriDoldur();
                    TBoxUrunNo.Clear();
                    TBoxUrunAdi.Clear();
                    CBoxDolgu.SelectedItem = null;
                    CBoxMeyve.SelectedItem = null;
                    VeriDoldur();
                }
                else
                {
                    MessageBox.Show("Ürün kaydedilemedi. Lütfen tekrar deneyin.");
                }
                VeriDoldur();
        }
        private void Ürünler_Load(object sender, EventArgs e)
        {
            VeriDoldur();
            BaslikGoster();
            BtnUrunGuncelle.Enabled= false;
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnUrunEkle.Enabled= false;
            BtnUrunGuncelle.Enabled = true;
            TBoxUrunAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TBoxUrunNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CBoxDolgu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            CBoxMeyve.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili ürünü silmek istediğinizden \nemin misiniz?", "Uyarı", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            UrunSil();
        }
    }
}