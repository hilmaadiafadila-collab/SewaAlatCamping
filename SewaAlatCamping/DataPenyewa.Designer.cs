namespace SewaAlatCamping
{
    partial class DataTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataTransaksi));
            dgvDataPenyewa = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDataPenyewa).BeginInit();
            SuspendLayout();
            // 
            // dgvDataPenyewa
            // 
            dgvDataPenyewa.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgvDataPenyewa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataPenyewa.Location = new Point(24, 12);
            dgvDataPenyewa.Name = "dgvDataPenyewa";
            dgvDataPenyewa.Size = new Size(745, 321);
            dgvDataPenyewa.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumAquamarine;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FromArgb(0, 64, 0);
            btnAdd.Location = new Point(24, 379);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 35);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SandyBrown;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(129, 379);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 35);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightPink;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.DarkRed;
            btnDelete.Location = new Point(684, 379);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 35);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // DataTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvDataPenyewa);
            Name = "DataTransaksi";
            Text = "DataPenyewa";
            ((System.ComponentModel.ISupportInitialize)dgvDataPenyewa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDataPenyewa;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}