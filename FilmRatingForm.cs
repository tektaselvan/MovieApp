using DevExpress.XtraEditors;
using MovieApp.Data;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class FilmRatingForm : Form
    {
        private readonly int _movieId;
        private readonly string _movieTitle; // Film adını saklamak için
        private readonly RatingRepository _ratingRepo;

        public FilmRatingForm(int movieId, string movieTitle)
        {
            InitializeComponent();
            _movieId = movieId;
            _movieTitle = movieTitle; // ata
            _ratingRepo = new RatingRepository();

            // NumericUpDown ayarları
            nudRating.Minimum = 1;
            nudRating.Maximum = 10;
            nudRating.Value = 5;
        }

        private void FilmRatingForm_Load(object sender, EventArgs e)
        {
            lblMovieTitle.Text = _movieTitle;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var rating = new Rating
            {
                MovieId = _movieId,
                UserIdentifier = null, // opsiyonel
                RatingValue = (byte)nudRating.Value,
                Note = richTextBox1.Text
            };

            _ratingRepo.AddRating(rating);

            XtraMessageBox.Show("Puan ve not kaydedildi!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lblMovieTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
