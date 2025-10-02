using System;

namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public int? TMDBId { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string PosterPath { get; set; }
        public bool IsManual { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
