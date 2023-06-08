namespace SinemaOtomasyonu
{
    partial class Form_Film
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
            this.gb_film_ekle = new System.Windows.Forms.GroupBox();
            this.lbl_filmAd = new System.Windows.Forms.Label();
            this.lbl_filmSure = new System.Windows.Forms.Label();
            this.lbl_filmDili = new System.Windows.Forms.Label();
            this.lbl_filmKategori = new System.Windows.Forms.Label();
            this.txt_filmAd = new System.Windows.Forms.TextBox();
            this.txt_filmSure = new System.Windows.Forms.TextBox();
            this.txt_filmDili = new System.Windows.Forms.TextBox();
            this.btn_film_ekle = new System.Windows.Forms.Button();
            this.cb_filmKategori = new System.Windows.Forms.ComboBox();
            this.grd_filmler = new System.Windows.Forms.DataGridView();
            this.gb_film_ekle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_filmler)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_film_ekle
            // 
            this.gb_film_ekle.BackColor = System.Drawing.Color.White;
            this.gb_film_ekle.Controls.Add(this.cb_filmKategori);
            this.gb_film_ekle.Controls.Add(this.btn_film_ekle);
            this.gb_film_ekle.Controls.Add(this.txt_filmDili);
            this.gb_film_ekle.Controls.Add(this.txt_filmSure);
            this.gb_film_ekle.Controls.Add(this.txt_filmAd);
            this.gb_film_ekle.Controls.Add(this.lbl_filmKategori);
            this.gb_film_ekle.Controls.Add(this.lbl_filmDili);
            this.gb_film_ekle.Controls.Add(this.lbl_filmSure);
            this.gb_film_ekle.Controls.Add(this.lbl_filmAd);
            this.gb_film_ekle.Location = new System.Drawing.Point(13, 13);
            this.gb_film_ekle.Name = "gb_film_ekle";
            this.gb_film_ekle.Size = new System.Drawing.Size(322, 207);
            this.gb_film_ekle.TabIndex = 0;
            this.gb_film_ekle.TabStop = false;
            this.gb_film_ekle.Text = "Yeni film ekle";
            // 
            // lbl_filmAd
            // 
            this.lbl_filmAd.AutoSize = true;
            this.lbl_filmAd.BackColor = System.Drawing.Color.LightGray;
            this.lbl_filmAd.Location = new System.Drawing.Point(37, 35);
            this.lbl_filmAd.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_filmAd.Name = "lbl_filmAd";
            this.lbl_filmAd.Padding = new System.Windows.Forms.Padding(4);
            this.lbl_filmAd.Size = new System.Drawing.Size(51, 21);
            this.lbl_filmAd.TabIndex = 0;
            this.lbl_filmAd.Text = "Film Adı";
            // 
            // lbl_filmSure
            // 
            this.lbl_filmSure.AutoSize = true;
            this.lbl_filmSure.BackColor = System.Drawing.Color.LightGray;
            this.lbl_filmSure.Location = new System.Drawing.Point(44, 64);
            this.lbl_filmSure.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_filmSure.Name = "lbl_filmSure";
            this.lbl_filmSure.Padding = new System.Windows.Forms.Padding(4);
            this.lbl_filmSure.Size = new System.Drawing.Size(44, 21);
            this.lbl_filmSure.TabIndex = 0;
            this.lbl_filmSure.Text = "Süresi";
            // 
            // lbl_filmDili
            // 
            this.lbl_filmDili.AutoSize = true;
            this.lbl_filmDili.BackColor = System.Drawing.Color.LightGray;
            this.lbl_filmDili.Location = new System.Drawing.Point(27, 94);
            this.lbl_filmDili.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_filmDili.Name = "lbl_filmDili";
            this.lbl_filmDili.Padding = new System.Windows.Forms.Padding(4);
            this.lbl_filmDili.Size = new System.Drawing.Size(61, 21);
            this.lbl_filmDili.TabIndex = 0;
            this.lbl_filmDili.Text = "Orijinal dili";
            // 
            // lbl_filmKategori
            // 
            this.lbl_filmKategori.AutoSize = true;
            this.lbl_filmKategori.BackColor = System.Drawing.Color.LightGray;
            this.lbl_filmKategori.Location = new System.Drawing.Point(6, 122);
            this.lbl_filmKategori.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_filmKategori.Name = "lbl_filmKategori";
            this.lbl_filmKategori.Padding = new System.Windows.Forms.Padding(4);
            this.lbl_filmKategori.Size = new System.Drawing.Size(82, 21);
            this.lbl_filmKategori.TabIndex = 0;
            this.lbl_filmKategori.Text = "Film Kategorisi";
            // 
            // txt_filmAd
            // 
            this.txt_filmAd.Location = new System.Drawing.Point(111, 36);
            this.txt_filmAd.Name = "txt_filmAd";
            this.txt_filmAd.Size = new System.Drawing.Size(100, 20);
            this.txt_filmAd.TabIndex = 1;
            // 
            // txt_filmSure
            // 
            this.txt_filmSure.Location = new System.Drawing.Point(111, 65);
            this.txt_filmSure.Name = "txt_filmSure";
            this.txt_filmSure.Size = new System.Drawing.Size(100, 20);
            this.txt_filmSure.TabIndex = 1;
            // 
            // txt_filmDili
            // 
            this.txt_filmDili.Location = new System.Drawing.Point(111, 94);
            this.txt_filmDili.Name = "txt_filmDili";
            this.txt_filmDili.Size = new System.Drawing.Size(100, 20);
            this.txt_filmDili.TabIndex = 1;
            // 
            // btn_film_ekle
            // 
            this.btn_film_ekle.Location = new System.Drawing.Point(111, 166);
            this.btn_film_ekle.Name = "btn_film_ekle";
            this.btn_film_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_film_ekle.TabIndex = 2;
            this.btn_film_ekle.Text = "Ekle";
            this.btn_film_ekle.UseVisualStyleBackColor = true;
            this.btn_film_ekle.Click += new System.EventHandler(this.btn_film_ekle_Click);
            // 
            // cb_filmKategori
            // 
            this.cb_filmKategori.FormattingEnabled = true;
            this.cb_filmKategori.Location = new System.Drawing.Point(111, 121);
            this.cb_filmKategori.Name = "cb_filmKategori";
            this.cb_filmKategori.Size = new System.Drawing.Size(121, 21);
            this.cb_filmKategori.TabIndex = 3;
            // 
            // grd_filmler
            // 
            this.grd_filmler.AllowUserToAddRows = false;
            this.grd_filmler.AllowUserToDeleteRows = false;
            this.grd_filmler.BackgroundColor = System.Drawing.Color.White;
            this.grd_filmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_filmler.Location = new System.Drawing.Point(372, 13);
            this.grd_filmler.Name = "grd_filmler";
            this.grd_filmler.ReadOnly = true;
            this.grd_filmler.Size = new System.Drawing.Size(402, 406);
            this.grd_filmler.TabIndex = 1;
            // 
            // Form_Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grd_filmler);
            this.Controls.Add(this.gb_film_ekle);
            this.Name = "Form_Film";
            this.Text = "Form_Film";
            this.Load += new System.EventHandler(this.Form_Film_Load);
            this.gb_film_ekle.ResumeLayout(false);
            this.gb_film_ekle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_filmler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_film_ekle;
        private System.Windows.Forms.Label lbl_filmKategori;
        private System.Windows.Forms.Label lbl_filmDili;
        private System.Windows.Forms.Label lbl_filmSure;
        private System.Windows.Forms.Label lbl_filmAd;
        private System.Windows.Forms.Button btn_film_ekle;
        private System.Windows.Forms.TextBox txt_filmDili;
        private System.Windows.Forms.TextBox txt_filmSure;
        private System.Windows.Forms.TextBox txt_filmAd;
        private System.Windows.Forms.ComboBox cb_filmKategori;
        private System.Windows.Forms.DataGridView grd_filmler;
    }
}