namespace SinemaOtomasyonu
{
    partial class Form_Salon
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
            this.lbl_salonNumara = new System.Windows.Forms.Label();
            this.gb_yeniSalon = new System.Windows.Forms.GroupBox();
            this.txt_salonNumara = new System.Windows.Forms.TextBox();
            this.btn_salon_ekle = new System.Windows.Forms.Button();
            this.grd_salonlar = new System.Windows.Forms.DataGridView();
            this.gb_yeniSalon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_salonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_salonNumara
            // 
            this.lbl_salonNumara.AutoSize = true;
            this.lbl_salonNumara.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_salonNumara.Location = new System.Drawing.Point(6, 25);
            this.lbl_salonNumara.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_salonNumara.Name = "lbl_salonNumara";
            this.lbl_salonNumara.Size = new System.Drawing.Size(79, 13);
            this.lbl_salonNumara.TabIndex = 0;
            this.lbl_salonNumara.Text = "Salon numarası";
            // 
            // gb_yeniSalon
            // 
            this.gb_yeniSalon.BackColor = System.Drawing.Color.White;
            this.gb_yeniSalon.Controls.Add(this.btn_salon_ekle);
            this.gb_yeniSalon.Controls.Add(this.txt_salonNumara);
            this.gb_yeniSalon.Controls.Add(this.lbl_salonNumara);
            this.gb_yeniSalon.Location = new System.Drawing.Point(12, 12);
            this.gb_yeniSalon.Name = "gb_yeniSalon";
            this.gb_yeniSalon.Size = new System.Drawing.Size(288, 59);
            this.gb_yeniSalon.TabIndex = 1;
            this.gb_yeniSalon.TabStop = false;
            this.gb_yeniSalon.Text = "Yeni Salon Ekle";
            // 
            // txt_salonNumara
            // 
            this.txt_salonNumara.Location = new System.Drawing.Point(93, 22);
            this.txt_salonNumara.Name = "txt_salonNumara";
            this.txt_salonNumara.Size = new System.Drawing.Size(100, 20);
            this.txt_salonNumara.TabIndex = 1;
            // 
            // btn_salon_ekle
            // 
            this.btn_salon_ekle.Location = new System.Drawing.Point(199, 20);
            this.btn_salon_ekle.Name = "btn_salon_ekle";
            this.btn_salon_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_salon_ekle.TabIndex = 2;
            this.btn_salon_ekle.Text = "Ekle";
            this.btn_salon_ekle.UseVisualStyleBackColor = true;
            this.btn_salon_ekle.Click += new System.EventHandler(this.btn_salon_ekle_Click);
            // 
            // grd_salonlar
            // 
            this.grd_salonlar.AllowUserToAddRows = false;
            this.grd_salonlar.AllowUserToDeleteRows = false;
            this.grd_salonlar.BackgroundColor = System.Drawing.Color.White;
            this.grd_salonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_salonlar.Location = new System.Drawing.Point(328, 12);
            this.grd_salonlar.Name = "grd_salonlar";
            this.grd_salonlar.ReadOnly = true;
            this.grd_salonlar.Size = new System.Drawing.Size(446, 305);
            this.grd_salonlar.TabIndex = 2;
            // 
            // Form_Salon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grd_salonlar);
            this.Controls.Add(this.gb_yeniSalon);
            this.Name = "Form_Salon";
            this.Text = "Form_Salon";
            this.Load += new System.EventHandler(this.Form_Salon_Load);
            this.gb_yeniSalon.ResumeLayout(false);
            this.gb_yeniSalon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_salonlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_salonNumara;
        private System.Windows.Forms.GroupBox gb_yeniSalon;
        private System.Windows.Forms.Button btn_salon_ekle;
        private System.Windows.Forms.TextBox txt_salonNumara;
        private System.Windows.Forms.DataGridView grd_salonlar;
    }
}