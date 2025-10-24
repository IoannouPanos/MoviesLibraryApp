namespace MovieLibraryApp
{
    partial class CategoryForm
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
            dgvCategory = new DataGridView();
            btnAddCat = new Button();
            lblNewCat = new Label();
            txtNewCat = new TextBox();
            btnEditCat = new Button();
            btnDelCat = new Button();
            txtEditCat = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // dgvCategory
            // 
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(70, 306);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.Size = new Size(464, 272);
            dgvCategory.TabIndex = 0;
            dgvCategory.CellClick += dgvCategory_CellClick;
            dgvCategory.CellValueChanged += dgvCategory_CellValueChanged;
            // 
            // btnAddCat
            // 
            btnAddCat.Cursor = Cursors.Hand;
            btnAddCat.Location = new Point(400, 96);
            btnAddCat.Name = "btnAddCat";
            btnAddCat.Size = new Size(134, 39);
            btnAddCat.TabIndex = 1;
            btnAddCat.Text = "Εισαγωγή";
            btnAddCat.UseVisualStyleBackColor = true;
            btnAddCat.Click += btnAddCat_Click;
            btnAddCat.MouseHover += btnNewCat_MouseHover;
            // 
            // lblNewCat
            // 
            lblNewCat.AutoSize = true;
            lblNewCat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblNewCat.Location = new Point(70, 71);
            lblNewCat.Name = "lblNewCat";
            lblNewCat.Size = new Size(119, 21);
            lblNewCat.TabIndex = 2;
            lblNewCat.Text = "Νέα Κατηγορία";
            // 
            // txtNewCat
            // 
            txtNewCat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtNewCat.Location = new Point(70, 106);
            txtNewCat.Name = "txtNewCat";
            txtNewCat.PlaceholderText = "Εισάγετε νέα κατηγορία";
            txtNewCat.Size = new Size(241, 29);
            txtNewCat.TabIndex = 3;
            // 
            // btnEditCat
            // 
            btnEditCat.Cursor = Cursors.Hand;
            btnEditCat.Location = new Point(400, 164);
            btnEditCat.Name = "btnEditCat";
            btnEditCat.Size = new Size(134, 39);
            btnEditCat.TabIndex = 4;
            btnEditCat.Text = "Επεξεργασία";
            btnEditCat.UseVisualStyleBackColor = true;
            btnEditCat.Click += btnEditCat_Click;
            // 
            // btnDelCat
            // 
            btnDelCat.Cursor = Cursors.Hand;
            btnDelCat.Location = new Point(400, 228);
            btnDelCat.Name = "btnDelCat";
            btnDelCat.Size = new Size(134, 39);
            btnDelCat.TabIndex = 5;
            btnDelCat.Text = "Διαγραφή";
            btnDelCat.UseVisualStyleBackColor = true;
            btnDelCat.Click += btnDelCat_Click;
            // 
            // txtEditCat
            // 
            txtEditCat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtEditCat.Location = new Point(70, 174);
            txtEditCat.Name = "txtEditCat";
            txtEditCat.PlaceholderText = "Επεξεργασία κατηγορίας";
            txtEditCat.Size = new Size(241, 29);
            txtEditCat.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label1.Location = new Point(204, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 30);
            label1.TabIndex = 8;
            label1.Text = "Κατηγορίες Ταινιών";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 590);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(txtEditCat);
            Controls.Add(btnDelCat);
            Controls.Add(btnEditCat);
            Controls.Add(txtNewCat);
            Controls.Add(lblNewCat);
            Controls.Add(btnAddCat);
            Controls.Add(dgvCategory);
            Name = "CategoryForm";
            Text = "Κατηγορίες";
            WindowState = FormWindowState.Maximized;
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategory;
        private Button btnAddCat;
        private Label lblNewCat;
        private TextBox txtNewCat;
        private Button btnEditCat;
        private Button btnDelCat;
        private TextBox txtEditCat;
        private Label label1;
    }
}