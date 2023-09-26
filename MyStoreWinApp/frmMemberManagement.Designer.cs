namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            lbMemberInformation = new Label();
            lbEmail = new Label();
            lbMemberID = new Label();
            lbCity = new Label();
            lbPassword = new Label();
            lbMemberName = new Label();
            lbCountry = new Label();
            txtEmail = new TextBox();
            txtMemberID = new TextBox();
            txtCity = new TextBox();
            txtPassword = new TextBox();
            txtMemberName = new TextBox();
            txtCountry = new TextBox();
            btnDelete = new Button();
            btnAdd = new Button();
            dgvMemberList = new DataGridView();
            btnLoad = new Button();
            btnClose = new Button();
            cbSort = new CheckBox();
            txtSearchID = new TextBox();
            txtSearchName = new TextBox();
            btnSearch = new Button();
            lbSearchID = new Label();
            lbSearchName = new Label();
            txtFilterCity = new TextBox();
            txtFilterCountry = new TextBox();
            btnFilter = new Button();
            lbFilterCity = new Label();
            lbFilterCountry = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // lbMemberInformation
            // 
            lbMemberInformation.AutoSize = true;
            lbMemberInformation.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbMemberInformation.Location = new Point(12, 9);
            lbMemberInformation.Name = "lbMemberInformation";
            lbMemberInformation.Size = new Size(358, 46);
            lbMemberInformation.TabIndex = 0;
            lbMemberInformation.Text = "Member Information";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(12, 93);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(12, 153);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(84, 20);
            lbMemberID.TabIndex = 2;
            lbMemberID.Text = "Member ID";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(12, 214);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 3;
            lbCity.Text = "City";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(434, 93);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(434, 153);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(109, 20);
            lbMemberName.TabIndex = 5;
            lbMemberName.Text = "Member Name";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(434, 214);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 6;
            lbCountry.Text = "Country";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(102, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(262, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(102, 146);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.ReadOnly = true;
            txtMemberID.Size = new Size(262, 27);
            txtMemberID.TabIndex = 8;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(102, 207);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(262, 27);
            txtCity.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(552, 86);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(262, 27);
            txtPassword.TabIndex = 10;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(552, 146);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.ReadOnly = true;
            txtMemberName.Size = new Size(262, 27);
            txtMemberName.TabIndex = 11;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(552, 207);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(262, 27);
            txtCountry.TabIndex = 12;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(635, 263);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(380, 263);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(12, 442);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(802, 253);
            dgvMemberList.TabIndex = 16;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(101, 263);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 17;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(369, 701);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cbSort
            // 
            cbSort.AutoSize = true;
            cbSort.Location = new Point(732, 412);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(81, 24);
            cbSort.TabIndex = 20;
            cbSort.Text = "Sort list";
            cbSort.UseVisualStyleBackColor = true;
            cbSort.CheckedChanged += cbSort_CheckedChanged;
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(12, 343);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(219, 27);
            txtSearchID.TabIndex = 21;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(255, 343);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(219, 27);
            txtSearchName.TabIndex = 22;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(491, 341);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbSearchID
            // 
            lbSearchID.AutoSize = true;
            lbSearchID.Location = new Point(12, 320);
            lbSearchID.Name = "lbSearchID";
            lbSearchID.Size = new Size(24, 20);
            lbSearchID.TabIndex = 24;
            lbSearchID.Text = "ID";
            // 
            // lbSearchName
            // 
            lbSearchName.AutoSize = true;
            lbSearchName.Location = new Point(255, 320);
            lbSearchName.Name = "lbSearchName";
            lbSearchName.Size = new Size(49, 20);
            lbSearchName.TabIndex = 25;
            lbSearchName.Text = "Name";
            // 
            // txtFilterCity
            // 
            txtFilterCity.Location = new Point(12, 397);
            txtFilterCity.Name = "txtFilterCity";
            txtFilterCity.Size = new Size(219, 27);
            txtFilterCity.TabIndex = 26;
            // 
            // txtFilterCountry
            // 
            txtFilterCountry.Location = new Point(255, 397);
            txtFilterCountry.Name = "txtFilterCountry";
            txtFilterCountry.Size = new Size(219, 27);
            txtFilterCountry.TabIndex = 27;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(491, 397);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 28;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // lbFilterCity
            // 
            lbFilterCity.AutoSize = true;
            lbFilterCity.Location = new Point(12, 374);
            lbFilterCity.Name = "lbFilterCity";
            lbFilterCity.Size = new Size(34, 20);
            lbFilterCity.TabIndex = 29;
            lbFilterCity.Text = "City";
            // 
            // lbFilterCountry
            // 
            lbFilterCountry.AutoSize = true;
            lbFilterCountry.Location = new Point(254, 374);
            lbFilterCountry.Name = "lbFilterCountry";
            lbFilterCountry.Size = new Size(60, 20);
            lbFilterCountry.TabIndex = 30;
            lbFilterCountry.Text = "Country";
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 742);
            Controls.Add(lbFilterCountry);
            Controls.Add(lbFilterCity);
            Controls.Add(btnFilter);
            Controls.Add(txtFilterCountry);
            Controls.Add(txtFilterCity);
            Controls.Add(lbSearchName);
            Controls.Add(lbSearchID);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchName);
            Controls.Add(txtSearchID);
            Controls.Add(cbSort);
            Controls.Add(btnClose);
            Controls.Add(btnLoad);
            Controls.Add(dgvMemberList);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(txtCountry);
            Controls.Add(txtMemberName);
            Controls.Add(txtPassword);
            Controls.Add(txtCity);
            Controls.Add(txtMemberID);
            Controls.Add(txtEmail);
            Controls.Add(lbCountry);
            Controls.Add(lbMemberName);
            Controls.Add(lbPassword);
            Controls.Add(lbCity);
            Controls.Add(lbMemberID);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberInformation);
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Management";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberInformation;
        private Label lbEmail;
        private Label lbMemberID;
        private Label lbCity;
        private Label lbPassword;
        private Label lbMemberName;
        private Label lbCountry;
        private TextBox txtEmail;
        private TextBox txtMemberID;
        private TextBox txtCity;
        private TextBox txtPassword;
        private TextBox txtMemberName;
        private TextBox txtCountry;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvMemberList;
        private Button btnLoad;
        private Button btnClose;
        private RadioButton rbtnSort;
        private CheckBox cbSort;
        private TextBox txtSearchID;
        private TextBox txtSearchName;
        private Button btnSearch;
        private Label lbSearchID;
        private Label lbSearchName;
        private TextBox txtFilterCity;
        private TextBox txtFilterCountry;
        private Button btnFilter;
        private Label lbFilterCity;
        private Label lbFilterCountry;
    }
}