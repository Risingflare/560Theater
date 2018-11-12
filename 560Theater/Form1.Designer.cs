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
            this.uxShowtimeLabel.Location = new System.Drawing.Point(45, 332);
            this.uxShowtimeLabel.Name = "uxShowtimeLabel";
            this.uxShowtimeLabel.Size = new System.Drawing.Size(53, 13);
            this.uxShowtimeLabel.TabIndex = 2;
            this.uxShowtimeLabel.Text = "Showtime";
            // 
            // uxTheaterLabel
            // 
            this.uxTheaterLabel.AutoSize = true;
            this.uxTheaterLabel.Location = new System.Drawing.Point(12, 32);
            this.uxTheaterLabel.Name = "uxTheaterLabel";
            this.uxTheaterLabel.Size = new System.Drawing.Size(63, 13);
            this.uxTheaterLabel.TabIndex = 4;
            this.uxTheaterLabel.Text = "Theater List";
            // 
            // uxMovieLabel
            // 
            this.uxMovieLabel.AutoSize = true;
            this.uxMovieLabel.Location = new System.Drawing.Point(292, 32);
            this.uxMovieLabel.Name = "uxMovieLabel";
            this.uxMovieLabel.Size = new System.Drawing.Size(55, 13);
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
            // uxCustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 397);
            this.Controls.Add(this.uxMovieListBox);
            this.Controls.Add(this.uxMovieLabel);
            this.Controls.Add(this.uxTheaterLabel);
            this.Controls.Add(this.uxShowtimeLabel);
            this.Controls.Add(this.uxTheaterListBox);
            this.Name = "uxCustomerUI";
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxTheaterListBox;
        private System.Windows.Forms.Label uxShowtimeLabel;
        private System.Windows.Forms.Label uxTheaterLabel;
        private System.Windows.Forms.Label uxMovieLabel;
        private System.Windows.Forms.ListBox uxMovieListBox;
    }
}

