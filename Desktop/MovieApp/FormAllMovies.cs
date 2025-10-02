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
    public partial class FormAllMovies : Form
    {
        private readonly MovieRepository _repo;
        public FormAllMovies()
        {
            InitializeComponent();
            _repo = new MovieRepository();
        }

        private void FormAllMovies_Load(object sender, EventArgs e)
        {
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
            gridView1.Columns["ReleaseDate"].Caption = "Filmin Çıkış Tarihi";
            gridView1.Columns["PosterPath"].Caption = "Film Görseli";
            gridView1.Columns["IsManual"].Caption = "Manuel Mi?";
            gridView1.Columns["CreatedAt"].Caption = "Oluşturulma Tarihi";







        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            
        }
       
    }
}
