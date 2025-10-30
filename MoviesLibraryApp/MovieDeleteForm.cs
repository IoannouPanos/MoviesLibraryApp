using MoviesLibraryApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesLibraryApp
{
    public partial class MovieDeleteForm : Form
    {
        dbContext db = new dbContext();
        public MovieDeleteForm()
        {
            InitializeComponent();
        }

        private void MovieDeleteForm_Load(object sender, EventArgs e)
        {
            dgvDelMovie.DataSource = db.Movies
                .Select(m => new
                {
                    //m.Id,
                    m.Title,
                }).ToList();

            LoadMovies();
        }

        private void LoadMovies()
        {
            cmbMovies.DataSource = db.Movies
                .OrderBy(m => m.Title)
                .Select(m => new { m.Id, m.Title })
                .ToList();
            cmbMovies.DisplayMember = "Title";
            cmbMovies.ValueMember = "Id";
            cmbMovies.SelectedIndex = -1; // κανένα default

        }


        private void BtnDelMovie_Click(object sender, EventArgs e)
        {
            if (dgvDelMovie.CurrentRow != null)
            {
                //var movie = db.Movies.Find((int)dgvDelMovie.CurrentRow.Cells["Id"].Value);
                int movieId = (int)dgvDelMovie.CurrentRow.Cells["Id"].Value;
                var movie = db.Movies.Find(movieId);
                if (movie != null)
                {
                    // ✅ Μήνυμα επιβεβαίωσης
                    DialogResult result = MessageBox.Show(
                        $"Είστε σίγουρος ότι θέλετε να διαγράψετε την ταινία:\n\n{movie.Title} ;",
                        "Επιβεβαίωση Διαγραφής",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    // Αν πατήσει ΟΧΙ -> ακύρωση
                    if (result == DialogResult.No)
                    {
                        return;
                    }

                    var movieActors = db.MovieActors.Where(ma => ma.MovieId == movieId).ToList();
                    db.MovieActors.RemoveRange(movieActors);

                    db.Movies.Remove(movie);
                    db.SaveChanges();
                    dgvDelMovie.DataSource = db.Movies
                        .Select(m => new
                        {
                            m.Id,
                            m.Title,
                        }).ToList();
                    MessageBox.Show("Η ταινία διαγράφηκε με επιτυχία!");
                }
            }

            LoadMovies();
        }
        private void btnFindMovie_Click(object sender, EventArgs e)
        {
            if (cmbMovies.SelectedIndex == -1)
            {
                MessageBox.Show("Επιλέξτε μια ταινία από τη λίστα.");
                return;
            }

            int selectedMovieId = (int)cmbMovies.SelectedValue;
            var selectedMovie = db.Movies
                .Where(m => m.Id == selectedMovieId)
                .Select(m => new{m.Id,m.Title}).ToList();

            dgvDelMovie.DataSource = selectedMovie;
        }
    }
}
