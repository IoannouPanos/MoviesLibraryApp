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

        private void MovieView_Load(object sender, EventArgs e)
        {

        }
    }
}
