namespace SinemaOtomasyonu
{
    partial class Form_Seans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_seans_ekle = new System.Windows.Forms.GroupBox();
            this.lbl_filmAd = new System.Windows.Forms.Label();
            this.lbl_salon = new System.Windows.Forms.Label();
            this.lbl_dil = new System.Windows.Forms.Label();
            this.lbl_altyazi = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.cb_filmAd = new System.Windows.Forms.ComboBox();
            this.cb_salonNo = new System.Windows.Forms.ComboBox();
            this.txt_filmDil = new System.Windows.Forms.TextBox();
            this.txt_altyaziDil = new System.Windows.Forms.TextBox();
            this.txt_tarih = new System.Windows.Forms.TextBox();
            this.txt_saat = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.grd_seanslar = new System.Windows.Forms.DataGridView();
            this.gb_seans_ekle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_seanslar)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_seans_ekle
            // 
            this.gb_seans_ekle.BackColor = System.Drawing.Color.White;
            this.gb_seans_ekle.Controls.Add(this.btn_ekle);
            this.gb_seans_ekle.Controls.Add(this.txt_saat);
            this.gb_seans_ekle.Controls.Add(this.txt_tarih);
            this.gb_seans_ekle.Controls.Add(this.txt_altyaziDil);
            this.gb_seans_ekle.Controls.Add(this.txt_filmDil);
            this.gb_seans_ekle.Controls.Add(this.cb_salonNo);
            this.gb_seans_ekle.Controls.Add(this.cb_filmAd);
            this.gb_seans_ekle.Controls.Add(this.lbl_saat);
            this.gb_seans_ekle.Controls.Add(this.lbl_tarih);
            this.gb_seans_ekle.Controls.Add(this.lbl_altyazi);
            this.gb_seans_ekle.Controls.Add(this.lbl_dil);
            this.gb_seans_ekle.Controls.Add(this.lbl_salon);
            this.gb_seans_ekle.Controls.Add(this.lbl_filmAd);
            this.gb_seans_ekle.Location = new System.Drawing.Point(13, 13);
            this.gb_seans_ekle.Name = "gb_seans_ekle";
            this.gb_seans_ekle.Size = new System.Drawing.Size(319, 383);
            this.gb_seans_ekle.TabIndex = 0;
            this.gb_seans_ekle.TabStop = false;
            this.gb_seans_ekle.Text = "Yeni seans ekle";
            // 
            // lbl_filmAd
            // 
            this.lbl_filmAd.AutoSize = true;
            this.lbl_filmAd.BackColor = System.Drawing.Color.LightGray;
            this.lbl_filmAd.Location = new System.Drawing.Point(56, 49);
            this.lbl_filmAd.Name = "lbl_filmAd";
            this.lbl_filmAd.Size = new System.Drawing.Size(42, 13);
            this.lbl_filmAd.TabIndex = 0;
            this.lbl_filmAd.Text = "Film adı";
            // 
            // lbl_salon
            // 
            this.lbl_salon.AutoSize = true;
            this.lbl_salon.BackColor = System.Drawing.Color.LightGray;
            this.lbl_salon.Location = new System.Drawing.Point(49, 85);
            this.lbl_salon.Name = "lbl_salon";
            this.lbl_salon.Size = new System.Drawing.Size(49, 13);
            this.lbl_salon.TabIndex = 1;
            this.lbl_salon.Text = "Salon no";
            // 
            // lbl_dil
            // 
            this.lbl_dil.AutoSize = true;
            this.lbl_dil.BackColor = System.Drawing.Color.LightGray;
            this.lbl_dil.Location = new System.Drawing.Point(79, 117);
            this.lbl_dil.Name = "lbl_dil";
            this.lbl_dil.Size = new System.Drawing.Size(19, 13);
            this.lbl_dil.TabIndex = 2;
            this.lbl_dil.Text = "Dil";
            // 
            // lbl_altyazi
            // 
            this.lbl_altyazi.AutoSize = true;
            this.lbl_altyazi.BackColor = System.Drawing.Color.LightGray;
            this.lbl_altyazi.Location = new System.Drawing.Point(46, 152);
            this.lbl_altyazi.Name = "lbl_altyazi";
            this.lbl_altyazi.Size = new System.Drawing.Size(52, 13);
            this.lbl_altyazi.TabIndex = 3;
            this.lbl_altyazi.Text = "Altyazı dili";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.BackColor = System.Drawing.Color.LightGray;
            this.lbl_tarih.Location = new System.Drawing.Point(67, 185);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(31, 13);
            this.lbl_tarih.TabIndex = 4;
            this.lbl_tarih.Text = "Tarih";
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.BackColor = System.Drawing.Color.LightGray;
            this.lbl_saat.Location = new System.Drawing.Point(69, 221);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(29, 13);
            this.lbl_saat.TabIndex = 5;
            this.lbl_saat.Text = "Saat";
            // 
            // cb_filmAd
            // 
            this.cb_filmAd.FormattingEnabled = true;
            this.cb_filmAd.Location = new System.Drawing.Point(116, 41);
            this.cb_filmAd.Name = "cb_filmAd";
            this.cb_filmAd.Size = new System.Drawing.Size(197, 21);
            this.cb_filmAd.TabIndex = 6;
            // 
            // cb_salonNo
            // 
            this.cb_salonNo.FormattingEnabled = true;
            this.cb_salonNo.Location = new System.Drawing.Point(116, 77);
            this.cb_salonNo.Name = "cb_salonNo";
            this.cb_salonNo.Size = new System.Drawing.Size(197, 21);
            this.cb_salonNo.TabIndex = 7;
            // 
            // txt_filmDil
            // 
            this.txt_filmDil.Location = new System.Drawing.Point(116, 110);
            this.txt_filmDil.Name = "txt_filmDil";
            this.txt_filmDil.Size = new System.Drawing.Size(100, 20);
            this.txt_filmDil.TabIndex = 8;
            // 
            // txt_altyaziDil
            // 
            this.txt_altyaziDil.Location = new System.Drawing.Point(116, 144);
            this.txt_altyaziDil.Name = "txt_altyaziDil";
            this.txt_altyaziDil.Size = new System.Drawing.Size(100, 20);
            this.txt_altyaziDil.TabIndex = 9;
            // 
            // txt_tarih
            // 
            this.txt_tarih.Location = new System.Drawing.Point(116, 178);
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Size = new System.Drawing.Size(100, 20);
            this.txt_tarih.TabIndex = 10;
            // 
            // txt_saat
            // 
            this.txt_saat.Location = new System.Drawing.Point(116, 213);
            this.txt_saat.Name = "txt_saat";
            this.txt_saat.Size = new System.Drawing.Size(100, 20);
            this.txt_saat.TabIndex = 11;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(116, 275);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 12;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // grd_seanslar
            // 
            this.grd_seanslar.AllowUserToAddRows = false;
            this.grd_seanslar.AllowUserToDeleteRows = false;
            this.grd_seanslar.BackgroundColor = System.Drawing.Color.White;
            this.grd_seanslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_seanslar.Location = new System.Drawing.Point(362, 13);
            this.grd_seanslar.Name = "grd_seanslar";
            this.grd_seanslar.ReadOnly = true;
            this.grd_seanslar.Size = new System.Drawing.Size(362, 383);
            this.grd_seanslar.TabIndex = 1;
            // 
            // Form_Seans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grd_seanslar);
            this.Controls.Add(this.gb_seans_ekle);
            this.Name = "Form_Seans";
            this.Text = "Form_Seans";
            this.Load += new System.EventHandler(this.Form_Seans_Load);
            this.gb_seans_ekle.ResumeLayout(false);
            this.gb_seans_ekle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_seanslar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_seans_ekle;
        private System.Windows.Forms.Label lbl_filmAd;
        private System.Windows.Forms.Label lbl_salon;
        private System.Windows.Forms.ComboBox cb_filmAd;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Label lbl_altyazi;
        private System.Windows.Forms.Label lbl_dil;
        private System.Windows.Forms.TextBox txt_saat;
        private System.Windows.Forms.TextBox txt_tarih;
        private System.Windows.Forms.TextBox txt_altyaziDil;
        private System.Windows.Forms.TextBox txt_filmDil;
        private System.Windows.Forms.ComboBox cb_salonNo;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView grd_seanslar;
    }
}