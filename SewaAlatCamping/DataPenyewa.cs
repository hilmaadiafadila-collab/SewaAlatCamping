using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SewaAlatCamping
{
    public partial class DataTransaksi : Form
    {
        // ==========================================
        // FIELDS
        // ==========================================
        private List<Transaksi> listDataTransaksi = new List<Transaksi>();
        private readonly List<AlatCamping> _daftarAlat;

        // ==========================================
        // CONSTRUCTOR
        // ==========================================
        public DataTransaksi(List<AlatCamping> daftarAlat)
        {
            InitializeComponent();
            _daftarAlat = daftarAlat ?? throw new ArgumentNullException(nameof(daftarAlat));
        }

        // ==========================================
        // FORM LOAD
        // ==========================================
        private void DataTransaksi_Load(object sender, EventArgs e)
        {
            // Setup kolom DataGridView
            dgvDataPenyewa.ColumnCount = 7;
            dgvDataPenyewa.Columns[0].Name = "ID Transaksi";
            dgvDataPenyewa.Columns[1].Name = "Nama Penyewa";
            dgvDataPenyewa.Columns[2].Name = "ID Barang";
            dgvDataPenyewa.Columns[3].Name = "Jumlah";
            dgvDataPenyewa.Columns[4].Name = "Tgl Sewa";
            dgvDataPenyewa.Columns[5].Name = "Tgl Kembali";
            dgvDataPenyewa.Columns[6].Name = "Total Harga";

            dgvDataPenyewa.Columns[0].Width = 120;
            dgvDataPenyewa.Columns[1].Width = 140;
            dgvDataPenyewa.Columns[6].Width = 120;

            dgvDataPenyewa.AllowUserToAddRows = false;
            dgvDataPenyewa.ReadOnly = true;
            dgvDataPenyewa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Dummy 1: Sewa Tenda Dome 4P (CMP-001)
            // Harga: Rp 50.000/hari | Durasi: 2 hari | Jumlah: 1 unit
            // Total = 2 hari * 1 unit * Rp 50.000 = Rp 100.000
            listDataTransaksi.Add(new Transaksi(
                "TRX-260503091500",           // ID Transaksi (Format: TRX-yyMMddHHmmss)
                "Budi Santoso",               // Nama Penyewa
                "CMP-001",                    // ID Barang
                1,                            // Jumlah
                new DateTime(2026, 5, 1),     // Tgl Sewa
                new DateTime(2026, 5, 3),     // Tgl Kembali
                100000m                       // Total Harga (gunakan akhiran 'm' untuk tipe decimal)
            ));

            // Dummy 2: Sewa Carrier 60L (CMP-002)
            // Harga Diskon: Rp 67.500/hari (karena ada diskon 10% dari Rp 75.000)
            // Durasi: 3 hari | Jumlah: 2 unit
            // Total = 3 hari * 2 unit * Rp 67.500 = Rp 405.000
            listDataTransaksi.Add(new Transaksi(
                "TRX-260503102000",
                "Siti Aminah",
                "CMP-002",
                2,
                new DateTime(2026, 5, 2),
                new DateTime(2026, 5, 5),
                405000m
            ));

            // Pastikan memanggil method ini untuk merender data ke DataGridView
            TampilkanDataTransaksi();
        }

        // ==========================================
        // TAMPILKAN DATA KE GRIDVIEW
        // ==========================================
        private void TampilkanDataTransaksi()
        {
            dgvDataPenyewa.Rows.Clear();

            foreach (Transaksi trx in listDataTransaksi)
            {
                dgvDataPenyewa.Rows.Add(
                    trx.IdTransaksi,
                    trx.NamaPenyewa,
                    trx.BarangId,
                    trx.Jumlah,
                    trx.TglSewa.ToString("dd MMM yyyy"),
                    trx.TglKembali.ToString("dd MMM yyyy"),
                    "Rp " + trx.TotalHarga.ToString("N0")
                );
            }
        }

        // ==========================================
        // EVENT HANDLERS - TOMBOL
        // ==========================================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormInput formBaru = new FormInput(_daftarAlat);

            if (formBaru.ShowDialog() == DialogResult.OK)
            {
                Transaksi trxBaru = formBaru.GetTransaksi();
                listDataTransaksi.Add(trxBaru);
                TampilkanDataTransaksi();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDataPenyewa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan klik baris transaksi yang ingin diubah terlebih dahulu!",
                                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indexDipilih = dgvDataPenyewa.SelectedRows[0].Index;
            Transaksi dataLama = listDataTransaksi[indexDipilih];

            // Kembalikan stok dulu sebelum update
            AlatCamping alatLama = _daftarAlat.Find(x => x.IdBarang == dataLama.BarangId);
            alatLama?.TambahStok(dataLama.Jumlah);

            FormInput formUpdate = new FormInput(_daftarAlat);
            formUpdate.Text = "Update Data Transaksi";
            formUpdate.IsiForm(dataLama);

            if (formUpdate.ShowDialog() == DialogResult.OK)
            {
                Transaksi dataBaru = formUpdate.GetTransaksi();
                listDataTransaksi[indexDipilih] = dataBaru;
                TampilkanDataTransaksi();
                MessageBox.Show("Data transaksi berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Batal update → kembalikan pengurangan stok lama
                alatLama?.KurangiStok(dataLama.Jumlah);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDataPenyewa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan klik baris transaksi yang ingin dihapus terlebih dahulu!",
                                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult jawaban = MessageBox.Show("Apakah Anda yakin ingin menghapus transaksi ini?",
                                                   "Konfirmasi Hapus",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (jawaban == DialogResult.Yes)
            {
                int indexDipilih = dgvDataPenyewa.SelectedRows[0].Index;
                Transaksi trxDihapus = listDataTransaksi[indexDipilih];

                // Kembalikan stok barang
                AlatCamping alat = _daftarAlat.Find(x => x.IdBarang == trxDihapus.BarangId);
                alat?.TambahStok(trxDihapus.Jumlah);

                listDataTransaksi.RemoveAt(indexDipilih);
                TampilkanDataTransaksi();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
