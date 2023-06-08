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
    public partial class Form_Film : Form
    {
        public Form_Film()
        {
            InitializeComponent();
        }

        private void Form_Film_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT id, ad FROM kategoriler";
                SqlCommand cmd = new SqlCommand(query, Database.SqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "kategoriler");
                cb_filmKategori.DisplayMember = "ad";
                cb_filmKategori.ValueMember = "id";
                cb_filmKategori.DataSource = ds.Tables["kategoriler"];
            }
            catch (Exception ex)
            {
                throw ex;
            }

            DataTable filmler = filmler_listele();
            grd_filmler.DataSource = filmler;
        }

        private void btn_film_ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_filmAd.Text) || string.IsNullOrEmpty(txt_filmDili.Text) || string.IsNullOrEmpty(txt_filmSure.Text))
            {
                return;
            }

            bool result = film_ekle();

            if (!result)
            {
                MessageBox.Show("Film eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Film başarıyla eklendi.", "Başarı", MessageBoxButtons.OK);
            }

            DataTable filmler = filmler_listele();
            grd_filmler.DataSource = filmler;
        }

        private bool film_ekle()
        {
            bool result = false;

            try
            {
                int filmId = 0;

                string query = "SELECT COUNT(id) from filmler";
                SqlCommand cmd = new SqlCommand(query, Database.SqlConnection);
                int resultQuery = (int)cmd.ExecuteScalar();

                if (resultQuery >= 1)
                {
                    query = "SELECT MAX(id) from filmler";
                    cmd = new SqlCommand(query, Database.SqlConnection);
                    filmId = (int)cmd.ExecuteScalar();
                }

                int newFilmId = filmId + 1;

                query = "INSERT INTO filmler (id, ad, sure, orijinal_dil) VALUES(@id, @ad, @sure, @orijinal_dil)";
                cmd = new SqlCommand(query, Database.SqlConnection);

                SqlParameter idParameter = new SqlParameter("@id", System.Data.SqlDbType.Int);
                idParameter.Value = newFilmId;
                SqlParameter adParameter = new SqlParameter("@ad", System.Data.SqlDbType.VarChar);
                adParameter.Value = txt_filmAd.Text;
                SqlParameter sureParameter = new SqlParameter("@sure", System.Data.SqlDbType.Int); //control this data type
                sureParameter.Value = txt_filmSure.Text;
                SqlParameter orijinal_diliParameter = new SqlParameter("@orijinal_dil", System.Data.SqlDbType.VarChar);
                orijinal_diliParameter.Value = txt_filmDili.Text;

                cmd.Parameters.Add(idParameter);
                cmd.Parameters.Add(adParameter);
                cmd.Parameters.Add(sureParameter);
                cmd.Parameters.Add(orijinal_diliParameter);

                cmd.ExecuteNonQuery();

                int filmKategoriId = 0;

                query = "SELECT COUNT(id) from film_kategori";
                cmd = new SqlCommand(query, Database.SqlConnection);
                resultQuery = (int)cmd.ExecuteScalar();

                if (resultQuery >= 1)
                {
                    query = "SELECT MAX(id) from film_kategori";
                    cmd = new SqlCommand(query, Database.SqlConnection);
                    filmKategoriId = (int)cmd.ExecuteScalar();
                }

                query = "INSERT INTO film_kategori (id, film_id, kategori_id) VALUES(@id, @film_id, @kategori_id)";
                cmd = new SqlCommand(query, Database.SqlConnection);

                SqlParameter fkIdParameter = new SqlParameter("@id", System.Data.SqlDbType.Int);
                fkIdParameter.Value = filmKategoriId + 1;
                SqlParameter fkFilm_idParameter = new SqlParameter("@film_id", System.Data.SqlDbType.Int);
                fkFilm_idParameter.Value = newFilmId;
                SqlParameter fkKategori_idParameter = new SqlParameter("@kategori_id", System.Data.SqlDbType.Int);
                fkKategori_idParameter.Value = cb_filmKategori.SelectedValue;

                cmd.Parameters.Add(fkIdParameter);
                cmd.Parameters.Add(fkFilm_idParameter);
                cmd.Parameters.Add(fkKategori_idParameter);

                cmd.ExecuteNonQuery();

                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static DataTable filmler_listele()
        {
            DataTable dt = new DataTable();
            try
            {
                /*
                string query = "SELECT k.id AS 'Id', k.numara AS 'Koltuk Numara', s.numara AS 'Salon numara' " +
                    "FROM koltuklar k JOIN salonlar s ON k.salon_id = s.id";
                */
                //TODO: query
                string query = "SELECT f.id as 'Id', f.ad as 'Film adı', f.sure as 'Suresi', f.orijinal_dil as 'Dil',  FROM filmler f JOIN "; //control this query
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
