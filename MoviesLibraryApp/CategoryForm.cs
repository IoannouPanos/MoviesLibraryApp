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
    public partial class CategoryForm : Form
    {
        dbContext db = new dbContext();


        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnNewCat_MouseHover(object sender, EventArgs e)
        {

        }
        // ==========================
        // ΦΟΡΤΩΣΗ ΚΑΤΗΓΟΡΙΩΝ ΣΤΟ GRID
        // ==========================
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            dgvCategory.DataSource = db.Categories.ToList();
            dgvCategory.Columns["Movies"].Visible = false;  // Κρύβει τη στήλη με τις ταινίες
        }
        // ==========================
        // ΠΡΟΣΘΗΚΗ ΝΕΑΣ ΚΑΤΗΓΟΡΙΑΣ
        // ==========================
        private void btnAddCat_Click(object sender, EventArgs e)
        {
            if (txtNewCat.Text.Length > 0)
            {
                try
                {
                    Category newCat = new Category();
                    newCat.Name = txtNewCat.Text;
                    db.Categories.Add(newCat);
                    db.SaveChanges();
                    dgvCategory.DataSource = db.Categories.ToList();
                    txtNewCat.Clear();
                    MessageBox.Show("Η κατηγορία προστέθηκε επιτυχώς");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // ==========================
        // ΔΙΑΓΡΑΦΗ ΚΑΤΗΓΟΡΙΑΣ
        // ==========================
        private void btnDelCat_Click(object sender, EventArgs e)
        {
            if (dgvCategory.CurrentRow != null)
            {
                var category = (Category)dgvCategory.CurrentRow.DataBoundItem;

                //Προαιρετικός έλεγχος 
                 if (db.Movies.Any(m => m.CategoryId == category.Id))
                {
                    MessageBox.Show("Η κατηγορία χρησιμοποιείται από ταινίες. Δεν μπορεί να διαγραφεί.");
                    return;
                }

                db.Categories.Remove(category);
                db.SaveChanges();
                dgvCategory.DataSource = db.Categories.ToList();
                txtEditCat.Clear();
                MessageBox.Show("Η κατηγορία διαγράφηκε επιτυχώς");
            }
        }
        // ==========================================
        // INLINE EDIT (Αλλαγή μέσα στο DataGridView)
        // ==========================================
        private void dgvCategory_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                db.SaveChanges();
                txtEditCat.Clear();
                MessageBox.Show("Η κατηγορία ενημερώθηκε επιτυχώς!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Σφαλμα: " + ex.Message);
            }
        }

        //2ος τρόπος
        // Αποθήκευση αλλαγών στην κατηγορία με την χρήση TextBox και Button

        // ======================================================
        // ΕΠΙΛΟΓΗ ΓΡΑΜΜΗΣ → ΕΜΦΑΝΙΣΗ ΣΤΟ TextBox ΓΙΑ ΕΠΕΞΕΡΓΑΣΙΑ
        // ======================================================
        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedCategory = (Category)dgvCategory.Rows[e.RowIndex].DataBoundItem;
                txtEditCat.Text = selectedCategory.Name;
            }
        }
        // ==========================
        // ΕΠΕΞΕΡΓΑΣΙΑ ΜΕ TEXTBOX ΚΑΙ ΚΟΥΜΠΙ
        // ==========================
        private void btnEditCat_Click(object sender, EventArgs e)
        {
               if (dgvCategory.CurrentRow != null)
               {
                   var selectedCategory = (Category)dgvCategory.CurrentRow.DataBoundItem;
                   if (selectedCategory != null && txtEditCat.Text.Length > 0)
                   {
                       try
                       {
                           selectedCategory.Name = txtEditCat.Text;
                           db.SaveChanges();
                           dgvCategory.DataSource = db.Categories.ToList();
                           txtEditCat.Clear();
                           MessageBox.Show("Η κατηγορία ενημερώθηκε επιτυχώς!");
                       }
                       catch (Exception ex)
                       {
                           MessageBox.Show("Σφάλμα: " + ex.Message);
                       }
                   }  

               }
        }
    }
}
