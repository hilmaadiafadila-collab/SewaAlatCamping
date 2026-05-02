namespace SewaAlatCamping
{
    partial class FormInput
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInput));
            lblJudul = new Label();
            lblIdTransaksi = new Label();
            lblNamaPenyewa = new Label();
            lblIdBarang = new Label();
            lblJumlah = new Label();
            lblTglSewa = new Label();
            lblTglKembali = new Label();
            lblTotal = new Label();
            txtIdTransaksi = new TextBox();
            textNamaPenyewa = new TextBox();
            cbBarangId = new ComboBox();
            numJumlah = new NumericUpDown();
            dtpTglSewa = new DateTimePicker();
            dtpTglKembali = new DateTimePicker();
            txtTotal = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            ((System.ComponentModel.ISupportInitialize)numJumlah).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.Transparent;
            lblJudul.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblJudul.ForeColor = Color.FromArgb(0, 64, 0);
            lblJudul.Image = (Image)resources.GetObject("lblJudul.Image");
            lblJudul.Location = new Point(240, 20);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(285, 37);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Form Input Transaksi";
            // 
            // lblIdTransaksi
            // 
            lblIdTransaksi.AutoSize = true;
            lblIdTransaksi.BackColor = Color.Transparent;
            lblIdTransaksi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblIdTransaksi.ForeColor = Color.FromArgb(192, 255, 192);
            lblIdTransaksi.Image = (Image)resources.GetObject("lblIdTransaksi.Image");
            lblIdTransaksi.Location = new Point(162, 80);
            lblIdTransaksi.Name = "lblIdTransaksi";
            lblIdTransaksi.Size = new Size(84, 19);
            lblIdTransaksi.TabIndex = 1;
            lblIdTransaksi.Text = "ID Transaksi";
            // 
            // lblNamaPenyewa
            // 
            lblNamaPenyewa.AutoSize = true;
            lblNamaPenyewa.BackColor = Color.Transparent;
            lblNamaPenyewa.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNamaPenyewa.ForeColor = Color.FromArgb(192, 255, 192);
            lblNamaPenyewa.Image = (Image)resources.GetObject("lblNamaPenyewa.Image");
            lblNamaPenyewa.Location = new Point(162, 120);
            lblNamaPenyewa.Name = "lblNamaPenyewa";
            lblNamaPenyewa.Size = new Size(105, 19);
            lblNamaPenyewa.TabIndex = 2;
            lblNamaPenyewa.Text = "Nama Penyewa";
            // 
            // lblIdBarang
            // 
            lblIdBarang.AutoSize = true;
            lblIdBarang.BackColor = Color.Transparent;
            lblIdBarang.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblIdBarang.ForeColor = Color.FromArgb(192, 255, 192);
            lblIdBarang.Image = (Image)resources.GetObject("lblIdBarang.Image");
            lblIdBarang.Location = new Point(162, 160);
            lblIdBarang.Name = "lblIdBarang";
            lblIdBarang.Size = new Size(70, 19);
            lblIdBarang.TabIndex = 3;
            lblIdBarang.Text = "ID Barang";
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.BackColor = Color.Transparent;
            lblJumlah.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblJumlah.ForeColor = Color.FromArgb(192, 255, 192);
            lblJumlah.Image = (Image)resources.GetObject("lblJumlah.Image");
            lblJumlah.Location = new Point(162, 200);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(54, 19);
            lblJumlah.TabIndex = 4;
            lblJumlah.Text = "Jumlah";
            // 
            // lblTglSewa
            // 
            lblTglSewa.AutoSize = true;
            lblTglSewa.BackColor = Color.Transparent;
            lblTglSewa.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTglSewa.ForeColor = Color.FromArgb(192, 255, 192);
            lblTglSewa.Image = (Image)resources.GetObject("lblTglSewa.Image");
            lblTglSewa.Location = new Point(162, 240);
            lblTglSewa.Name = "lblTglSewa";
            lblTglSewa.Size = new Size(95, 19);
            lblTglSewa.TabIndex = 5;
            lblTglSewa.Text = "Tanggal Sewa";
            // 
            // lblTglKembali
            // 
            lblTglKembali.AutoSize = true;
            lblTglKembali.BackColor = Color.Transparent;
            lblTglKembali.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTglKembali.ForeColor = Color.FromArgb(192, 255, 192);
            lblTglKembali.Image = (Image)resources.GetObject("lblTglKembali.Image");
            lblTglKembali.Location = new Point(162, 280);
            lblTglKembali.Name = "lblTglKembali";
            lblTglKembali.Size = new Size(113, 19);
            lblTglKembali.TabIndex = 6;
            lblTglKembali.Text = "Tanggal Kembali";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(192, 255, 192);
            lblTotal.Image = (Image)resources.GetObject("lblTotal.Image");
            lblTotal.Location = new Point(162, 320);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(81, 19);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total Harga";
            // 
            // txtIdTransaksi
            // 
            txtIdTransaksi.BackColor = Color.FromArgb(192, 255, 192);
            txtIdTransaksi.BorderStyle = BorderStyle.FixedSingle;
            txtIdTransaksi.Font = new Font("Segoe UI", 10F);
            txtIdTransaksi.Location = new Point(305, 78);
            txtIdTransaksi.Name = "txtIdTransaksi";
            txtIdTransaksi.Size = new Size(322, 25);
            txtIdTransaksi.TabIndex = 0;
            // 
            // textNamaPenyewa
            // 
            textNamaPenyewa.BackColor = Color.FromArgb(192, 255, 192);
            textNamaPenyewa.BorderStyle = BorderStyle.FixedSingle;
            textNamaPenyewa.Font = new Font("Segoe UI", 10F);
            textNamaPenyewa.Location = new Point(305, 118);
            textNamaPenyewa.Name = "textNamaPenyewa";
            textNamaPenyewa.Size = new Size(322, 25);
            textNamaPenyewa.TabIndex = 1;
            // 
            // cbBarangId
            // 
            cbBarangId.BackColor = Color.FromArgb(192, 255, 192);
            cbBarangId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBarangId.Font = new Font("Segoe UI", 10F);
            cbBarangId.Location = new Point(305, 158);
            cbBarangId.Name = "cbBarangId";
            cbBarangId.Size = new Size(322, 25);
            cbBarangId.TabIndex = 2;
            // 
            // numJumlah
            // 
            numJumlah.BackColor = Color.FromArgb(192, 255, 192);
            numJumlah.Font = new Font("Segoe UI", 10F);
            numJumlah.Location = new Point(305, 198);
            numJumlah.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numJumlah.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numJumlah.Name = "numJumlah";
            numJumlah.Size = new Size(322, 25);
            numJumlah.TabIndex = 3;
            numJumlah.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpTglSewa
            // 
            dtpTglSewa.Font = new Font("Segoe UI", 10F);
            dtpTglSewa.Location = new Point(305, 238);
            dtpTglSewa.Name = "dtpTglSewa";
            dtpTglSewa.Size = new Size(322, 25);
            dtpTglSewa.TabIndex = 4;
            // 
            // dtpTglKembali
            // 
            dtpTglKembali.Font = new Font("Segoe UI", 10F);
            dtpTglKembali.Location = new Point(305, 278);
            dtpTglKembali.Name = "dtpTglKembali";
            dtpTglKembali.Size = new Size(322, 25);
            dtpTglKembali.TabIndex = 5;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.FromArgb(192, 255, 192);
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTotal.ForeColor = Color.FromArgb(0, 100, 0);
            txtTotal.Location = new Point(305, 318);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(322, 25);
            txtTotal.TabIndex = 6;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(180, 230, 180);
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.FromArgb(0, 64, 0);
            btnSimpan.Location = new Point(430, 380);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 35);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnTambah_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(255, 192, 203);
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatAppearance.BorderSize = 0;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBatal.ForeColor = Color.FromArgb(139, 0, 0);
            btnBatal.Location = new Point(534, 380);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(90, 35);
            btnBatal.TabIndex = 8;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // FormInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(lblJudul);
            Controls.Add(lblIdTransaksi);
            Controls.Add(txtIdTransaksi);
            Controls.Add(lblNamaPenyewa);
            Controls.Add(textNamaPenyewa);
            Controls.Add(lblIdBarang);
            Controls.Add(cbBarangId);
            Controls.Add(lblJumlah);
            Controls.Add(numJumlah);
            Controls.Add(lblTglSewa);
            Controls.Add(dtpTglSewa);
            Controls.Add(lblTglKembali);
            Controls.Add(dtpTglKembali);
            Controls.Add(lblTotal);
            Controls.Add(txtTotal);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Name = "FormInput";
            Text = "Form Input Transaksi";
            ((System.ComponentModel.ISupportInitialize)numJumlah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblIdTransaksi;
        private Label lblNamaPenyewa;
        private Label lblIdBarang;
        private Label lblJumlah;
        private Label lblTglSewa;
        private Label lblTglKembali;
        private Label lblTotal;

        private TextBox txtIdTransaksi;
        private TextBox textNamaPenyewa;
        private ComboBox cbBarangId;
        private NumericUpDown numJumlah;
        private DateTimePicker dtpTglSewa;
        private DateTimePicker dtpTglKembali;
        private TextBox txtTotal;
        private Button btnSimpan;
        private Button btnBatal;
    }
}