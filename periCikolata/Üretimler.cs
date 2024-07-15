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
        #region Bağlantı Olayları
        private void UretimiSil()
        {
            string Komut = "Delete from UretimTablosu where UretimId = @UretimId";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@UretimId", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            VtIslem.KomutCalistir(Komut);

            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Üretim silindi.");
                VeriDoldur();
            }
            else
            {
                MessageBox.Show("Üretim silinemedi. Lütfen tekrar deneyin.");
            }
            VeriDoldur();
        }
        private void UrunleriGetir()
        {
            string sec = "Select UrunId from UrunlerTablosu";
            CBoxUrunNo.DataSource = VtIslem.VeriGetir(sec);
            //CBoxUrunNo.DisplayMember = "MalAdi";
            CBoxUrunNo.ValueMember = "UrunId";
        }
        private void VeriDoldur()
        {
            string sec = "Select UretimId,UrunId,Uretimtarihi,UretimMiktari,UretimTutari from UretimTablosu";
            dataGridView1.DataSource = VtIslem.VeriGetir(sec);
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
            byte urunNo = Convert.ToByte(CBoxUrunNo.Text);
            byte uretimMiktar = Convert.ToByte(TBoxUretimMiktar.Text);
            double uretimTutari = double.Parse(TBoxUretimTutar.Text);
            DateTime uretimTarih = DTPUretim.Value;

            if (TBoxUretimMiktar.Text.Trim() !="" & TBoxUretimTutar.Text.Trim() !="" & CBoxUrunNo.Text.Trim() !="")
            {
                string Komut = "INSERT INTO UretimTablosu (UrunId,UretimTarihi,UretimMiktari,UretimTutari)" +
                    " VALUES (@UrunId,@UretimTarihi,@UretimMiktari,@UretimTutari)";
                VtIslem.command.Parameters.Clear();
               VtIslem.command.Parameters.AddWithValue("@UrunId", urunNo);
                VtIslem.command.Parameters.AddWithValue("@UretimTarihi", uretimTarih);
                VtIslem.command.Parameters.AddWithValue("@UretimMiktari", uretimMiktar);
                VtIslem.command.Parameters.AddWithValue("@UretimTutari", uretimTutari);
                VtIslem.KomutCalistir(Komut);

                Komut = "Insert Into StokHareketTablosu (UrunId,GuncelMiktar) Values (@UrunId,@GuncelMiktar)";
                VtIslem.command.Parameters.Clear();
                VtIslem.command.Parameters.AddWithValue("@UrunId", urunNo);
                VtIslem.command.Parameters.AddWithValue("@GuncelMiktar", uretimMiktar);
                VtIslem.KomutCalistir(Komut);

                    if (Periparam.affectedRows > 0)
                    {
                        MessageBox.Show("Üretim eklendi.");
                        //CBoxUrunNo.Items.Clear();
                        TBoxUretimNo.Clear();
                        TBoxUretimMiktar.Clear();
                        TBoxUretimTutar.Clear();
                        VeriDoldur();
                    }
                    else
                    {
                        MessageBox.Show("Üretim eklenemedi. Lütfen tekrar deneyin.");
                    }
            }
            else
            {
                MessageBox.Show("Tüm alanların dolu olduğundan emin olunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnUretimGuncelle_Click(object sender, EventArgs e)
        {
            string Komut = "Update UretimTablosu set UrunId='" + Convert.ToInt16(CBoxUrunNo.Text) + "',UretimTarihi='" + DTPUretim.Value + "', UretimMiktari='" + Convert.ToInt16(TBoxUretimMiktar.Text) + "'," +
                "UretimTutari='" + decimal.Parse(TBoxUretimTutar.Text) + "' Where UretimId ="+Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)+" ";
            VtIslem.KomutCalistir(Komut);

            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Üretim güncellendi.");
                //CBoxUrunNo.Items.Clear();
                TBoxUretimNo.Clear();
                TBoxUretimMiktar.Clear();
                TBoxUretimTutar.Clear();
                VeriDoldur();
            }
            else
            {
                MessageBox.Show("Üretim güncellenemedi. Lütfen tekrar deneyin.");
            }
        }
        private void Üretimler_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
            VeriDoldur();
            BaslikGoster();
            BtnUretimGuncelle.Enabled= false;
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnUretimEkle.Enabled=false;
            BtnUretimGuncelle.Enabled = true;
            TBoxUretimNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CBoxUrunNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TBoxUretimMiktar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TBoxUretimTutar.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            DTPUretim.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili üretim işlemini \nsilmek istediğinizden emin misiniz?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UretimiSil();
            }
            
        }
    }
}
