using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu
{
    public static class Database
    {
        public static SqlConnection SqlConnection;

        public static string SqlConnectionString = "Server=ACER-ASPIRE-5\\SQLEXPRESS;Database=sinema;Trusted_Connection=True;"; 

        public static bool connect()
        {
            bool result = false;

            try
            {
                SqlConnection = new SqlConnection(SqlConnectionString);
                SqlConnection.Open();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static void disconnect()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
    }
}
