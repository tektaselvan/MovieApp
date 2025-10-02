using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MovieApp.Data
{
    public class MovieRepository
    {
     
            /// <summary>
            /// Yeni film ekler ve Id'sini döner.
            /// </summary>
            public int AddMovie(Movie m)
            {
                var sql = @"
                INSERT INTO dbo.Movies 
                (TMDBId, Title, Overview, ReleaseDate, PosterPath, IsManual, IsDeleted, CreatedAt)
                VALUES 
                (@TMDBId, @Title, @Overview, @ReleaseDate, @PosterPath, @IsManual, 0, GETDATE());
                SELECT SCOPE_IDENTITY();";

                var idObj = DbHelper.ExecuteScalar(sql,
                    new SqlParameter("@TMDBId", (object)m.TMDBId ?? DBNull.Value),
                    new SqlParameter("@Title", m.Title ?? string.Empty),
                    new SqlParameter("@Overview", (object)m.Overview ?? DBNull.Value),
                    new SqlParameter("@ReleaseDate", (object)m.ReleaseDate ?? DBNull.Value),
                    new SqlParameter("@PosterPath", (object)m.PosterPath ?? DBNull.Value),
                    new SqlParameter("@IsManual", m.IsManual ? 1 : 0)
                );

                return Convert.ToInt32(idObj);
            }

            /// <summary>
            /// Var olan filmi günceller.
            /// </summary>
            public void UpdateMovie(Movie m)
            {
                var sql = @"
                UPDATE dbo.Movies
                SET Title=@Title, Overview=@Overview, ReleaseDate=@ReleaseDate, 
                    PosterPath=@PosterPath, IsManual=@IsManual, UpdatedAt=GETDATE()
                WHERE Id=@Id";

                DbHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@Title", m.Title ?? string.Empty),
                    new SqlParameter("@Overview", (object)m.Overview ?? DBNull.Value),
                    new SqlParameter("@ReleaseDate", (object)m.ReleaseDate ?? DBNull.Value),
                    new SqlParameter("@PosterPath", (object)m.PosterPath ?? DBNull.Value),
                    new SqlParameter("@IsManual", m.IsManual ? 1 : 0),
                    new SqlParameter("@Id", m.Id)
                );
            }

            /// <summary>
            /// Filmi soft-delete yapar (silmez, IsDeleted=1 işaretler).
            /// </summary>
            public void SoftDeleteMovie(int movieId)
            {
                var sql = "UPDATE dbo.Movies SET IsDeleted = 1, UpdatedAt = GETDATE() WHERE Id=@Id";
                DbHelper.ExecuteNonQuery(sql, new SqlParameter("@Id", movieId));
            }

            /// <summary>
            /// Id'ye göre film getirir.
            /// </summary>
            public Movie GetMovieById(int id)
            {
                var sql = "SELECT * FROM dbo.Movies WHERE Id=@Id";

                var list = DbHelper.ExecuteReaderToList(sql, reader => new Movie
                {
                    Id = (int)reader["Id"],
                    TMDBId = reader["TMDBId"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["TMDBId"]),
                    Title = reader["Title"].ToString(),
                    Overview = reader["Overview"] == DBNull.Value ? null : reader["Overview"].ToString(),
                    ReleaseDate = reader["ReleaseDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["ReleaseDate"]),
                    PosterPath = reader["PosterPath"] == DBNull.Value ? null : reader["PosterPath"].ToString(),
                    IsManual = Convert.ToBoolean(reader["IsManual"]),
                    IsDeleted = Convert.ToBoolean(reader["IsDeleted"]),
                    CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                }, new SqlParameter("@Id", id));

                return list.Count > 0 ? list[0] : null;
            }

            /// <summary>
            /// Tüm filmleri listeler. Silinmiş olanları dahil etmek için parametre true verilebilir.
            /// </summary>
            public List<Movie> GetAllMovies(bool includeDeleted = false)
            {
                var sql = includeDeleted ? "SELECT * FROM dbo.Movies"
                                         : "SELECT * FROM dbo.Movies WHERE IsDeleted=0";

                return DbHelper.ExecuteReaderToList(sql, reader => new Movie
                {
                    Id = (int)reader["Id"],
                    TMDBId = reader["TMDBId"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["TMDBId"]),
                    Title = reader["Title"].ToString(),
                    Overview = reader["Overview"] == DBNull.Value ? null : reader["Overview"].ToString(),
                    ReleaseDate = reader["ReleaseDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["ReleaseDate"]),
                    PosterPath = reader["PosterPath"] == DBNull.Value ? null : reader["PosterPath"].ToString(),
                    IsManual = Convert.ToBoolean(reader["IsManual"]),
                    IsDeleted = Convert.ToBoolean(reader["IsDeleted"]),
                    CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                });
            }


        public Movie GetByTmdbId(int tmdbId)
        {
            var sql = "SELECT * FROM dbo.Movies WHERE TMDBId = @TMDBId";
            var list = DbHelper.ExecuteReaderToList(sql, reader => new Movie
            {
                Id = (int)reader["Id"],
                TMDBId = reader["TMDBId"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["TMDBId"]),
                Title = reader["Title"].ToString(),
                Overview = reader["Overview"] == DBNull.Value ? null : reader["Overview"].ToString(),
                ReleaseDate = reader["ReleaseDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["ReleaseDate"]),
                PosterPath = reader["PosterPath"] == DBNull.Value ? null : reader["PosterPath"].ToString(),
                IsManual = Convert.ToBoolean(reader["IsManual"]),
                IsDeleted = Convert.ToBoolean(reader["IsDeleted"]),
                CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
            }, new SqlParameter("@TMDBId", tmdbId));

            return list.Count > 0 ? list[0] : null;
        }
    }

    }

