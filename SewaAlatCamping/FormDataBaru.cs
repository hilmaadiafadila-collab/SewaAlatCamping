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
            cbKondisi.Items.AddRange(new string[] {"Baik", "Rusak Ringan", "Rusak"});
            cbStatus.Items.AddRange(new string[] {"Tersedia", "Tidak Tersedia"});
        }

        public AlatCamping GetAlatCamping()
        {
            return new AlatCamping
            {
                IdBarang = txtIdBarang.Text,
                NamaBarang = txtNamaBarang.Text,
                Kategori = cbKategori.Text,
                HargaHarian = decimal.Parse(txtHargaHarian.Text),
                HargaPaket = decimal.Parse(txtHargaPaket.Text),
                Stok = int.Parse(txtStok.Text),
                Kondisi = cbKondisi.Text,
                TanggalMasuk = dtpTglMasuk.Value,
                Status = cbStatus.Text,
                Lokasi = txtLokasi.Text
            };
        }

        public void IsiForm(AlatCamping data)
        {
            txtIdBarang.Text = data.IdBarang;
            txtNamaBarang.Text = data.NamaBarang;
            cbKategori.Text = data.Kategori;
            txtHargaHarian.Text = data.HargaHarian.ToString();
            txtHargaPaket.Text = data.HargaPaket.ToString();
            txtStok.Text = data.Stok.ToString();
            cbKondisi.Text = data.Kondisi;
            dtpTglMasuk.Value = data.TanggalMasuk;
            cbStatus.Text = data.Status;
            txtLokasi.Text = data.Lokasi;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdBarang.Text) ||
                string.IsNullOrWhiteSpace(txtNamaBarang.Text) ||
                string.IsNullOrWhiteSpace(cbKategori.Text) ||
                string.IsNullOrWhiteSpace(txtHargaHarian.Text) ||
                string.IsNullOrWhiteSpace(txtHargaPaket.Text) ||
                string.IsNullOrWhiteSpace(txtStok.Text) ||
                string.IsNullOrWhiteSpace(cbKondisi.Text) ||
                string.IsNullOrWhiteSpace(cbStatus.Text) ||
                string.IsNullOrWhiteSpace(txtLokasi.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
