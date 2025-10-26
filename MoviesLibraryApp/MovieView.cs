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
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace MoviesLibraryApp
{
    public partial class MovieView : Form
    {
        dbContext db = new dbContext();
        public MovieView(int movieID)
        {
            InitializeComponent();
            LoadMovieDetails(movieId);
            SetControlsReadOnly();
        }

        private void LoadMovieDetails(int movieID)
        {
            var movie = db.Movies
                          .Include(m => m.Category)
                          .Include(m => m.Media)
                          .Include(m => m.MovieActors).ThenInclude(ma => ma.Actor)
                          .FirstOrDefault(m => m.Id == movieID);
            if (movie == null)
            {
                MessageBox.Show("Δεν βρέθηκε η επιλεγμένη ταινία στη βάση δεδομένων.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // Γέμισμα των πεδίων προβολής
            txtViewTitle.Text = movie.Title ?? "";
            txtViewCategory.Text = movie.Category != null ? movie.Category.Name : "";
            txtViewMedia.Text = movie.Media != null ? movie.Media.Media : "";
            txtViewRating.Text = movie.Rating.HasValue ? movie.Rating.Value.ToString("0.0") : "";
            txtViewPubDate.Text = movie.PublishDate.HasValue ? movie.PublishDate.Value.ToString("dd/MM/yyyy") : "";
            txtViewWatcDate.Text = movie.WatchedDate.HasValue ? movie.WatchedDate.Value.ToString("dd/MM/yyyy") : "";

            txtViewActors.Text = string.Join(", ",
                movie.MovieActors
                     .Select(ma => ma.Actor?.Name)
                     .Where(n => !string.IsNullOrWhiteSpace(n)));



            if (!string.IsNullOrEmpty(movie.Picture) && File.Exists(movie.Picture))
            {
                pbMovieView.ImageLocation = movie.Picture;
            }
            else
            {
                pbMovieView.Image = null;
                pbMovieView.ImageLocation = null;
            }
        }

        private void SetControlsReadOnly()
        {
            // Κάνει όλα τα TextBox μόνο για προβολή
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.ReadOnly = true;
                    txt.BackColor = SystemColors.Control; // Για πιο “view-only” αίσθηση
                    txt.BorderStyle = BorderStyle.None;
                }
            }

        }
        private void MovieView_Load(object sender, EventArgs e)
        {

        }
    }
}
