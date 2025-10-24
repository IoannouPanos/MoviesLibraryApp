using Microsoft.EntityFrameworkCore;
using MovieLibraryApp;
using MoviesLibraryApp.Models;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MoviesLibraryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void mnbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnbtn_Click(object sender, EventArgs e)
        {// Κάνω την φορμα parent
            MovieSearchForm frm = new MovieSearchForm();
            frm.MdiParent = this;
            frm.Show();

        }

        private void mnbtnCreateMovie_Click(object sender, EventArgs e)
        {
            MovieCreateForm frm = new MovieCreateForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnbtnEditMovie_Click(object sender, EventArgs e)
        {
            MovieEditForm frm = new MovieEditForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnbtnDelMovie_Click(object sender, EventArgs e)
        {
            MovieDeleteForm frm = new MovieDeleteForm();
           
            frm.Show();
        }

        private void btnmnCategories_Click(object sender, EventArgs e)
        {
            CategoryForm frm = new CategoryForm();
            frm.MdiParent = this;
            frm.Show();

        }
        private void mnbtnMedia_Click(object sender, EventArgs e)
        {
            MediaForm frm = new MediaForm();
            frm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnbtnFindMovies_Click(object sender, EventArgs e)
        {
            //foreach (Form child in this.MdiChildren)
            //{
            //    child.Close();
            //}
            MovieSearchForm frm = new MovieSearchForm();
            frm.MdiParent = this;
            frm.Show();
        }


    }
}
