using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SewaAlatCamping
{
    public partial class Form1 : Form
    {
        // Menyimpan data di RAM
        private List<AlatCamping> listDataAlat = new List<AlatCamping>();

        public Form1()
        {
            InitializeComponent();

            // Membuat sudut komponen melengkung
            BuatSudutMelengkung(btnAdd, 15);
            BuatSudutMelengkung(btnUpdate, 15);
            BuatSudutMelengkung(btnDelete, 15);
            BuatSudutMelengkung(dgvAlat, 15);
        }

        private void BuatSudutMelengkung(Control kontrol, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(kontrol.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(kontrol.Width - radius, kontrol.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, kontrol.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            kontrol.Region = new Region(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MENGUBAH JUMLAH KOLOM MENJADI 12
            dgvAlat.ColumnCount = 12;

            // Memberi nama Header Tabel
            dgvAlat.Columns[0].Name = "ID Barang";
            dgvAlat.Columns[1].Name = "Nama Alat";
            dgvAlat.Columns[2].Name = "Merk";
            dgvAlat.Columns[3].Name = "Kategori";
            dgvAlat.Columns[4].Name = "Berat (gr)";
            dgvAlat.Columns[5].Name = "Stok";
            dgvAlat.Columns[6].Name = "Satuan";
            dgvAlat.Columns[7].Name = "Tgl Masuk";
            dgvAlat.Columns[8].Name = "Harga Asli";
            dgvAlat.Columns[9].Name = "Diskon";
            dgvAlat.Columns[10].Name = "Harga Final";
            dgvAlat.Columns[11].Name = "Denda/Hari";

            // Mengatur lebar kolom agar data tidak terpotong
            dgvAlat.Columns[0].Width = 110; // ID
            dgvAlat.Columns[1].Width = 130; // Nama
            dgvAlat.Columns[7].Width = 100; // Tgl Masuk
            dgvAlat.Columns[10].Width = 120; // Harga Final

            // Mencegah baris kosong ekstra di paling bawah tabel
            dgvAlat.AllowUserToAddRows = false;
            dgvAlat.ReadOnly = true;
            dgvAlat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void TampilkanData()
        {
            dgvAlat.Rows.Clear();

            foreach (AlatCamping alat in listDataAlat)
            {
                // Format teks diskon (Tampilkan persen jika ada promo, jika tidak tampilkan tanda strip)
                string statusPromo = alat.IsPromo ? $"{alat.DiskonPersen}%" : "-";

                // Memasukkan 12 data berurutan persis seperti urutan kolom di atas
                dgvAlat.Rows.Add(
                    alat.IdBarang,
                    alat.NamaBarang,
                    alat.MerkBarang,
                    alat.Kategori,
                    alat.BeratGram.ToString("N0"), // Format angka ribuan
                    alat.Stok,
                    alat.Satuan,
                    alat.TanggalMasuk.ToString("dd MMM yyyy"), // Format tanggal (Contoh: 02 May 2026)
                    "Rp " + alat.HargaHarian.ToString("N0"),
                    statusPromo,
                    "Rp " + alat.HargaSetelahDiskon.ToString("N0"),
                    "Rp " + alat.DendaHarian.ToString("N0")
                );
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormDataBaru formBaru = new FormDataBaru();

            if (formBaru.ShowDialog() == DialogResult.OK)
            {
                AlatCamping alatBaru = formBaru.GetAlatCamping();
                listDataAlat.Add(alatBaru);
                TampilkanData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAlat.SelectedRows.Count > 0)
            {
                int indexYangDipilih = dgvAlat.SelectedRows[0].Index;
                DialogResult jawaban = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?",
                                                       "Konfirmasi Hapus",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);

                if (jawaban == DialogResult.Yes)
                {
                    listDataAlat.RemoveAt(indexYangDipilih);
                    TampilkanData();
                }
            }
            else
            {
                MessageBox.Show("Silakan klik baris data yang ingin dihapus terlebih dahulu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 1. Pastikan ada baris tabel yang dipilih/diklik oleh pengguna
            if (dgvAlat.SelectedRows.Count > 0)
            {
                // 2. Ambil index (urutan baris) yang diklik
                int indexYangDipilih = dgvAlat.SelectedRows[0].Index;

                // 3. Ambil objek data asli dari List berdasarkan index tersebut
                AlatCamping dataLama = listDataAlat[indexYangDipilih];

                // 4. Buka FormDataBaru
                FormDataBaru formUpdate = new FormDataBaru();

                // 5. [PENTING] Lempar data lama ke form agar kotak-kotaknya terisi otomatis!
                formUpdate.IsiForm(dataLama);

                // Ubah sedikit teks form agar pengguna tahu mereka sedang meng-update, bukan menambah baru (Opsional)
                formUpdate.Text = "Update Data Barang";

                // 6. Tampilkan form. Jika pengguna mengklik "Simpan"...
                if (formUpdate.ShowDialog() == DialogResult.OK)
                {
                    // 7. Ambil objek data yang sudah selesai diedit
                    AlatCamping dataBaru = formUpdate.GetAlatCamping();

                    // 8. Timpa/Ganti data lama di dalam gudang List dengan data yang baru
                    listDataAlat[indexYangDipilih] = dataBaru;

                    // 9. Segarkan tampilan tabel agar data barunya muncul!
                    TampilkanData();

                    MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Silakan klik baris data yang ingin diubah terlebih dahulu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvAlat_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}