using Post.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.DAL
{
    public class ReviewSqlDAO : IReviewDAO
    {
        private readonly string connectionString;

        public ReviewSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Returns a list of all reviews
        /// </summary>
        /// <returns></returns>
        public IList<Review> GetAllReviews()
        {
            List<Review> reviews = new List<Review>();
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmdText = "SELECT * FROM reviews";
                SqlCommand cmd = new SqlCommand(cmdText, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Review review = new Review();

                    review.Id = (int)reader["review_id"];
                    review.Username = (string)reader["username"];
                    review.Rating = (int)reader["rating"];
                    review.Title = (string)reader["review_title"];
                    review.Text = (string)reader["review_text"];
                    review.Date = DateTime.Parse(reader["review_date"].ToString());

                    reviews.Add(review);
                }
            }

            return reviews;
        }

        /// <summary>
        /// Saves a new review to the system.
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns></returns>
        public int SaveReview(Review newReview)
        {
            int newId = 0;
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmdText = "INSERT INTO reviews (username,rating,review_title,review_text,review_date)";
                cmdText += " VALUES (@username,@rating, @title, @text, GETDATE())";
                SqlCommand cmd = new SqlCommand(cmdText, connection);
                cmd.Parameters.AddWithValue("@username", newReview.Username);
                cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                cmd.Parameters.AddWithValue("@title", newReview.Title);
                cmd.Parameters.AddWithValue("@text", newReview.Text);

                newId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return newId;
        }
    }
}
