using MovieApp.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Mappers
{
    public static class TmdbMapper
    {
        public static Movie ToMovie(this TmdbMovie dto, string imageBaseUrl, string posterSize)
        {
            if (dto == null) return null;

            DateTime? releaseDate = null;
            if (DateTime.TryParseExact(dto.release_date, "yyyy-MM-dd", CultureInfo.InvariantCulture,
                                       DateTimeStyles.None, out var dt))
            {
                releaseDate = dt;
            }

            var posterFull = string.IsNullOrWhiteSpace(dto.poster_path)
                ? null
                : $"{imageBaseUrl}{posterSize}{dto.poster_path}";

            return new Movie
            {
                TMDBId = dto.id,
                Title = dto.title ?? string.Empty,
                Overview = dto.overview,
                ReleaseDate = releaseDate,
                PosterPath = posterFull,
                IsManual = false,
                CreatedAt = DateTime.Now
            };
        }
    }
}
