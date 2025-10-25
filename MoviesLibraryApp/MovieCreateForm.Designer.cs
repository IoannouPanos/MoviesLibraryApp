namespace MoviesLibraryApp
{
    partial class MovieCreateForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvAddMovie = new DataGridView();
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAddMovie = new Button();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            txtActors = new TextBox();
            label8 = new Label();
            txtRating = new TextBox();
            label9 = new Label();
            cmbCategory = new ComboBox();
            cmbMedia = new ComboBox();
            pictureBox = new PictureBox();
            gbWatched = new GroupBox();
            rdBtnNo = new RadioButton();
            rdBtnYes = new RadioButton();
            label5 = new Label();
            dtpPublishDate = new DateTimePicker();
            dtpWatchedDate = new DateTimePicker();
            btnSelectImage = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAddMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            gbWatched.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAddMovie
            // 
            dgvAddMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAddMovie.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAddMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAddMovie.DefaultCellStyle = dataGridViewCellStyle1;
            dgvAddMovie.Dock = DockStyle.Bottom;
            dgvAddMovie.Location = new Point(0, 471);
            dgvAddMovie.Name = "dgvAddMovie";
            dgvAddMovie.Size = new Size(669, 150);
            dgvAddMovie.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtTitle.Location = new Point(38, 78);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Εισάγετε τον τίτλο";
            txtTitle.Size = new Size(377, 29);
            txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label1.Location = new Point(38, 55);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 2;
            label1.Text = "Τίτλος";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label2.Location = new Point(208, 9);
            label2.Name = "label2";
            label2.Size = new Size(210, 30);
            label2.TabIndex = 3;
            label2.Text = "Δημιουργία Ταινίας";
            // 
            // btnAddMovie
            // 
            btnAddMovie.Cursor = Cursors.Hand;
            btnAddMovie.Location = new Point(12, 391);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(655, 41);
            btnAddMovie.TabIndex = 4;
            btnAddMovie.Text = "Προσθήκη";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label3.Location = new Point(38, 128);
            label3.Name = "label3";
            label3.Size = new Size(186, 20);
            label3.TabIndex = 6;
            label3.Text = "Ημερομηνία Κυκλοφορίας";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label4.Location = new Point(249, 128);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 8;
            label4.Text = "Κατηγορία";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label7.Location = new Point(38, 184);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 14;
            label7.Text = "Πρωταγωνιστές";
            // 
            // txtActors
            // 
            txtActors.Location = new Point(38, 207);
            txtActors.Multiline = true;
            txtActors.Name = "txtActors";
            txtActors.Size = new Size(186, 91);
            txtActors.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label8.Location = new Point(249, 252);
            label8.Name = "label8";
            label8.Size = new Size(131, 20);
            label8.TabIndex = 16;
            label8.Text = "IMDB βαθμολογία";
            // 
            // txtRating
            // 
            txtRating.Location = new Point(249, 275);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(166, 23);
            txtRating.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label9.Location = new Point(249, 184);
            label9.Name = "label9";
            label9.Size = new Size(120, 20);
            label9.TabIndex = 18;
            label9.Text = "Μέσο Προβολής";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(249, 151);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(166, 23);
            cmbCategory.TabIndex = 19;
            // 
            // cmbMedia
            // 
            cmbMedia.FormattingEnabled = true;
            cmbMedia.Location = new Point(249, 207);
            cmbMedia.Name = "cmbMedia";
            cmbMedia.Size = new Size(166, 23);
            cmbMedia.TabIndex = 20;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Location = new Point(436, 78);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(219, 239);
            pictureBox.TabIndex = 21;
            pictureBox.TabStop = false;
            // 
            // gbWatched
            // 
            gbWatched.Controls.Add(rdBtnNo);
            gbWatched.Controls.Add(rdBtnYes);
            gbWatched.Cursor = Cursors.Hand;
            gbWatched.Location = new Point(38, 310);
            gbWatched.Name = "gbWatched";
            gbWatched.Size = new Size(186, 51);
            gbWatched.TabIndex = 22;
            gbWatched.TabStop = false;
            gbWatched.Text = "Την Έχω δει";
            // 
            // rdBtnNo
            // 
            rdBtnNo.AutoSize = true;
            rdBtnNo.Location = new Point(102, 22);
            rdBtnNo.Name = "rdBtnNo";
            rdBtnNo.Size = new Size(44, 19);
            rdBtnNo.TabIndex = 1;
            rdBtnNo.TabStop = true;
            rdBtnNo.Text = "Όχι";
            rdBtnNo.UseVisualStyleBackColor = true;
            // 
            // rdBtnYes
            // 
            rdBtnYes.AutoSize = true;
            rdBtnYes.Location = new Point(20, 22);
            rdBtnYes.Name = "rdBtnYes";
            rdBtnYes.Size = new Size(44, 19);
            rdBtnYes.TabIndex = 0;
            rdBtnYes.TabStop = true;
            rdBtnYes.Text = "Ναι";
            rdBtnYes.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label5.Location = new Point(249, 315);
            label5.Name = "label5";
            label5.Size = new Size(166, 20);
            label5.TabIndex = 24;
            label5.Text = "Ημερομηνία Προβολής";
            // 
            // dtpPublishDate
            // 
            dtpPublishDate.Format = DateTimePickerFormat.Short;
            dtpPublishDate.Location = new Point(38, 151);
            dtpPublishDate.Name = "dtpPublishDate";
            dtpPublishDate.Size = new Size(186, 23);
            dtpPublishDate.TabIndex = 27;
            // 
            // dtpWatchedDate
            // 
            dtpWatchedDate.Format = DateTimePickerFormat.Short;
            dtpWatchedDate.Location = new Point(249, 338);
            dtpWatchedDate.Name = "dtpWatchedDate";
            dtpWatchedDate.Size = new Size(166, 23);
            dtpWatchedDate.TabIndex = 28;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Cursor = Cursors.Hand;
            btnSelectImage.Location = new Point(436, 323);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(219, 36);
            btnSelectImage.TabIndex = 29;
            btnSelectImage.Text = "Επιλογή Εικόνας";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // MovieCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(669, 621);
            ControlBox = false;
            Controls.Add(btnSelectImage);
            Controls.Add(dtpWatchedDate);
            Controls.Add(dtpPublishDate);
            Controls.Add(label5);
            Controls.Add(gbWatched);
            Controls.Add(pictureBox);
            Controls.Add(cmbMedia);
            Controls.Add(cmbCategory);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtRating);
            Controls.Add(label7);
            Controls.Add(txtActors);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnAddMovie);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Controls.Add(dgvAddMovie);
            MaximizeBox = false;
            Name = "MovieCreateForm";
            Text = "Δημιουργία Ταινίας";
            WindowState = FormWindowState.Maximized;
            Load += MovieCreateForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAddMovie).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            gbWatched.ResumeLayout(false);
            gbWatched.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAddMovie;
        private TextBox txtTitle;
        private Label label1;
        private Label label2;
        private Button btnAddMovie;
        private Label label3;
        private Label label4;
        private Label label7;
        private TextBox txtActors;
        private Label label8;
        private TextBox txtRating;
        private Label label9;
        private ComboBox cmbCategory;
        private ComboBox cmbMedia;
        private PictureBox pictureBox;
        private GroupBox gbWatched;
        private RadioButton rdBtnNo;
        private RadioButton rdBtnYes;
        private Label label5;
        private DateTimePicker dtpPublishDate;
        private DateTimePicker dtpWatchedDate;
        private Button btnSelectImage;
    }
}