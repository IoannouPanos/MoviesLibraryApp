using MoviesLibraryApp.Models;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Net.Http;


namespace MoviesLibraryApp
{
    public partial class MovieView : Form
    {
        dbContext db = new dbContext();
        private static readonly HttpClient httpClient = new HttpClient();
        private const string OMDB_API_KEY = "86da02f4";

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

                _ = LoadMoviePlotAsync(movie.Title);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Σφάλμα κατά τη φόρτωση της ταινίας: " + ex.Message, "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadMoviePlotAsync(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                txtViewPlot.Text = "Δεν υπάρχει τίτλος για αναζήτηση στο OMDb API.";
                return;
            }

            try
            {
                // Δημιουργούμε URL κωδικοποιώντας τον τίτλο
                string url = $"https://www.omdbapi.com/?t={Uri.EscapeDataString(title)}&apikey={OMDB_API_KEY}&plot=full";

                // Αίτημα HTTP
                HttpResponseMessage response = await httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    txtViewPlot.Text = $"Σφάλμα κατά τη λήψη δεδομένων ({response.StatusCode}).";
                    return;
                }

                string json = await response.Content.ReadAsStringAsync();

                // Ανάλυση JSON
                var data = JObject.Parse(json);

                if (data["Response"]?.ToString() == "True")
                {
                    txtViewPlot.Text = data["Plot"]?.ToString() ?? "Δεν βρέθηκε περίληψη.";
                }
                else
                {
                    txtViewPlot.Text = $"Δεν βρέθηκε περίληψη για '{title}'.";
                }
            }
            catch (HttpRequestException)
            {
                txtViewPlot.Text = "Πρόβλημα σύνδεσης με το OMDb API.";
            }
            catch (Exception ex)
            {
                txtViewPlot.Text = "Σφάλμα κατά την ανάκτηση περίληψης: " + ex.Message;
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

        private void MovieView_Load(object sender, EventArgs e)
        {

        }
    }
}
