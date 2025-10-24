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

namespace MovieLibraryApp
{
    public partial class MediaForm : Form
    {
        dbContext db = new dbContext();
        public MediaForm()
        {
            InitializeComponent();
        }

        private void MediaForm_Load(object sender, EventArgs e)
        {
            dgvMedia.DataSource = db.Media.ToList();
            dgvMedia.Columns["Movies"].Visible = false;  // Κρύβει τη στήλη με τις ταινίες
        }
        // =============================
        // ΠΡΟΣΘΗΚΗ ΝΕΟΥ ΜΕΣΟΥ ΠΡΟΒΟΛΗΣ
        // =============================
        private void btnAddMedia_Click(object sender, EventArgs e)
        {
            if (txtAddMedia.Text.Length > 0)
            {
                try
                {
                    Medium newMedia = new Medium();
                    newMedia.Media = txtAddMedia.Text;
                    db.Media.Add(newMedia);
                    db.SaveChanges();
                    dgvMedia.DataSource = db.Media.ToList();
                    txtAddMedia.Clear();
                    MessageBox.Show("Το Μέσο Προβολής ενημερώθηκε επιτυχώς!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // ============================================
        // ΕΠΕΞΕΡΓΑΣΙΑ ΚΑΤΗΓΟΡΙΑΣ ΜΕ TEXTBOX ΚΑΙ BUTTON
        // ============================================
        private void dgvMedia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedMedia = (Medium)dgvMedia.Rows[e.RowIndex].DataBoundItem;
                txtEditMedia.Text = selectedMedia.Media;
            }
        }
        private void btnEditMedia_Click(object sender, EventArgs e)
        {
            if (dgvMedia.CurrentRow != null)
            {
                var selectedMedia = (Medium)dgvMedia.CurrentRow.DataBoundItem;
                if (selectedMedia != null && txtEditMedia.Text.Length > 0)
                {
                    try
                    {
                        selectedMedia.Media = txtEditMedia.Text;
                        db.SaveChanges();
                        dgvMedia.DataSource = db.Media.ToList();
                        txtEditMedia.Clear();
                        MessageBox.Show("Το Μέσο Προβολής ενημερώθηκε επιτυχώς!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Σφάλμα: " + ex.Message);
                    }
                }

            }
        }
        // ==========================
        // ΔΙΑΓΡΑΦΗ ΚΑΤΗΓΟΡΙΑΣ
        // ==========================
        private void btnDelMedia_Click(object sender, EventArgs e)
        {
            if (dgvMedia.CurrentRow != null)
            {
                var media = (Medium)dgvMedia.CurrentRow.DataBoundItem;

                db.Media.Remove(media);
                db.SaveChanges();
                dgvMedia.DataSource = db.Media.ToList();
                txtEditMedia.Clear();
                MessageBox.Show("Το Μέσο Προβολής διαγράφηκε!");

            }

        }
    }
}
