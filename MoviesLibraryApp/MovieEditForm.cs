using Microsoft.EntityFrameworkCore;
using MoviesLibraryApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MoviesLibraryApp
{
    public partial class MovieEditForm : Form
    {
         dbContext db = new dbContext();

        public MovieEditForm()
        {
            InitializeComponent();
        }

        private void MovieEditForm_Load(object sender, EventArgs e)
        {
              LoadMovies(); 
        }
        private void LoadMovies()
        {
            cmbSelectMovie.DataSource = db.Movies
                .OrderBy(m => m.Title)
                .Select(m => new { m.Id, m.Title })
                .ToList();
            cmbSelectMovie.DisplayMember = "Title";
            cmbSelectMovie.ValueMember = "Id";
            cmbSelectMovie.SelectedIndex = -1; // κανένα default
        }
    }
}
