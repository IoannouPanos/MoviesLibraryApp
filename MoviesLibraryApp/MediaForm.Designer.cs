namespace MovieLibraryApp
{
    partial class MediaForm
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
            dgvMedia = new DataGridView();
            txtAddMedia = new TextBox();
            label1 = new Label();
            btnAddMedia = new Button();
            btnEditMedia = new Button();
            btnDelMedia = new Button();
            txtEditMedia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMedia).BeginInit();
            SuspendLayout();
            // 
            // dgvMedia
            // 
            dgvMedia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedia.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvMedia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedia.Location = new Point(50, 252);
            dgvMedia.Name = "dgvMedia";
            dgvMedia.Size = new Size(308, 245);
            dgvMedia.TabIndex = 0;
            dgvMedia.CellClick += dgvMedia_CellClick;
            // 
            // txtAddMedia
            // 
            txtAddMedia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtAddMedia.Location = new Point(50, 100);
            txtAddMedia.Name = "txtAddMedia";
            txtAddMedia.PlaceholderText = "Προσθήκη Μέσου ";
            txtAddMedia.Size = new Size(185, 29);
            txtAddMedia.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label1.Location = new Point(108, 29);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 2;
            label1.Text = "Μέσο Προβολής";
            // 
            // btnAddMedia
            // 
            btnAddMedia.Location = new Point(260, 100);
            btnAddMedia.Name = "btnAddMedia";
            btnAddMedia.Size = new Size(99, 29);
            btnAddMedia.TabIndex = 3;
            btnAddMedia.Text = "Προσθήκη";
            btnAddMedia.UseVisualStyleBackColor = true;
            btnAddMedia.Click += btnAddMedia_Click;
            // 
            // btnEditMedia
            // 
            btnEditMedia.Location = new Point(260, 153);
            btnEditMedia.Name = "btnEditMedia";
            btnEditMedia.Size = new Size(98, 29);
            btnEditMedia.TabIndex = 4;
            btnEditMedia.Text = "Επεξεργασία";
            btnEditMedia.UseVisualStyleBackColor = true;
            btnEditMedia.Click += btnEditMedia_Click;
            // 
            // btnDelMedia
            // 
            btnDelMedia.Location = new Point(259, 201);
            btnDelMedia.Name = "btnDelMedia";
            btnDelMedia.Size = new Size(99, 28);
            btnDelMedia.TabIndex = 5;
            btnDelMedia.Text = "Διαγραφή";
            btnDelMedia.UseVisualStyleBackColor = true;
            btnDelMedia.Click += btnDelMedia_Click;
            // 
            // txtEditMedia
            // 
            txtEditMedia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtEditMedia.Location = new Point(50, 153);
            txtEditMedia.Name = "txtEditMedia";
            txtEditMedia.PlaceholderText = "Επεξεργασία Μέσου ";
            txtEditMedia.Size = new Size(185, 29);
            txtEditMedia.TabIndex = 6;
            // 
            // MediaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(423, 509);
            Controls.Add(txtEditMedia);
            Controls.Add(btnDelMedia);
            Controls.Add(btnEditMedia);
            Controls.Add(btnAddMedia);
            Controls.Add(label1);
            Controls.Add(txtAddMedia);
            Controls.Add(dgvMedia);
            Name = "MediaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Μέσο Προβολής";
            Load += MediaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMedia;
        private TextBox txtAddMedia;
        private Label label1;
        private Button btnAddMedia;
        private Button btnEditMedia;
        private Button btnDelMedia;
        private TextBox txtEditMedia;
    }
}