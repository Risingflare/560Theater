namespace _560Theater
{
    partial class CreateAccount
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
            this.uxFNameTxtbox = new System.Windows.Forms.TextBox();
            this.uxLastNameTxt = new System.Windows.Forms.TextBox();
            this.uxEmailAddressTxt = new System.Windows.Forms.TextBox();
            this.uxPasswordTxt = new System.Windows.Forms.TextBox();
            this.uxCreateAcctLabel = new System.Windows.Forms.Label();
            this.uxEmailLabel = new System.Windows.Forms.Label();
            this.uxFNameLabel = new System.Windows.Forms.Label();
            this.uxLNameLabel = new System.Windows.Forms.Label();
            this.uxPasswordLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // uxFNameTxtbox
            // 
            this.uxFNameTxtbox.Location = new System.Drawing.Point(138, 118);
            this.uxFNameTxtbox.Name = "uxFNameTxtbox";
            this.uxFNameTxtbox.Size = new System.Drawing.Size(192, 20);
            this.uxFNameTxtbox.TabIndex = 0;
            // 
            // uxLastNameTxt
            // 
            this.uxLastNameTxt.Location = new System.Drawing.Point(138, 164);
            this.uxLastNameTxt.Name = "uxLastNameTxt";
            this.uxLastNameTxt.Size = new System.Drawing.Size(192, 20);
            this.uxLastNameTxt.TabIndex = 1;
            // 
            // uxEmailAddressTxt
            // 
            this.uxEmailAddressTxt.Location = new System.Drawing.Point(138, 211);
            this.uxEmailAddressTxt.Name = "uxEmailAddressTxt";
            this.uxEmailAddressTxt.Size = new System.Drawing.Size(192, 20);
            this.uxEmailAddressTxt.TabIndex = 2;
            // 
            // uxPasswordTxt
            // 
            this.uxPasswordTxt.Location = new System.Drawing.Point(138, 250);
            this.uxPasswordTxt.Name = "uxPasswordTxt";
            this.uxPasswordTxt.Size = new System.Drawing.Size(192, 20);
            this.uxPasswordTxt.TabIndex = 3;
            // 
            // uxCreateAcctLabel
            // 
            this.uxCreateAcctLabel.AutoSize = true;
            this.uxCreateAcctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCreateAcctLabel.Location = new System.Drawing.Point(133, 57);
            this.uxCreateAcctLabel.Name = "uxCreateAcctLabel";
            this.uxCreateAcctLabel.Size = new System.Drawing.Size(192, 25);
            this.uxCreateAcctLabel.TabIndex = 4;
            this.uxCreateAcctLabel.Text = "Create an Account";
            // 
            // uxEmailLabel
            // 
            this.uxEmailLabel.AutoSize = true;
            this.uxEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxEmailLabel.Location = new System.Drawing.Point(12, 211);
            this.uxEmailLabel.Name = "uxEmailLabel";
            this.uxEmailLabel.Size = new System.Drawing.Size(111, 20);
            this.uxEmailLabel.TabIndex = 5;
            this.uxEmailLabel.Text = "Email Address";
            // 
            // uxFNameLabel
            // 
            this.uxFNameLabel.AutoSize = true;
            this.uxFNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxFNameLabel.Location = new System.Drawing.Point(34, 116);
            this.uxFNameLabel.Name = "uxFNameLabel";
            this.uxFNameLabel.Size = new System.Drawing.Size(86, 20);
            this.uxFNameLabel.TabIndex = 6;
            this.uxFNameLabel.Text = "First Name";
            // 
            // uxLNameLabel
            // 
            this.uxLNameLabel.AutoSize = true;
            this.uxLNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxLNameLabel.Location = new System.Drawing.Point(34, 162);
            this.uxLNameLabel.Name = "uxLNameLabel";
            this.uxLNameLabel.Size = new System.Drawing.Size(86, 20);
            this.uxLNameLabel.TabIndex = 7;
            this.uxLNameLabel.Text = "Last Name";
            // 
            // uxPasswordLabel
            // 
            this.uxPasswordLabel.AutoSize = true;
            this.uxPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxPasswordLabel.Location = new System.Drawing.Point(42, 250);
            this.uxPasswordLabel.Name = "uxPasswordLabel";
            this.uxPasswordLabel.Size = new System.Drawing.Size(78, 20);
            this.uxPasswordLabel.TabIndex = 8;
            this.uxPasswordLabel.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxPasswordLabel);
            this.Controls.Add(this.uxLNameLabel);
            this.Controls.Add(this.uxFNameLabel);
            this.Controls.Add(this.uxEmailLabel);
            this.Controls.Add(this.uxCreateAcctLabel);
            this.Controls.Add(this.uxPasswordTxt);
            this.Controls.Add(this.uxEmailAddressTxt);
            this.Controls.Add(this.uxLastNameTxt);
            this.Controls.Add(this.uxFNameTxtbox);
            this.Location = new System.Drawing.Point(0, -50);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxFNameTxtbox;
        private System.Windows.Forms.TextBox uxLastNameTxt;
        private System.Windows.Forms.TextBox uxEmailAddressTxt;
        private System.Windows.Forms.TextBox uxPasswordTxt;
        private System.Windows.Forms.Label uxCreateAcctLabel;
        private System.Windows.Forms.Label uxEmailLabel;
        private System.Windows.Forms.Label uxFNameLabel;
        private System.Windows.Forms.Label uxLNameLabel;
        private System.Windows.Forms.Label uxPasswordLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}