using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        private String userRole;
        private String userEmail;
        public frmMemberManagement(String role, String email)
        {
            InitializeComponent();
            userRole = role;
            userEmail = email;
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
            btnSearch.Enabled = false;
            btnFilter.Enabled = false;
            dgvMemberList.CellContentDoubleClick += DgvMemberList_CellDoubleClick;
        }


        private void DgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberObjectDetails frmMemberObjectDetails = new frmMemberObjectDetails
            {
                Text = "Update member",
                InsertOrUpdate = true,
                MemberInfo = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frmMemberObjectDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList(userEmail);
                source.Position = source.Count - 1;
            }
        }

        public void LoadMemberList(string filterEmail = null)
        {
            var memberObjects = memberRepository.GetMemberObjects();
            try
            {
                source = new BindingSource();

                // If filterEmail is not null, only display members with corresponding email addresses.
                if (!string.IsNullOrEmpty(filterEmail))
                {
                    memberObjects = memberObjects.Where(mem => mem.Email == filterEmail).ToList();
                }

                source.DataSource = memberObjects;

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtCity.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

                if (memberObjects.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                    btnFilter.Enabled = false;
                    btnSearch.Enabled = false;
                }
                else
                {
                    btnSearch.Enabled = true;
                    btnFilter.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }


        private void ClearText()
        {
            txtEmail.Text = string.Empty;
            txtMemberID.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private MemberObject GetMemberObject()
        {
            MemberObject memberObject = null;
            try
            {
                memberObject = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get memberObject");
            }
            return memberObject;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userRole) || userRole != "Admin")
            {
                // If userRole is null or not "Admin," load only members with email addresses corresponding to userEmail.
                LoadMemberList(userEmail);
                btnSearch.Enabled = false;
                btnFilter.Enabled = false;
            }
            else if (userRole == "Admin")
            {
                // If userRole is "Admin," allow the user to perform all functions.
                LoadMemberList();
                btnDelete.Enabled = true;
                btnAdd.Enabled = true;
            }
            cbSort.Checked = false;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberObjectDetails frmMemberObjectDetails = new frmMemberObjectDetails
            {
                Text = "Add member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };

            if (frmMemberObjectDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var memberObject = GetMemberObject();
                memberRepository.DeleteMemberObject(memberObject.MemberID);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private bool isDescending = false; // Variable to track sorting order

        private void SortMembers()
        {
            try
            {
                // Get the current member list
                var memberObjects = memberRepository.GetMemberObjects();

                // Toggle sorting order based on isDescending variable
                var sortedMembers = isDescending
                    ? memberObjects.OrderBy(mem => mem.MemberName).ToList()
                    : memberObjects.OrderByDescending(mem => mem.MemberName).ToList();

                // Update the DataGridView with the sorted list
                source = new BindingSource();
                source.DataSource = sortedMembers;

                // Clear existing data bindings
                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                // Add data bindings with the sorted list
                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

                // Toggle the sorting order
                isDescending = !isDescending;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sort members");
            }
        }
        private void cbSort_CheckedChanged(object sender, EventArgs e)
        {
            isDescending = !isDescending;
            SortMembers();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the search criteria from the TextBox controls
            int? searchID = !string.IsNullOrWhiteSpace(txtSearchID.Text) ? int.Parse(txtSearchID.Text) : (int?)null;
            string searchName = txtSearchName.Text.Trim();

            if (!string.IsNullOrEmpty(txtSearchID.Text))
            {
                if (!int.TryParse(txtSearchID.Text, out int tempSearchID))
                {
                    MessageBox.Show("Invalid Member ID. Please enter a valid numeric ID.");
                    return;
                }
                searchID = tempSearchID; // Assign the parsed value to searchID
            }

            // Get the current member list
            var memberObjects = memberRepository.GetMemberObjects();

            // Perform the search based on the entered criteria
            var searchResults = memberObjects
             .Where(mem => (!searchID.HasValue || mem.MemberID == searchID.Value) && (string.IsNullOrWhiteSpace(searchName) || mem.MemberName.Contains(searchName, StringComparison.OrdinalIgnoreCase)))
             .ToList();


            // Check if txtSearchName is empty, if not, filter by MemberName
            if (!string.IsNullOrEmpty(searchName))
            {
                searchResults = searchResults
                    .Where(mem => mem.MemberName.Contains(searchName, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // Filter by MemberID if searchID has a value
            if (searchID.HasValue)
            {
                searchResults = searchResults
                    .Where(mem => mem.MemberID == searchID)
                    .ToList();
            }

            // Display the search results in a DataGridView control
            source = new BindingSource();
            source.DataSource = searchResults;

            txtMemberID.DataBindings.Clear();
            txtMemberName.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtCountry.DataBindings.Clear();

            txtMemberID.DataBindings.Add("Text", source, "MemberID");
            txtMemberName.DataBindings.Add("Text", source, "MemberName");
            txtEmail.DataBindings.Add("Text", source, "Email");
            txtPassword.DataBindings.Add("Text", source, "Password");
            txtCity.DataBindings.Add("Text", source, "City");
            txtCountry.DataBindings.Add("Text", source, "Country");

            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = source;

            if (searchResults.Count == 0)
            {
                MessageBox.Show("No matching members found.");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Get the filter criteria from the TextBox controls
            string cityFilter = txtFilterCity.Text.Trim();
            string countryFilter = txtFilterCountry.Text.Trim();

            // Get the current member list
            var memberObjects = memberRepository.GetMemberObjects();

            // Perform the filtering based on the entered criteria
            var filteredMembers = memberObjects
                .Where(mem =>
                    (string.IsNullOrEmpty(cityFilter) || mem.City.Contains(cityFilter, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(countryFilter) || mem.Country.Contains(countryFilter, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            // Display the filtered members in the DataGridView control
            source = new BindingSource();
            source.DataSource = filteredMembers;

            txtMemberID.DataBindings.Clear();
            txtMemberName.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtCountry.DataBindings.Clear();

            txtMemberID.DataBindings.Add("Text", source, "MemberID");
            txtMemberName.DataBindings.Add("Text", source, "MemberName");
            txtEmail.DataBindings.Add("Text", source, "Email");
            txtPassword.DataBindings.Add("Text", source, "Password");
            txtCity.DataBindings.Add("Text", source, "City");
            txtCountry.DataBindings.Add("Text", source, "Country");

            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = source;

            if (filteredMembers.Count == 0)
            {
                MessageBox.Show("No matching members found.");
            }
        }
    }
}
