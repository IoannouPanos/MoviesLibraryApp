namespace MoviesLibraryApp
{
    partial class MovieEditForm
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
            btnEditSelectImage = new Button();
            dtpEditWatchedDate = new DateTimePicker();
            dtpEditPublishDate = new DateTimePicker();
            label5 = new Label();
            gbWatched = new GroupBox();
            rdBtnNo = new RadioButton();
            rdBtnYes = new RadioButton();
            pictureBoxEdit = new PictureBox();
            cmbEditMedia = new ComboBox();
            cmbEditCategory = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            txtEditRating = new TextBox();
            label7 = new Label();
            txtEditActors = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEditTitle = new TextBox();
            btnEditSave = new Button();
            btnEditCancel = new Button();
            cmbSelectMovie = new ComboBox();
            label6 = new Label();
            btnSelectMovie = new Button();
            gbWatched.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit).BeginInit();
            SuspendLayout();
            // 
            // btnEditSelectImage
            // 
            btnEditSelectImage.BackColor = Color.White;
            btnEditSelectImage.Cursor = Cursors.Hand;
            btnEditSelectImage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnEditSelectImage.Location = new Point(423, 376);
            btnEditSelectImage.Name = "btnEditSelectImage";
            btnEditSelectImage.Size = new Size(219, 36);
            btnEditSelectImage.TabIndex = 47;
            btnEditSelectImage.Text = "Επιλογή Εικόνας";
            btnEditSelectImage.UseVisualStyleBackColor = false;
            // 
            // dtpEditWatchedDate
            // 
            dtpEditWatchedDate.Format = DateTimePickerFormat.Short;
            dtpEditWatchedDate.Location = new Point(236, 389);
            dtpEditWatchedDate.Name = "dtpEditWatchedDate";
            dtpEditWatchedDate.Size = new Size(166, 23);
            dtpEditWatchedDate.TabIndex = 46;
            // 
            // dtpEditPublishDate
            // 
            dtpEditPublishDate.Format = DateTimePickerFormat.Short;
            dtpEditPublishDate.Location = new Point(25, 202);
            dtpEditPublishDate.Name = "dtpEditPublishDate";
            dtpEditPublishDate.Size = new Size(186, 23);
            dtpEditPublishDate.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label5.Location = new Point(236, 366);
            label5.Name = "label5";
            label5.Size = new Size(166, 20);
            label5.TabIndex = 44;
            label5.Text = "Ημερομηνία Προβολής";
            // 
            // gbWatched
            // 
            gbWatched.Controls.Add(rdBtnNo);
            gbWatched.Controls.Add(rdBtnYes);
            gbWatched.Cursor = Cursors.Hand;
            gbWatched.Location = new Point(25, 361);
            gbWatched.Name = "gbWatched";
            gbWatched.Size = new Size(186, 51);
            gbWatched.TabIndex = 43;
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
            // pictureBoxEdit
            // 
            pictureBoxEdit.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxEdit.Location = new Point(423, 59);
            pictureBoxEdit.Name = "pictureBoxEdit";
            pictureBoxEdit.Size = new Size(219, 309);
            pictureBoxEdit.TabIndex = 42;
            pictureBoxEdit.TabStop = false;
            // 
            // cmbEditMedia
            // 
            cmbEditMedia.FormattingEnabled = true;
            cmbEditMedia.Location = new Point(236, 258);
            cmbEditMedia.Name = "cmbEditMedia";
            cmbEditMedia.Size = new Size(166, 23);
            cmbEditMedia.TabIndex = 41;
            // 
            // cmbEditCategory
            // 
            cmbEditCategory.FormattingEnabled = true;
            cmbEditCategory.Location = new Point(236, 202);
            cmbEditCategory.Name = "cmbEditCategory";
            cmbEditCategory.Size = new Size(166, 23);
            cmbEditCategory.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label9.Location = new Point(236, 235);
            label9.Name = "label9";
            label9.Size = new Size(120, 20);
            label9.TabIndex = 39;
            label9.Text = "Μέσο Προβολής";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label8.Location = new Point(236, 303);
            label8.Name = "label8";
            label8.Size = new Size(131, 20);
            label8.TabIndex = 38;
            label8.Text = "IMDB βαθμολογία";
            // 
            // txtEditRating
            // 
            txtEditRating.Location = new Point(236, 326);
            txtEditRating.Name = "txtEditRating";
            txtEditRating.Size = new Size(166, 23);
            txtEditRating.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label7.Location = new Point(25, 235);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 36;
            label7.Text = "Πρωταγωνιστές";
            // 
            // txtEditActors
            // 
            txtEditActors.Location = new Point(25, 258);
            txtEditActors.Multiline = true;
            txtEditActors.Name = "txtEditActors";
            txtEditActors.Size = new Size(186, 91);
            txtEditActors.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label4.Location = new Point(236, 179);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 34;
            label4.Text = "Κατηγορία";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label3.Location = new Point(25, 179);
            label3.Name = "label3";
            label3.Size = new Size(186, 20);
            label3.TabIndex = 33;
            label3.Text = "Ημερομηνία Κυκλοφορίας";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label2.Location = new Point(197, 9);
            label2.Name = "label2";
            label2.Size = new Size(218, 30);
            label2.TabIndex = 32;
            label2.Text = "Επεξεργασία Ταινίας";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label1.Location = new Point(25, 105);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 31;
            label1.Text = "Τίτλος";
            // 
            // txtEditTitle
            // 
            txtEditTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtEditTitle.Location = new Point(22, 125);
            txtEditTitle.Name = "txtEditTitle";
            txtEditTitle.Size = new Size(380, 29);
            txtEditTitle.TabIndex = 30;
            // 
            // btnEditSave
            // 
            btnEditSave.AccessibleRole = AccessibleRole.MenuBar;
            btnEditSave.BackColor = Color.White;
            btnEditSave.Cursor = Cursors.Hand;
            btnEditSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnEditSave.Location = new Point(25, 428);
            btnEditSave.Name = "btnEditSave";
            btnEditSave.Size = new Size(617, 36);
            btnEditSave.TabIndex = 48;
            btnEditSave.Text = "Αποθήκευση";
            btnEditSave.UseVisualStyleBackColor = false;
            btnEditSave.Click += btnEditSave_Click;
            // 
            // btnEditCancel
            // 
            btnEditCancel.AccessibleRole = AccessibleRole.MenuBar;
            btnEditCancel.BackColor = Color.White;
            btnEditCancel.Cursor = Cursors.Hand;
            btnEditCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnEditCancel.Location = new Point(25, 470);
            btnEditCancel.Name = "btnEditCancel";
            btnEditCancel.Size = new Size(617, 36);
            btnEditCancel.TabIndex = 49;
            btnEditCancel.Text = "Άκυρο";
            btnEditCancel.UseVisualStyleBackColor = false;
            btnEditCancel.Click += btnEditCancel_Click;
            // 
            // cmbSelectMovie
            // 
            cmbSelectMovie.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            cmbSelectMovie.FormattingEnabled = true;
            cmbSelectMovie.Location = new Point(22, 67);
            cmbSelectMovie.Name = "cmbSelectMovie";
            cmbSelectMovie.Size = new Size(284, 28);
            cmbSelectMovie.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label6.Location = new Point(25, 47);
            label6.Name = "label6";
            label6.Size = new Size(96, 17);
            label6.TabIndex = 51;
            label6.Text = "Επίλεξε Ταινία";
            // 
            // btnSelectMovie
            // 
            btnSelectMovie.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnSelectMovie.Location = new Point(312, 67);
            btnSelectMovie.Name = "btnSelectMovie";
            btnSelectMovie.Size = new Size(90, 28);
            btnSelectMovie.TabIndex = 52;
            btnSelectMovie.Text = "Επιλογή";
            btnSelectMovie.UseVisualStyleBackColor = true;
            btnSelectMovie.Click += btnSelectMovie_Click;
            // 
            // MovieEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(664, 518);
            ControlBox = false;
            Controls.Add(btnSelectMovie);
            Controls.Add(label6);
            Controls.Add(cmbSelectMovie);
            Controls.Add(btnEditCancel);
            Controls.Add(btnEditSave);
            Controls.Add(btnEditSelectImage);
            Controls.Add(dtpEditWatchedDate);
            Controls.Add(dtpEditPublishDate);
            Controls.Add(label5);
            Controls.Add(gbWatched);
            Controls.Add(pictureBoxEdit);
            Controls.Add(cmbEditMedia);
            Controls.Add(cmbEditCategory);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtEditRating);
            Controls.Add(label7);
            Controls.Add(txtEditActors);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEditTitle);
            Name = "MovieEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Επεξεργασία Ταινίας";
            WindowState = FormWindowState.Maximized;
            Load += MovieEditForm_Load;
            gbWatched.ResumeLayout(false);
            gbWatched.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditSelectImage;
        private DateTimePicker dtpEditWatchedDate;
        private DateTimePicker dtpEditPublishDate;
        private Label label5;
        private GroupBox gbWatched;
        private RadioButton rdBtnNo;
        private RadioButton rdBtnYes;
        private PictureBox pictureBoxEdit;
        private ComboBox cmbEditMedia;
        private ComboBox cmbEditCategory;
        private Label label9;
        private Label label8;
        private TextBox txtEditRating;
        private Label label7;
        private TextBox txtEditActors;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEditTitle;
        private Button btnEditSave;
        private Button btnEditCancel;
        private ComboBox cmbSelectMovie;
        private Label label6;
        private Button btnSelectMovie;
    }
}