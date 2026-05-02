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

            txtIdBarang.Text = "CMP-" + DateTime.Now.ToString("yyMMddHHmmss");
            txtIdBarang.ReadOnly = true;
            txtIdBarang.BackColor = Color.LightGray;

            numDiskon.Enabled = false;
        }

        private void chkPromo_CheckedChanged(object sender, EventArgs e)
        {
            numDiskon.Enabled = chkPromo.Checked;

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
                (double)numBerat.Value,       
                (int)numStok.Value,
                cbSatuan.Text,
                dtpTglMasuk.Value,
                numHarga.Value,
                numDenda.Value,
                chkPromo.Checked,             
                numDiskon.Value               
            );
        }

        public void IsiForm(AlatCamping data)
        {
            txtIdBarang.Text = data.IdBarang;
            txtNamaBarang.Text = data.NamaBarang;
            txtMerk.Text = data.MerkBarang;
            cbKategori.Text = data.Kategori;
            cbSatuan.Text = data.Satuan;
            dtpTglMasuk.Value = data.TanggalMasuk;
 
            numBerat.Value = (decimal)data.BeratGram;
            numStok.Value = data.Stok;
            numHarga.Value = data.HargaHarian;
            numDenda.Value = data.DendaHarian;

            chkPromo.Checked = data.IsPromo;
            numDiskon.Value = data.DiskonPersen;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
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