namespace _560Theater
{
    partial class ShowTimeGUI
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
            this.uxShowtimeListView = new System.Windows.Forms.ListView();
            this.chMovieName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTheaterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chShowtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxBuyTicket = new System.Windows.Forms.Button();
            this.chLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // uxShowtimeListView
            // 
            this.uxShowtimeListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.uxShowtimeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMovieName,
            this.chTheaterName,
            this.chLocation,
            this.chShowtime,
            this.chRoom});
            this.uxShowtimeListView.FullRowSelect = true;
            this.uxShowtimeListView.Location = new System.Drawing.Point(21, 24);
            this.uxShowtimeListView.MultiSelect = false;
            this.uxShowtimeListView.Name = "uxShowtimeListView";
            this.uxShowtimeListView.Size = new System.Drawing.Size(668, 236);
            this.uxShowtimeListView.TabIndex = 0;
            this.uxShowtimeListView.UseCompatibleStateImageBehavior = false;
            this.uxShowtimeListView.View = System.Windows.Forms.View.Details;
            // 
            // chMovieName
            // 
            this.chMovieName.Text = "Movie Name";
            this.chMovieName.Width = 100;
            // 
            // chTheaterName
            // 
            this.chTheaterName.Text = "Theater Name";
            this.chTheaterName.Width = 145;
            // 
            // chShowtime
            // 
            this.chShowtime.Text = "ShowTime";
            this.chShowtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chShowtime.Width = 162;
            // 
            // chRoom
            // 
            this.chRoom.Text = "Room";
            this.chRoom.Width = 138;
            // 
            // uxBuyTicket
            // 
            this.uxBuyTicket.Location = new System.Drawing.Point(21, 311);
            this.uxBuyTicket.Name = "uxBuyTicket";
            this.uxBuyTicket.Size = new System.Drawing.Size(121, 55);
            this.uxBuyTicket.TabIndex = 1;
            this.uxBuyTicket.Text = "Buy Ticket";
            this.uxBuyTicket.UseVisualStyleBackColor = true;
            this.uxBuyTicket.Click += new System.EventHandler(this.uxBuyTicket_Click);
            // 
            // chLocation
            // 
            this.chLocation.Text = "Location";
            this.chLocation.Width = 166;
            // 
            // ShowTimeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 404);
            this.Controls.Add(this.uxBuyTicket);
            this.Controls.Add(this.uxShowtimeListView);
            this.Name = "ShowTimeGUI";
            this.Text = "ShowTimeGUI";
            this.Load += new System.EventHandler(this.ShowTimeGUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView uxShowtimeListView;
        private System.Windows.Forms.Button uxBuyTicket;
        private System.Windows.Forms.ColumnHeader chMovieName;
        private System.Windows.Forms.ColumnHeader chTheaterName;
        private System.Windows.Forms.ColumnHeader chShowtime;
        private System.Windows.Forms.ColumnHeader chRoom;
        private System.Windows.Forms.ColumnHeader chLocation;
    }
}