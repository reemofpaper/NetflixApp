namespace NetflixApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayMovies = new System.Windows.Forms.Button();
            this.movieList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dbname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.movieID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.avgRating = new System.Windows.Forms.TextBox();
            this.movieReviews = new System.Windows.Forms.ListBox();
            this.numFives = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numFours = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numTwos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numThrees = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numOnes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numTotal = new System.Windows.Forms.TextBox();
            this.userReviews = new System.Windows.Forms.ListBox();
            this.userOccupation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.ListBox();
            this.displayUsers = new System.Windows.Forms.Button();
            this.totalMovies = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.totalUsers = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.topNMovies = new System.Windows.Forms.ListBox();
            this.topN = new System.Windows.Forms.Button();
            this.nNum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.addReview = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ratingNum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayMovies
            // 
            this.displayMovies.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMovies.Location = new System.Drawing.Point(6, 170);
            this.displayMovies.Name = "displayMovies";
            this.displayMovies.Size = new System.Drawing.Size(115, 22);
            this.displayMovies.TabIndex = 0;
            this.displayMovies.Text = "Display Movies";
            this.displayMovies.UseVisualStyleBackColor = true;
            this.displayMovies.Click += new System.EventHandler(this.displayMovies_Click);
            // 
            // movieList
            // 
            this.movieList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieList.FormattingEnabled = true;
            this.movieList.HorizontalScrollbar = true;
            this.movieList.ItemHeight = 14;
            this.movieList.Location = new System.Drawing.Point(6, 19);
            this.movieList.Name = "movieList";
            this.movieList.Size = new System.Drawing.Size(186, 144);
            this.movieList.TabIndex = 1;
            this.movieList.SelectedIndexChanged += new System.EventHandler(this.movieList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Database";
            // 
            // dbname
            // 
            this.dbname.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbname.Location = new System.Drawing.Point(123, 6);
            this.dbname.Name = "dbname";
            this.dbname.Size = new System.Drawing.Size(125, 20);
            this.dbname.TabIndex = 3;
            this.dbname.Text = "netflix-200k.mdf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Movie ID";
            // 
            // movieID
            // 
            this.movieID.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieID.Location = new System.Drawing.Point(378, 90);
            this.movieID.Name = "movieID";
            this.movieID.Size = new System.Drawing.Size(47, 20);
            this.movieID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Avg Rating";
            // 
            // avgRating
            // 
            this.avgRating.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgRating.Location = new System.Drawing.Point(378, 135);
            this.avgRating.Name = "avgRating";
            this.avgRating.Size = new System.Drawing.Size(57, 20);
            this.avgRating.TabIndex = 7;
            // 
            // movieReviews
            // 
            this.movieReviews.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieReviews.FormattingEnabled = true;
            this.movieReviews.HorizontalScrollbar = true;
            this.movieReviews.ItemHeight = 14;
            this.movieReviews.Location = new System.Drawing.Point(198, 19);
            this.movieReviews.Name = "movieReviews";
            this.movieReviews.Size = new System.Drawing.Size(174, 144);
            this.movieReviews.TabIndex = 8;
            // 
            // numFives
            // 
            this.numFives.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFives.Location = new System.Drawing.Point(56, 29);
            this.numFives.Name = "numFives";
            this.numFives.Size = new System.Drawing.Size(42, 20);
            this.numFives.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "4";
            // 
            // numFours
            // 
            this.numFours.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFours.Location = new System.Drawing.Point(56, 55);
            this.numFours.Name = "numFours";
            this.numFours.Size = new System.Drawing.Size(42, 20);
            this.numFours.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 14);
            this.label6.TabIndex = 16;
            this.label6.Text = "2";
            // 
            // numTwos
            // 
            this.numTwos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTwos.Location = new System.Drawing.Point(56, 107);
            this.numTwos.Name = "numTwos";
            this.numTwos.Size = new System.Drawing.Size(42, 20);
            this.numTwos.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 14);
            this.label9.TabIndex = 14;
            this.label9.Text = "3";
            // 
            // numThrees
            // 
            this.numThrees.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numThrees.Location = new System.Drawing.Point(56, 81);
            this.numThrees.Name = "numThrees";
            this.numThrees.Size = new System.Drawing.Size(42, 20);
            this.numThrees.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "1";
            // 
            // numOnes
            // 
            this.numOnes.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOnes.Location = new System.Drawing.Point(56, 133);
            this.numOnes.Name = "numOnes";
            this.numOnes.Size = new System.Drawing.Size(42, 20);
            this.numOnes.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 14);
            this.label8.TabIndex = 20;
            this.label8.Text = "Total";
            // 
            // numTotal
            // 
            this.numTotal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTotal.Location = new System.Drawing.Point(56, 159);
            this.numTotal.Name = "numTotal";
            this.numTotal.Size = new System.Drawing.Size(42, 20);
            this.numTotal.TabIndex = 19;
            // 
            // userReviews
            // 
            this.userReviews.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userReviews.FormattingEnabled = true;
            this.userReviews.HorizontalScrollbar = true;
            this.userReviews.ItemHeight = 14;
            this.userReviews.Location = new System.Drawing.Point(106, 20);
            this.userReviews.Name = "userReviews";
            this.userReviews.Size = new System.Drawing.Size(194, 144);
            this.userReviews.TabIndex = 28;
            // 
            // userOccupation
            // 
            this.userOccupation.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userOccupation.Location = new System.Drawing.Point(316, 138);
            this.userOccupation.Name = "userOccupation";
            this.userOccupation.Size = new System.Drawing.Size(84, 20);
            this.userOccupation.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(313, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 14);
            this.label11.TabIndex = 26;
            this.label11.Text = "User Occupation";
            // 
            // userID
            // 
            this.userID.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID.Location = new System.Drawing.Point(316, 92);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(84, 20);
            this.userID.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(313, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 14);
            this.label12.TabIndex = 24;
            this.label12.Text = "User ID";
            // 
            // userList
            // 
            this.userList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userList.FormattingEnabled = true;
            this.userList.HorizontalScrollbar = true;
            this.userList.ItemHeight = 14;
            this.userList.Location = new System.Drawing.Point(6, 20);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(94, 144);
            this.userList.TabIndex = 23;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // displayUsers
            // 
            this.displayUsers.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayUsers.Location = new System.Drawing.Point(6, 173);
            this.displayUsers.Name = "displayUsers";
            this.displayUsers.Size = new System.Drawing.Size(115, 22);
            this.displayUsers.TabIndex = 22;
            this.displayUsers.Text = "Display Users";
            this.displayUsers.UseVisualStyleBackColor = true;
            this.displayUsers.Click += new System.EventHandler(this.displayUsers_Click);
            // 
            // totalMovies
            // 
            this.totalMovies.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMovies.Location = new System.Drawing.Point(378, 40);
            this.totalMovies.Name = "totalMovies";
            this.totalMovies.Size = new System.Drawing.Size(47, 20);
            this.totalMovies.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(375, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 14);
            this.label13.TabIndex = 29;
            this.label13.Text = "Total Movies";
            // 
            // totalUsers
            // 
            this.totalUsers.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUsers.Location = new System.Drawing.Point(316, 43);
            this.totalUsers.Name = "totalUsers";
            this.totalUsers.Size = new System.Drawing.Size(84, 20);
            this.totalUsers.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(313, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 14);
            this.label14.TabIndex = 31;
            this.label14.Text = "Total Users";
            // 
            // topNMovies
            // 
            this.topNMovies.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topNMovies.FormattingEnabled = true;
            this.topNMovies.HorizontalScrollbar = true;
            this.topNMovies.ItemHeight = 14;
            this.topNMovies.Location = new System.Drawing.Point(11, 27);
            this.topNMovies.Name = "topNMovies";
            this.topNMovies.Size = new System.Drawing.Size(192, 144);
            this.topNMovies.TabIndex = 34;
            // 
            // topN
            // 
            this.topN.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topN.Location = new System.Drawing.Point(217, 80);
            this.topN.Name = "topN";
            this.topN.Size = new System.Drawing.Size(69, 52);
            this.topN.TabIndex = 33;
            this.topN.Text = "Display Top N Movies";
            this.topN.UseVisualStyleBackColor = true;
            this.topN.Click += new System.EventHandler(this.topN_Click);
            // 
            // nNum
            // 
            this.nNum.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nNum.Location = new System.Drawing.Point(217, 55);
            this.nNum.Name = "nNum";
            this.nNum.Size = new System.Drawing.Size(69, 20);
            this.nNum.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(209, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 14);
            this.label15.TabIndex = 35;
            this.label15.Text = "Enter Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.movieList);
            this.groupBox1.Controls.Add(this.movieReviews);
            this.groupBox1.Controls.Add(this.avgRating);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.movieID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.displayMovies);
            this.groupBox1.Controls.Add(this.totalMovies);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 201);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userList);
            this.groupBox2.Controls.Add(this.userReviews);
            this.groupBox2.Controls.Add(this.userOccupation);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.displayUsers);
            this.groupBox2.Controls.Add(this.userID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.totalUsers);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(500, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 201);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.topNMovies);
            this.groupBox3.Controls.Add(this.topN);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.nNum);
            this.groupBox3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(169, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 185);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Top Movies";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numFives);
            this.groupBox4.Controls.Add(this.numTwos);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.numOnes);
            this.groupBox4.Controls.Add(this.numFours);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.numThrees);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.numTotal);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(133, 187);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Selected Movie Ratings Summary";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.addReview);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.ratingNum);
            this.groupBox5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(500, 249);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(317, 185);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Insert Review";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(9, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 14);
            this.label18.TabIndex = 39;
            this.label18.Text = "add review!";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(252, 14);
            this.label17.TabIndex = 38;
            this.label17.Text = "list, enter rating from 1-5 and hit";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(287, 14);
            this.label16.TabIndex = 37;
            this.label16.Text = "movie list, select a user from the user ";
            // 
            // addReview
            // 
            this.addReview.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReview.Location = new System.Drawing.Point(77, 115);
            this.addReview.Name = "addReview";
            this.addReview.Size = new System.Drawing.Size(69, 52);
            this.addReview.TabIndex = 33;
            this.addReview.Text = "Add Review";
            this.addReview.UseVisualStyleBackColor = true;
            this.addReview.Click += new System.EventHandler(this.addReview_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(301, 14);
            this.label10.TabIndex = 35;
            this.label10.Text = "To enter a review, select a movie from the";
            // 
            // ratingNum
            // 
            this.ratingNum.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingNum.Location = new System.Drawing.Point(163, 128);
            this.ratingNum.Name = "ratingNum";
            this.ratingNum.Size = new System.Drawing.Size(69, 20);
            this.ratingNum.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(955, 446);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dbname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Netflix Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayMovies;
        private System.Windows.Forms.ListBox movieList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dbname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox movieID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox avgRating;
        private System.Windows.Forms.ListBox movieReviews;
        private System.Windows.Forms.TextBox numFives;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numFours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numTwos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox numThrees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numOnes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numTotal;
        private System.Windows.Forms.ListBox userReviews;
        private System.Windows.Forms.TextBox userOccupation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Button displayUsers;
        private System.Windows.Forms.TextBox totalMovies;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox totalUsers;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox topNMovies;
        private System.Windows.Forms.Button topN;
        private System.Windows.Forms.TextBox nNum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button addReview;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ratingNum;
    }
}

