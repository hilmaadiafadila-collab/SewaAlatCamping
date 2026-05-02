namespace SewaAlatCamping
{
    partial class FormDataBaru
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataBaru));
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
            txtMerk = new TextBox();
            txtStok = new TextBox();
            txtBerat = new TextBox();
            cbKategori = new ComboBox();
            cbSatuan = new ComboBox();
            dtpTglMasuk = new DateTimePicker();
            txtDendaHarian = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(104, 82);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 22;
            label1.Text = "Id Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(104, 216);
            label2.Name = "label2";
            label2.Size = new Size(134, 19);
            label2.TabIndex = 21;
            label2.Text = "Berat Satuan (gram)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 255, 192);
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(104, 284);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 20;
            label3.Text = "Satuan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 255, 192);
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(104, 318);
            label4.Name = "label4";
            label4.Size = new Size(103, 19);
            label4.TabIndex = 19;
            label4.Text = "Tanggal Masuk";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 255, 192);
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(104, 386);
            label5.Name = "label5";
            label5.Size = new Size(94, 19);
            label5.TabIndex = 18;
            label5.Text = "Denda Harian";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 255, 192);
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(104, 245);
            label6.Name = "label6";
            label6.Size = new Size(37, 19);
            label6.TabIndex = 17;
            label6.Text = "Stok";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 255, 192);
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(104, 151);
            label7.Name = "label7";
            label7.Size = new Size(88, 19);
            label7.TabIndex = 16;
            label7.Text = "Merk Barang";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(192, 255, 192);
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(104, 351);
            label8.Name = "label8";
            label8.Size = new Size(91, 19);
            label8.TabIndex = 15;
            label8.Text = "Harga Harian";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(192, 255, 192);
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(104, 116);
            label9.Name = "label9";
            label9.Size = new Size(93, 19);
            label9.TabIndex = 14;
            label9.Text = "Nama Barang";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(192, 255, 192);
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(104, 185);
            label10.Name = "label10";
            label10.Size = new Size(62, 19);
            label10.TabIndex = 13;
            label10.Text = "Kategori";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(0, 64, 0);
            label11.Image = (Image)resources.GetObject("label11.Image");
            label11.Location = new Point(222, 20);
            label11.Name = "label11";
            label11.Size = new Size(243, 37);
            label11.TabIndex = 12;
            label11.Text = "Entri Data Barang";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.SeaGreen;
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(408, 430);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(80, 32);
            btnSimpan.TabIndex = 11;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.LightPink;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatAppearance.BorderSize = 0;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBatal.ForeColor = Color.DarkRed;
            btnBatal.Location = new Point(494, 430);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(80, 32);
            btnBatal.TabIndex = 10;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // txtIdBarang
            // 
            txtIdBarang.BackColor = Color.FromArgb(192, 255, 192);
            txtIdBarang.BorderStyle = BorderStyle.FixedSingle;
            txtIdBarang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdBarang.ForeColor = SystemColors.WindowText;
            txtIdBarang.Location = new Point(252, 81);
            txtIdBarang.Name = "txtIdBarang";
            txtIdBarang.Size = new Size(322, 25);
            txtIdBarang.TabIndex = 9;
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.BackColor = Color.FromArgb(192, 255, 192);
            txtNamaBarang.BorderStyle = BorderStyle.FixedSingle;
            txtNamaBarang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamaBarang.Location = new Point(252, 115);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(322, 25);
            txtNamaBarang.TabIndex = 8;
            // 
            // txtHargaHarian
            // 
            txtHargaHarian.BackColor = Color.FromArgb(192, 255, 192);
            txtHargaHarian.BorderStyle = BorderStyle.FixedSingle;
            txtHargaHarian.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHargaHarian.Location = new Point(252, 349);
            txtHargaHarian.Name = "txtHargaHarian";
            txtHargaHarian.Size = new Size(322, 25);
            txtHargaHarian.TabIndex = 7;
            // 
            // txtMerk
            // 
            txtMerk.BackColor = Color.FromArgb(192, 255, 192);
            txtMerk.BorderStyle = BorderStyle.FixedSingle;
            txtMerk.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMerk.Location = new Point(252, 150);
            txtMerk.Name = "txtMerk";
            txtMerk.Size = new Size(322, 25);
            txtMerk.TabIndex = 6;
            // 
            // txtStok
            // 
            txtStok.BackColor = Color.FromArgb(192, 255, 192);
            txtStok.BorderStyle = BorderStyle.FixedSingle;
            txtStok.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStok.Location = new Point(252, 243);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(322, 25);
            txtStok.TabIndex = 5;
            // 
            // txtBerat
            // 
            txtBerat.BackColor = Color.FromArgb(192, 255, 192);
            txtBerat.BorderStyle = BorderStyle.FixedSingle;
            txtBerat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBerat.Location = new Point(252, 214);
            txtBerat.Name = "txtBerat";
            txtBerat.Size = new Size(322, 25);
            txtBerat.TabIndex = 4;
            // 
            // cbKategori
            // 
            cbKategori.BackColor = Color.FromArgb(192, 255, 192);
            cbKategori.FlatStyle = FlatStyle.Flat;
            cbKategori.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKategori.Location = new Point(252, 184);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(322, 25);
            cbKategori.TabIndex = 3;
            // 
            // cbSatuan
            // 
            cbSatuan.BackColor = Color.FromArgb(192, 255, 192);
            cbSatuan.FlatStyle = FlatStyle.Flat;
            cbSatuan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSatuan.ForeColor = SystemColors.WindowText;
            cbSatuan.Location = new Point(252, 281);
            cbSatuan.Name = "cbSatuan";
            cbSatuan.Size = new Size(322, 25);
            cbSatuan.TabIndex = 2;
            // 
            // dtpTglMasuk
            // 
            dtpTglMasuk.CalendarForeColor = Color.Black;
            dtpTglMasuk.CalendarMonthBackground = Color.FromArgb(192, 255, 192);
            dtpTglMasuk.CalendarTitleBackColor = Color.FromArgb(192, 255, 192);
            dtpTglMasuk.CalendarTitleForeColor = Color.Black;
            dtpTglMasuk.CalendarTrailingForeColor = Color.Black;
            dtpTglMasuk.Cursor = Cursors.IBeam;
            dtpTglMasuk.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTglMasuk.Location = new Point(252, 315);
            dtpTglMasuk.Name = "dtpTglMasuk";
            dtpTglMasuk.Size = new Size(322, 25);
            dtpTglMasuk.TabIndex = 1;
            // 
            // txtDendaHarian
            // 
            txtDendaHarian.BackColor = Color.FromArgb(192, 255, 192);
            txtDendaHarian.BorderStyle = BorderStyle.FixedSingle;
            txtDendaHarian.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDendaHarian.Location = new Point(252, 385);
            txtDendaHarian.Name = "txtDendaHarian";
            txtDendaHarian.Size = new Size(322, 25);
            txtDendaHarian.TabIndex = 0;
            // 
            // FormDataBaru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(700, 500);
            Controls.Add(txtDendaHarian);
            Controls.Add(dtpTglMasuk);
            Controls.Add(cbSatuan);
            Controls.Add(cbKategori);
            Controls.Add(txtBerat);
            Controls.Add(txtStok);
            Controls.Add(txtMerk);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entri Data Barang";
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
        private TextBox txtMerk;
        private TextBox txtStok;
        private TextBox txtBerat;
        private ComboBox cbKategori;
        private ComboBox cbSatuan;
        private DateTimePicker dtpTglMasuk;
        private TextBox txtDendaHarian;
    }
}