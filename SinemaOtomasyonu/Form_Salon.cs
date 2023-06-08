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

namespace SinemaOtomasyonu
{
    public partial class Form_Salon : Form
    {
        public Form_Salon()
        {
            InitializeComponent();
        }

        private void btn_salon_ekle_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_salonNumara.Text))
            {
                return;
            }

            bool result = salon_ekle();

            if (!result)
            {
                MessageBox.Show("Salon eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                MessageBox.Show("Salon başarıyla eklendi.", "Başarı", MessageBoxButtons.OK);
            }

            DataTable salonlar = salonlistele();

            grd_salonlar.DataSource = salonlar;
        }

        public bool salon_ekle()
        {
            bool result = false;

            try
            {
                int id = 0;

                string query = "SELECT COUNT(id) from salonlar";
                SqlCommand cmd = new SqlCommand(query, Database.SqlConnection);
                int resultQuery = (int)cmd.ExecuteScalar();

                if (resultQuery >= 1)
                {
                    query = "SELECT MAX(id) from salonlar";
                    cmd = new SqlCommand(query, Database.SqlConnection);
                    id = (int)cmd.ExecuteScalar();
                }

                query = "INSERT INTO salonlar (id, numara) VALUES (@id, @numara)";
                cmd = new SqlCommand(query, Database.SqlConnection);

                SqlParameter idParameter = new SqlParameter("@id", System.Data.SqlDbType.Int);
                idParameter.Value = id + 1;
                SqlParameter numaraParameter = new SqlParameter("@numara", System.Data.SqlDbType.VarChar);
                numaraParameter.Value = txt_salonNumara.Text;
                cmd.Parameters.Add(idParameter);
                cmd.Parameters.Add(numaraParameter);

                cmd.ExecuteNonQuery();

                result = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        private void Form_Salon_Load(object sender, EventArgs e)
        {
            DataTable salonlar = salonlistele();

            grd_salonlar.DataSource = salonlar;
        }

        public static DataTable salonlistele()
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT s.id AS 'Id', s.numara AS 'Numara' FROM salonlar s";
                SqlCommand cmd = new SqlCommand(query, Database.SqlConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);

            } catch(Exception ex) {
                throw ex;
            }

            return dt;
        }
    }
}
