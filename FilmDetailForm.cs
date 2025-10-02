using DevExpress.XtraGrid;
using MovieApp.Data;
using MovieApp.Models;
using MovieApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class FilmDetailForm : Form
    {
        private readonly Movie _movie;
        private readonly RatingRepository _ratingRepo;
        public FilmDetailForm(Movie movie)
        {
            InitializeComponent();
            _movie = movie;
            _ratingRepo = new RatingRepository();

            LoadMovieDetails();
            LoadRatings();
            this.ActiveControl = null;
        }
        private void LoadMovieDetails()
        {
            
            // Title TextEdit'e yazdır
            textEdit1.Text = _movie.Title;

            // Overview RichTextBox'a yazdır
            richTextBox1.Text = _movie.Overview;

            // ReleaseDate  label'a yazdır
            lblReleaseDate.Text = $"Çıkış Tarihi: {_movie.ReleaseDate?.ToString("dd.MM.yyyy") ?? "-"}\n";

            // Poster yükleme
            if (!string.IsNullOrEmpty(_movie.PosterPath))
            {
                try
                {
                    if (_movie.IsManual && File.Exists(_movie.PosterPath))
                    {
                        picPoster.Image = Image.FromFile(_movie.PosterPath);
                    }
                    else
                    {
                        picPoster.Image = GetImageFromUrl(_movie.PosterPath);
                    }
                }
                catch
                {
                    picPoster.Image = null;
                }
            }
        }
        private void LoadRatings()
        {
           
            //double avg = _ratingRepo.GetAverageRating(_movie.Id);

            var ratings = _ratingRepo.GetRatingsByMovieId(_movie.Id);

            double avg1 = 0.0;
            if (ratings.Count > 0)
                avg1 = ratings.Average(r => r.RatingValue); // Ratings tablosundaki tüm RatingValue'ları alıp ortalama

            lblAverageRating.Text = $"Ortalama Puan: {avg1:F1}/10";

            if (ratings.Count > 0)
            {
                
                var lastRating = ratings.OrderByDescending(r => r.CreatedAt).First();
                lblUserRating.Text = $"Son Puan: {lastRating.RatingValue}/10";
                txtUserNote.Text = lastRating.Note;
            }
            else
            {
                lblUserRating.Text = "Son Puan: -";
                txtUserNote.Text = "";
            }
        }
        // Bu metod sınıf içinde eklenir
        private Image GetImageFromUrl(string url)
        {
            if (string.IsNullOrEmpty(url) || !url.StartsWith("http")) return null;
            using (var wc = new WebClient())
            {
                byte[] bytes = wc.DownloadData(url);
                using (var ms = new MemoryStream(bytes))
                {
                    return Image.FromStream(ms);
                }
            }
        }
        private void FilmDetailForm_Load(object sender, EventArgs e)
        {

            this.ActiveControl = null;
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
           
        }

        private async void btnRecommend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRecommendEmail.Text))
            {
                MessageBox.Show("Lütfen bir e-posta adresi giriniz.");
                return;
            }

            try
            {
                // App.config üzerinden bilgileri alıyoruz
                var host = System.Configuration.ConfigurationManager.AppSettings["EmailHost"];
                var port = int.Parse(System.Configuration.ConfigurationManager.AppSettings["EmailPort"]);
                var user = System.Configuration.ConfigurationManager.AppSettings["EmailUser"];
                var pass = System.Configuration.ConfigurationManager.AppSettings["EmailPass"];

                var emailService = new EmailService(host, port, user, pass);

                string subject = $"Film Tavsiyesi: {_movie.Title}";
                string body = $@"
            <h2>{_movie.Title}</h2>
            <p>{_movie.Overview}</p>
            <p><b>Çıkış Tarihi:</b> {_movie.ReleaseDate?.ToString("dd.MM.yyyy")}</p>
            {(string.IsNullOrEmpty(_movie.PosterPath) ? "" : $"<img src='{_movie.PosterPath}' width='200'/>")}
        ";

                await emailService.SendEmailAsync(txtRecommendEmail.Text, subject, body);

                MessageBox.Show("Tavsiye e-postası başarıyla gönderildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderilemedi: " + ex.Message);
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
