namespace SinemaOtomasyonu
{
    partial class AnaPencere
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
            this.gb_veriler = new System.Windows.Forms.GroupBox();
            this.btn_koltuklar = new System.Windows.Forms.Button();
            this.btn_salonlar = new System.Windows.Forms.Button();
            this.btn_kategori = new System.Windows.Forms.Button();
            this.btn_filmler = new System.Windows.Forms.Button();
            this.btn_seanslar = new System.Windows.Forms.Button();
            this.gb_veriler.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_veriler
            // 
            this.gb_veriler.BackColor = System.Drawing.Color.White;
            this.gb_veriler.Controls.Add(this.btn_seanslar);
            this.gb_veriler.Controls.Add(this.btn_filmler);
            this.gb_veriler.Controls.Add(this.btn_kategori);
            this.gb_veriler.Controls.Add(this.btn_koltuklar);
            this.gb_veriler.Controls.Add(this.btn_salonlar);
            this.gb_veriler.Location = new System.Drawing.Point(40, 43);
            this.gb_veriler.Name = "gb_veriler";
            this.gb_veriler.Size = new System.Drawing.Size(200, 335);
            this.gb_veriler.TabIndex = 0;
            this.gb_veriler.TabStop = false;
            this.gb_veriler.Text = "Veriler";
            // 
            // btn_koltuklar
            // 
            this.btn_koltuklar.Location = new System.Drawing.Point(6, 47);
            this.btn_koltuklar.Name = "btn_koltuklar";
            this.btn_koltuklar.Size = new System.Drawing.Size(75, 23);
            this.btn_koltuklar.TabIndex = 1;
            this.btn_koltuklar.Text = "Koltuklar";
            this.btn_koltuklar.UseVisualStyleBackColor = true;
            this.btn_koltuklar.Click += new System.EventHandler(this.btn_koltuklar_Click);
            // 
            // btn_salonlar
            // 
            this.btn_salonlar.Location = new System.Drawing.Point(6, 19);
            this.btn_salonlar.Name = "btn_salonlar";
            this.btn_salonlar.Size = new System.Drawing.Size(75, 23);
            this.btn_salonlar.TabIndex = 0;
            this.btn_salonlar.Text = "Salonlar";
            this.btn_salonlar.UseVisualStyleBackColor = true;
            this.btn_salonlar.Click += new System.EventHandler(this.btn_salonlar_Click);
            // 
            // btn_kategori
            // 
            this.btn_kategori.Location = new System.Drawing.Point(7, 77);
            this.btn_kategori.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kategori.Name = "btn_kategori";
            this.btn_kategori.Size = new System.Drawing.Size(75, 23);
            this.btn_kategori.TabIndex = 2;
            this.btn_kategori.Text = "Film Kategori";
            this.btn_kategori.UseVisualStyleBackColor = true;
            this.btn_kategori.Click += new System.EventHandler(this.btn_kategori_Click);
            // 
            // btn_filmler
            // 
            this.btn_filmler.Location = new System.Drawing.Point(7, 108);
            this.btn_filmler.Name = "btn_filmler";
            this.btn_filmler.Size = new System.Drawing.Size(75, 23);
            this.btn_filmler.TabIndex = 3;
            this.btn_filmler.Text = "Filmler";
            this.btn_filmler.UseVisualStyleBackColor = true;
            this.btn_filmler.Click += new System.EventHandler(this.btn_filmler_Click);
            // 
            // btn_seanslar
            // 
            this.btn_seanslar.Location = new System.Drawing.Point(7, 138);
            this.btn_seanslar.Name = "btn_seanslar";
            this.btn_seanslar.Size = new System.Drawing.Size(75, 23);
            this.btn_seanslar.TabIndex = 4;
            this.btn_seanslar.Text = "Seanslar";
            this.btn_seanslar.UseVisualStyleBackColor = true;
            this.btn_seanslar.Click += new System.EventHandler(this.btn_seanslar_Click);
            // 
            // AnaPencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_veriler);
            this.Name = "AnaPencere";
            this.Text = "Ana Pencere";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaPencere_FormClosing);
            this.Load += new System.EventHandler(this.AnaPencere_Load);
            this.gb_veriler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_veriler;
        private System.Windows.Forms.Button btn_salonlar;
        private System.Windows.Forms.Button btn_koltuklar;
        private System.Windows.Forms.Button btn_kategori;
        private System.Windows.Forms.Button btn_filmler;
        private System.Windows.Forms.Button btn_seanslar;
    }
}

