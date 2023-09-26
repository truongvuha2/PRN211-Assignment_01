using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using BusinessObject;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }
        public IMemberRepository memberRepository = new MemberRepository();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Read the content of the appsettings.json file
                string json = File.ReadAllText("D:\\study\\project\\Ass01Solution\\MyStoreWinApp\\appsettings.json");

                // Parse the JSON content
                JObject jsonObject = JObject.Parse(json);

                // Get default account information from JSON
                string defaultEmail = (string)jsonObject["DefaultAccount"]["Email"];
                string defaultPassword = (string)jsonObject["DefaultAccount"]["Password"];
                string defaultRole = (string)jsonObject["DefaultAccount"]["Role"];

                // Get login information from the user
                string inputEmail = txtEmail.Text;
                string inputPassword = txtPassword.Text;

                MemberObject user = memberRepository.GetMemberByEmail(inputEmail);
                // Authenticate login information
                if (inputEmail == defaultEmail && inputPassword == defaultPassword)
                {
                    string userRole = defaultRole; // Assume the default role for admin

                    // Check if there's a user-specific role in the MemberDAO
                    // Continue with your application logic based on the user's role
                    if (userRole == "Admin")
                    {
                        //Open the admin dashboard
                        frmMemberManagement adminDashboardForm = new frmMemberManagement(userRole, inputEmail);
                        adminDashboardForm.Show();
                    }
                    this.Hide(); // Hide the login form after successful login
                }
                else if (user != null && user.Password == inputPassword)
                {
                    frmMemberManagement frmMemberManagement = new frmMemberManagement(null, inputEmail);
                    frmMemberManagement.Show();
                    this.Hide();
                }
                else
                {
                    // Authentication failed, display an error message
                    MessageBox.Show("Email or password is incorrect. Please try again.");
                }
            }
            catch (Exception ex)
            {
                // Handle errors when reading or parsing the JSON file
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnHideShow_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility();

        }
        private void TogglePasswordVisibility()
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
