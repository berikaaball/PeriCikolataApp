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
    public partial class Mallar : Form
    {
        public Mallar()
        {
            InitializeComponent();
        }
        #region Bağlantı Olayları
        private void VeriDoldur()
        {
            string sec = "Select MalId,MalAdi from MalTablosu";
            dataGridView1.DataSource = VtIslem.VeriGetir(sec);
        }
        private void BaslikGoster()
        {
            dataGridView1.Columns[0].HeaderText = "Mal No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Mal Adı";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }
        #endregion
        private void BtnMalEkle_Click(object sender, EventArgs e)
        {
            string malAdi = TBoxMalAdi.Text;

            //string varmi = "SELECT * FROM MalTablosu WHERE MalAdi = @MalAdi";
           
            string Komut = "INSERT INTO MalTablosu (MalAdi)" +
                   " VALUES (@MalAdi)";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@MalAdi", malAdi);
            
            VtIslem.KomutCalistir(Komut);
            if (Periparam.affectedRows > 0)
            {
                MessageBox.Show("Mal eklendi.");
                TBoxMalAdi.Text = "";
                TBoxMalNo.Text = "";
            }
            else
            {
                MessageBox.Show("Mal eklenemedi. Lütfen tekrar deneyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VeriDoldur();
        }
        private void Mallar_Load(object sender, EventArgs e)
        {
            VeriDoldur();
            BaslikGoster();
        }
    }
}
