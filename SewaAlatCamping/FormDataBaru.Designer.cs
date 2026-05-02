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
            txtMerk = new TextBox();
            cbKategori = new ComboBox();
            cbSatuan = new ComboBox();
            dtpTglMasuk = new DateTimePicker();
            numBerat = new NumericUpDown();
            numStok = new NumericUpDown();
            numHarga = new NumericUpDown();
            numDenda = new NumericUpDown();
            label12 = new Label();
            label13 = new Label();
            numDiskon = new NumericUpDown();
            chkPromo = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numBerat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiskon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 255, 192);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(104, 54);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 26;
            label1.Text = "Id Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 255, 192);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(104, 185);
            label2.Name = "label2";
            label2.Size = new Size(134, 19);
            label2.TabIndex = 25;
            label2.Text = "Berat Satuan (gram)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 255, 192);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(104, 251);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 24;
            label3.Text = "Satuan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 255, 192);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(104, 286);
            label4.Name = "label4";
            label4.Size = new Size(103, 19);
            label4.TabIndex = 23;
            label4.Text = "Tanggal Masuk";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(192, 255, 192);
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(101, 351);
            label5.Name = "label5";
            label5.Size = new Size(94, 19);
            label5.TabIndex = 22;
            label5.Text = "Denda Harian";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(192, 255, 192);
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(104, 218);
            label6.Name = "label6";
            label6.Size = new Size(37, 19);
            label6.TabIndex = 21;
            label6.Text = "Stok";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(192, 255, 192);
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(104, 121);
            label7.Name = "label7";
            label7.Size = new Size(88, 19);
            label7.TabIndex = 20;
            label7.Text = "Merk Barang";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(192, 255, 192);
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.Location = new Point(101, 319);
            label8.Name = "label8";
            label8.Size = new Size(91, 19);
            label8.TabIndex = 19;
            label8.Text = "Harga Harian";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(192, 255, 192);
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.Location = new Point(104, 87);
            label9.Name = "label9";
            label9.Size = new Size(93, 19);
            label9.TabIndex = 18;
            label9.Text = "Nama Barang";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(192, 255, 192);
            label10.Image = (Image)resources.GetObject("label10.Image");
            label10.Location = new Point(104, 153);
            label10.Name = "label10";
            label10.Size = new Size(62, 19);
            label10.TabIndex = 17;
            label10.Text = "Kategori";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(0, 64, 0);
            label11.Image = (Image)resources.GetObject("label11.Image");
            label11.Location = new Point(227, 9);
            label11.Name = "label11";
            label11.Size = new Size(243, 37);
            label11.TabIndex = 16;
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
            btnSimpan.Location = new Point(408, 456);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(80, 32);
            btnSimpan.TabIndex = 15;
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
            btnBatal.Location = new Point(494, 456);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(80, 32);
            btnBatal.TabIndex = 14;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // txtIdBarang
            // 
            txtIdBarang.BackColor = Color.FromArgb(192, 255, 192);
            txtIdBarang.BorderStyle = BorderStyle.None;
            txtIdBarang.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdBarang.Location = new Point(252, 54);
            txtIdBarang.Name = "txtIdBarang";
            txtIdBarang.Size = new Size(322, 20);
            txtIdBarang.TabIndex = 13;
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.BackColor = Color.FromArgb(192, 255, 192);
            txtNamaBarang.BorderStyle = BorderStyle.None;
            txtNamaBarang.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamaBarang.Location = new Point(252, 85);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(322, 20);
            txtNamaBarang.TabIndex = 12;
            // 
            // txtMerk
            // 
            txtMerk.BackColor = Color.FromArgb(192, 255, 192);
            txtMerk.BorderStyle = BorderStyle.None;
            txtMerk.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMerk.Location = new Point(252, 116);
            txtMerk.Name = "txtMerk";
            txtMerk.Size = new Size(322, 20);
            txtMerk.TabIndex = 11;
            // 
            // cbKategori
            // 
            cbKategori.BackColor = Color.FromArgb(192, 255, 192);
            cbKategori.FlatStyle = FlatStyle.Flat;
            cbKategori.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKategori.Location = new Point(252, 150);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(322, 25);
            cbKategori.TabIndex = 10;
            // 
            // cbSatuan
            // 
            cbSatuan.BackColor = Color.FromArgb(192, 255, 192);
            cbSatuan.FlatStyle = FlatStyle.Flat;
            cbSatuan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSatuan.Location = new Point(252, 248);
            cbSatuan.Name = "cbSatuan";
            cbSatuan.Size = new Size(322, 25);
            cbSatuan.TabIndex = 9;
            // 
            // dtpTglMasuk
            // 
            dtpTglMasuk.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTglMasuk.Location = new Point(252, 280);
            dtpTglMasuk.Name = "dtpTglMasuk";
            dtpTglMasuk.Size = new Size(322, 25);
            dtpTglMasuk.TabIndex = 8;
            // 
            // numBerat
            // 
            numBerat.BackColor = Color.FromArgb(192, 255, 192);
            numBerat.Location = new Point(252, 185);
            numBerat.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numBerat.Name = "numBerat";
            numBerat.Size = new Size(322, 23);
            numBerat.TabIndex = 7;
            // 
            // numStok
            // 
            numStok.BackColor = Color.FromArgb(192, 255, 192);
            numStok.Location = new Point(252, 218);
            numStok.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numStok.Name = "numStok";
            numStok.Size = new Size(322, 23);
            numStok.TabIndex = 6;
            // 
            // numHarga
            // 
            numHarga.BackColor = Color.FromArgb(192, 255, 192);
            numHarga.Location = new Point(252, 315);
            numHarga.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numHarga.Name = "numHarga";
            numHarga.Size = new Size(322, 23);
            numHarga.TabIndex = 5;
            numHarga.ThousandsSeparator = true;
            // 
            // numDenda
            // 
            numDenda.BackColor = Color.FromArgb(192, 255, 192);
            numDenda.Location = new Point(252, 347);
            numDenda.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numDenda.Name = "numDenda";
            numDenda.Size = new Size(322, 23);
            numDenda.TabIndex = 4;
            numDenda.ThousandsSeparator = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(192, 255, 192);
            label12.Image = (Image)resources.GetObject("label12.Image");
            label12.Location = new Point(101, 413);
            label12.Name = "label12";
            label12.Size = new Size(115, 19);
            label12.TabIndex = 3;
            label12.Text = "Besar Diskon (%)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(192, 255, 192);
            label13.Image = (Image)resources.GetObject("label13.Image");
            label13.Location = new Point(101, 382);
            label13.Name = "label13";
            label13.Size = new Size(80, 19);
            label13.TabIndex = 2;
            label13.Text = "Ada Diskon";
            // 
            // numDiskon
            // 
            numDiskon.BackColor = Color.FromArgb(192, 255, 192);
            numDiskon.Location = new Point(252, 409);
            numDiskon.Name = "numDiskon";
            numDiskon.Size = new Size(322, 23);
            numDiskon.TabIndex = 1;
            // 
            // chkPromo
            // 
            chkPromo.AutoSize = true;
            chkPromo.BackColor = Color.Transparent;
            chkPromo.Cursor = Cursors.Hand;
            chkPromo.Location = new Point(252, 382);
            chkPromo.Name = "chkPromo";
            chkPromo.Size = new Size(15, 14);
            chkPromo.TabIndex = 0;
            chkPromo.UseVisualStyleBackColor = false;
            chkPromo.CheckedChanged += chkPromo_CheckedChanged;
            // 
            // FormDataBaru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(700, 500);
            Controls.Add(chkPromo);
            Controls.Add(numDiskon);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(numDenda);
            Controls.Add(numHarga);
            Controls.Add(numStok);
            Controls.Add(numBerat);
            Controls.Add(dtpTglMasuk);
            Controls.Add(cbSatuan);
            Controls.Add(cbKategori);
            Controls.Add(txtMerk);
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
            ((System.ComponentModel.ISupportInitialize)numBerat).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHarga).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiskon).EndInit();
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
        private TextBox txtMerk;
        private ComboBox cbKategori;
        private ComboBox cbSatuan;
        private DateTimePicker dtpTglMasuk;
        private NumericUpDown numBerat;
        private NumericUpDown numStok;
        private NumericUpDown numHarga;
        private NumericUpDown numDenda;
        private Label label12;
        private Label label13;
        private NumericUpDown numDiskon;
        private CheckBox chkPromo;
    }
}