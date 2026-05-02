using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SewaAlatCamping
{
    public partial class Form1 : Form
    {
        private List<AlatCamping> listDataAlat = new List<AlatCamping>();
        List<Transaksi> listTransaksi = new List<Transaksi>();

        public Form1()
        {
            InitializeComponent();

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

            dgvAlat.Columns[0].Width = 110; 
            dgvAlat.Columns[1].Width = 130; 
            dgvAlat.Columns[7].Width = 100; 
            dgvAlat.Columns[10].Width = 120;

            dgvAlat.AllowUserToAddRows = false;
            dgvAlat.ReadOnly = true;
            dgvAlat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            listDataAlat.Add(new AlatCamping(
                "CMP-001",                   
                "Tenda Dome 4P",             
                "Eiger",                     
                "Tent & Shelter",            
                3500,                        
                5,                           
                "Unit",                      
                new DateTime(2024, 1, 10),   
                50000m,                      
                10000m,                      
                false,                       
                0m                           
            ));

            listDataAlat.Add(new AlatCamping(
                "CMP-002",
                "Carrier 60L",
                "Osprey",
                "Hiking Gear",
                1800,
                3,
                "Unit",
                new DateTime(2024, 2, 15),
                75000m,
                15000m,
                true,
                10m
            ));

            TampilkanData();
        }

        private void TampilkanData()
        {
            dgvAlat.Rows.Clear();

            foreach (AlatCamping alat in listDataAlat)
            {
                string statusPromo = alat.IsPromo ? $"{alat.DiskonPersen}%" : "-";

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
            if (dgvAlat.SelectedRows.Count > 0)
            {
                int indexYangDipilih = dgvAlat.SelectedRows[0].Index;

                AlatCamping dataLama = listDataAlat[indexYangDipilih];
                FormDataBaru formUpdate = new FormDataBaru();

                formUpdate.IsiForm(dataLama);
                formUpdate.Text = "Update Data Barang";
                if (formUpdate.ShowDialog() == DialogResult.OK)
                {
                    AlatCamping dataBaru = formUpdate.GetAlatCamping();
                    listDataAlat[indexYangDipilih] = dataBaru;
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

        private void btnDataPenyewa_Click(object sender, EventArgs e)
        {
            DataTransaksi formPenyewa = new DataTransaksi(listDataAlat);
            formPenyewa.ShowDialog();
            TampilkanData();
        }
    }
}