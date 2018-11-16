using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//
// BusinessTier: business logic, acting as interface between UI and data store.
//
// <<Reem Hussein>>
// U. of Illinois, Chicago
// CS341, Spring 2018
// Final Project
//

namespace NetflixApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool fileExists(string filename)
        {
            if (!System.IO.File.Exists(filename))
            {
                string msg = string.Format("Input file not found: '{0}'", filename);
                MessageBox.Show(msg);
                return false;
            }
            // exists!
            return true;
        }
        private void displayMovies_Click(object sender, EventArgs e)
        {
            this.movieList.Items.Clear();
            //opens the provided filename
            string filename = this.dbname.Text;
            if (!fileExists(filename))
                return;
            //changes the cursor to waiting while work is done
            this.Cursor = Cursors.WaitCursor;

            //establishing a database connection
            string ver, connectionInfo;
            SqlConnection db;
            ver = "MSSQLLocalDB";

            connectionInfo = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True; ", ver, filename);
            db = new SqlConnection(connectionInfo);
            db.Open();

            //query taking the movie IDs and names and sorting by the movieName
            string sql = string.Format(@"SELECT MovieName FROM Movies ORDER BY MovieName ASC;");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.CommandText = sql;
            adapter.Fill(ds);

            db.Close();
            int numMovies = 0;
            //fills the listbox with the movies
            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                string msg = string.Format("{0}", Convert.ToString(row["MovieName"]));
                this.movieList.Items.Add(msg);
                numMovies++;
            }
            //fills up the total movies and reverts the cursor 
            this.totalMovies.Text = numMovies.ToString();
            this.Cursor = Cursors.Default;
        }

        private void movieList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clears the previously added items
            this.movieReviews.Items.Clear();

            //grabs the database and establishes a connection
            string dbfilename = this.dbname.Text;
            if (!fileExists(dbfilename))
                return;

            //change the cursor to waiting and connect to database
            this.Cursor = Cursors.WaitCursor;
            BusinessTier.Business btier = new BusinessTier.Business(dbfilename);

            string moviename = this.movieList.Text;

            //displays the movie ID
            var movie = btier.GetMovie(moviename);
            if (movie == null)
                this.movieID.Text = "N/A";
            else
                this.movieID.Text = movie.MovieID.ToString();

            //displays the Avg rating
            var details = btier.GetMovieDetail(movie.MovieID);
            if (details == null)
                this.avgRating.Text = "N/A";
            else
            {
                this.avgRating.Text = details.AvgRating.ToString();

                //counting the number of reviews of each rating
                int fives, fours, threes, twos, ones;
                ones = twos = threes = fours = fives = 0;

                var reviews = details.Reviews;

                //adding the movie name to the listbox before adding each review
                this.movieReviews.Items.Add(movie.MovieName);
                this.movieReviews.Items.Add("\n");

                //adds and counts reviews of each type
                foreach (var review in reviews)
                {
                    string msg = string.Format("{0} : {1}", Convert.ToString(review.UserID), Convert.ToString(review.Rating));
                    this.movieReviews.Items.Add(msg);
                    if (review.Rating == 5) fives = fives + 1;
                    else if (review.Rating == 4) fours = fours + 1;
                    else if (review.Rating == 3) threes = threes + 1;
                    else if (review.Rating == 2) twos = twos + 1;
                    else if (review.Rating == 1) ones = ones + 1;
                }

                //fills the textboxs for the rating summaries
                this.numFives.Text = Convert.ToString(fives);
                this.numFours.Text = Convert.ToString(fours);
                this.numThrees.Text = Convert.ToString(threes);
                this.numTwos.Text = Convert.ToString(twos);
                this.numOnes.Text = Convert.ToString(ones);
                this.numTotal.Text = details.NumReviews.ToString();
            }
            //reverts the cursor to back to default
            this.Cursor = Cursors.Default;
        }


        private void displayUsers_Click(object sender, EventArgs e)
        {
            //clear the user list from previous additions
            this.userList.Items.Clear();

            //establish connection between the database
            string dbfilename = this.dbname.Text;
            if (!fileExists(dbfilename))
                return;

            //change cursor to waiting
            this.Cursor = Cursors.WaitCursor;

            BusinessTier.Business btier = new BusinessTier.Business(dbfilename);

            //string moviename = this.movieList.Text;
            int total = 0;
            //grabs the users
            var users = btier.GetAllNamedUsers();

            //adds each user to the user list
            foreach (var user in users)
            {
                string msg = string.Format("{0}", Convert.ToString(user.UserName));
                this.userList.Items.Add(msg);
                total++;
            }
            this.totalUsers.Text = total.ToString();
            //revert the cursor back to default
            this.Cursor = Cursors.Default;
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clears the previously selected user info out of the way
            this.userReviews.Items.Clear();
            //establish connection between the database
            string dbfilename = this.dbname.Text;
            if (!fileExists(dbfilename))
                return;
            //change cursor to waiting
            this.Cursor = Cursors.WaitCursor;

            BusinessTier.Business btier = new BusinessTier.Business(dbfilename);

            //gathering user information
            string userName = this.userList.Text;
            var user = btier.GetNamedUser(userName);
            if (user == null) {
                this.userID.Text = "N/A";
                this.userOccupation.Text = "N/A";
            }
            else {
                if (user.Occupation == "")
                    this.userOccupation.Text = "N/A";
                else
                    this.userOccupation.Text = user.Occupation.ToString();

                this.userID.Text = user.UserID.ToString();
                this.userReviews.Items.Add(userName);
                this.userReviews.Items.Add("\n");

                //grabbing and adding the reviews to the review list
                var userDetail = btier.GetUserDetail(user.UserID);
                var userRevs = userDetail.Reviews;
                foreach (var review in userRevs)
                {
                    var movie = btier.GetMovie(review.MovieID);
                    string msg = string.Format("{0} -> {1}", Convert.ToString(movie.MovieName), Convert.ToString(review.Rating));
                    this.userReviews.Items.Add(msg);
                }
                //change the cursor back to default
                this.Cursor = Cursors.Default;
            }
        }
        private void topN_Click(object sender, EventArgs e)
        {
            //clears the movies added in previous button click
            this.topNMovies.Items.Clear();
            //establish connection between the database
            string dbfilename = this.dbname.Text;
            if (!fileExists(dbfilename))
                return;
            this.Cursor = Cursors.WaitCursor;

            BusinessTier.Business btier = new BusinessTier.Business(dbfilename);

            //a ton of error checking happening here

            //checking if there is anything in the text box
            var nNumText = this.nNum.Text;
            if (string.IsNullOrEmpty(nNumText)){
                MessageBox.Show("Please enter a value! Try again!");
                this.Cursor = Cursors.Default;
                return;
            }
            //checking if the textbox holds a number
            var NNumVal = nNumText.All(char.IsDigit);
            if (!NNumVal) {
                MessageBox.Show("Please enter a number! Try again!");
                this.Cursor = Cursors.Default;
                return;
            }
            //making sure that the number is positive
            int num = Convert.ToInt32(nNumText);
            if (num <= 0) {
                MessageBox.Show("Please enter greater than 0! Try again!");
                this.Cursor = Cursors.Default;
                return;
            }
            //grabbing the actual top movies now and adding them to the listbox
            var topMovies = btier.GetTopMoviesByAvgRating(num);
            foreach (var movie in topMovies)
            {
                var movieID = movie.MovieID;
                var movieInfo = btier.GetMovieDetail(movieID);

                string msg = string.Format("{0} : {1}", Convert.ToString(movie.MovieName), Convert.ToString(movieInfo.AvgRating));
                this.topNMovies.Items.Add(msg);
            }
            //change the cursor back to normal
            this.Cursor = Cursors.Default;

        }
      
        private void addReview_Click(object sender, EventArgs e)
        {
            string dbfilename = this.dbname.Text;
            if (!fileExists(dbfilename))
                return;
            this.Cursor = Cursors.WaitCursor;

            BusinessTier.Business btier = new BusinessTier.Business(dbfilename);
 
            //setting flags for error checking
            int movieID = 0;
            int userID = 0;
            int reviewRating = 0;

            var movieName = this.movieList.Text.ToString();

            if (movieName == "") {

                MessageBox.Show("Please Select a movie!");
                this.Cursor = Cursors.Default;
                return;
            }
            else
            {
                var movieDetails = btier.GetMovie(movieName);
                if (movieDetails != null)
                    movieID = movieDetails.MovieID;
            }
            
            //checking if a username was picked
            var userName = this.userList.Text.ToString();
            if (userName == "") {
                MessageBox.Show("Please Select a user!");
                this.Cursor = Cursors.Default;
                return;
            }
            else {
                //grab the details from the username
                var userDetails = btier.GetNamedUser(userName);
                //check if the detail is valid
                if (userDetails != null)
                    userID = userDetails.UserID;
            }
            
            //checking if the rating was entered
            string rating = this.ratingNum.Text;
            if (rating == "")
            {
                MessageBox.Show("Please enter a rating!");
                this.Cursor = Cursors.Default;
                return;
            }
            else
            {
                //check if what was entered was a number
                if (rating.All(char.IsDigit)){
                    //convert the number to an integer
                    reviewRating = Convert.ToInt32(rating);
                    //if the rating is invalid, then the flag is set to be invalid
                    if (reviewRating < 1 || reviewRating > 5) {
                        MessageBox.Show("Please enter a valid rating!");
                        this.Cursor = Cursors.Default;
                        return;
                    }
                }
            }

            //check our flags to see if something went wrong with the inputs
            if (movieID != 0 && userID != 0 && reviewRating != 0) {
                btier.AddReview(movieID, userID, reviewRating);
                MessageBox.Show("Review added!");
            }
            else {
                MessageBox.Show("Invalid input! Try again!");
            }
            // resetting everything
            this.ratingNum.Text = "";
            this.Cursor = Cursors.Default;
        }
        
        //i dont know what this is and it won't let me delete it 
        //without destroying the rest of the GUI
        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}