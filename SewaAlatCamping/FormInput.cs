using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SewaAlatCamping
{
    public partial class FormInput : Form
    {
        private List<AlatCamping> _daftarAlat;

        public FormInput(List<AlatCamping> daftarAlat)
        {
            InitializeComponent();
            _daftarAlat = daftarAlat;
        }

        // Constructor menerima kiriman list barang dari Form1
        private void HitungTotal()
        {
            // Cari alat di dalam list yang ID-nya cocok dengan yang diketik di TextBox
            // Ganti 'txtBarangid' dengan nama (Name) TextBox ID Barang Anda
            var alatTerpilih = _daftarAlat.FirstOrDefault(x => x.IdBarang == txtBarangid.Text);

            if (alatTerpilih != null)
            {
                // Hitung selisih hari
                TimeSpan selisih = dtpTglKembali.Value - dtpTglSewa.Value;
                int totalHari = selisih.Days;
                if (totalHari <= 0) totalHari = 1; // Minimal sewa 1 hari

                // Hitung total: Hari * Harga Barang * Jumlah Unit
                decimal total = totalHari * alatTerpilih.HargaHarian * numJumlah.Value;

                // Tampilkan ke TextBox Total
                txtTotal.Text = total.ToString("N0");
            }
            else
            {
                txtTotal.Text = "0"; // Jika ID barang tidak ditemukan
            }
        }

        private void Control_Changed(object sender, EventArgs e) => HitungTotal();

        public Transaksi GetTransaksi()
        {
            return new Transaksi
            {
                IdTransaksi = txtIdTransaksi.Text,
                NamaPenyewa = textNamaPenyewa.Text,
                Barangid = txtBarangid.Text,
                Jumlah = (int)numJumlah.Value,
                TglSewa = dtpTglSewa.Value,
                TglKembali = dtpTglKembali.Value,
                TotalHarga = decimal.Parse(txtTotal.Text)
            };
        }

        // Tambahkan method ini di dalam FormInput.cs Anda

        public void IsiForm(Transaksi data)
        {
            // PERHATIAN: 
            // Ganti txtNamaPenyewa, txtAlat, dll di bawah ini 
            // dengan nama TextBox/ComboBox yang benar-benar ada di desain FormInput Anda!

            // Ganti juga data.NamaPenyewa dengan nama Properti yang ada di class Transaksi.cs Anda!

            txtIdTransaksi.Text = data.IdTransaksi; // (Jika ID bisa diedit atau ditampilkan)
            textNamaPenyewa.Text = data.NamaPenyewa;
            txtBarangid.Text = data.Barangid;
            dtpTglSewa.Value = data.TglSewa;
            dtpTglKembali.Value = data.TglKembali;
            numJumlah.Value = data.Jumlah;
            txtTotal.Text = data.TotalHarga.ToString("N0");

            // Tambahkan kotak input lainnya sesuai dengan kebutuhan transaksi Anda...
        }
        public FormInput()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNamaPenyewa.Text) ||
            string.IsNullOrWhiteSpace(txtBarangid.Text))
            {
                MessageBox.Show("Harap isi semua kolom data terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Menghentikan proses simpan jika ada yang kosong
            }

            // 2. Logika Simpan Data (Sesuaikan dengan metode Anda, misal pakai List<T> atau Database)
            // Contoh: TransaksiBaru(txtNamaPenyewa.Text, txtAlatDisewa.Text);

            // 3. Memberikan pesan sukses
            MessageBox.Show("Data penyewaan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
