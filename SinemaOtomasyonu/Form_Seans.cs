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
    public partial class Form_Seans : Form
    {
        public Form_Seans()
        {
            InitializeComponent();
        }

        private void Form_Seans_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT id, ad FROM filmler";
                SqlCommand cmd = new SqlCommand(query, Database.SqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "filmler");
                cb_filmAd.DisplayMember = "ad";
                cb_filmAd.ValueMember = "id";
                cb_filmAd.DataSource = ds.Tables["filmler"];
            }
            catch (Exception ex)
            {
                throw ex;
            }

            try
            {
                string query = "SELECT id, numara FROM salonlar";
                SqlCommand cmd = new SqlCommand(query, Database.SqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "salonlar");
                cb_salonNo.DisplayMember = "numara";
                cb_salonNo.ValueMember = "id";
                cb_salonNo.DataSource = ds.Tables["salonlar"];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_filmDil.Text) || string.IsNullOrEmpty(txt_altyaziDil.Text) || 
                string.IsNullOrEmpty(txt_saat.Text) || string.IsNullOrEmpty(txt_tarih.Text))
            {
                return;
            }

            bool result = seans_ekle();

            if (!result)
            {
                MessageBox.Show("Seans eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Seans başarıyla eklendi.", "Başarı", MessageBoxButtons.OK);
            }
        }

        private bool seans_ekle()
        {
            bool result = false;

            try
            {
                int seansId = 0;

                string query = "SELECT COUNT(id) from seanslar";
                SqlCommand cmd = new SqlCommand(query, Database.SqlConnection);
                int resultQuery = (int)cmd.ExecuteScalar();

                if (resultQuery >= 1)
                {
                    query = "SELECT MAX(id) from seanslar";
                    cmd = new SqlCommand(query, Database.SqlConnection);
                    seansId = (int)cmd.ExecuteScalar();
                }

                int newSeansId = seansId + 1;

                query = "INSERT INTO seanslar (id, film_id, salon_id, dili, altyazi_dili, tarih, saat) VALUES(@id, @film_id, @salon_id, @dili, @altyazi_dili, @tarih, @saat)";
                cmd = new SqlCommand(query, Database.SqlConnection);

                SqlParameter idParameter = new SqlParameter("@id", System.Data.SqlDbType.Int);
                idParameter.Value = newSeansId;
                SqlParameter film_idParameter = new SqlParameter("@film_id", System.Data.SqlDbType.Int);
                film_idParameter.Value = cb_filmAd.SelectedValue;
                SqlParameter salon_idParameter = new SqlParameter("@salon_id", System.Data.SqlDbType.Int);
                salon_idParameter.Value = cb_salonNo.SelectedValue;
                SqlParameter diliParameter = new SqlParameter("@dili", System.Data.SqlDbType.VarChar);
                diliParameter.Value = txt_filmDil.Text;
                SqlParameter altyazi_diliParameter = new SqlParameter("@altyazi_dili", System.Data.SqlDbType.VarChar);
                altyazi_diliParameter.Value = txt_altyaziDil;
                SqlParameter tarihParameter = new SqlParameter("@tarih", System.Data.SqlDbType.VarChar); //change to date
                tarihParameter.Value = txt_tarih.Text;
                SqlParameter saatParameter = new SqlParameter("@saat", System.Data.SqlDbType.VarChar); // change to time
                saatParameter.Value = txt_saat.Text;

                cmd.Parameters.Add(idParameter);
                cmd.Parameters.Add(film_idParameter);
                cmd.Parameters.Add(salon_idParameter);
                cmd.Parameters.Add(diliParameter);
                cmd.Parameters.Add(altyazi_diliParameter);
                cmd.Parameters.Add(tarihParameter);
                cmd.Parameters.Add(saatParameter);

                cmd.ExecuteNonQuery();

                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static DataTable seanslar_listele()
        { 
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT k.id AS 'Id', k.numara AS 'Koltuk Numara', s.numara AS 'Salon numara' FROM koltuklar k JOIN salonlar s ON k.salon_id = s.id";
                //string query = ""
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
