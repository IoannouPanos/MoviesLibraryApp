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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtViewTitle = new TextBox();
            txtViewCategory = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 400);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(370, 70);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Τίτλος";

            // 
            // txtViewTitle
            // 
            txtViewTitle.Location = new Point(370, 88);
            txtViewTitle.Name = "txtViewTitle";
            txtViewTitle.Size = new Size(216, 23);
            txtViewTitle.TabIndex = 2;
            // 
            // txtViewCategory
            // 
            txtViewCategory.Location = new Point(377, 154);
            txtViewCategory.Name = "txtViewCategory";
            txtViewCategory.Size = new Size(216, 23);
            txtViewCategory.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(370, 131);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Κατηγορία";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(377, 215);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 23);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 192);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 5;
            label3.Text = "Μέσο Προβολής";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(377, 273);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(216, 23);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(370, 250);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 7;
            label4.Text = "Βαθμολογία";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(377, 331);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(216, 23);
            textBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(370, 308);
            label5.Name = "label5";
            label5.Size = new Size(147, 15);
            label5.TabIndex = 9;
            label5.Text = "Ημερομηνία Κυκλοφορίας";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(377, 393);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(216, 23);
            textBox6.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(370, 370);
            label6.Name = "label6";
            label6.Size = new Size(131, 15);
            label6.TabIndex = 11;
            label6.Text = "Ημερομηνία Προβολής";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(377, 442);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(216, 23);
            textBox7.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 419);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 13;
            label7.Text = "label7";
            // 
            // MovieView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 489);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(txtViewCategory);
            Controls.Add(label2);
            Controls.Add(txtViewTitle);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "MovieView";
            Text = "Ταινία";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtViewTitle;
        private TextBox txtViewCategory;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
    }
}