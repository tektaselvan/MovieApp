using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using MovieApp.Data;
using MovieApp.Models;
using MovieApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class FormMovies : Form
    {
        
        private readonly MovieRepository _repo;
        private string selectedPosterPath;

        public FormMovies()
        {
            InitializeComponent();
            _repo = new MovieRepository();
        }

        private void FormMovies_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            progressBarControl1.Visible = false;
            gridControl1.ContextMenuStrip = contextMenuStrip1;
            LoadMovies();
        }
        private void LoadMovies()
        {
            var movies = _repo.GetAllMovies(); 
            gridControl1.DataSource = movies;

            // GridView ayarları
            gridView1.Columns["Id"].Visible = false;
            gridView1.Columns["TMDBId"].Visible = false;
            gridView1.Columns["IsDeleted"].Visible = false;
            
            gridView1.Columns["Title"].Caption = "Film Adı";
            gridView1.Columns["Overview"].Caption = "Film Açıklaması";
            gridView1.Columns["PosterPath"].Caption = "Film Görseli";
            gridView1.Columns["ReleaseDate"].Caption = "Filmin Çıkış Tarihi";
            gridView1.Columns["IsManual"].Caption = "Manuel Mi?";
            gridView1.Columns["CreatedAt"].Caption = "Oluşturulma Tarihi";

        }
       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime? releaseDate = null;
            if (dateRelease.EditValue != null && DateTime.TryParse(dateRelease.EditValue.ToString(), out DateTime dt))
            {
                releaseDate = dt;
            }

            if (string.IsNullOrEmpty(selectedPosterPath))
            {
                XtraMessageBox.Show("Lütfen bir afiş görseli seçin.");
                return;
            }

            var movie = new Movie
            {
                Title = txtTitle.Text.Trim(),
                Overview = richTextBox1.Text.Trim(),
                ReleaseDate = releaseDate,
                PosterPath = selectedPosterPath,
                IsManual = true
            };

            int newId = _repo.AddMovie(movie);
            if (newId > 0)
            {
                XtraMessageBox.Show("Film başarıyla eklendi.");
                LoadMovies(); // gridi güncelle

                // Araçları temizle
                txtTitle.Text = "";
                richTextBox1.Text = "";
                dateRelease.EditValue = null;
                txtPosterPath.Text = "";
                selectedPosterPath = null;
            }
            else
            {
                XtraMessageBox.Show("Film eklenirken bir hata oluştu.");
            }
        }


        private async void btnImportMovies_Click(object sender, EventArgs e)
        {
            ImportMoviesFromApiAsync();
        }

        private void btnAllMovies_Click(object sender, EventArgs e)
        {
            var f = new FormAllMovies();
            f.ShowDialog();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "IsManual")
            {
                e.DisplayText = (bool)e.Value ? "Manuel" : "API";
            }
        }

        private void btnSelectPoster_Click(object sender, EventArgs e)
        {
            using (var ofd = new DevExpress.XtraEditors.XtraOpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Filmin Afiş Görselini Seçin";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedPosterPath = ofd.FileName;
                    txtPosterPath.Text = selectedPosterPath; 
                }
            }
        }


        private async Task ImportMoviesFromApiAsync()
        {
            btnImportMovies.Enabled = false;
            progressBarControl1.Visible = true;
            progressBarControl1.EditValue = 0;
            progressBarControl1.Properties.Maximum = 1000;
            lblProgress.Visible = true;

            var repo = new MovieRepository();
            var apiKey = ConfigurationManager.AppSettings["TmdbApiKey"];
            var service = new TmdbService(apiKey, repo);

            var startTime = DateTime.Now;

            try
            {
                int added = await service.SeedMoviesAsync(1000, (currentAdded) =>
                {
                    this.Invoke((Action)(() =>
                    {
                        progressBarControl1.EditValue = currentAdded;
                        var elapsed = DateTime.Now - startTime;
                        lblProgress.Text = $"Filmler ekleniyor... ({currentAdded}/1000) - Geçen süre: {elapsed.Minutes}m {elapsed.Seconds}s";
                    }));
                });

                XtraMessageBox.Show($"{added} yeni film eklendi.");
                LoadMovies();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                progressBarControl1.Visible = false;
                lblProgress.Visible = false;
                btnImportMovies.Enabled = true;
            }
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void filmDetaylarınıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() is Movie selectedMovie)
            {
                using (var form = new FilmDetailForm(selectedMovie))
                {
                    form.ShowDialog();
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen bir film seçin.");
            }
        }

        private void filmiPuanlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() is Movie selectedMovie)
            {
                using (var form = new FilmRatingForm(selectedMovie.Id, selectedMovie.Title))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadMovies();
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen bir film seçin.");
            }
        }

        private void filmiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length == 0)
            {
                XtraMessageBox.Show("Lütfen silmek istediğiniz filmi seçin.");
                return;
            }
            var rowHandle = gridView1.GetSelectedRows()[0];
            var movie = gridView1.GetRow(rowHandle) as Movie;
            if (movie == null)
                return;
            var confirm = XtraMessageBox.Show($"\"{movie.Title}\" filmini silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _repo.SoftDeleteMovie(movie.Id);
                LoadMovies();
            }
        }
    }
}
