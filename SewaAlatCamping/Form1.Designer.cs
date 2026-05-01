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
            dgvAlat = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlat).BeginInit();
            SuspendLayout();
            // 
            // dgvAlat
            // 
            dgvAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlat.Location = new Point(12, 12);
            dgvAlat.Name = "dgvAlat";
            dgvAlat.Size = new Size(776, 351);
            dgvAlat.TabIndex = 0;
            dgvAlat.CellClick += dgvAlat_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 397);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(713, 397);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 397);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvAlat);
            Name = "Form1";
            Text = "Data Barang";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAlat;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
    }
}
