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
    public partial class Form_Kategori : Form
    {
        public Form_Kategori()
        {
            InitializeComponent();
        }

        private void btn_kategori_ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_kategoriAd.Text))
            {
                return;
            }

            bool result = kategori_ekle();

            if (!result)
            {
                MessageBox.Show("Kategori eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Kategori başarıyla eklendi.", "Başarı", MessageBoxButtons.OK);
            }

            DataTable kategoriler = kategoriler_listele();
            grd_kategoriler.DataSource = kategoriler;
        }

        private bool kategori_ekle()
        {
            bool result = false;

            try
            {
                int id = 0;

                string query = "SELECT COUNT(id) from kategoriler";
                SqlCommand cmd = new SqlCommand(query, Database.SqlConnection);
                int resultQuery = (int)cmd.ExecuteScalar();

                if (resultQuery >= 1)
                {
                    query = "SELECT MAX(id) from kategoriler";
                    cmd = new SqlCommand(query, Database.SqlConnection);
                    id = (int)cmd.ExecuteScalar();
                }

                query = "INSERT INTO kategoriler (id, ad) VALUES(@id, @ad)";
                cmd = new SqlCommand(query, Database.SqlConnection);

                SqlParameter idParameter = new SqlParameter("@id", System.Data.SqlDbType.Int);
                idParameter.Value = id + 1;
                SqlParameter adParameter = new SqlParameter("@ad", System.Data.SqlDbType.VarChar); //control this
                adParameter.Value = txt_kategoriAd.Text;

                cmd.Parameters.Add(idParameter);
                cmd.Parameters.Add(adParameter);

                cmd.ExecuteNonQuery();

                result = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        private void Form_Kategori_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable kategoriler = kategoriler_listele();
                grd_kategoriler.DataSource = kategoriler;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable kategoriler_listele()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT k.id AS 'Id', k.ad AS 'Kategori Adi' FROM kategoriler k";
                SqlCommand cmd = new SqlCommand(query, Database.SqlConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }
    }
}
