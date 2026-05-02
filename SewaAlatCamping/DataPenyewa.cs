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
        private List<Transaksi> listDataTransaksi = new List<Transaksi>();


        public DataTransaksi()
        {
            InitializeComponent();
        }

        private void DataTransaksi_Load(object sender, EventArgs e)
        {
            // Mengatur kolom DataGridView secara manual (jika tidak diatur lewat Design)
            dgvDataPenyewa.ColumnCount = 7;

            dgvDataPenyewa.Columns[0].Name = "ID Transaksi";
            dgvDataPenyewa.Columns[1].Name = "Nama Penyewa";
            dgvDataPenyewa.Columns[2].Name = "ID Barang";
            dgvDataPenyewa.Columns[3].Name = "Tgl Sewa";
            dgvDataPenyewa.Columns[4].Name = "Tgl Kembali";
            dgvDataPenyewa.Columns[5].Name = "Jumlah";
            dgvDataPenyewa.Columns[6].Name = "Total Harga";

            // Merapikan tampilan tabel agar lebih profesional
            dgvDataPenyewa.AllowUserToAddRows = false;
            dgvDataPenyewa.ReadOnly = true;
            dgvDataPenyewa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Contoh memasukkan data dummy ke dalam tabel untuk dites

            // Merapikan tampilan tabel
            dgvDataPenyewa.AllowUserToAddRows = false; // Menghilangkan baris kosong di bawah
            dgvDataPenyewa.ReadOnly = true; // Tabel tidak bisa diedit langsung
        }

        private void TampilkanDataTransaksi()
        {
            // 1. Bersihkan tabel sebelum memasukkan data baru agar tidak ganda
            dgvDataPenyewa.Rows.Clear();

            // 2. Looping: Ambil satu per satu data dari List, lalu masukkan ke tabel
            foreach (Transaksi trx in listDataTransaksi)
            {
                // Masukkan data ke kolom tabel. 
                // PASTIKAN NAMA PROPERTI (seperti trx.IdTransaksi) SESUAI DENGAN ISI CLASS Transaksi.cs ANDA!
                dgvDataPenyewa.Rows.Add(
                    trx.IdTransaksi,
                    trx.NamaPenyewa,
                    trx.Barangid,
                    trx.TglSewa.ToString("dd MMM yyyy")
                );
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormInput formBaru = new FormInput();

            // Jika pengguna mengklik tombol Simpan di FormInput
            if (formBaru.ShowDialog() == DialogResult.OK)
            {
                // Ambil data transaksi dari form input
                Transaksi trxBaru = formBaru.GetTransaksi();

                // Tambahkan ke dalam List
                listDataTransaksi.Add(trxBaru);

                // Segarkan tabel agar data baru muncul
                TampilkanDataTransaksi();
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Pastikan pengguna sudah memilih baris
            if (dgvDataPenyewa.SelectedRows.Count > 0)
            {
                int indexYangDipilih = dgvDataPenyewa.SelectedRows[0].Index;

                // Ambil data transaksi lama dari List
                Transaksi dataLama = listDataTransaksi[indexYangDipilih];

                FormInput formUpdate = new FormInput();
                formUpdate.Text = "Update Data Transaksi"; // Ubah judul form (opsional)

                // Lempar data lama ke form agar kotak input terisi otomatis
                // Pastikan Anda sudah membuat method IsiForm() di FormInput.cs
                formUpdate.IsiForm(dataLama);

                // Buka form, dan jika pengguna klik Simpan...
                if (formUpdate.ShowDialog() == DialogResult.OK)
                {
                    // Ambil data yang sudah diedit
                    Transaksi dataBaru = formUpdate.GetTransaksi();

                    // Timpa data lama dengan data baru di posisi index yang sama
                    listDataTransaksi[indexYangDipilih] = dataBaru;

                    // Segarkan tabel
                    TampilkanDataTransaksi();

                    MessageBox.Show("Data transaksi berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Silakan klik baris transaksi yang ingin diubah terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Pastikan pengguna sudah mengklik/memilih salah satu baris di tabel
            if (dgvDataPenyewa.SelectedRows.Count > 0)
            {
                // Ambil posisi baris (index) yang diklik
                int indexYangDipilih = dgvDataPenyewa.SelectedRows[0].Index;

                // Munculkan kotak konfirmasi
                DialogResult jawaban = MessageBox.Show("Apakah Anda yakin ingin menghapus transaksi ini?",
                                                       "Konfirmasi Hapus",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);

                if (jawaban == DialogResult.Yes)
                {
                    // Hapus data dari List berdasarkan index
                    listDataTransaksi.RemoveAt(indexYangDipilih);

                    // Segarkan tabel
                    TampilkanDataTransaksi();
                }
            }
            else
            {
                MessageBox.Show("Silakan klik baris transaksi yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
