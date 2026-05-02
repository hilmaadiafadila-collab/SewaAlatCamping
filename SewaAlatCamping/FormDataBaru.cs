using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SewaAlatCamping
{
    public partial class FormDataBaru : Form
    {
        public FormDataBaru()
        {
            InitializeComponent();

            cbKategori.Items.AddRange(new string[] { "Cooking Gear", "Hiking Gear", "Sleeping Gear", "Tent & Shelter", "Lighting & Tools" });
            cbSatuan.Items.AddRange(new string[] { "Unit", "Set", "Pasang" });

            // Generate ID Otomatis
            txtIdBarang.Text = "CMP-" + DateTime.Now.ToString("yyMMddHHmmss");
            txtIdBarang.ReadOnly = true;
            txtIdBarang.BackColor = Color.LightGray;

            // Mematikan input diskon secara default (karena belum dicentang)
            numDiskon.Enabled = false;

            // (Panggil method BuatSudutMelengkung Anda di sini jika mau...)
        }

        // ==========================================
        // EVENT CHECKBOX (Interaksi UI)
        // ==========================================
        private void chkPromo_CheckedChanged(object sender, EventArgs e)
        {
            // Jika dicentang, numDiskon menyala. Jika tidak, numDiskon mati.
            numDiskon.Enabled = chkPromo.Checked;

            // Jika tidak dicentang, kembalikan nilai diskon ke 0 secara otomatis
            if (!chkPromo.Checked)
            {
                numDiskon.Value = 0;
            }
        }

        public AlatCamping GetAlatCamping()
        {
            return new AlatCamping(
                txtIdBarang.Text,
                txtNamaBarang.Text,
                txtMerk.Text,
                cbKategori.Text,
                (double)numBerat.Value,       // Sekarang menggunakan NumericUpDown
                (int)numStok.Value,
                cbSatuan.Text,
                dtpTglMasuk.Value,
                numHarga.Value,
                numDenda.Value,
                chkPromo.Checked,             // Status CheckBox Promo
                numDiskon.Value               // Persentase Diskon (0 - 100)
            );
        }

        // Letakkan tepat di bawah penutup kurung kurawal } milik GetAlatCamping()

        public void IsiForm(AlatCamping data)
        {
            // Mengisi data teks ke kotak input
            txtIdBarang.Text = data.IdBarang;
            txtNamaBarang.Text = data.NamaBarang;
            txtMerk.Text = data.MerkBarang;
            cbKategori.Text = data.Kategori;
            cbSatuan.Text = data.Satuan;
            dtpTglMasuk.Value = data.TanggalMasuk;

            // Mengisi data angka ke NumericUpDown 
            // (numBerat butuh (decimal) karena aslinya double di class AlatCamping)
            numBerat.Value = (decimal)data.BeratGram;
            numStok.Value = data.Stok;
            numHarga.Value = data.HargaHarian;
            numDenda.Value = data.DendaHarian;

            // Mengisi data CheckBox dan Persentase Diskon
            chkPromo.Checked = data.IsPromo;
            numDiskon.Value = data.DiskonPersen;
        }

        // Pastikan di bawahnya adalah method: private void btnSimpan_Click(...)

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi string sekarang SANGAT SEDIKIT, program jadi bebas crash!
            if (string.IsNullOrWhiteSpace(txtNamaBarang.Text) ||
                string.IsNullOrWhiteSpace(txtMerk.Text) ||
                string.IsNullOrWhiteSpace(cbKategori.Text) ||
                string.IsNullOrWhiteSpace(cbSatuan.Text))
            {
                MessageBox.Show("Harap isi semua field teks!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                AlatCamping alatBaru = GetAlatCamping();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Data Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}