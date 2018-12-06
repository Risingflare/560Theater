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
            this.uxEmailTextbox = new System.Windows.Forms.TextBox();
            this.uxLogin = new System.Windows.Forms.Button();
            this.uxNewAccount = new System.Windows.Forms.Button();
            this.uxPasswordBox = new System.Windows.Forms.TextBox();
            this.uxEmailLabel = new System.Windows.Forms.Label();
            this.uxPswLabel = new System.Windows.Forms.Label();
            this.uxAdminRadioButton = new System.Windows.Forms.RadioButton();
            this.uxCustomerRadioButton = new System.Windows.Forms.RadioButton();
            this.uxDontHaveAcctLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authentication Complete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CustomerQuickLogin: \'c\' and \'c\'";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AdminQuickLogin: \'a\' and \'a\'";
            // 
            // uxEmailTextbox
            // 
            this.uxEmailTextbox.Location = new System.Drawing.Point(86, 111);
            this.uxEmailTextbox.Name = "uxEmailTextbox";
            this.uxEmailTextbox.Size = new System.Drawing.Size(100, 20);
            this.uxEmailTextbox.TabIndex = 0;
            this.uxEmailTextbox.VisibleChanged += new System.EventHandler(this.uxLoginTextbox_VisibleChanged);
            // 
            // uxLogin
            // 
            this.uxLogin.Location = new System.Drawing.Point(86, 186);
            this.uxLogin.Name = "uxLogin";
            this.uxLogin.Size = new System.Drawing.Size(100, 27);
            this.uxLogin.TabIndex = 4;
            this.uxLogin.Text = "Login";
            this.uxLogin.UseVisualStyleBackColor = true;
            this.uxLogin.Click += new System.EventHandler(this.uxLogin_Click);
            // 
            // uxNewAccount
            // 
            this.uxNewAccount.Location = new System.Drawing.Point(323, 238);
            this.uxNewAccount.Name = "uxNewAccount";
            this.uxNewAccount.Size = new System.Drawing.Size(117, 35);
            this.uxNewAccount.TabIndex = 5;
            this.uxNewAccount.Text = "Create Account";
            this.uxNewAccount.UseVisualStyleBackColor = true;
            this.uxNewAccount.Click += new System.EventHandler(this.uxCreateAccount_Click);
            // 
            // uxPasswordBox
            // 
            this.uxPasswordBox.Location = new System.Drawing.Point(86, 150);
            this.uxPasswordBox.Name = "uxPasswordBox";
            this.uxPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.uxPasswordBox.TabIndex = 1;
            // 
            // uxEmailLabel
            // 
            this.uxEmailLabel.AutoSize = true;
            this.uxEmailLabel.Location = new System.Drawing.Point(7, 114);
            this.uxEmailLabel.Name = "uxEmailLabel";
            this.uxEmailLabel.Size = new System.Drawing.Size(73, 13);
            this.uxEmailLabel.TabIndex = 7;
            this.uxEmailLabel.Text = "Email Address";
            // 
            // uxPswLabel
            // 
            this.uxPswLabel.AutoSize = true;
            this.uxPswLabel.Location = new System.Drawing.Point(12, 153);
            this.uxPswLabel.Name = "uxPswLabel";
            this.uxPswLabel.Size = new System.Drawing.Size(53, 13);
            this.uxPswLabel.TabIndex = 8;
            this.uxPswLabel.Text = "Password";
            // 
            // uxAdminRadioButton
            // 
            this.uxAdminRadioButton.AutoSize = true;
            this.uxAdminRadioButton.Font = new System.Drawing.Font("Miriam CLM", 8.249999F, System.Drawing.FontStyle.Bold);
            this.uxAdminRadioButton.Location = new System.Drawing.Point(62, 55);
            this.uxAdminRadioButton.Name = "uxAdminRadioButton";
            this.uxAdminRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxAdminRadioButton.Size = new System.Drawing.Size(55, 16);
            this.uxAdminRadioButton.TabIndex = 9;
            this.uxAdminRadioButton.Text = "Admin";
            this.uxAdminRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxCustomerRadioButton
            // 
            this.uxCustomerRadioButton.AutoSize = true;
            this.uxCustomerRadioButton.Font = new System.Drawing.Font("Miriam CLM", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.uxCustomerRadioButton.Location = new System.Drawing.Point(45, 77);
            this.uxCustomerRadioButton.Name = "uxCustomerRadioButton";
            this.uxCustomerRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxCustomerRadioButton.Size = new System.Drawing.Size(72, 16);
            this.uxCustomerRadioButton.TabIndex = 10;
            this.uxCustomerRadioButton.Text = "Customer";
            this.uxCustomerRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxDontHaveAcctLabel
            // 
            this.uxDontHaveAcctLabel.AutoSize = true;
            this.uxDontHaveAcctLabel.Location = new System.Drawing.Point(318, 222);
            this.uxDontHaveAcctLabel.Name = "uxDontHaveAcctLabel";
            this.uxDontHaveAcctLabel.Size = new System.Drawing.Size(122, 13);
            this.uxDontHaveAcctLabel.TabIndex = 11;
            this.uxDontHaveAcctLabel.Text = "Don\'t have an account?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Can use any admin/customer login in database";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Created Accounts are saved to database";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "RadioButton must match user";
            // 
            // uxLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 296);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxDontHaveAcctLabel);
            this.Controls.Add(this.uxCustomerRadioButton);
            this.Controls.Add(this.uxAdminRadioButton);
            this.Controls.Add(this.uxPswLabel);
            this.Controls.Add(this.uxEmailLabel);
            this.Controls.Add(this.uxPasswordBox);
            this.Controls.Add(this.uxNewAccount);
            this.Controls.Add(this.uxLogin);
            this.Controls.Add(this.uxEmailTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uxLoginScreen";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxEmailTextbox;
        private System.Windows.Forms.Button uxLogin;
        private System.Windows.Forms.Button uxNewAccount;
        private System.Windows.Forms.TextBox uxPasswordBox;
        private System.Windows.Forms.Label uxEmailLabel;
        private System.Windows.Forms.Label uxPswLabel;
        private System.Windows.Forms.RadioButton uxAdminRadioButton;
        private System.Windows.Forms.RadioButton uxCustomerRadioButton;
        private System.Windows.Forms.Label uxDontHaveAcctLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}