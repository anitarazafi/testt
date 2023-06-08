using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class AnaPencere : Form
    {
        public AnaPencere()
        {
            InitializeComponent();
        }

        private void AnaPencere_Load(object sender, EventArgs e)
        {
            bool result = Database.connect();

            if (!result)
            {
                MessageBox.Show("Bağlantı hatası!", "ex", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnaPencere_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database.disconnect();
        }

        private void btn_salonlar_Click(object sender, EventArgs e)
        {
            Form_Salon form_Salon = new Form_Salon();
            form_Salon.ShowDialog();
        }

        private void btn_koltuklar_Click(object sender, EventArgs e)
        {
            Form_koltuk form_koltuk = new Form_koltuk();
            form_koltuk.ShowDialog();
        }

        private void btn_kategori_Click(object sender, EventArgs e)
        {
            Form_Kategori form_Kategori = new Form_Kategori();
            form_Kategori.ShowDialog();
        }

        private void btn_filmler_Click(object sender, EventArgs e)
        {
            Form_Film form_film = new Form_Film();
            form_film.ShowDialog();
        }

        private void btn_seanslar_Click(object sender, EventArgs e)
        {

        }
    }
}
