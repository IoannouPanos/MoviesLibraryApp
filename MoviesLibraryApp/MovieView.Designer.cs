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
            pbMovieView.Location = new Point(27, 91);
            pbMovieView.Margin = new Padding(4);
            pbMovieView.Name = "pbMovieView";
            pbMovieView.Size = new Size(388, 485);
            pbMovieView.TabIndex = 0;
            pbMovieView.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(476, 91);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 1;
            label1.Text = "Τίτλος";
            // 
            // txtViewTitle
            // 
            txtViewTitle.Location = new Point(476, 116);
            txtViewTitle.Margin = new Padding(4);
            txtViewTitle.Name = "txtViewTitle";
            txtViewTitle.Size = new Size(277, 29);
            txtViewTitle.TabIndex = 2;
            // 
            // txtViewCategory
            // 
            txtViewCategory.Location = new Point(476, 277);
            txtViewCategory.Margin = new Padding(4);
            txtViewCategory.Name = "txtViewCategory";
            txtViewCategory.Size = new Size(277, 29);
            txtViewCategory.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(476, 252);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 3;
            label2.Text = "Κατηγορία";
            // 
            // txtViewMedia
            // 
            txtViewMedia.Location = new Point(476, 347);
            txtViewMedia.Margin = new Padding(4);
            txtViewMedia.Name = "txtViewMedia";
            txtViewMedia.Size = new Size(277, 29);
            txtViewMedia.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 322);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 5;
            label3.Text = "Μέσο Προβολής";
            // 
            // txtViewRating
            // 
            txtViewRating.Location = new Point(476, 417);
            txtViewRating.Margin = new Padding(4);
            txtViewRating.Name = "txtViewRating";
            txtViewRating.Size = new Size(277, 29);
            txtViewRating.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 392);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 7;
            label4.Text = "Βαθμολογία";
            // 
            // txtViewPubDate
            // 
            txtViewPubDate.Location = new Point(476, 481);
            txtViewPubDate.Margin = new Padding(4);
            txtViewPubDate.Name = "txtViewPubDate";
            txtViewPubDate.Size = new Size(277, 29);
            txtViewPubDate.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(476, 455);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(192, 21);
            label5.TabIndex = 9;
            label5.Text = "Ημερομηνία Κυκλοφορίας";
            // 
            // txtViewWatcDate
            // 
            txtViewWatcDate.Location = new Point(476, 547);
            txtViewWatcDate.Margin = new Padding(4);
            txtViewWatcDate.Name = "txtViewWatcDate";
            txtViewWatcDate.Size = new Size(277, 29);
            txtViewWatcDate.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(476, 522);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(170, 21);
            label6.TabIndex = 11;
            label6.Text = "Ημερομηνία Προβολής";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label8.Location = new Point(360, 13);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(68, 25);
            label8.TabIndex = 15;
            label8.Text = "Ταινία";
            // 
            // txtViewActors
            // 
            txtViewActors.Location = new Point(476, 180);
            txtViewActors.Margin = new Padding(4);
            txtViewActors.Multiline = true;
            txtViewActors.Name = "txtViewActors";
            txtViewActors.Size = new Size(277, 68);
            txtViewActors.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(476, 155);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 21);
            label7.TabIndex = 16;
            label7.Text = "Ηθοποιοί";
            // 
            // MovieView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 610);
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
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            Margin = new Padding(4);
            Name = "MovieView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ταινία";
            Load += MovieView_Load;
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