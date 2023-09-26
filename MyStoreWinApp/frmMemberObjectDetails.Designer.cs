namespace MyStoreWinApp
{
    partial class frmMemberObjectDetails
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
            lbMemberName = new Label();
            lbMemberID = new Label();
            lbEmail = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            lbPassword = new Label();
            txtMemberName = new TextBox();
            txtMemberID = new TextBox();
            txtEmail = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(49, 50);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(109, 20);
            lbMemberName.TabIndex = 0;
            lbMemberName.Text = "Member Name";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(49, 89);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(84, 20);
            lbMemberID.TabIndex = 1;
            lbMemberID.Text = "Member ID";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(49, 130);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(381, 50);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 3;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(381, 89);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 4;
            lbCountry.Text = "Country";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(381, 134);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 5;
            lbPassword.Text = "Password";
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(164, 43);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(181, 27);
            txtMemberName.TabIndex = 6;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(164, 86);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(181, 27);
            txtMemberID.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(164, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(181, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(466, 43);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(181, 27);
            txtCity.TabIndex = 9;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(466, 82);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(181, 27);
            txtCountry.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(466, 127);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(181, 27);
            txtPassword.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(164, 195);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(466, 195);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmMemberObjectDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 262);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberID);
            Controls.Add(txtMemberName);
            Controls.Add(lbPassword);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberID);
            Controls.Add(lbMemberName);
            Name = "frmMemberObjectDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMemberObjectDetails";
            Load += frmMemberObjectDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberName;
        private Label lbMemberID;
        private Label lbEmail;
        private Label lbCity;
        private Label lbCountry;
        private Label lbPassword;
        private TextBox txtMemberName;
        private TextBox txtMemberID;
        private TextBox txtEmail;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPassword;
        private Button btnSave;
        private Button btnCancel;
    }
}