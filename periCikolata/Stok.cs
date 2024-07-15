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
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }
        #region Bağlantı Olayları
        private void UrunleriGetir()
        {
            string sec = "Select UrunId from UrunlerTablosu";
            CBoxUrun.DataSource = VtIslem.VeriGetir(sec);
            //CBoxUrunNo.DisplayMember = "MalAdi";
            CBoxUrun.ValueMember = "UrunId";
        }
        private void VeriDoldur()
        {
            string sec = "Select UrunId,GuncelMiktar from StokHareketTablosu";
            dataGridView1.DataSource = VtIslem.VeriGetir(sec);
        }
        private void BaslikGoster()
        {
            dataGridView1.Columns[0].HeaderText = "Ürün No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Güncel Miktar";
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }
        #endregion
        private void Stok_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
            VeriDoldur();
            BaslikGoster();
        }
        private void BtnAra_Click(object sender, EventArgs e)
        {
            string Komut = "Select UrunId,GuncelMiktar from StokHareketTablosu " +
                "Where UrunId LIKE '%"+CBoxUrun.SelectedItem.ToString()+"%'";
            VtIslem.KomutCalistir(Komut);
            VeriDoldur();
        }
    }
}
