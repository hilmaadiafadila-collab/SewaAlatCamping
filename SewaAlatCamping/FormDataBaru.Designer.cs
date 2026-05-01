namespace SewaAlatCamping
{
    partial class FormDataBaru
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnSimpan = new Button();
            btnBatal = new Button();
            txtIdBarang = new TextBox();
            txtNamaBarang = new TextBox();
            txtHargaHarian = new TextBox();
            txtHargaPaket = new TextBox();
            txtStok = new TextBox();
            txtLokasi = new TextBox();
            cbKategori = new ComboBox();
            cbStatus = new ComboBox();
            cbKondisi = new ComboBox();
            dtpTglMasuk = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 82);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Id Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 383);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Lokasi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 351);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 318);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 3;
            label4.Text = "Tanggal Masuk";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 290);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 4;
            label5.Text = "Kondisi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(104, 254);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 5;
            label6.Text = "Stok";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(104, 224);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 6;
            label7.Text = "Harga Paket";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(104, 184);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 7;
            label8.Text = "Harga Harian";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(104, 116);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 8;
            label9.Text = "Nama Barang";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(104, 150);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 9;
            label10.Text = "Kategori";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(192, 64, 0);
            label11.Location = new Point(252, 18);
            label11.Name = "label11";
            label11.Size = new Size(209, 32);
            label11.TabIndex = 10;
            label11.Text = "Entri Data Barang";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(618, 414);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 11;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(709, 415);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 12;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // txtIdBarang
            // 
            txtIdBarang.Location = new Point(252, 81);
            txtIdBarang.Name = "txtIdBarang";
            txtIdBarang.Size = new Size(322, 23);
            txtIdBarang.TabIndex = 13;
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.Location = new Point(252, 116);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(322, 23);
            txtNamaBarang.TabIndex = 14;
            // 
            // txtHargaHarian
            // 
            txtHargaHarian.Location = new Point(252, 183);
            txtHargaHarian.Name = "txtHargaHarian";
            txtHargaHarian.Size = new Size(322, 23);
            txtHargaHarian.TabIndex = 15;
            // 
            // txtHargaPaket
            // 
            txtHargaPaket.Location = new Point(252, 218);
            txtHargaPaket.Name = "txtHargaPaket";
            txtHargaPaket.Size = new Size(322, 23);
            txtHargaPaket.TabIndex = 16;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(252, 251);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(322, 23);
            txtStok.TabIndex = 17;
            // 
            // txtLokasi
            // 
            txtLokasi.Location = new Point(252, 380);
            txtLokasi.Name = "txtLokasi";
            txtLokasi.Size = new Size(322, 23);
            txtLokasi.TabIndex = 18;
            // 
            // cbKategori
            // 
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(252, 151);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(322, 23);
            cbKategori.TabIndex = 19;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(252, 348);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(322, 23);
            cbStatus.TabIndex = 20;
            // 
            // cbKondisi
            // 
            cbKondisi.FormattingEnabled = true;
            cbKondisi.Location = new Point(252, 283);
            cbKondisi.Name = "cbKondisi";
            cbKondisi.Size = new Size(322, 23);
            cbKondisi.TabIndex = 21;
            // 
            // dtpTglMasuk
            // 
            dtpTglMasuk.Location = new Point(252, 315);
            dtpTglMasuk.Name = "dtpTglMasuk";
            dtpTglMasuk.Size = new Size(322, 23);
            dtpTglMasuk.TabIndex = 22;
            // 
            // FormDataBaru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpTglMasuk);
            Controls.Add(cbKondisi);
            Controls.Add(cbStatus);
            Controls.Add(cbKategori);
            Controls.Add(txtLokasi);
            Controls.Add(txtStok);
            Controls.Add(txtHargaPaket);
            Controls.Add(txtHargaHarian);
            Controls.Add(txtNamaBarang);
            Controls.Add(txtIdBarang);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDataBaru";
            Text = "FormDataBaru";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnSimpan;
        private Button btnBatal;
        private TextBox txtIdBarang;
        private TextBox txtNamaBarang;
        private TextBox txtHargaHarian;
        private TextBox txtHargaPaket;
        private TextBox txtStok;
        private TextBox txtLokasi;
        private ComboBox cbKategori;
        private ComboBox cbStatus;
        private ComboBox cbKondisi;
        private DateTimePicker dtpTglMasuk;
    }
}