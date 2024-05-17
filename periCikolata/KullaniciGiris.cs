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

        static string connectionString = "Data Source=DESKTOP-RORVUON\\SQLEXPRESS;Initial Catalog=PeriCikolata;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        #endregion


        #region Bağlantı Olayları

        private void KomutCalistir(string Komut)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.Connection = connection;
                command.CommandText = Komut;
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantıda bir problem oluştu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }

        private bool Kontrol(string KullaniciAdi)
        {
            try
            {
                string Komut = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi=@kullaniciAdi";
                SqlCommand command = new SqlCommand(Komut, connection);
                command.Parameters.AddWithValue("@kullaniciAdi", KullaniciAdi);
                //command.Parameters.AddWithValue("@sifre", sifre);
                KomutCalistir(Komut);

                int kullaniciSayisi = (int)command.ExecuteScalar();
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
                KomutCalistir(Komut);

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
                KomutCalistir(Komut);

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
