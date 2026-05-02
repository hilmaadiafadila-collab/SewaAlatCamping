namespace SewaAlatCamping
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvAlat = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnDataPenyewa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlat).BeginInit();
            SuspendLayout();
            // 
            // dgvAlat
            // 
            dataGridViewCellStyle1.BackColor = Color.Honeydew;
            dgvAlat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlat.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgvAlat.BorderStyle = BorderStyle.None;
            dgvAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAlat.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAlat.GridColor = Color.FromArgb(0, 64, 0);
            dgvAlat.Location = new Point(12, 53);
            dgvAlat.Name = "dgvAlat";
            dgvAlat.Size = new Size(776, 310);
            dgvAlat.TabIndex = 0;
            dgvAlat.CellClick += dgvAlat_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumAquamarine;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FromArgb(0, 64, 0);
            btnAdd.Location = new Point(12, 385);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 35);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightPink;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.DarkRed;
            btnDelete.Location = new Point(703, 385);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 35);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SandyBrown;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(108, 385);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 35);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDataPenyewa
            // 
            btnDataPenyewa.Location = new Point(636, 12);
            btnDataPenyewa.Name = "btnDataPenyewa";
            btnDataPenyewa.Size = new Size(152, 23);
            btnDataPenyewa.TabIndex = 4;
            btnDataPenyewa.Text = "Data Penyewa";
            btnDataPenyewa.UseVisualStyleBackColor = true;
            btnDataPenyewa.Click += btnDataPenyewa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDataPenyewa);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvAlat);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Barang Sewa";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAlat;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnDataPenyewa;
    }
}