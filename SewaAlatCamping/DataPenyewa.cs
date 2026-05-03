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
        private readonly List<AlatCamping> _daftarAlat;

        public DataTransaksi(List<AlatCamping> daftarAlat)
        {
            InitializeComponent();
            _daftarAlat = daftarAlat ?? throw new ArgumentNullException(nameof(daftarAlat));
        }

        private void DataTransaksi_Load(object sender, EventArgs e)
        {
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

            listDataTransaksi.Add(new Transaksi(
                "TRX-260503091500",           
                "Budi Santoso",               
                "CMP-001",                    
                1,                            
                new DateTime(2026, 5, 1),     
                new DateTime(2026, 5, 3),     
                100000m                       
            ));

            listDataTransaksi.Add(new Transaksi(
                "TRX-260503102000",
                "Siti Aminah",
                "CMP-002",
                2,
                new DateTime(2026, 5, 2),
                new DateTime(2026, 5, 5),
                405000m
            ));

            TampilkanDataTransaksi();
        }

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
