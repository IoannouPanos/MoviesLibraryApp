using MoviesLibraryApp.Models;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MoviesLibraryApp
{
    public partial class MovieView : Form
    {
        dbContext db = new dbContext();

        public MovieView(int movieID)
        {
            InitializeComponent();
            LoadMovieDetails(movieID);
            SetControlsReadOnly();

            // Dispose context όταν κλείνει η φόρμα
            this.FormClosed += (s, e) => db?.Dispose();
        }

        private void LoadMovieDetails(int movieID)
        {
            try
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

                // Null-safe ανάθεση πεδίων
                txtViewTitle.Text = movie.Title ?? "";
                txtViewCategory.Text = movie.Category?.Name ?? "";
                txtViewMedia.Text = movie.Media?.Media ?? "";
                txtViewRating.Text = movie.Rating.HasValue ? movie.Rating.Value.ToString("0.0") : "";
                txtViewPubDate.Text = movie.PublishDate.HasValue ? movie.PublishDate.Value.ToString("dd/MM/yyyy") : "";
                txtViewWatcDate.Text = movie.WatchedDate.HasValue ? movie.WatchedDate.Value.ToString("dd/MM/yyyy") : "";

                var actors = (movie.MovieActors ?? Enumerable.Empty<MovieActor>())
                             .Select(ma => ma.Actor?.Name)
                             .Where(n => !string.IsNullOrWhiteSpace(n));
                txtViewActors.Text = string.Join(", ", actors);

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
            catch (Exception ex)
            {
                MessageBox.Show("Σφάλμα κατά τη φόρτωση της ταινίας: " + ex.Message, "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Αναδρομική εκδοχή που καλύπτει nested controls
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

 


    }
}
