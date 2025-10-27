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
using System.Globalization;
using System.IO;

namespace MoviesLibraryApp
{
    public partial class MovieCreateForm : Form
    {
        dbContext db = new dbContext();
        public MovieCreateForm()
        {
            InitializeComponent();
        }
        private string selectedImagePath = null;
        private void MovieCreateForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadMedia();
        }
        private void LoadCategories()
        {

            {
                var categories = db.Categories
                                   .OrderBy(c => c.Name)
                                   .ToList();

                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";
                cmbCategory.SelectedIndex = -1; // κανένα default
            }
        }
        private void LoadMedia()
        {

            {
                var media = db.Media
                    .OrderBy(m => m.Media)
                    .ToList();

                cmbMedia.DataSource = media;
                cmbMedia.DisplayMember = "Media";
                cmbMedia.ValueMember = "Id";
                cmbMedia.SelectedIndex = -1; // Καμία επιλογή αρχικά
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            // Έλεγχος για κενά πεδία
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                cmbCategory.SelectedIndex == -1 ||
                cmbMedia.SelectedIndex == -1)
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε Τίτλο, Κατηγορία και Μέσο Προβολής.");
                return;
            }
            // Έλεγχος και μετατροπή βαθμολογίας
            if (!double.TryParse(txtRating.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double rating))
            {
                MessageBox.Show("Η βαθμολογία πρέπει να είναι αριθμός με τελεία (π.χ. 7.5).");
                return;
            }
            if (rating < 0 || rating > 10)
            {
                MessageBox.Show("Η βαθμολογία πρέπει να είναι μεταξύ 0 και 10.");
                return;
            }

            string relativeImagePath = null;

            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                // Δημιουργούμε φάκελο Images μέσα στον φάκελο εκτέλεσης
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                Directory.CreateDirectory(imagesFolder);

                // Δημιουργούμε το τελικό path και αντιγράφουμε το αρχείο
                string destFileName = Path.Combine(imagesFolder, Path.GetFileName(selectedImagePath));
                File.Copy(selectedImagePath, destFileName, true);

                // Αποθηκεύουμε το σχετικό path (για την βάση)
                relativeImagePath = Path.Combine("Images", Path.GetFileName(selectedImagePath));
            }

            // 1️. Δημιουργία νέας ταινίας
            Movie newMovie = new Movie
            {
                Title = txtTitle.Text,
                PublishDate = dtpPublishDate.Value,
                CategoryId = (int)cmbCategory.SelectedValue,
                MediaId = (int)cmbMedia.SelectedValue,
                Rating = rating,
                Picture = relativeImagePath,

            };
            if (rdBtnYes.Checked)
            {
                newMovie.Watched = "Ναι";
                newMovie.WatchedDate = dtpWatchedDate.Value;
            }
            else
            {
                newMovie.Watched = "Όχι";
                newMovie.WatchedDate = null;
            }
            try
            {
                db.Movies.Add(newMovie);
                db.SaveChanges();

                // 2️. Αποθήκευση Actors (Πολλά-προς-Πολλά)

                if (!string.IsNullOrWhiteSpace(txtActors.Text))
                {
                    var actorNames = txtActors.Text
                        .Split(',')
                        .Select(a => a.Trim())
                        .Where(a => !string.IsNullOrWhiteSpace(a))
                        .ToList();

                    // Φέρνουμε όσους υπάρχουν ήδη στη βάση (case-insensitive)
                    var existingActors = db.Actors
                        .Where(a => actorNames.Contains(a.Name))
                        .ToList();

                    var newActors = new List<Actor>();

                    foreach (var name in actorNames)
                    {
                        var actor = existingActors
                            .FirstOrDefault(a => string.Equals(a.Name, name, StringComparison.OrdinalIgnoreCase));

                        if (actor == null)
                        {
                            actor = new Actor { Name = name };
                            newActors.Add(actor);
                        }

                        db.MovieActors.Add(new MovieActor
                        {
                            Movie = newMovie,
                            Actor = actor
                        });
                    }

                    // Προσθέτουμε μαζικά μόνο τους νέους ηθοποιούς (όχι SaveChanges σε κάθε loop)
                    if (newActors.Any())
                        db.Actors.AddRange(newActors);

                    db.SaveChanges();
                }







                //if (!string.IsNullOrWhiteSpace(txtActors.Text))
                //{
                //    string[] actors = txtActors.Text.Split(',');

                //    foreach (var actorName in actors)
                //    {
                //        string cleanName = actorName.Trim();
                //        if (string.IsNullOrEmpty(cleanName)) continue;

                //        // Έλεγχος αν υπάρχει ήδη ο ηθοποιός
                //        Actor actor = db.Actors.FirstOrDefault(a => a.Name == cleanName);

                //        if (actor == null)
                //        {
                //            actor = new Actor { Name = cleanName };
                //            db.Actors.Add(actor);
                //            db.SaveChanges();
                //        }

                //        // Δημιουργία σύνδεσης στη MovieActors
                //        db.MovieActors.Add(new MovieActor
                //        {
                //            MovieId = newMovie.Id,
                //            ActorId = actor.Id
                //        });
                //    }

                //    db.SaveChanges();
                //}

                // 3️. Προβολή μόνο της νέας ταινίας στο DataGrid
                dgvAddMovie.DataSource = db.Movies
                    .Where(m => m.Id == newMovie.Id)
                    .Select(m => new
                    {
                        Τίτλος = m.Title,
                        Ημερομηνία_Κυκλοφορίας = m.PublishDate.HasValue ? m.PublishDate.Value.ToString("dd/MM/yyyy") : "",
                        Κατηγορία = m.Category != null ? m.Category.Name : "",
                        Μέσο = m.Media != null ? m.Media.Media : "",
                        Ηθοποιοί = string.Join(", ", m.MovieActors.Select(ma => ma.Actor.Name)),
                        Βαθμολογία = m.Rating.HasValue ? m.Rating.Value.ToString("0.0") : "",
                        Εχω_Δει = m.Watched,
                        Ημερομηνία_Προβολής = m.WatchedDate.HasValue ? m.WatchedDate.Value.ToString("dd/MM/yyyy") : ""

                    })
                    .ToList();

                MessageBox.Show("Η ταινία προστέθηκε επιτυχώς!");

                // 4️. Καθαρισμός πεδίων
                txtTitle.Clear();
                txtActors.Clear();
                cmbCategory.SelectedIndex = -1;
                cmbMedia.SelectedIndex = -1;
                rdBtnNo.Checked = true;
                txtRating.Clear();

                // Μηδενισμός ημερομηνιών σε Today
                dtpPublishDate.Value = DateTime.Today;
                dtpWatchedDate.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Σφάλμα κατά την προσθήκη της ταινίας: " + ex.InnerException?.Message);
            }
        }
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
                    
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Εικόνες|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
                pictureBox.ImageLocation = selectedImagePath;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    
    }
};