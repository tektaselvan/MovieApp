using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public class RatingRepository
    {
        public int AddRating(Rating r)
        {
            var sql = @"
                INSERT INTO dbo.Ratings (MovieId, UserIdentifier, Rating, Note, CreatedAt)
                VALUES (@MovieId, @UserIdentifier, @Rating, @Note, GETDATE());
                SELECT SCOPE_IDENTITY();";

            var idObj = DbHelper.ExecuteScalar(sql,
                new SqlParameter("@MovieId", r.MovieId),
                new SqlParameter("@UserIdentifier", (object)r.UserIdentifier ?? DBNull.Value),
                new SqlParameter("@Rating", r.RatingValue),
                new SqlParameter("@Note", (object)r.Note ?? DBNull.Value)
            );

            return Convert.ToInt32(idObj);
        }

        public List<Rating> GetRatingsByMovieId(int movieId)
        {
            var sql = "SELECT * FROM dbo.Ratings WHERE MovieId = @MovieId ORDER BY CreatedAt DESC";
            return DbHelper.ExecuteReaderToList(sql, reader => new Rating
            {
                Id = (int)reader["Id"],
                MovieId = (int)reader["MovieId"],
                UserIdentifier = reader["UserIdentifier"] == DBNull.Value ? null : reader["UserIdentifier"].ToString(),
                RatingValue = Convert.ToByte(reader["Rating"]),
                Note = reader["Note"] == DBNull.Value ? null : reader["Note"].ToString(),
                CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
            }, new SqlParameter("@MovieId", movieId));
        }

        public double GetAverageRating(int movieId)
        {
            var sql = "SELECT AVG(CAST(Rating AS FLOAT)) FROM dbo.Ratings WHERE MovieId = @MovieId";
            var obj = DbHelper.ExecuteScalar(sql, new SqlParameter("@MovieId", movieId));
            if (obj == DBNull.Value || obj == null) return 0.0;
            return Convert.ToDouble(obj);
        }

        public void DeleteRating(int ratingId)
        {
            var sql = "DELETE FROM dbo.Ratings WHERE Id = @Id";
            DbHelper.ExecuteNonQuery(sql, new SqlParameter("@Id", ratingId));
        }
    }
}
