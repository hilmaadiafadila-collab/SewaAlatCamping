namespace SewaAlatCamping
{
    public partial class Form1 : Form
    {
        List<AlatCamping> alatCampings = new List<AlatCamping>();
        int indexDipilih;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormDataBaru formInput = new FormDataBaru();
            if (formInput.ShowDialog() == DialogResult.OK)
            {
                alatCampings.Add(formInput.GetAlatCamping());
                dgvAlat.DataSource = null;
                dgvAlat.DataSource = alatCampings;
            }
        }

        private void dgvAlat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indexDipilih = e.RowIndex;

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (konfirmasi == DialogResult.Yes)
            {
                alatCampings.RemoveAt(indexDipilih);
                dgvAlat.DataSource = null;
                dgvAlat.DataSource = alatCampings;

                MessageBox.Show("Data berhasil dihapus!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormDataBaru formInput = new FormDataBaru();

            AlatCamping dataLama = alatCampings[indexDipilih];

            formInput.IsiForm(dataLama);
            if (formInput.ShowDialog() == DialogResult.OK)
            {
                alatCampings[indexDipilih] = formInput.GetAlatCamping();
                dgvAlat.DataSource = null;
                dgvAlat.DataSource = alatCampings;
            }
        }
    }
}
