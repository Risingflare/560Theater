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
            this.uxEmailTextbox = new System.Windows.Forms.TextBox();
            this.uxLogin = new System.Windows.Forms.Button();
            this.uxNewAccount = new System.Windows.Forms.Button();
            this.uxPasswordBox = new System.Windows.Forms.TextBox();
            this.uxEmailLabel = new System.Windows.Forms.Label();
            this.uxPswLabel = new System.Windows.Forms.Label();
            this.uxAdminRadioButton = new System.Windows.Forms.RadioButton();
            this.uxCustomerRadioButton = new System.Windows.Forms.RadioButton();
            this.uxDontHaveAcctLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxReadOnlyTxtbox = new System.Windows.Forms.TextBox();
            this.uxHelpProvider = new System.Windows.Forms.HelpProvider();
            this.uxHelpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.uxAdminRadioButton.Location = new System.Drawing.Point(64, 43);
            this.uxAdminRadioButton.Name = "uxAdminRadioButton";
            this.uxAdminRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxAdminRadioButton.Size = new System.Drawing.Size(101, 28);
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
            this.uxCustomerRadioButton.Size = new System.Drawing.Size(130, 28);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam CLM", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(254, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Welcome!";
            // 
            // uxReadOnlyTxtbox
            // 
            this.uxReadOnlyTxtbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.uxReadOnlyTxtbox.Location = new System.Drawing.Point(248, 73);
            this.uxReadOnlyTxtbox.Multiline = true;
            this.uxReadOnlyTxtbox.Name = "uxReadOnlyTxtbox";
            this.uxReadOnlyTxtbox.ReadOnly = true;
            this.uxReadOnlyTxtbox.Size = new System.Drawing.Size(150, 36);
            this.uxReadOnlyTxtbox.TabIndex = 13;
            this.uxReadOnlyTxtbox.Text = "Create an account or login with an existing account.";
            // 
            // uxHelpButton
            // 
            this.uxHelpButton.BackColor = System.Drawing.Color.Red;
            this.uxHelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHelpButton.Location = new System.Drawing.Point(402, 12);
            this.uxHelpButton.Name = "uxHelpButton";
            this.uxHelpButton.Size = new System.Drawing.Size(47, 27);
            this.uxHelpButton.TabIndex = 14;
            this.uxHelpButton.Text = "Help";
            this.uxHelpButton.UseVisualStyleBackColor = false;
            this.uxHelpButton.Click += new System.EventHandler(this.uxHelpButton_Click);
            // 
            // uxLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(461, 296);
            this.Controls.Add(this.uxHelpButton);
            this.Controls.Add(this.uxReadOnlyTxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDontHaveAcctLabel);
            this.Controls.Add(this.uxCustomerRadioButton);
            this.Controls.Add(this.uxAdminRadioButton);
            this.Controls.Add(this.uxPswLabel);
            this.Controls.Add(this.uxEmailLabel);
            this.Controls.Add(this.uxPasswordBox);
            this.Controls.Add(this.uxNewAccount);
            this.Controls.Add(this.uxLogin);
            this.Controls.Add(this.uxEmailTextbox);
            this.Name = "uxLoginScreen";
            this.ShowIcon = false;
            this.Text = "TheaterZone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uxEmailTextbox;
        private System.Windows.Forms.Button uxLogin;
        private System.Windows.Forms.Button uxNewAccount;
        private System.Windows.Forms.TextBox uxPasswordBox;
        private System.Windows.Forms.Label uxEmailLabel;
        private System.Windows.Forms.Label uxPswLabel;
        private System.Windows.Forms.RadioButton uxAdminRadioButton;
        private System.Windows.Forms.RadioButton uxCustomerRadioButton;
        private System.Windows.Forms.Label uxDontHaveAcctLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxReadOnlyTxtbox;
        private System.Windows.Forms.HelpProvider uxHelpProvider;
        private System.Windows.Forms.Button uxHelpButton;
    }
}