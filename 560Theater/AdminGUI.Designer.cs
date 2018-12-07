namespace _560Theater
{
    partial class AdminGUI
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Movie = new System.Windows.Forms.TabPage();
            this.movieList = new System.Windows.Forms.ListView();
            this.MovieIDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MovieNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MovieReleaseYearCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MovieGenreCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MovieIsActiveCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MovieCreatedOnCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MovieUpdatedOnCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Theater = new System.Windows.Forms.TabPage();
            this.theaterList = new System.Windows.Forms.ListView();
            this.TheaterIDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TheaterNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TheaterLocationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TheaterIsActiveCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TheaterCreatedOnCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TheaterUpdatedOnCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Showing = new System.Windows.Forms.TabPage();
            this.showingList = new System.Windows.Forms.ListView();
            this.ShowingIDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowingTheaterNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowingMovieNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowingRoomCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowingShowTimeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowingLocationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowingIsActiveCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowingCreatedOnCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowingUpdatedOnCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.activateBtn = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.uxGenerateShowings = new System.Windows.Forms.ToolStripLabel();
            this.tabControl.SuspendLayout();
            this.Movie.SuspendLayout();
            this.Theater.SuspendLayout();
            this.Showing.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Movie);
            this.tabControl.Controls.Add(this.Theater);
            this.tabControl.Controls.Add(this.Showing);
            this.tabControl.Location = new System.Drawing.Point(12, 30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(498, 308);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.indexChange);
            // 
            // Movie
            // 
            this.Movie.Controls.Add(this.movieList);
            this.Movie.Location = new System.Drawing.Point(4, 22);
            this.Movie.Name = "Movie";
            this.Movie.Padding = new System.Windows.Forms.Padding(3);
            this.Movie.Size = new System.Drawing.Size(490, 282);
            this.Movie.TabIndex = 0;
            this.Movie.Text = "Movie";
            this.Movie.UseVisualStyleBackColor = true;
            // 
            // movieList
            // 
            this.movieList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MovieIDCol,
            this.MovieNameCol,
            this.MovieReleaseYearCol,
            this.MovieGenreCol,
            this.MovieIsActiveCol,
            this.MovieCreatedOnCol,
            this.MovieUpdatedOnCol});
            this.movieList.FullRowSelect = true;
            this.movieList.Location = new System.Drawing.Point(-3, 0);
            this.movieList.MultiSelect = false;
            this.movieList.Name = "movieList";
            this.movieList.Size = new System.Drawing.Size(490, 286);
            this.movieList.TabIndex = 3;
            this.movieList.UseCompatibleStateImageBehavior = false;
            this.movieList.View = System.Windows.Forms.View.Details;
            // 
            // MovieIDCol
            // 
            this.MovieIDCol.Text = "MovieID";
            // 
            // MovieNameCol
            // 
            this.MovieNameCol.Text = "MovieName";
            this.MovieNameCol.Width = 77;
            // 
            // MovieReleaseYearCol
            // 
            this.MovieReleaseYearCol.DisplayIndex = 3;
            this.MovieReleaseYearCol.Text = "ReleaseYear";
            this.MovieReleaseYearCol.Width = 74;
            // 
            // MovieGenreCol
            // 
            this.MovieGenreCol.DisplayIndex = 2;
            this.MovieGenreCol.Text = "Genre";
            // 
            // MovieIsActiveCol
            // 
            this.MovieIsActiveCol.Text = "IsActive";
            // 
            // MovieCreatedOnCol
            // 
            this.MovieCreatedOnCol.Text = "CreatedOn";
            this.MovieCreatedOnCol.Width = 66;
            // 
            // MovieUpdatedOnCol
            // 
            this.MovieUpdatedOnCol.Text = "UpdatedOn";
            this.MovieUpdatedOnCol.Width = 70;
            // 
            // Theater
            // 
            this.Theater.Controls.Add(this.theaterList);
            this.Theater.Location = new System.Drawing.Point(4, 22);
            this.Theater.Name = "Theater";
            this.Theater.Padding = new System.Windows.Forms.Padding(3);
            this.Theater.Size = new System.Drawing.Size(490, 282);
            this.Theater.TabIndex = 1;
            this.Theater.Text = "Theater";
            this.Theater.UseVisualStyleBackColor = true;
            // 
            // theaterList
            // 
            this.theaterList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TheaterIDCol,
            this.TheaterNameCol,
            this.TheaterLocationCol,
            this.TheaterIsActiveCol,
            this.TheaterCreatedOnCol,
            this.TheaterUpdatedOnCol});
            this.theaterList.Location = new System.Drawing.Point(0, 0);
            this.theaterList.Name = "theaterList";
            this.theaterList.Size = new System.Drawing.Size(490, 300);
            this.theaterList.TabIndex = 0;
            this.theaterList.UseCompatibleStateImageBehavior = false;
            this.theaterList.View = System.Windows.Forms.View.Details;
            // 
            // TheaterIDCol
            // 
            this.TheaterIDCol.Text = "TheaterID";
            // 
            // TheaterNameCol
            // 
            this.TheaterNameCol.Text = "TheaterName";
            this.TheaterNameCol.Width = 86;
            // 
            // TheaterLocationCol
            // 
            this.TheaterLocationCol.Text = "Location";
            // 
            // TheaterIsActiveCol
            // 
            this.TheaterIsActiveCol.Text = "IsActive";
            // 
            // TheaterCreatedOnCol
            // 
            this.TheaterCreatedOnCol.Text = "CreatedOn";
            this.TheaterCreatedOnCol.Width = 71;
            // 
            // TheaterUpdatedOnCol
            // 
            this.TheaterUpdatedOnCol.Text = "UpdatedOn";
            this.TheaterUpdatedOnCol.Width = 71;
            // 
            // Showing
            // 
            this.Showing.Controls.Add(this.showingList);
            this.Showing.Location = new System.Drawing.Point(4, 22);
            this.Showing.Name = "Showing";
            this.Showing.Padding = new System.Windows.Forms.Padding(3);
            this.Showing.Size = new System.Drawing.Size(490, 282);
            this.Showing.TabIndex = 2;
            this.Showing.Text = "Showing";
            this.Showing.UseVisualStyleBackColor = true;
            // 
            // showingList
            // 
            this.showingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ShowingIDCol,
            this.ShowingTheaterNameCol,
            this.ShowingMovieNameCol,
            this.ShowingRoomCol,
            this.ShowingShowTimeCol,
            this.ShowingLocationCol,
            this.ShowingIsActiveCol,
            this.ShowingCreatedOnCol,
            this.ShowingUpdatedOnCol});
            this.showingList.Location = new System.Drawing.Point(0, 0);
            this.showingList.Name = "showingList";
            this.showingList.Size = new System.Drawing.Size(490, 300);
            this.showingList.TabIndex = 0;
            this.showingList.UseCompatibleStateImageBehavior = false;
            this.showingList.View = System.Windows.Forms.View.Details;
            // 
            // ShowingIDCol
            // 
            this.ShowingIDCol.Text = "ShowingID";
            this.ShowingIDCol.Width = 71;
            // 
            // ShowingTheaterNameCol
            // 
            this.ShowingTheaterNameCol.Text = "TheaterName";
            this.ShowingTheaterNameCol.Width = 79;
            // 
            // ShowingMovieNameCol
            // 
            this.ShowingMovieNameCol.Text = "MovieName";
            this.ShowingMovieNameCol.Width = 69;
            // 
            // ShowingRoomCol
            // 
            this.ShowingRoomCol.Text = "Room";
            this.ShowingRoomCol.Width = 41;
            // 
            // ShowingShowTimeCol
            // 
            this.ShowingShowTimeCol.Text = "ShowTime";
            this.ShowingShowTimeCol.Width = 62;
            // 
            // ShowingLocationCol
            // 
            this.ShowingLocationCol.DisplayIndex = 8;
            this.ShowingLocationCol.Text = "Location";
            // 
            // ShowingIsActiveCol
            // 
            this.ShowingIsActiveCol.DisplayIndex = 5;
            this.ShowingIsActiveCol.Text = "IsActive";
            // 
            // ShowingCreatedOnCol
            // 
            this.ShowingCreatedOnCol.DisplayIndex = 6;
            this.ShowingCreatedOnCol.Text = "CreatedOn";
            this.ShowingCreatedOnCol.Width = 63;
            // 
            // ShowingUpdatedOnCol
            // 
            this.ShowingUpdatedOnCol.DisplayIndex = 7;
            this.ShowingUpdatedOnCol.Text = "UpdatedOn";
            this.ShowingUpdatedOnCol.Width = 76;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(25, 363);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(108, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(139, 363);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(108, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(253, 363);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(108, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Deactivate";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 404);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 430);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(406, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 456);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(406, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Movie Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ReleaseYear:";
            // 
            // activateBtn
            // 
            this.activateBtn.Location = new System.Drawing.Point(367, 363);
            this.activateBtn.Name = "activateBtn";
            this.activateBtn.Size = new System.Drawing.Size(108, 23);
            this.activateBtn.TabIndex = 10;
            this.activateBtn.Text = "Activate";
            this.activateBtn.UseVisualStyleBackColor = true;
            this.activateBtn.Click += new System.EventHandler(this.activateBtn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxGenerateShowings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(525, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // uxGenerateShowings
            // 
            this.uxGenerateShowings.Name = "uxGenerateShowings";
            this.uxGenerateShowings.Size = new System.Drawing.Size(108, 22);
            this.uxGenerateShowings.Text = "Generate Showings";
            this.uxGenerateShowings.Click += new System.EventHandler(this.uxGenerateShowings_Click);
            // 
            // AdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 493);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.activateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminGUI";
            this.Text = "AdminGUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onClose);
            this.tabControl.ResumeLayout(false);
            this.Movie.ResumeLayout(false);
            this.Theater.ResumeLayout(false);
            this.Showing.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Movie;
        private System.Windows.Forms.TabPage Theater;
        private System.Windows.Forms.TabPage Showing;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView movieList;
        private System.Windows.Forms.ColumnHeader MovieIDCol;
        private System.Windows.Forms.ColumnHeader MovieNameCol;
        private System.Windows.Forms.ColumnHeader MovieGenreCol;
        private System.Windows.Forms.ColumnHeader MovieReleaseYearCol;
        private System.Windows.Forms.ColumnHeader MovieIsActiveCol;
        private System.Windows.Forms.ColumnHeader MovieCreatedOnCol;
        private System.Windows.Forms.ColumnHeader MovieUpdatedOnCol;
        private System.Windows.Forms.ListView theaterList;
        private System.Windows.Forms.ColumnHeader TheaterIDCol;
        private System.Windows.Forms.ColumnHeader TheaterNameCol;
        private System.Windows.Forms.ColumnHeader TheaterLocationCol;
        private System.Windows.Forms.ColumnHeader TheaterIsActiveCol;
        private System.Windows.Forms.ColumnHeader TheaterCreatedOnCol;
        private System.Windows.Forms.ColumnHeader TheaterUpdatedOnCol;
        private System.Windows.Forms.ListView showingList;
        private System.Windows.Forms.ColumnHeader ShowingIDCol;
        private System.Windows.Forms.ColumnHeader ShowingTheaterNameCol;
        private System.Windows.Forms.ColumnHeader ShowingMovieNameCol;
        private System.Windows.Forms.ColumnHeader ShowingRoomCol;
        private System.Windows.Forms.ColumnHeader ShowingShowTimeCol;
        private System.Windows.Forms.ColumnHeader ShowingIsActiveCol;
        private System.Windows.Forms.ColumnHeader ShowingCreatedOnCol;
        private System.Windows.Forms.ColumnHeader ShowingUpdatedOnCol;
        private System.Windows.Forms.ColumnHeader ShowingLocationCol;
        private System.Windows.Forms.Button activateBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel uxGenerateShowings;
    }
}