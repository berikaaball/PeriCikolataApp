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
using System.Data.Common;

namespace periCikolata
{
    public partial class Alımlar : Form
    {
       
        public Alımlar()
        {
            InitializeComponent();
        }
        #region Bağlantı Olayları  
        private void AlimSil()
        {
            string Komut = "Delete from AlimTablosu where AlimNo = @AlimNo";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@AlimNo", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            VtIslem.KomutCalistir(Komut);

            if (Periparam.affectedRows > 0)
            {
                VeriDoldur();
            }
            else
            {
                MessageBox.Show("Alım silinemedi. Lütfen tekrar deneyin.");
            }
            VeriDoldur();
        }
        private void VeriDoldur()
        {
            string sec = "Select al.AlimNo,mal.MalId, mal.MalAdi,al.MalSKT,al.AlimMiktari,al.OdemeTuru,al.AlimTutari,al.AlimTarihi from AlimTablosu al, MalTablosu mal where al.MalId=mal.MalId";
            dataGridView1.DataSource = VtIslem.VeriGetir(sec);
        }
        private void MallariGetir()
        {
            string sec = "Select * from MalTablosu";
            CBoxMalNo.DataSource = VtIslem.VeriGetir(sec);
            CBoxMalNo.DisplayMember = "MalAdi";
            CBoxMalNo.ValueMember = "MalId";
        }
        private void BaslikGoster()
        {
            dataGridView1.Columns[0].HeaderText = "Alım No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            //DataGridViewComboBoxColumn malcolumn = new DataGridViewComboBoxColumn();
            //malcolumn.Width = 100;
            //malcolumn.DefaultCellStyle.Alignment =
            //    DataGridViewContentAlignment.MiddleCenter;
            //string sec = "Select * from MalTablosu";
            //malcolumn.DataSource = MalTablosunuGetir(sec);
            //malcolumn.DataPropertyName = "MalId";
            //malcolumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            //malcolumn.DisplayMember = "MalAdi";
            //malcolumn.ValueMember = "MalId";
            //malcolumn.HeaderText = "Mal Adı";
            //dataGridView1.Columns.Add(malcolumn);
            dataGridView1.Columns[1].HeaderText = "Mal ID";
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Mal Adı";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[3].HeaderText = "Mal SKT";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "Alım Miktarı";
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderText = "Ödeme Türü";
            dataGridView1.Columns[5].Width = 90;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].HeaderText = "Alım Tutarı";
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns[7].HeaderText = "Alım Tarihi";
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment =
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
                VtIslem.command.Parameters.AddWithValue("@MalId", malNo);
                VtIslem.command.Parameters.AddWithValue("@MalSKT",skt);
                VtIslem.command.Parameters.AddWithValue("@AlimMiktari",alimMiktar);
                VtIslem.command.Parameters.AddWithValue("@OdemeTuru",odemeTuru);
                VtIslem.command.Parameters.AddWithValue("@AlimTutari", tutar);
                VtIslem.command.Parameters.AddWithValue("@AlimTarihi", alinanTarih);
                VtIslem.KomutCalistir(Komut);

                    if (Periparam.affectedRows > 0)
                    {
                        MessageBox.Show("Alım eklendi.");
                        TBoxAlimNo.Clear();
                        TBoxAlimMiktar.Clear();
                        TBoxAlimTutari.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Alım eklenemedi. Lütfen tekrar deneyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            VeriDoldur();
        }
        private void BtnAlimGuncelle_Click(object sender, EventArgs e)
        {
            string Komut = "Update AlimTablosu set MalId='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() +
              "', MalSKT='" + DTPMalSKT.Value + "', AlimMiktari='" + Convert.ToInt16(TBoxAlimMiktar.Text) + "'," +
              "OdemeTuru='" + CBoxOdemeTuru.SelectedItem.ToString() + "',AlimTutari= '" + decimal.Parse(TBoxAlimTutari.Text) + "',AlimTarihi= '" + DTPAlimTarih.Value + "' where   AlimNo='" + Convert.ToInt16(TBoxAlimNo.Text) + "'";
            VtIslem.KomutCalistir(Komut);

            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Alım güncellendi.");
                TBoxAlimNo.Clear();
                TBoxAlimMiktar.Clear();
                TBoxAlimTutari.Clear();
                DTPAlimTarih.Text = "";
                DTPMalSKT.Text = "";
                CBoxOdemeTuru.Items.Clear();
            }
            else
            {
                MessageBox.Show("Alım güncellenemedi. Lütfen tekrar deneyin.");
            }
            VeriDoldur();
        }
        private void Alımlar_Load(object sender, EventArgs e)
        {
            VeriDoldur();
            MallariGetir();
            BaslikGoster();
            BtnAlimGuncelle.Enabled = false;
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnAlimGuncelle.Enabled = true;
            BtnAlimEkle.Enabled = false;
            TBoxAlimNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CBoxMalNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TBoxAlimMiktar.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            CBoxOdemeTuru.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TBoxAlimTutari.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Alım İşlemini \nSilmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AlimSil();
            }
        }
    }
}