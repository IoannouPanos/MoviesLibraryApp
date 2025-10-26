namespace MoviesLibraryApp
{
    partial class MovieView
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
            pbMovieView = new PictureBox();
            label1 = new Label();
            txtViewTitle = new TextBox();
            txtViewCategory = new TextBox();
            label2 = new Label();
            txtViewMedia = new TextBox();
            label3 = new Label();
            txtViewRating = new TextBox();
            label4 = new Label();
            txtViewPubDate = new TextBox();
            label5 = new Label();
            txtViewWatcDate = new TextBox();
            label6 = new Label();
            label8 = new Label();
            txtViewActors = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbMovieView).BeginInit();
            SuspendLayout();
            // 
            // pbMovieView
            // 
            pbMovieView.BorderStyle = BorderStyle.Fixed3D;
            pbMovieView.Location = new Point(12, 62);
            pbMovieView.Name = "pbMovieView";
            pbMovieView.Size = new Size(243, 285);
            pbMovieView.SizeMode = PictureBoxSizeMode.Zoom;
            pbMovieView.TabIndex = 0;
            pbMovieView.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 62);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 1;
            label1.Text = "Τίτλος";
            // 
            // txtViewTitle
            // 
            txtViewTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtViewTitle.Location = new Point(268, 82);
            txtViewTitle.Name = "txtViewTitle";
            txtViewTitle.Size = new Size(297, 25);
            txtViewTitle.TabIndex = 2;
            // 
            // txtViewCategory
            // 
            txtViewCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtViewCategory.Location = new Point(462, 198);
            txtViewCategory.Name = "txtViewCategory";
            txtViewCategory.Size = new Size(104, 25);
            txtViewCategory.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(268, 201);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 3;
            label2.Text = "Κατηγορία";
            // 
            // txtViewMedia
            // 
            txtViewMedia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtViewMedia.Location = new Point(463, 229);
            txtViewMedia.Name = "txtViewMedia";
            txtViewMedia.Size = new Size(103, 25);
            txtViewMedia.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 232);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 5;
            label3.Text = "Μέσο Προβολής";
            // 
            // txtViewRating
            // 
            txtViewRating.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtViewRating.Location = new Point(462, 260);
            txtViewRating.Name = "txtViewRating";
            txtViewRating.Size = new Size(103, 25);
            txtViewRating.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 263);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 7;
            label4.Text = "Βαθμολογία";
            // 
            // txtViewPubDate
            // 
            txtViewPubDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtViewPubDate.Location = new Point(462, 291);
            txtViewPubDate.Name = "txtViewPubDate";
            txtViewPubDate.Size = new Size(102, 25);
            txtViewPubDate.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(268, 294);
            label5.Name = "label5";
            label5.Size = new Size(160, 17);
            label5.TabIndex = 9;
            label5.Text = "Ημερομηνία Κυκλοφορίας";
            // 
            // txtViewWatcDate
            // 
            txtViewWatcDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtViewWatcDate.Location = new Point(461, 322);
            txtViewWatcDate.Name = "txtViewWatcDate";
            txtViewWatcDate.Size = new Size(103, 25);
            txtViewWatcDate.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(268, 325);
            label6.Name = "label6";
            label6.Size = new Size(141, 17);
            label6.TabIndex = 11;
            label6.Text = "Ημερομηνία Προβολής";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label8.Location = new Point(263, 9);
            label8.Name = "label8";
            label8.Size = new Size(68, 25);
            label8.TabIndex = 15;
            label8.Text = "Ταινία";
            // 
            // txtViewActors
            // 
            txtViewActors.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            txtViewActors.Location = new Point(268, 134);
            txtViewActors.Multiline = true;
            txtViewActors.Name = "txtViewActors";
            txtViewActors.Size = new Size(297, 58);
            txtViewActors.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(268, 114);
            label7.Name = "label7";
            label7.Size = new Size(63, 17);
            label7.TabIndex = 16;
            label7.Text = "Ηθοποιοί";
            // 
            // MovieView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 374);
            Controls.Add(txtViewActors);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtViewWatcDate);
            Controls.Add(label6);
            Controls.Add(txtViewPubDate);
            Controls.Add(label5);
            Controls.Add(txtViewRating);
            Controls.Add(label4);
            Controls.Add(txtViewMedia);
            Controls.Add(label3);
            Controls.Add(txtViewCategory);
            Controls.Add(label2);
            Controls.Add(txtViewTitle);
            Controls.Add(label1);
            Controls.Add(pbMovieView);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 161);
            Name = "MovieView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ταινία";
            ((System.ComponentModel.ISupportInitialize)pbMovieView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbMovieView;
        private Label label1;
        private TextBox txtViewTitle;
        private TextBox txtViewCategory;
        private Label label2;
        private TextBox txtViewMedia;
        private Label label3;
        private TextBox txtViewRating;
        private Label label4;
        private TextBox txtViewPubDate;
        private Label label5;
        private TextBox txtViewWatcDate;
        private Label label6;
        private Label label8;
        private TextBox txtViewActors;
        private Label label7;
    }
}