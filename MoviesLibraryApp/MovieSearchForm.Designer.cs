namespace MoviesLibraryApp
{
    partial class MovieSearchForm
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            cmbSearceCategory = new ComboBox();
            groupBox3 = new GroupBox();
            cmbRating = new ComboBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label2 = new Label();
            cmbSearchPlatform = new ComboBox();
            btnRandom = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            label4 = new Label();
            dgvSearchResult = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResult).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbSearceCategory);
            groupBox1.Location = new Point(42, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(171, 81);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 19);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 7;
            label1.Text = "Κατηγορία";
            // 
            // cmbSearceCategory
            // 
            cmbSearceCategory.FormattingEnabled = true;
            cmbSearceCategory.Location = new Point(15, 41);
            cmbSearceCategory.Name = "cmbSearceCategory";
            cmbSearceCategory.Size = new Size(138, 23);
            cmbSearceCategory.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(cmbRating);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(467, 38);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(171, 81);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            // 
            // cmbRating
            // 
            cmbRating.FormattingEnabled = true;
            cmbRating.Location = new Point(18, 41);
            cmbRating.Name = "cmbRating";
            cmbRating.Size = new Size(138, 23);
            cmbRating.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 19);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 7;
            label3.Text = "Βαθμολογία";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cmbSearchPlatform);
            groupBox2.Location = new Point(257, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(171, 81);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 19);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 7;
            label2.Text = "Μέσο Προβολής";
            // 
            // cmbSearchPlatform
            // 
            cmbSearchPlatform.FormattingEnabled = true;
            cmbSearchPlatform.Location = new Point(15, 41);
            cmbSearchPlatform.Name = "cmbSearchPlatform";
            cmbSearchPlatform.Size = new Size(138, 23);
            cmbSearchPlatform.TabIndex = 6;
            // 
            // btnRandom
            // 
            btnRandom.Anchor = AnchorStyles.None;
            btnRandom.Cursor = Cursors.Hand;
            btnRandom.Location = new Point(485, 192);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(138, 45);
            btnRandom.TabIndex = 21;
            btnRandom.Text = "Τυχαία Επιλογή";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Location = new Point(272, 192);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 45);
            btnClear.TabIndex = 20;
            btnClear.Text = "Καθαρισμός";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(57, 192);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(138, 45);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Εύρεση";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label4.Location = new Point(272, 9);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 23;
            label4.Text = "Εύρεση Ταινίας";
            // 
            // dgvSearchResult
            // 
            dgvSearchResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearchResult.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSearchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSearchResult.DefaultCellStyle = dataGridViewCellStyle1;
            dgvSearchResult.Dock = DockStyle.Bottom;
            dgvSearchResult.Location = new Point(0, 370);
            dgvSearchResult.Name = "dgvSearchResult";
            dgvSearchResult.Size = new Size(666, 188);
            dgvSearchResult.TabIndex = 25;
            dgvSearchResult.CellDoubleClick += dgvSearchResult_CellDoubleClick;
            // 
            // MovieSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 558);
            ControlBox = false;
            Controls.Add(dgvSearchResult);
            Controls.Add(label4);
            Controls.Add(btnRandom);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MovieSearchForm";
            Text = "Εύρεση Ταινιών";
            WindowState = FormWindowState.Maximized;
            Load += MovieSearchForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbSearceCategory;
        private GroupBox groupBox3;
        private Label label3;
        private GroupBox groupBox2;
        private Label label2;
        private ComboBox cmbSearchPlatform;
        private Button btnRandom;
        private Button btnClear;
        private Button btnSearch;
        private Label label4;
        private ComboBox cmbRating;
        private DataGridView dgvSearchResult;
    }
}