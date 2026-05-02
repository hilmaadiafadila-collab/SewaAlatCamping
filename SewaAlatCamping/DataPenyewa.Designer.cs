namespace SewaAlatCamping
{
    partial class DataTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataTransaksi));

            dgvDataPenyewa = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvDataPenyewa).BeginInit();
            SuspendLayout();

            // ── DataGridView ───────────────────────────────────────────
            dgvDataPenyewa.BackgroundColor = System.Drawing.Color.FromArgb(220, 255, 220);
            dgvDataPenyewa.BorderStyle = BorderStyle.None;
            dgvDataPenyewa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataPenyewa.Location = new System.Drawing.Point(12, 50);
            dgvDataPenyewa.Name = "dgvDataPenyewa";
            dgvDataPenyewa.Size = new System.Drawing.Size(776, 300);
            dgvDataPenyewa.TabIndex = 0;

            // Style header
            dgvDataPenyewa.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(144, 238, 144);
            dgvDataPenyewa.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 64, 0);
            dgvDataPenyewa.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvDataPenyewa.EnableHeadersVisualStyles = false;

            // Style row alternating
            dgvDataPenyewa.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Honeydew;

            // ── Tombol Add (pastel hijau mint) ─────────────────────────
            btnAdd.BackColor = System.Drawing.Color.FromArgb(180, 230, 180);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAdd.ForeColor = System.Drawing.Color.FromArgb(0, 64, 0);
            btnAdd.Location = new System.Drawing.Point(12, 370);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(85, 35);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;

            // ── Tombol Update (pastel oranye) ──────────────────────────
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(255, 218, 185);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnUpdate.ForeColor = System.Drawing.Color.FromArgb(139, 69, 19);
            btnUpdate.Location = new System.Drawing.Point(107, 370);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(85, 35);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;

            // ── Tombol Delete (pastel merah muda) ──────────────────────
            btnDelete.BackColor = System.Drawing.Color.FromArgb(255, 182, 193);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDelete.ForeColor = System.Drawing.Color.FromArgb(139, 0, 0);
            btnDelete.Location = new System.Drawing.Point(703, 370);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(85, 35);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;

            // ── Tombol Back (pastel biru lavender) ─────────────────────
            btnBack.BackColor = System.Drawing.Color.FromArgb(200, 200, 255);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnBack.ForeColor = System.Drawing.Color.FromArgb(50, 50, 150);
            btnBack.Location = new System.Drawing.Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(90, 30);
            btnBack.TabIndex = 4;
            btnBack.Text = "◀ Kembali";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;

            // ── Form ───────────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(800, 450);
            Name = "DataTransaksi";
            Text = "Data Penyewa";
            Load += DataTransaksi_Load;

            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvDataPenyewa);

            ((System.ComponentModel.ISupportInitialize)dgvDataPenyewa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDataPenyewa;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack;
    }
}