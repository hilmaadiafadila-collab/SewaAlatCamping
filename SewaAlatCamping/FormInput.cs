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
        private readonly List<AlatCamping> _daftarAlat;

        public FormInput(List<AlatCamping> daftarAlat)
        {
            InitializeComponent();
            _daftarAlat = daftarAlat ?? throw new ArgumentNullException(nameof(daftarAlat));

            InisialisasiForm();
        }

        private void InisialisasiForm()
        {

            txtIdTransaksi.Text = "TRX-" + DateTime.Now.ToString("yyMMddHHmmss");
            txtIdTransaksi.ReadOnly = true;
            txtIdTransaksi.BackColor = Color.LightGray;

            IsiComboBoxBarang();

            txtTotal.ReadOnly = true;
            txtTotal.BackColor = Color.LightYellow;

            cbBarangId.SelectedIndexChanged += Control_Changed;
            numJumlah.ValueChanged += Control_Changed;
            dtpTglSewa.ValueChanged += Control_Changed;
            dtpTglKembali.ValueChanged += Control_Changed;

            HitungTotal();
        }

        private void IsiComboBoxBarang()
        {
            cbBarangId.Items.Clear();
            foreach (AlatCamping alat in _daftarAlat)
            {
                if (alat.Stok > 0)
                    cbBarangId.Items.Add($"{alat.IdBarang} - {alat.NamaBarang} (Stok: {alat.Stok})");
            }
            if (cbBarangId.Items.Count > 0)
                cbBarangId.SelectedIndex = 0;
        }

        private string GetIdBarangDipilih()
        {
            if (cbBarangId.SelectedItem == null) return string.Empty;
            string teks = cbBarangId.SelectedItem.ToString();
            int idx = teks.IndexOf(" - ");
            return idx >= 0 ? teks.Substring(0, idx) : teks;
        }

        private void HitungTotal()
        {
            string idDipilih = GetIdBarangDipilih();
            AlatCamping alatTerpilih = _daftarAlat.FirstOrDefault(x => x.IdBarang == idDipilih);

            if (alatTerpilih != null)
            {
                int totalHari = (dtpTglKembali.Value.Date - dtpTglSewa.Value.Date).Days;
                if (totalHari <= 0) totalHari = 1; 

                decimal total = totalHari * alatTerpilih.HargaSetelahDiskon * (int)numJumlah.Value;
                txtTotal.Text = "Rp " + total.ToString("N0");
            }
            else
            {
                txtTotal.Text = "Rp 0";
            }
        }

        private void Control_Changed(object sender, EventArgs e) => HitungTotal();

        public Transaksi GetTransaksi()
        {
            string idBarang = GetIdBarangDipilih();

            string totalBersih = txtTotal.Text.Replace("Rp", "").Replace(".", "").Replace(",", "").Trim();
            decimal totalHarga = decimal.TryParse(totalBersih, out decimal parsed) ? parsed : 0;

            return new Transaksi(
                txtIdTransaksi.Text,
                textNamaPenyewa.Text,
                idBarang,
                (int)numJumlah.Value,
                dtpTglSewa.Value.Date,
                dtpTglKembali.Value.Date,
                totalHarga
            );
        }

        public void IsiForm(Transaksi data)
        {
            txtIdTransaksi.Text = data.IdTransaksi;
            textNamaPenyewa.Text = data.NamaPenyewa;

            for (int i = 0; i < cbBarangId.Items.Count; i++)
            {
                if (cbBarangId.Items[i].ToString().StartsWith(data.BarangId))
                {
                    cbBarangId.SelectedIndex = i;
                    break;
                }
            }

            numJumlah.Value = data.Jumlah;
            dtpTglSewa.Value = data.TglSewa;
            dtpTglKembali.Value = data.TglKembali;
            txtTotal.Text = "Rp " + data.TotalHarga.ToString("N0");
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNamaPenyewa.Text))
            {
                MessageBox.Show("Harap isi Nama Penyewa!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbBarangId.SelectedItem == null)
            {
                MessageBox.Show("Harap pilih ID Barang!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpTglKembali.Value.Date <= dtpTglSewa.Value.Date)
            {
                MessageBox.Show("Tanggal kembali harus setelah tanggal sewa!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idBarang = GetIdBarangDipilih();
            AlatCamping alatDipilih = _daftarAlat.FirstOrDefault(x => x.IdBarang == idBarang);

            if (alatDipilih == null)
            {
                MessageBox.Show("Barang tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int jumlahDiminta = (int)numJumlah.Value;
            if (jumlahDiminta > alatDipilih.Stok)
            {
                MessageBox.Show($"Stok tidak mencukupi!\nStok tersedia: {alatDipilih.Stok}\nJumlah diminta: {jumlahDiminta}",
                                "Stok Kurang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                alatDipilih.KurangiStok(jumlahDiminta);

                MessageBox.Show("Data penyewaan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
