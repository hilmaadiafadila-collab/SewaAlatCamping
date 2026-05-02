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
        }

        public AlatCamping GetAlatCamping()
        {
            // Menggunakan Constructor dari AlatCamping.cs yang menjaga enkapsulasi
            return new AlatCamping(
                txtIdBarang.Text,
                txtNamaBarang.Text,
                txtMerk.Text,
                cbKategori.Text,
                double.Parse(txtBerat.Text),
                int.Parse(txtStok.Text),
                cbSatuan.Text,
                dtpTglMasuk.Value,
                decimal.Parse(txtHargaHarian.Text),
                decimal.Parse(txtDendaHarian.Text)
            );
        }

        public void IsiForm(AlatCamping data)
        {
            // Mengisi form berdasarkan 10 data yang benar
            txtIdBarang.Text = data.IdBarang;
            txtNamaBarang.Text = data.NamaBarang;
            txtMerk.Text = data.MerkBarang;
            cbKategori.Text = data.Kategori;
            txtBerat.Text = data.BeratGram.ToString();
            txtStok.Text = data.Stok.ToString();
            cbSatuan.Text = data.Satuan;
            dtpTglMasuk.Value = data.TanggalMasuk;
            txtHargaHarian.Text = data.HargaHarian.ToString();
            txtDendaHarian.Text = data.DendaHarian.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdBarang.Text) ||
                string.IsNullOrWhiteSpace(txtNamaBarang.Text) ||
                string.IsNullOrWhiteSpace(txtMerk.Text) ||
                string.IsNullOrWhiteSpace(cbKategori.Text) ||
                string.IsNullOrWhiteSpace(txtBerat.Text) ||
                string.IsNullOrWhiteSpace(txtStok.Text) ||
                string.IsNullOrWhiteSpace(cbSatuan.Text) ||
                string.IsNullOrWhiteSpace(txtHargaHarian.Text) ||
                string.IsNullOrWhiteSpace(txtDendaHarian.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                AlatCamping alatBaru = GetAlatCamping();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Tipe data tidak sesuai! Pastikan kolom Berat, Stok, Harga, dan Denda diisi dengan ANGKA murni.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Data Ditolak Sistem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan sistem: {ex.Message}", "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Added stub in case the designer wires a Click event for label5
        private void label5_Click(object sender, EventArgs e)
        {
            // No action required for label clicks; stub to satisfy designer reference
        }

    }
}