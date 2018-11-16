 // BusinessTier:  business logic, acting as interface between UI and data store.
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;

// BusinessTier: business logic, acting as interface between UI and data store.
// <<Reem Hussein>>
// U. of Illinois, Chicago
// CS341, Spring 2018
// Final Project

namespace BusinessTier
{
    //
    // Business:
    //
    public class Business {
        //
        // Fields:
        //
        private string _DBFile;
        private DataAccessTier.Data dataTier;


        // Constructor:

        public Business(string DatabaseFilename)
        {
            _DBFile = DatabaseFilename;
            dataTier = new DataAccessTier.Data(DatabaseFilename);
        }

        // TestConnection:
        // Returns true if we can establish a connection to the database, false if not.

        public bool TestConnection()
        {
            return dataTier.TestConnection();
        }

        public User GetUser(int UserID)
        {
            if (UserID == 0)
            {
                return null;
            }
            string query = string.Format(@"SELECT * FROM Users where UserID = {0}", UserID);

            DataSet ds = dataTier.ExecuteNonScalarQuery(query);

            string user_name = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[1]);
            string user_job = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[2]);
            return new User(UserID, user_name, user_job);
        }

        // GetNamedUser:
        // Retrieves User object based on USER NAME; returns null if user is not
        // found.
        // NOTE: there are "named" users from the Users table, and anonymous users
        // that only exist in the Reviews table.  This function only looks up "named"
        // users from the Users table.

        public User GetNamedUser(string UserName)
        {
            if (UserName == "") {
                return null;
            }
            UserName = UserName.Replace("'", "''");
            string query = string.Format(@"SELECT * FROM Users where UserName = '{0}'", UserName);

            DataSet ds = dataTier.ExecuteNonScalarQuery(query);

            int user_id = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);
            string user_job = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[2]);
            return new User(user_id, UserName, user_job);
        }
        
        // GetAllNamedUsers:
        // Returns a list of all the users in the Users table ("named" users), sorted 
        // by user name.
        // NOTE: the database also contains lots of "anonymous" users, which this 
        // function does not return.
  
        public IReadOnlyList<User> GetAllNamedUsers()
        {
            List<User> users = new List<User>();
            string query = string.Format(@"SELECT * From Users");
            DataSet ds = dataTier.ExecuteNonScalarQuery(query);

            int rows = ds.Tables[0].Rows.Count;
              for (int i = 0; i < rows; i++)
            {
                int user_id = (int) ds.Tables[0].Rows[i].ItemArray[0];
                string user_name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string user_job = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                users.Add(new User(user_id, user_name, user_job));
            }
            return users;
        }
        
        // GetMovie:
        // Retrieves Movie object based on MOVIE ID; returns null if movie is not
        // found.
     
        public Movie GetMovie(int MovieID)
        {
            if (MovieID == 0) {
                return null;
            }
            string query = string.Format(@"SELECT * FROM Movies where MovieID = {0}", MovieID);
            var ds = dataTier.ExecuteNonScalarQuery(query);
            var MovieName = (string) ds.Tables[0].Rows[0].ItemArray[1];
            return new Movie(MovieID, MovieName);
        }
        
        // GetMovie:
        // Retrieves Movie object based on MOVIE NAME; returns null if movie is not
        // found.

        public Movie GetMovie(string MovieName)
        {
            if (MovieName == "") {
                return null;
            }
            MovieName = MovieName.Replace("'", "''");
            string query = string.Format(@"SELECT *  FROM Movies where MovieName = '{0}'", MovieName);
            var ds = dataTier.ExecuteNonScalarQuery(query);
            var MovieID = (int)ds.Tables[0].Rows[0].ItemArray[0];
            return new Movie(MovieID, MovieName);   
        }
        
        // AddReview:
        // Adds review based on MOVIE ID, returning a Review object containing
        // the review, review's id, etc.  If the add failed, null is returned.

        public Review AddReview(int MovieID, int UserID, int Rating)
        {
            string query = string.Format
                (@"INSERT INTO Reviews(MovieId, UserId, Rating) VALUES({0},{1},{2}); SELECT ReviewID 
                FROM Reviews WHERE ReviewID = SCOPE_IDENTITY()", MovieID,UserID,Rating);

            int review_id = dataTier.ExecuteActionQuery(query);
            if (review_id == 0)  return null;
            else return new Review(review_id, MovieID, UserID, Rating);
                            
        }

        // GetMovieDetail:
        // Given a MOVIE ID, returns detailed information about this movie --- all
        // the reviews, the total number of reviews, average rating, etc.  If the 
        // movie cannot be found, null is returned.

        public MovieDetail GetMovieDetail(int MovieID)
        {
            var movie = GetMovie(MovieID);
            string query = string.Format(@"SELECT * FROM Reviews where MovieID = {0} 
                                              ORDER BY Rating DESC, UserID ASC", MovieID);
            
            DataSet ds = dataTier.ExecuteNonScalarQuery(query);
            List<Review> reviews = new List<Review>();
            int rows =  ds.Tables[0].Rows.Count;
            double avg_rating = 0;
            for (int i = 0; i < rows; i++) {
                int review_id = (int)ds.Tables[0].Rows[i].ItemArray[0];
                int user_id = (int)ds.Tables[0].Rows[i].ItemArray[2];
                int review_rating = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[3]);

                reviews.Add(new Review(review_id, MovieID, user_id, review_rating));
                avg_rating += (double) review_rating;
            }
            if (rows != 0)
                avg_rating = avg_rating / ((double)rows);
            else
                avg_rating = 0;

            avg_rating = Math.Round(avg_rating, 4);

            return new MovieDetail(movie, avg_rating, rows, reviews); 
        }

        // GetUserDetail:
        // Given a USER ID, returns detailed information about this user --- all
        // the reviews submitted by this user, the total number of reviews, average 
        // rating given, etc.  If the user cannot be found, null is returned.

        public UserDetail GetUserDetail(int UserID)
        {
            string query = string.Format(@"SELECT * FROM Reviews where UserID = {0}", UserID);
            DataSet ds = dataTier.ExecuteNonScalarQuery(query);

            User user = GetUser(UserID);
            List<Review> reviews = new List<Review>();
            int rows = ds.Tables[0].Rows.Count;
            double avg_rating = 0;
            for (int i = 0; i < rows; i++)
            {
                int review_id = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);
                int movie_id = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[1]);
                int review_rating = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[3]);

                reviews.Add(new Review(review_id, movie_id, UserID, review_rating));
                avg_rating += (double)review_rating;
            }

            if (rows != 0)
                avg_rating = avg_rating / ((double)rows);
            else
                avg_rating = 0;
            avg_rating = Math.Round(avg_rating, 4);

            //List<Review> newList = reviews.OrderByDescending(o => o.Rating).ToList();
            return new UserDetail(user, avg_rating, rows, reviews);
        }

        // GetTopMoviesByAvgRating:
        //
        // Returns the top N movies in descending order by average rating.  If two
        // movies have the same rating, the movies are presented in ascending order
        // by name.  If N < 1, an EMPTY LIST is returned.

        public IReadOnlyList<Movie> GetTopMoviesByAvgRating(int N)
        {
            List<Movie> movies = new List<Movie>();
            List<MovieDetail> movie_detail = new List<MovieDetail>();

            string query = string.Format(@"SELECT * FROM Movies;");
            DataSet ds = dataTier.ExecuteNonScalarQuery(query);
            
            int rows = ds.Tables[0].Rows.Count;

            for (int i = 0; i < rows; i++)
            {
                int movie_id = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);
                MovieDetail md = GetMovieDetail(movie_id);
                movie_detail.Add(md);
            }
            
            List<MovieDetail> newList = movie_detail.OrderByDescending(o => o.AvgRating).ToList();

            for (int i = 0; i < N; i++) {
                movies.Add(newList[i].movie);
            }
            return movies;
        }
    }//class
}//namespace