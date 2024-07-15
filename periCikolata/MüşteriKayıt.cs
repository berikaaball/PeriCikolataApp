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

        #endregion
        #region Bağlantı Olayları   
        private void MusteriSil()
        {
            string Komut = "Delete from MusteriBilgileri where MusteriNo = @MusteriNo";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@MusteriNo", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            VtIslem.KomutCalistir(Komut);

            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Müşteri silindi.");
                VeriDoldur();
            }
            else
            {
                MessageBox.Show("Müşteri silinemedi. Lütfen tekrar deneyin.");
            }
            VeriDoldur();
        }
        private void VeriDoldur()
        {
            string sec = "Select MusteriNo,MusteriAdi,MusteriSoyadi,MusteriSirketi,MusteriTelefon from MusteriBilgileri";
            dataGridView1.DataSource = VtIslem.VeriGetir(sec);
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
        }
        private void BtnMusteriEkle_Click(object sender, EventArgs e)
        {
            string ad = TBoxMusteriAdi.Text;
            string soyad = TBoxSoyad.Text;
            string sirket = TBoxFirmaAdi.Text;
            string telefon = TBoxTelefon.Text;
            if (TBoxTelefon.Text.Length> 10 || TBoxTelefon.Text.Length < 10)
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.");
                TBoxTelefon.Select();
                return;
            }
            else
            {
                string Komut = "Insert Into MusteriBilgileri (MusteriAdi,MusteriSoyadi,MusteriSirketi,MusteriTelefon) Values " +
                    "(@MusteriAdi,@MusteriSoyadi,@MusteriSirketi,@MusteriTelefon)";
                VtIslem.command.Parameters.AddWithValue("MusteriAdi", ad);
                VtIslem.command.Parameters.AddWithValue("MusteriSoyadi", soyad);
                VtIslem.command.Parameters.AddWithValue("MusteriSirketi", sirket);
                VtIslem.command.Parameters.AddWithValue("MusteriTelefon", telefon);

                VtIslem.KomutCalistir(Komut);

                if (Periparam.affectedRows > 0)
                {
                    MessageBox.Show("Müşteri eklendi.", "Bilgi", MessageBoxButtons.OK);
                    TBoxMusteriNo.Text = "";
                    TBoxMusteriAdi.Text = "";
                    TBoxSoyad.Text = "";
                    TBoxFirmaAdi.Text = "";
                    TBoxTelefon.Text = "";
                }
                else
                {
                    MessageBox.Show("Müşteri eklenemedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                VeriDoldur();
            }
        }
        private void BtnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            string Komut = "Update MusteriBilgileri Set MusteriAdi= '"+TBoxMusteriAdi.Text+"'," +
                " MusteriSoyadi= '"+TBoxSoyad.Text+"', MusteriSirketi = '"+TBoxFirmaAdi.Text+"'," +
                " MusteriTelefon= '"+TBoxTelefon.Text+"' Where MusteriNo = '"+TBoxMusteriNo.Text+"'";
            VtIslem.KomutCalistir(Komut);

            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Müşteri güncellendi.","Bilgi",MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Müşteri güncellenemedi. Lütfen tekrar deneyin.","Bilgi",MessageBoxButtons.OK);
            }
            VeriDoldur();
            BtnMusteriGuncelle.Enabled = false;
            BtnMusteriEkle.Enabled = true;
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnMusteriEkle.Enabled= false;
            BtnMusteriGuncelle.Enabled= true;
            TBoxFirmaAdi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TBoxMusteriAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TBoxMusteriNo.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TBoxSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TBoxTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Müşteriyi \nSilmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MusteriSil();
            }
        }
    }
}