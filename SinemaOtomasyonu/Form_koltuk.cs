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
    public partial class Form_koltuk : Form
    {
        public Form_koltuk()
        {
            InitializeComponent();
        }

        private void Form_koltuk_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT id, numara FROM salonlar";
                SqlCommand cmd = new SqlCommand(query, Database.SqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "salonlar");
                cb_salonNumara.DisplayMember = "numara";
                cb_salonNumara.ValueMember = "id";
                cb_salonNumara.DataSource = ds.Tables["salonlar"];
            } catch(Exception ex)
            {
                throw ex;
            }

            try
            {
                DataTable koltuklar = koltuklar_listele();
                grd_koltuklar.DataSource = koltuklar;

            } catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_koltuk_ekle_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_koltukNumara.Text))
            {
                return;
            }

            bool result = koltuk_ekle();

            if (!result)
            {
                MessageBox.Show("Koltuk eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Koltuk başarıyla eklendi.", "Başarı", MessageBoxButtons.OK);
            }

            DataTable koltuklar = koltuklar_listele();
            grd_koltuklar.DataSource = koltuklar;
        }

        private bool koltuk_ekle()
        {
            bool result = false;

            try
            {
                int id = 0;

                string query = "SELECT COUNT(id) from koltuklar";
                SqlCommand cmd = new SqlCommand(query, Database.SqlConnection);
                int resultQuery = (int)cmd.ExecuteScalar();

                if (resultQuery >= 1)
                {
                    query = "SELECT MAX(id) from koltuklar";
                    cmd = new SqlCommand(query, Database.SqlConnection);
                    id = (int)cmd.ExecuteScalar();
                }

                query = "INSERT INTO koltuklar (id, numara, salon_id) VALUES(@id, @numara, @salon_id)";
                cmd = new SqlCommand(query, Database.SqlConnection);

                SqlParameter idParameter = new SqlParameter("@id", System.Data.SqlDbType.Int);
                idParameter.Value = id + 1;
                SqlParameter numaraParameter = new SqlParameter("@numara", System.Data.SqlDbType.VarChar);
                numaraParameter.Value = txt_koltukNumara.Text;
                SqlParameter salon_idParameter = new SqlParameter("@salon_id", System.Data.SqlDbType.Int);
                salon_idParameter.Value = (int)cb_salonNumara.SelectedValue;

                cmd.Parameters.Add(idParameter);
                cmd.Parameters.Add(numaraParameter);
                cmd.Parameters.Add(salon_idParameter);

                cmd.ExecuteNonQuery();

                result = true;

            } catch(Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static DataTable koltuklar_listele()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT k.id AS 'Id', k.numara AS 'Koltuk Numara', s.numara AS 'Salon numara' FROM koltuklar k JOIN salonlar s ON k.salon_id = s.id";
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
