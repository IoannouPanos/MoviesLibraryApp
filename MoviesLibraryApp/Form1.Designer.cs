namespace MoviesLibraryApp
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
            menuStrip1 = new MenuStrip();
            mnbtnFindMovies = new ToolStripMenuItem();
            διαχείρησηΤαινιώνToolStripMenuItem = new ToolStripMenuItem();
            mnbtnCreateMovie = new ToolStripMenuItem();
            mnbtnEditMovie = new ToolStripMenuItem();
            mnbtnDelMovie = new ToolStripMenuItem();
            btnmnCategories = new ToolStripMenuItem();
            mnbtnMedia = new ToolStripMenuItem();
            mnbtnExit = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnbtnFindMovies, διαχείρησηΤαινιώνToolStripMenuItem, btnmnCategories, mnbtnMedia, mnbtnExit });
            menuStrip1.Location = new Point(2, 2);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(685, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnbtnFindMovies
            // 
            mnbtnFindMovies.Name = "mnbtnFindMovies";
            mnbtnFindMovies.Size = new Size(55, 20);
            mnbtnFindMovies.Text = "Ταινίες";
            mnbtnFindMovies.Click += mnbtnFindMovies_Click;
            // 
            // διαχείρησηΤαινιώνToolStripMenuItem
            // 
            διαχείρησηΤαινιώνToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnbtnCreateMovie, mnbtnEditMovie, mnbtnDelMovie });
            διαχείρησηΤαινιώνToolStripMenuItem.Name = "διαχείρησηΤαινιώνToolStripMenuItem";
            διαχείρησηΤαινιώνToolStripMenuItem.Size = new Size(124, 20);
            διαχείρησηΤαινιώνToolStripMenuItem.Text = "Διαχείρηση Ταινιών";
            // 
            // mnbtnCreateMovie
            // 
            mnbtnCreateMovie.Name = "mnbtnCreateMovie";
            mnbtnCreateMovie.Size = new Size(140, 22);
            mnbtnCreateMovie.Text = "Δημιουργία";
            mnbtnCreateMovie.Click += mnbtnCreateMovie_Click;
            // 
            // mnbtnEditMovie
            // 
            mnbtnEditMovie.Name = "mnbtnEditMovie";
            mnbtnEditMovie.Size = new Size(140, 22);
            mnbtnEditMovie.Text = "Επεξεργασία";
            mnbtnEditMovie.Click += mnbtnEditMovie_Click;
            // 
            // mnbtnDelMovie
            // 
            mnbtnDelMovie.Name = "mnbtnDelMovie";
            mnbtnDelMovie.Size = new Size(140, 22);
            mnbtnDelMovie.Text = "Διαγραφή";
            mnbtnDelMovie.Click += mnbtnDelMovie_Click;
            // 
            // btnmnCategories
            // 
            btnmnCategories.Name = "btnmnCategories";
            btnmnCategories.Size = new Size(80, 20);
            btnmnCategories.Text = "Κατηγορίες";
            btnmnCategories.Click += btnmnCategories_Click;
            // 
            // mnbtnMedia
            // 
            mnbtnMedia.Name = "mnbtnMedia";
            mnbtnMedia.Size = new Size(108, 20);
            mnbtnMedia.Text = "Μέσο Προβολής";
            mnbtnMedia.Click += mnbtnMedia_Click;
            // 
            // mnbtnExit
            // 
            mnbtnExit.Name = "mnbtnExit";
            mnbtnExit.Size = new Size(58, 20);
            mnbtnExit.Text = "Έξοδος";
            mnbtnExit.Click += mnbtnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 620);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Padding = new Padding(2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Βιβιλιοθήκη Ταινιών";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        //private void mnbtnFindMovies_Click(object sender, EventArgs e)
        //{
        //    MovieSearchForm frm = new MovieSearchForm();
        //    frm.MdiParent = this;
        //    frm.Show();

        //}

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem διαχείρησηΤαινιώνToolStripMenuItem;
        private ToolStripMenuItem btnmnCategories;
        private ToolStripMenuItem mnbtnMedia;
        private ToolStripMenuItem mnbtnExit;
        private ToolStripMenuItem mnbtnFindMovies;
        private ToolStripMenuItem mnbtnCreateMovie;
        private ToolStripMenuItem mnbtnEditMovie;
        private ToolStripMenuItem mnbtnDelMovie;
    }
}
