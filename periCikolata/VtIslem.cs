using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace periCikolata
{
    public static class VtIslem
    {
        static SqlConnection connection = new SqlConnection(VtBaglanti.connectionString);
        public static SqlCommand command = new SqlCommand();
        static SqlDataAdapter adapter;

        public static DataTable VeriGetir(string sec)
        {
            DataTable goster = new DataTable();
            adapter = new SqlDataAdapter(sec, connection);
            adapter.Fill(goster);
            return goster;
        }

        public static void KomutCalistir(string Komut)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.Connection = connection;
                command.CommandText = Komut;
                Periparam.affectedRows = command.ExecuteNonQuery();
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
    }
}
