namespace SQL_Connect
{
    partial class Display
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
            this.uxShowData = new System.Windows.Forms.Button();
            this.uxGrid = new System.Windows.Forms.DataGridView();
            this.cis560_team04_PersonTest_DataSet1 = new SQL_Connect.cis560_team04_PersonTest_DataSet();
            this.uxDisplayName = new System.Windows.Forms.TextBox();
            this.uxGetNameButton = new System.Windows.Forms.Button();
            this.uxEnterID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560_team04_PersonTest_DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxShowData
            // 
            this.uxShowData.Location = new System.Drawing.Point(200, 248);
            this.uxShowData.Name = "uxShowData";
            this.uxShowData.Size = new System.Drawing.Size(165, 40);
            this.uxShowData.TabIndex = 0;
            this.uxShowData.Text = "Show Data";
            this.uxShowData.UseVisualStyleBackColor = true;
            this.uxShowData.Click += new System.EventHandler(this.uxShowData_Click);
            // 
            // uxGrid
            // 
            this.uxGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGrid.Location = new System.Drawing.Point(127, 56);
            this.uxGrid.Name = "uxGrid";
            this.uxGrid.Size = new System.Drawing.Size(308, 183);
            this.uxGrid.TabIndex = 1;
            // 
            // cis560_team04_PersonTest_DataSet1
            // 
            this.cis560_team04_PersonTest_DataSet1.DataSetName = "cis560_team04_PersonTest_DataSet";
            this.cis560_team04_PersonTest_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uxDisplayName
            // 
            this.uxDisplayName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uxDisplayName.Location = new System.Drawing.Point(373, 356);
            this.uxDisplayName.Multiline = true;
            this.uxDisplayName.Name = "uxDisplayName";
            this.uxDisplayName.ReadOnly = true;
            this.uxDisplayName.Size = new System.Drawing.Size(124, 31);
            this.uxDisplayName.TabIndex = 2;
            // 
            // uxGetNameButton
            // 
            this.uxGetNameButton.Location = new System.Drawing.Point(221, 356);
            this.uxGetNameButton.Name = "uxGetNameButton";
            this.uxGetNameButton.Size = new System.Drawing.Size(124, 31);
            this.uxGetNameButton.TabIndex = 3;
            this.uxGetNameButton.Text = "Get Name";
            this.uxGetNameButton.UseVisualStyleBackColor = true;
            this.uxGetNameButton.Click += new System.EventHandler(this.uxGetPerson_Click);
            // 
            // uxEnterID
            // 
            this.uxEnterID.Location = new System.Drawing.Point(94, 362);
            this.uxEnterID.Name = "uxEnterID";
            this.uxEnterID.Size = new System.Drawing.Size(100, 20);
            this.uxEnterID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PersonID";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxEnterID);
            this.Controls.Add(this.uxGetNameButton);
            this.Controls.Add(this.uxDisplayName);
            this.Controls.Add(this.uxGrid);
            this.Controls.Add(this.uxShowData);
            this.Name = "Display";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.uxGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis560_team04_PersonTest_DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cis560_team04_PersonTest_DataSet cis560_team04_PersonTest_DataSet1;
        private System.Windows.Forms.Button uxShowData;
        private System.Windows.Forms.DataGridView uxGrid;
        private System.Windows.Forms.TextBox uxDisplayName;
        private System.Windows.Forms.Button uxGetNameButton;
        private System.Windows.Forms.TextBox uxEnterID;
        private System.Windows.Forms.Label label1;
    }
}

