namespace _560Theater
{
    partial class uxCustomerUI
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
            this.uxTheaterListBox = new System.Windows.Forms.ListBox();
            this.uxShowtimeLabel = new System.Windows.Forms.Label();
            this.uxTheaterLabel = new System.Windows.Forms.Label();
            this.uxMovieLabel = new System.Windows.Forms.Label();
            this.uxMovieListBox = new System.Windows.Forms.ListBox();
            this.uxSearch = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.uxHistory = new System.Windows.Forms.ToolStripLabel();
            this.uxHoursNumeric = new System.Windows.Forms.NumericUpDown();
            this.uxMinutesNumeric = new System.Windows.Forms.NumericUpDown();
            this.uxDescriptionLabel = new System.Windows.Forms.Label();
            this.uxHourLabel = new System.Windows.Forms.Label();
            this.uxMinutesLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxHoursNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinutesNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // uxTheaterListBox
            // 
            this.uxTheaterListBox.FormattingEnabled = true;
            this.uxTheaterListBox.Location = new System.Drawing.Point(12, 62);
            this.uxTheaterListBox.Name = "uxTheaterListBox";
            this.uxTheaterListBox.Size = new System.Drawing.Size(192, 212);
            this.uxTheaterListBox.TabIndex = 0;
            // 
            // uxShowtimeLabel
            // 
            this.uxShowtimeLabel.AutoSize = true;
            this.uxShowtimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxShowtimeLabel.Location = new System.Drawing.Point(9, 343);
            this.uxShowtimeLabel.Name = "uxShowtimeLabel";
            this.uxShowtimeLabel.Size = new System.Drawing.Size(148, 32);
            this.uxShowtimeLabel.TabIndex = 2;
            this.uxShowtimeLabel.Text = "Showtime:";
            // 
            // uxTheaterLabel
            // 
            this.uxTheaterLabel.AutoSize = true;
            this.uxTheaterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxTheaterLabel.Location = new System.Drawing.Point(12, 32);
            this.uxTheaterLabel.Name = "uxTheaterLabel";
            this.uxTheaterLabel.Size = new System.Drawing.Size(165, 32);
            this.uxTheaterLabel.TabIndex = 4;
            this.uxTheaterLabel.Text = "Theater List";
            // 
            // uxMovieLabel
            // 
            this.uxMovieLabel.AutoSize = true;
            this.uxMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxMovieLabel.Location = new System.Drawing.Point(252, 32);
            this.uxMovieLabel.Name = "uxMovieLabel";
            this.uxMovieLabel.Size = new System.Drawing.Size(143, 32);
            this.uxMovieLabel.TabIndex = 5;
            this.uxMovieLabel.Text = "Movie List";
            // 
            // uxMovieListBox
            // 
            this.uxMovieListBox.FormattingEnabled = true;
            this.uxMovieListBox.Location = new System.Drawing.Point(255, 62);
            this.uxMovieListBox.Name = "uxMovieListBox";
            this.uxMovieListBox.Size = new System.Drawing.Size(188, 212);
            this.uxMovieListBox.TabIndex = 6;
            // 
            // uxSearch
            // 
            this.uxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxSearch.Location = new System.Drawing.Point(295, 314);
            this.uxSearch.Name = "uxSearch";
            this.uxSearch.Size = new System.Drawing.Size(148, 46);
            this.uxSearch.TabIndex = 7;
            this.uxSearch.Text = "Show Showtimes";
            this.uxSearch.UseVisualStyleBackColor = true;
            this.uxSearch.Click += new System.EventHandler(this.uxSearch_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxHistory});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(466, 35);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // uxHistory
            // 
            this.uxHistory.Name = "uxHistory";
            this.uxHistory.Size = new System.Drawing.Size(160, 32);
            this.uxHistory.Text = "Ticket History";
            this.uxHistory.Click += new System.EventHandler(this.uxHistory_Click);
            // 
            // uxHoursNumeric
            // 
            this.uxHoursNumeric.Location = new System.Drawing.Point(87, 344);
            this.uxHoursNumeric.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.uxHoursNumeric.Name = "uxHoursNumeric";
            this.uxHoursNumeric.Size = new System.Drawing.Size(33, 20);
            this.uxHoursNumeric.TabIndex = 11;
            // 
            // uxMinutesNumeric
            // 
            this.uxMinutesNumeric.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.uxMinutesNumeric.Location = new System.Drawing.Point(132, 344);
            this.uxMinutesNumeric.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.uxMinutesNumeric.Name = "uxMinutesNumeric";
            this.uxMinutesNumeric.Size = new System.Drawing.Size(33, 20);
            this.uxMinutesNumeric.TabIndex = 12;
            // 
            // uxDescriptionLabel
            // 
            this.uxDescriptionLabel.AutoSize = true;
            this.uxDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.uxDescriptionLabel.Location = new System.Drawing.Point(9, 314);
            this.uxDescriptionLabel.Name = "uxDescriptionLabel";
            this.uxDescriptionLabel.Size = new System.Drawing.Size(490, 29);
            this.uxDescriptionLabel.TabIndex = 13;
            this.uxDescriptionLabel.Text = "Military Time using 15 minutes increments";
            // 
            // uxHourLabel
            // 
            this.uxHourLabel.AutoSize = true;
            this.uxHourLabel.Location = new System.Drawing.Point(85, 375);
            this.uxHourLabel.Name = "uxHourLabel";
            this.uxHourLabel.Size = new System.Drawing.Size(30, 13);
            this.uxHourLabel.TabIndex = 14;
            this.uxHourLabel.Text = "Hour";
            // 
            // uxMinutesLabel
            // 
            this.uxMinutesLabel.AutoSize = true;
            this.uxMinutesLabel.Location = new System.Drawing.Point(129, 375);
            this.uxMinutesLabel.Name = "uxMinutesLabel";
            this.uxMinutesLabel.Size = new System.Drawing.Size(44, 13);
            this.uxMinutesLabel.TabIndex = 15;
            this.uxMinutesLabel.Text = "Minutes";
            // 
            // uxCustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 397);
            this.Controls.Add(this.uxMinutesLabel);
            this.Controls.Add(this.uxHourLabel);
            this.Controls.Add(this.uxDescriptionLabel);
            this.Controls.Add(this.uxMinutesNumeric);
            this.Controls.Add(this.uxHoursNumeric);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.uxSearch);
            this.Controls.Add(this.uxMovieListBox);
            this.Controls.Add(this.uxMovieLabel);
            this.Controls.Add(this.uxTheaterLabel);
            this.Controls.Add(this.uxShowtimeLabel);
            this.Controls.Add(this.uxTheaterListBox);
            this.Name = "uxCustomerUI";
            this.Text = "Filter Showtimes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.uxCustomerUI_FormClosed);
            this.Load += new System.EventHandler(this.uxCustomerUI_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxHoursNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinutesNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxTheaterListBox;
        private System.Windows.Forms.Label uxShowtimeLabel;
        private System.Windows.Forms.Label uxTheaterLabel;
        private System.Windows.Forms.Label uxMovieLabel;
        private System.Windows.Forms.ListBox uxMovieListBox;
        private System.Windows.Forms.Button uxSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.NumericUpDown uxHoursNumeric;
        private System.Windows.Forms.NumericUpDown uxMinutesNumeric;
        private System.Windows.Forms.Label uxDescriptionLabel;
        private System.Windows.Forms.Label uxHourLabel;
        private System.Windows.Forms.Label uxMinutesLabel;
        private System.Windows.Forms.ToolStripLabel uxHistory;
    }
}

