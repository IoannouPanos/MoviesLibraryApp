using Microsoft.EntityFrameworkCore;
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
    public partial class MovieSearchForm : Form
    {
        dbContext db = new dbContext();
        public MovieSearchForm()
        {
            InitializeComponent();
        }

        private class RatingRange
        {
            public string Name { get; set; }
            public double? Min { get; set; }
            public double? Max { get; set; }
            public override string ToString() => Name;

        }

        private void MovieSearchForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadMedia();
            LoadRating();
        }
        private void LoadCategories()
        {
            {
                var categories = db.Categories
                                   .OrderBy(c => c.Name)
                                   .ToList();

                cmbSearceCategory.DataSource = categories;
                cmbSearceCategory.DisplayMember = "Name";
                cmbSearceCategory.ValueMember = "Id";
                cmbSearceCategory.SelectedIndex = -1; // κανένα default
            }
        }
        private void LoadMedia()
        {
            {
                var media = db.Media
                    .OrderBy(m => m.Media)
                    .ToList();

                cmbSearchPlatform.DataSource = media;
                cmbSearchPlatform.DisplayMember = "Media";
                cmbSearchPlatform.ValueMember = "Id";
                cmbSearchPlatform.SelectedIndex = -1; // Καμία επιλογή αρχικά
            }
        }
        private void LoadRating()
        {
            var ratingRanges = new List<RatingRange>
            {
                new RatingRange { Name = "Όλες", Min = null, Max = null },
                new RatingRange { Name = "0 - 2.9  Πολύ χαμηλή", Min = 0.0, Max = 2.9 },
                new RatingRange { Name = "3 - 5.9  Μέτρια", Min = 3.0, Max = 5.9 },
                new RatingRange { Name = "6 - 7.9  Καλή", Min = 6.0, Max = 7.9 },
                new RatingRange { Name = "8 - 8.9  Πολύ καλή", Min = 8.0, Max = 8.9 },
                new RatingRange { Name = "9 - 10  Εξαιρετική", Min = 9.0, Max = 10.0 }
            };

            cmbRating.DataSource = ratingRanges;
            cmbRating.DisplayMember = "Name";
            cmbRating.ValueMember = "Name";
            cmbRating.SelectedIndex = 0; // προεπιλογή "Όλες"
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
                // Include MovieActors and then Actor so that actor names are available client-side
                var query = db.Movies
                              .Include(m => m.Category)
                              .Include(m => m.Media)
                              .Include(m => m.MovieActors)
                                  .ThenInclude(ma => ma.Actor)
                              .AsQueryable();

                // Φίλτρο κατηγορίας
                if (cmbSearceCategory.SelectedIndex >= 0)
                {
                    int categoryId = (int)cmbSearceCategory.SelectedValue;
                    query = query.Where(m => m.CategoryId == categoryId);
                }

                // Φίλτρο μέσου
                if (cmbSearchPlatform.SelectedIndex >= 0)
                {
                    int mediaId = (int)cmbSearchPlatform.SelectedValue;
                    query = query.Where(m => m.MediaId == mediaId);
                }

                // Φίλτρο IMDb από cmbRating (server-side)
                if (cmbRating.SelectedItem is RatingRange range && (range.Min.HasValue || range.Max.HasValue))
                {
                    if (range.Min.HasValue)
                    {
                        query = query.Where(m => m.Rating >= range.Min.Value);
                    }
                    if (range.Max.HasValue)
                    {
                        query = query.Where(m => m.Rating <= range.Max.Value);
                    }
                }

                // <<<<<< CHECK πριν Select >>>>>> - τα MovieActors έχουν ήδη φορτωθεί λόγω Include/ThenInclude
                var checkData = query.ToList();
                MessageBox.Show("Φόρτωσα ταινίες: " + checkData.Count);

                var results = checkData
                    .Select(m => new
                    {
                        Id = m.Id,
                        Τίτλος = m.Title,
                        Ημερομηνία_Κυκλοφορίας = m.PublishDate.HasValue ? m.PublishDate.Value.ToString("dd/MM/yyyy") : "",
                        Κατηγορία = m.Category != null ? m.Category.Name : "",
                        Μέσο = m.Media != null ? m.Media.Media : "",
                        // Guard against null Actor and remove empty names
                        Ηθοποιοί = string.Join(", ", m.MovieActors
                                                     .Select(ma => ma.Actor?.Name)
                                                     .Where(name => !string.IsNullOrWhiteSpace(name))),
                        Βαθμολογία = m.Rating.HasValue ? m.Rating.Value.ToString("0.0") : "",
                        Εχω_Δει = m.Watched,
                        Ημερομηνία_Προβολής = m.WatchedDate.HasValue ? m.WatchedDate.Value.ToString("dd/MM/yyyy") : ""
                    })
                    .ToList();

                dgvSearchResult.DataSource = results;
                dgvSearchResult.Columns["Id"].Visible = false; // Απόκρυψη της στήλης Id
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadCategories();
            LoadMedia();
            LoadRating();
            dgvSearchResult.DataSource = null;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️. Φίλτρο (Αυτή η εντολή μεταφράζεται σε SQL)
                var query = db.Movies
                              .Include(m => m.Category)
                              .Include(m => m.Media)
                              .Where(m => m.Watched == "Όχι");

                // 2️. Φέρνουμε ΟΛΕΣ τις ταινίες που πληρούν το κριτήριο στη μνήμη (Client-side)
                // Εάν δεν υπάρχουν ταινίες, επιστρέφει κενή λίστα
                var availableMovies = query.ToList();

                if (availableMovies.Count == 0)
                {
                    MessageBox.Show("Δεν βρέθηκαν ταινίες (Watched = 'Όχι').", "Καμία ταινία", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSearchResult.DataSource = null;
                    return;
                }

                // 3️. Επιλέγουμε μία τυχαία ταινία από τη λίστα στη μνήμη (C#)
                Random random = new Random();
                int randomIndex = random.Next(availableMovies.Count);

                var randomMovie = availableMovies[randomIndex];

                // 4️. Δημιουργία του τελικού ανώνυμου αντικειμένου για το DataGridView
                var result = new
                {
                    Τίτλος = randomMovie.Title,
                    Ημερομηνία_Κυκλοφορίας = randomMovie.PublishDate.HasValue ? randomMovie.PublishDate.Value.ToString("dd/MM/yyyy") : "",
                    Κατηγορία = randomMovie.Category?.Name ?? "",
                    Μέσο = randomMovie.Media?.Media ?? "",
                    Βαθμολογία = randomMovie.Rating.HasValue ? randomMovie.Rating.Value.ToString("0.0") : ""
                };

                // 5️. Ανάθεση στο DataGridView
                var results = new List<object> { result };
                dgvSearchResult.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Προέκυψε σφάλμα κατά την επιλογή τυχαίας ταινίας:\n" + ex.Message, "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                // Παίρνουμε το ID της ταινίας από το DataGridView
                int movieId = Convert.ToInt32(dgvSearchResult.Rows[e.RowIndex].Cells["Id"].Value);

                // Δημιουργούμε και εμφανίζουμε τη φόρμα προβολής
                MovieView frm = new MovieView(movieId);
                frm.ShowDialog();
            }
        }
    }

}
