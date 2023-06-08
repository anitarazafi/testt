namespace SinemaOtomasyonu
{
    partial class Form_koltuk
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
            this.lbl_koltukNumara = new System.Windows.Forms.Label();
            this.txt_koltukNumara = new System.Windows.Forms.TextBox();
            this.btn_koltuk_ekle = new System.Windows.Forms.Button();
            this.gb_koltuk_ekle = new System.Windows.Forms.GroupBox();
            this.cb_salonNumara = new System.Windows.Forms.ComboBox();
            this.grd_koltuklar = new System.Windows.Forms.DataGridView();
            this.gb_koltuk_ekle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_koltuklar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_salonNumara
            // 
            this.lbl_salonNumara.AutoSize = true;
            this.lbl_salonNumara.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_salonNumara.Location = new System.Drawing.Point(26, 24);
            this.lbl_salonNumara.Name = "lbl_salonNumara";
            this.lbl_salonNumara.Size = new System.Drawing.Size(90, 16);
            this.lbl_salonNumara.TabIndex = 0;
            this.lbl_salonNumara.Text = "Salon numara";
            // 
            // lbl_koltukNumara
            // 
            this.lbl_koltukNumara.AutoSize = true;
            this.lbl_koltukNumara.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_koltukNumara.Location = new System.Drawing.Point(25, 64);
            this.lbl_koltukNumara.Name = "lbl_koltukNumara";
            this.lbl_koltukNumara.Size = new System.Drawing.Size(91, 16);
            this.lbl_koltukNumara.TabIndex = 1;
            this.lbl_koltukNumara.Text = "Koltuk numara";
            // 
            // txt_koltukNumara
            // 
            this.txt_koltukNumara.Location = new System.Drawing.Point(122, 61);
            this.txt_koltukNumara.Name = "txt_koltukNumara";
            this.txt_koltukNumara.Size = new System.Drawing.Size(100, 22);
            this.txt_koltukNumara.TabIndex = 3;
            // 
            // btn_koltuk_ekle
            // 
            this.btn_koltuk_ekle.Location = new System.Drawing.Point(28, 103);
            this.btn_koltuk_ekle.Name = "btn_koltuk_ekle";
            this.btn_koltuk_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_koltuk_ekle.TabIndex = 4;
            this.btn_koltuk_ekle.Text = "Ekle";
            this.btn_koltuk_ekle.UseVisualStyleBackColor = true;
            this.btn_koltuk_ekle.Click += new System.EventHandler(this.btn_koltuk_ekle_Click);
            // 
            // gb_koltuk_ekle
            // 
            this.gb_koltuk_ekle.Controls.Add(this.cb_salonNumara);
            this.gb_koltuk_ekle.Controls.Add(this.btn_koltuk_ekle);
            this.gb_koltuk_ekle.Controls.Add(this.lbl_salonNumara);
            this.gb_koltuk_ekle.Controls.Add(this.txt_koltukNumara);
            this.gb_koltuk_ekle.Controls.Add(this.lbl_koltukNumara);
            this.gb_koltuk_ekle.Location = new System.Drawing.Point(12, 12);
            this.gb_koltuk_ekle.Name = "gb_koltuk_ekle";
            this.gb_koltuk_ekle.Size = new System.Drawing.Size(251, 150);
            this.gb_koltuk_ekle.TabIndex = 5;
            this.gb_koltuk_ekle.TabStop = false;
            this.gb_koltuk_ekle.Text = "Koltuk Ekle";
            // 
            // cb_salonNumara
            // 
            this.cb_salonNumara.FormattingEnabled = true;
            this.cb_salonNumara.Location = new System.Drawing.Point(123, 22);
            this.cb_salonNumara.Name = "cb_salonNumara";
            this.cb_salonNumara.Size = new System.Drawing.Size(121, 24);
            this.cb_salonNumara.TabIndex = 5;
            // 
            // grd_koltuklar
            // 
            this.grd_koltuklar.AllowUserToAddRows = false;
            this.grd_koltuklar.AllowUserToDeleteRows = false;
            this.grd_koltuklar.BackgroundColor = System.Drawing.Color.White;
            this.grd_koltuklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_koltuklar.Location = new System.Drawing.Point(296, 12);
            this.grd_koltuklar.Name = "grd_koltuklar";
            this.grd_koltuklar.ReadOnly = true;
            this.grd_koltuklar.RowHeadersWidth = 51;
            this.grd_koltuklar.RowTemplate.Height = 24;
            this.grd_koltuklar.Size = new System.Drawing.Size(450, 341);
            this.grd_koltuklar.TabIndex = 6;
            // 
            // Form_koltuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grd_koltuklar);
            this.Controls.Add(this.gb_koltuk_ekle);
            this.Name = "Form_koltuk";
            this.Text = "Form_koltuk";
            this.Load += new System.EventHandler(this.Form_koltuk_Load);
            this.gb_koltuk_ekle.ResumeLayout(false);
            this.gb_koltuk_ekle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_koltuklar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_salonNumara;
        private System.Windows.Forms.Label lbl_koltukNumara;
        private System.Windows.Forms.TextBox txt_koltukNumara;
        private System.Windows.Forms.Button btn_koltuk_ekle;
        private System.Windows.Forms.GroupBox gb_koltuk_ekle;
        private System.Windows.Forms.ComboBox cb_salonNumara;
        private System.Windows.Forms.DataGridView grd_koltuklar;
    }
}