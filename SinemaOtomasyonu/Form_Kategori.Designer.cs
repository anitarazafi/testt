namespace SinemaOtomasyonu
{
    partial class Form_Kategori
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
            this.gb_kategori = new System.Windows.Forms.GroupBox();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.txt_kategoriAd = new System.Windows.Forms.TextBox();
            this.btn_kategori_ekle = new System.Windows.Forms.Button();
            this.grd_kategoriler = new System.Windows.Forms.DataGridView();
            this.gb_kategori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_kategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_kategori
            // 
            this.gb_kategori.BackColor = System.Drawing.Color.White;
            this.gb_kategori.Controls.Add(this.btn_kategori_ekle);
            this.gb_kategori.Controls.Add(this.txt_kategoriAd);
            this.gb_kategori.Controls.Add(this.lbl_kategori);
            this.gb_kategori.Location = new System.Drawing.Point(13, 13);
            this.gb_kategori.Name = "gb_kategori";
            this.gb_kategori.Size = new System.Drawing.Size(200, 100);
            this.gb_kategori.TabIndex = 0;
            this.gb_kategori.TabStop = false;
            this.gb_kategori.Text = "Kategori Ekle";
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_kategori.Location = new System.Drawing.Point(7, 29);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(63, 13);
            this.lbl_kategori.TabIndex = 0;
            this.lbl_kategori.Text = "Kategori adı";
            // 
            // txt_kategoriAd
            // 
            this.txt_kategoriAd.Location = new System.Drawing.Point(76, 26);
            this.txt_kategoriAd.Name = "txt_kategoriAd";
            this.txt_kategoriAd.Size = new System.Drawing.Size(100, 20);
            this.txt_kategoriAd.TabIndex = 1;
            // 
            // btn_kategori_ekle
            // 
            this.btn_kategori_ekle.Location = new System.Drawing.Point(6, 61);
            this.btn_kategori_ekle.Name = "btn_kategori_ekle";
            this.btn_kategori_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_kategori_ekle.TabIndex = 2;
            this.btn_kategori_ekle.Text = "Ekle";
            this.btn_kategori_ekle.UseVisualStyleBackColor = true;
            this.btn_kategori_ekle.Click += new System.EventHandler(this.btn_kategori_ekle_Click);
            // 
            // grd_kategoriler
            // 
            this.grd_kategoriler.AllowUserToAddRows = false;
            this.grd_kategoriler.AllowUserToDeleteRows = false;
            this.grd_kategoriler.BackgroundColor = System.Drawing.Color.White;
            this.grd_kategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_kategoriler.Location = new System.Drawing.Point(300, 13);
            this.grd_kategoriler.Name = "grd_kategoriler";
            this.grd_kategoriler.ReadOnly = true;
            this.grd_kategoriler.Size = new System.Drawing.Size(433, 347);
            this.grd_kategoriler.TabIndex = 1;
            // 
            // Form_Kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grd_kategoriler);
            this.Controls.Add(this.gb_kategori);
            this.Name = "Form_Kategori";
            this.Text = "Form_Kategori";
            this.Load += new System.EventHandler(this.Form_Kategori_Load);
            this.gb_kategori.ResumeLayout(false);
            this.gb_kategori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_kategoriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_kategori;
        private System.Windows.Forms.Button btn_kategori_ekle;
        private System.Windows.Forms.TextBox txt_kategoriAd;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.DataGridView grd_kategoriler;
    }
}