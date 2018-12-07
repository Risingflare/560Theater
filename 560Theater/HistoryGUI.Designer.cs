namespace _560Theater
{
    partial class HistoryGUI
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
            this.uxHistoryRemoveSelected = new System.Windows.Forms.Button();
            this.uxHistoryListView = new System.Windows.Forms.ListView();
            this.chMovieName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTheater = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chShowtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPurchaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // uxHistoryRemoveSelected
            // 
            this.uxHistoryRemoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.uxHistoryRemoveSelected.Location = new System.Drawing.Point(208, 301);
            this.uxHistoryRemoveSelected.Name = "uxHistoryRemoveSelected";
            this.uxHistoryRemoveSelected.Size = new System.Drawing.Size(117, 40);
            this.uxHistoryRemoveSelected.TabIndex = 1;
            this.uxHistoryRemoveSelected.Text = "Remove Selected";
            this.uxHistoryRemoveSelected.UseVisualStyleBackColor = true;
            this.uxHistoryRemoveSelected.Click += new System.EventHandler(this.uxHistoryRemoveSelected_Click);
            // 
            // uxHistoryListView
            // 
            this.uxHistoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMovieName,
            this.chTheater,
            this.chLocation,
            this.chShowtime,
            this.chRoom,
            this.chPurchaseDate});
            this.uxHistoryListView.FullRowSelect = true;
            this.uxHistoryListView.Location = new System.Drawing.Point(12, 21);
            this.uxHistoryListView.Name = "uxHistoryListView";
            this.uxHistoryListView.Size = new System.Drawing.Size(521, 240);
            this.uxHistoryListView.TabIndex = 2;
            this.uxHistoryListView.UseCompatibleStateImageBehavior = false;
            this.uxHistoryListView.View = System.Windows.Forms.View.Details;
            // 
            // chMovieName
            // 
            this.chMovieName.Text = "Movie Name";
            this.chMovieName.Width = 91;
            // 
            // chTheater
            // 
            this.chTheater.Text = "Theater";
            this.chTheater.Width = 86;
            // 
            // chLocation
            // 
            this.chLocation.Text = "Location";
            // 
            // chShowtime
            // 
            this.chShowtime.Text = "Showtime";
            this.chShowtime.Width = 99;
            // 
            // chRoom
            // 
            this.chRoom.Text = "Room";
            // 
            // chPurchaseDate
            // 
            this.chPurchaseDate.Text = "Purchase Date";
            this.chPurchaseDate.Width = 93;
            // 
            // HistoryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 365);
            this.Controls.Add(this.uxHistoryListView);
            this.Controls.Add(this.uxHistoryRemoveSelected);
            this.Name = "HistoryGUI";
            this.Text = "HistoryGUI";
            this.Load += new System.EventHandler(this.HistoryGUI_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button uxHistoryRemoveSelected;
        private System.Windows.Forms.ListView uxHistoryListView;
        private System.Windows.Forms.ColumnHeader chMovieName;
        private System.Windows.Forms.ColumnHeader chTheater;
        private System.Windows.Forms.ColumnHeader chLocation;
        private System.Windows.Forms.ColumnHeader chShowtime;
        private System.Windows.Forms.ColumnHeader chRoom;
        private System.Windows.Forms.ColumnHeader chPurchaseDate;
    }
}