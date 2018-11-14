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
            this.uxHistoryListBox = new System.Windows.Forms.ListBox();
            this.uxHistoryRemoveSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxHistoryListBox
            // 
            this.uxHistoryListBox.FormattingEnabled = true;
            this.uxHistoryListBox.Location = new System.Drawing.Point(24, 26);
            this.uxHistoryListBox.Name = "uxHistoryListBox";
            this.uxHistoryListBox.Size = new System.Drawing.Size(229, 238);
            this.uxHistoryListBox.TabIndex = 0;
            // 
            // uxHistoryRemoveSelected
            // 
            this.uxHistoryRemoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.uxHistoryRemoveSelected.Location = new System.Drawing.Point(77, 302);
            this.uxHistoryRemoveSelected.Name = "uxHistoryRemoveSelected";
            this.uxHistoryRemoveSelected.Size = new System.Drawing.Size(117, 40);
            this.uxHistoryRemoveSelected.TabIndex = 1;
            this.uxHistoryRemoveSelected.Text = "Remove Selected";
            this.uxHistoryRemoveSelected.UseVisualStyleBackColor = true;
            this.uxHistoryRemoveSelected.Click += new System.EventHandler(this.uxHistoryRemoveSelected_Click);
            // 
            // HistoryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 365);
            this.Controls.Add(this.uxHistoryRemoveSelected);
            this.Controls.Add(this.uxHistoryListBox);
            this.Name = "HistoryGUI";
            this.Text = "HistoryGUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxHistoryListBox;
        private System.Windows.Forms.Button uxHistoryRemoveSelected;
    }
}