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
    public partial class AySonuVeriler : Form
    {
        public AySonuVeriler()
        {
            InitializeComponent();
        }
        #region Bağlantı Tanımlamaları

        #endregion

        #region Bağlantı Olayları
        private void UrtmGrBtn_Click(object sender, EventArgs e)
        {
            string sec = "Select UretimId,UrunId,UretimTarihi,UretimMiktari,UretimTutari from UretimTablosu " +
                "where Convert(date,UretimTarihi) >= '" + monthCalendar1.SelectionStart + "' AND Convert(date,UretimTarihi) <= '" + monthCalendar1.SelectionEnd + "'";
            dataGridView1.DataSource = VtIslem.VeriGetir(sec);

            dataGridView1.Columns[0].HeaderText = "Üretim No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Ürün No";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Üretim Tarihi";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "Üretim Miktarı";
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "Üretim Tutarı";
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            int netsayi = dataGridView1.Rows.Count;
            TBoxNetSayi.Text = netsayi.ToString();

        }

        private void StsGrBtn_Click(object sender, EventArgs e)
        {
            string sec = "Select SatisId,KutulamaId,SatisTuru,SatisMiktari,SatisTutari,SatisTarihi from SatisTablosu " +
                "where Convert(date,SatisTarihi) >= '" + monthCalendar1.SelectionStart + "' AND Convert(date,SatisTarihi) <= '" + monthCalendar1.SelectionEnd + "'";
            dataGridView1.DataSource = VtIslem.VeriGetir(sec);


            dataGridView1.Columns[0].HeaderText = "Satış No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Kutulama No";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Satış Türü";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "Satış Miktarı";
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "Satış Tutarı";
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderText = "Satış Tarihi";
            dataGridView1.Columns[5].Width = 90;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            int netsayi = dataGridView1.Rows.Count;
            TBoxNetSayi.Text = netsayi.ToString();
        }

        private void MlytBtn_Click(object sender, EventArgs e)
        {
            //Select al.AlimNo,mal.MalId, mal.MalAdi,al.MalSKT,al.AlimMiktari,al.OdemeTuru,
            //    al.AlimTutari,al.AlimTarihi from AlimTablosu al, MalTablosu mal where al.MalId = mal.MalId
            string sec = "Select al.AlimNo,mal.MalAdi,al.AlimMiktari,al.OdemeTuru,al.AlimTutari,al.AlimTarihi from AlimTablosu al, MalTablosu mal" +
                " where al.MalId=mal.MalId and (Convert(date,AlimTarihi) >= '" + monthCalendar1.SelectionStart + "' AND Convert(date,AlimTarihi) <= '" + monthCalendar1.SelectionEnd + "')";
            dataGridView1.DataSource = VtIslem.VeriGetir(sec);

            dataGridView1.Columns[0].HeaderText = "Alım No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Mal Adı";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Alım Miktarı";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "Ödeme Türü";
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "Alım Tutarı";
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderText = "Alım Tarihi";
            dataGridView1.Columns[5].Width = 90;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            int netsayi = dataGridView1.Rows.Count;
            TBoxNetSayi.Text = netsayi.ToString();
        }

        private void WorkshopGorBtn_Click(object sender, EventArgs e)
        {
            string sec = "Select EtkinlikId,EtkinlikAdi,Kapasite,Tarih,Adres from Workshop " +
                "where Convert(date,Tarih) >= '" + monthCalendar1.SelectionStart + "' AND Convert(date,Tarih) <= '" + monthCalendar1.SelectionEnd + "'";
            dataGridView1.DataSource = VtIslem.VeriGetir(sec);

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

            int netsayi = dataGridView1.Rows.Count;
            TBoxNetSayi.Text = netsayi.ToString();
        }
        #endregion
    }
}