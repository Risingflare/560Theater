namespace _560Theater
{
    partial class uxLoginScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxLoginTextbox = new System.Windows.Forms.TextBox();
            this.uxLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uxPasswordBox = new System.Windows.Forms.TextBox();
            this.uxUserLabel = new System.Windows.Forms.Label();
            this.uxPassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This form hasn\'t been implemented yet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please put 1 in the textbox to access Admin GUI and click Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "or put 2 in the textbox to access CustomerGUI and click Login";
            // 
            // uxLoginTextbox
            // 
            this.uxLoginTextbox.Location = new System.Drawing.Point(86, 99);
            this.uxLoginTextbox.Name = "uxLoginTextbox";
            this.uxLoginTextbox.Size = new System.Drawing.Size(100, 20);
            this.uxLoginTextbox.TabIndex = 3;
            this.uxLoginTextbox.VisibleChanged += new System.EventHandler(this.uxLoginTextbox_VisibleChanged);
            // 
            // uxLogin
            // 
            this.uxLogin.Location = new System.Drawing.Point(86, 209);
            this.uxLogin.Name = "uxLogin";
            this.uxLogin.Size = new System.Drawing.Size(100, 43);
            this.uxLogin.TabIndex = 4;
            this.uxLogin.Text = "Login";
            this.uxLogin.UseVisualStyleBackColor = true;
            this.uxLogin.Click += new System.EventHandler(this.uxLogin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uxPasswordBox
            // 
            this.uxPasswordBox.Location = new System.Drawing.Point(86, 138);
            this.uxPasswordBox.Name = "uxPasswordBox";
            this.uxPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.uxPasswordBox.TabIndex = 6;
            // 
            // uxUserLabel
            // 
            this.uxUserLabel.AutoSize = true;
            this.uxUserLabel.Location = new System.Drawing.Point(14, 102);
            this.uxUserLabel.Name = "uxUserLabel";
            this.uxUserLabel.Size = new System.Drawing.Size(55, 13);
            this.uxUserLabel.TabIndex = 7;
            this.uxUserLabel.Text = "Username";
            // 
            // uxPassLabel
            // 
            this.uxPassLabel.AutoSize = true;
            this.uxPassLabel.Location = new System.Drawing.Point(14, 141);
            this.uxPassLabel.Name = "uxPassLabel";
            this.uxPassLabel.Size = new System.Drawing.Size(53, 13);
            this.uxPassLabel.TabIndex = 8;
            this.uxPassLabel.Text = "Password";
            // 
            // uxLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 296);
            this.Controls.Add(this.uxPassLabel);
            this.Controls.Add(this.uxUserLabel);
            this.Controls.Add(this.uxPasswordBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxLogin);
            this.Controls.Add(this.uxLoginTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uxLoginScreen";
            this.Text = "LoginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxLoginTextbox;
        private System.Windows.Forms.Button uxLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox uxPasswordBox;
        private System.Windows.Forms.Label uxUserLabel;
        private System.Windows.Forms.Label uxPassLabel;
    }
}