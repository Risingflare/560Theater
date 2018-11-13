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
            this.label1 = new System.Windows.Forms.Label();
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
            this.uxTheaterListBox.Size = new System.Drawing.Size(148, 212);
            this.uxTheaterListBox.TabIndex = 0;
            // 
            // uxShowtimeLabel
            // 
            this.uxShowtimeLabel.AutoSize = true;
            this.uxShowtimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxShowtimeLabel.Location = new System.Drawing.Point(9, 343);
            this.uxShowtimeLabel.Name = "uxShowtimeLabel";
            this.uxShowtimeLabel.Size = new System.Drawing.Size(72, 17);
            this.uxShowtimeLabel.TabIndex = 2;
            this.uxShowtimeLabel.Text = "Showtime:";
            // 
            // uxTheaterLabel
            // 
            this.uxTheaterLabel.AutoSize = true;
            this.uxTheaterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxTheaterLabel.Location = new System.Drawing.Point(12, 32);
            this.uxTheaterLabel.Name = "uxTheaterLabel";
            this.uxTheaterLabel.Size = new System.Drawing.Size(84, 17);
            this.uxTheaterLabel.TabIndex = 4;
            this.uxTheaterLabel.Text = "Theater List";
            // 
            // uxMovieLabel
            // 
            this.uxMovieLabel.AutoSize = true;
            this.uxMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.uxMovieLabel.Location = new System.Drawing.Point(292, 32);
            this.uxMovieLabel.Name = "uxMovieLabel";
            this.uxMovieLabel.Size = new System.Drawing.Size(71, 17);
            this.uxMovieLabel.TabIndex = 5;
            this.uxMovieLabel.Text = "Movie List";
            // 
            // uxMovieListBox
            // 
            this.uxMovieListBox.FormattingEnabled = true;
            this.uxMovieListBox.Location = new System.Drawing.Point(295, 62);
            this.uxMovieListBox.Name = "uxMovieListBox";
            this.uxMovieListBox.Size = new System.Drawing.Size(148, 212);
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
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxHistory});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(466, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // uxHistory
            // 
            this.uxHistory.Name = "uxHistory";
            this.uxHistory.Size = new System.Drawing.Size(80, 22);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(9, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Military Time using 15 minutes increments";
            // 
            // uxCustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 397);
            this.Controls.Add(this.label1);
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
            this.Text = "Customer";
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
        private System.Windows.Forms.ToolStripLabel uxHistory;
        private System.Windows.Forms.NumericUpDown uxHoursNumeric;
        private System.Windows.Forms.NumericUpDown uxMinutesNumeric;
        private System.Windows.Forms.Label label1;
    }
}

