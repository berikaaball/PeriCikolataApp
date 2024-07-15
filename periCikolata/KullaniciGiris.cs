using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace periCikolata
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        public Kutular kutufrm;


        #region Bağlantı Tanımlamaları
   
        #endregion


        #region Bağlantı Olayları


        private bool Kontrol(string KullaniciAdi)
        {
            try
            {
                string Komut = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi=@kullaniciAdi";
                VtIslem.command.Parameters.Clear();
                VtIslem.command.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
  
                VtIslem.KomutCalistir(Komut);

                int kullaniciSayisi = (int)VtIslem.command.ExecuteScalar();
                return kullaniciSayisi > 0;
            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.Message, "Kullanıcı bulunamadı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
        }
        #endregion
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            //if (TBoxKullaniciAdi.Text.Trim() != "" & TBoxSifre.Text.Trim() != "")
           // {
                string kullaniciAdi = TBoxKullaniciAdi.Text;
                string sifre = TBoxSifre.Text;

            if (Kontrol(kullaniciAdi))
            {

            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı! Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
           // }
            
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TBoxKullaniciAdi.Text.Trim() != "" & TBoxSifre.Text.Trim() != "")
            {
                string Komut = "Insert into KullaniciBilgileri (KullaniciAdi,KullaniciSifresi) Values ('" + TBoxKullaniciAdi.Text + "','" + TBoxSifre.Text + "')";
                VtIslem.KomutCalistir(Komut);

                MessageBox.Show("Kullanıcı eklendi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
                TBoxKullaniciAdi.Clear();
                TBoxSifre.Clear();
            }
            else
            {
                MessageBox.Show("Alanları kontrol ediniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string Komut = "Delete * From KullaniciBilgileri where KullaniciAdi='" + TBoxKullaniciAdi.Text+ "'";
                VtIslem.KomutCalistir(Komut);

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                MessageBox.Show("Kullanıcı silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
