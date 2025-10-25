namespace MoviesLibraryApp
{
    partial class MovieDeleteForm
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
            cmbMovies = new ComboBox();
            label1 = new Label();
            dgvDelMovie = new DataGridView();
            BtnDelMovie = new Button();
            btnFindMovie = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDelMovie).BeginInit();
            SuspendLayout();
            // 
            // cmbMovies
            // 
            cmbMovies.BackColor = SystemColors.InactiveCaption;
            cmbMovies.FormattingEnabled = true;
            cmbMovies.Location = new Point(26, 69);
            cmbMovies.Name = "cmbMovies";
            cmbMovies.Size = new Size(187, 23);
            cmbMovies.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label1.Location = new Point(26, 49);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 1;
            label1.Text = "Επίλεξε Ταινία";
            // 
            // dgvDelMovie
            // 
            dgvDelMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDelMovie.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvDelMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDelMovie.Location = new Point(26, 149);
            dgvDelMovie.Name = "dgvDelMovie";
            dgvDelMovie.Size = new Size(358, 249);
            dgvDelMovie.TabIndex = 2;
            // 
            // BtnDelMovie
            // 
            BtnDelMovie.Location = new Point(269, 99);
            BtnDelMovie.Name = "BtnDelMovie";
            BtnDelMovie.Size = new Size(115, 26);
            BtnDelMovie.TabIndex = 3;
            BtnDelMovie.Text = "Διαγραφή Ταινίας";
            BtnDelMovie.UseVisualStyleBackColor = true;
            BtnDelMovie.Click += BtnDelMovie_Click;
            // 
            // btnFindMovie
            // 
            btnFindMovie.Location = new Point(269, 67);
            btnFindMovie.Name = "btnFindMovie";
            btnFindMovie.Size = new Size(115, 23);
            btnFindMovie.TabIndex = 4;
            btnFindMovie.Text = "Επιλογή Ταινίας";
            btnFindMovie.UseVisualStyleBackColor = true;
            btnFindMovie.Click += btnFindMovie_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label2.Location = new Point(119, 9);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 5;
            label2.Text = "Διαγραφή Ταινίας";
            // 
            // MovieDeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(416, 423);
            Controls.Add(label2);
            Controls.Add(btnFindMovie);
            Controls.Add(BtnDelMovie);
            Controls.Add(dgvDelMovie);
            Controls.Add(label1);
            Controls.Add(cmbMovies);
            Name = "MovieDeleteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Διαγραφή Ταινίας";
            Load += MovieDeleteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDelMovie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMovies;
        private Label label1;
        private DataGridView dgvDelMovie;
        private Button BtnDelMovie;
        private Button btnFindMovie;
        private Label label2;
    }
}