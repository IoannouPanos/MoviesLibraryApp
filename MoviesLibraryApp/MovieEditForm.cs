using Microsoft.EntityFrameworkCore;
using MoviesLibraryApp.Models;
using System;
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
            LoadCategories();
            LoadMedia();
        }

        private void LoadMovies()
        {
            cmbSelectMovie.DataSource = db.Movies
                .OrderBy(m => m.Title)
                .Select(m => new { m.Id, m.Title })
                .ToList();
            cmbSelectMovie.DisplayMember = "Title";
            cmbSelectMovie.ValueMember = "Id";
            cmbSelectMovie.SelectedIndex = -1; // no default
        }

        private void LoadCategories()
        {
            var categories = db.Categories
                               .OrderBy(c => c.Name)
                               .ToList();
            cmbEditCategory.DataSource = categories;
            cmbEditCategory.DisplayMember = "Name";
            cmbEditCategory.ValueMember = "Id";
            cmbEditCategory.SelectedIndex = -1;
        }

        private void LoadMedia()
        {
            var media = db.Media
                .OrderBy(m => m.Media)
                .ToList();
            cmbEditMedia.DataSource = media;
            cmbEditMedia.DisplayMember = "Media";
            cmbEditMedia.ValueMember = "Id";
            cmbEditMedia.SelectedIndex = -1;
        }

        private void btnSelectMovie_Click(object sender, EventArgs e)
        {
            if (cmbSelectMovie.SelectedIndex == -1)
            {
                MessageBox.Show("Επιλέξτε μια ταινία από τη λίστα.");
                return;
            }

            int selectedMovieId = (int)cmbSelectMovie.SelectedValue;
            
            var movie = db.Movies
                .Include(m => m.Category)
                .Include(m => m.Media)
                .Include(m => m.MovieActors)
                    .ThenInclude(ma => ma.Actor)
                .FirstOrDefault(m => m.Id == selectedMovieId);

            if (movie == null)
            {
                MessageBox.Show("Δεν βρέθηκε η επιλεγμένη ταινία στη βάση δεδομένων.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // --- ΓΕΜΙΖΩ ΤΑ ΠΕΔΙΑ TEXT ---            
            txtEditTitle.Text = movie.Title ?? "";

            txtEditActors.Text = string.Join(", ",
                (movie.MovieActors ?? Enumerable.Empty<MovieActor>())
                    .Select(ma => ma.Actor?.Name)
                    .Where(n => !string.IsNullOrWhiteSpace(n)));

            txtEditRating.Text = movie.Rating.HasValue ? movie.Rating.Value.ToString("0.0") : "";

            // ---- ΕΙΚΟΝΑ ----
            if (!string.IsNullOrEmpty(movie.Picture) && File.Exists(movie.Picture))
            {
                pictureBoxEdit.ImageLocation = movie.Picture;
            }
            else
            {
                pictureBoxEdit.Image = null;
                pictureBoxEdit.ImageLocation = null;
            }

            // --- ΕΠΙΛΟΓΗ CATERGORY ΚΑΙ MEDIA ----

            if (movie.CategoryId.HasValue)
                cmbEditCategory.SelectedValue = movie.CategoryId.Value;
            else
                cmbEditCategory.SelectedIndex = -1;

            if (movie.MediaId.HasValue)
                cmbEditMedia.SelectedValue = movie.MediaId.Value;
            else
                cmbEditMedia.SelectedIndex = -1;


            // Publish date (nullable)
            if (movie.PublishDate.HasValue)
            {
                dtpEditPublishDate.Value = movie.PublishDate.Value;
                // if you use ShowCheckBox = true, set Checked accordingly
                try { dtpEditPublishDate.Checked = true; } catch { }
            }
            else
            {
                try { dtpEditPublishDate.Checked = false; } catch { }
            }

            // Watched date (nullable)
            if (movie.WatchedDate.HasValue)
            {
                dtpEditWatchedDate.Value = movie.WatchedDate.Value;
                try { dtpEditWatchedDate.Checked = true; } catch { }
            }
            else
            {
                try { dtpEditWatchedDate.Checked = false; } catch { }
            }
        }
    }
}
