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
        #region Bağlantı Olayları
        private void EtkinlikSil()
        {
            string Komut = "Delete from Workshop where EtkinlikId = @EtkinlikId";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@EtkinlikId", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            VtIslem.KomutCalistir(Komut);
            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Etkinlik silindi.");
                VeriDoldur();
            }
            else
            {
                MessageBox.Show("Etkinlik silinemedi.Lütfen tekrar deneyiniz.");
            }
            VeriDoldur();
        }
         private void VeriDoldur()
        {
            string sec = "Select EtkinlikId,EtkinlikAdi,Kapasite,Tarih,Adres from Workshop";
            dataGridView1.DataSource = VtIslem.VeriGetir(sec);
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
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@EtkinlikAdi", etkadi);
            VtIslem.command.Parameters.AddWithValue("@Tarih", etktarih);
            VtIslem.command.Parameters.AddWithValue("@Kapasite", kapasite);
            VtIslem.command.Parameters.AddWithValue("@Adres", adres);

            VtIslem.KomutCalistir(Komut);

            if (Periparam.affectedRows > 0)
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
            VeriDoldur();
        }
        private void BtnEtkinlikGuncelle_Click(object sender, EventArgs e)
        {
            string Komut = "Update Workshop set EtkinlikAdi='" + EtkAdTBox.Text +
               "', Tarih='" + dateTimePicker1.Value + "', Adres='" + AdresTBox.Text + "'," +
               "Kapasite='" + Convert.ToInt16(KapasiteTBox.Text) + "' where EtkinlikId= '"+EtkNoTBox.Text+"'";
            VtIslem.KomutCalistir(Komut);

            if (Periparam.affectedRows > 0)
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
            VeriDoldur();
            BtnEtkinlikGuncelle.Enabled = false;
            EtkKaydetBtn.Enabled = true;
        }
        private void Workshop_Load(object sender, EventArgs e)
        {
            VeriDoldur();
            BaslikGoster();
            BtnEtkinlikGuncelle.Enabled = false;
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnEtkinlikGuncelle.Enabled = true;
            EtkKaydetBtn.Enabled = false;
            AdresTBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            EtkAdTBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EtkNoTBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            KapasiteTBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili etkinliği silmek istediğinizden \nemin misiniz?", "Uyarı", 
                MessageBoxButtons.YesNo) == DialogResult.Yes);
            EtkinlikSil();
        }
    }
}
