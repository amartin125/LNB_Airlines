using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  // adding an Access Object

namespace LNB_Airlines_Login
{
    public partial class Login : Form
    {

        // Create SQL Application
        private SqlConnection sqlConnection;
        private string connectionString = @"Data Source=DESKTOP-UPSRTGM\SQLEXPRESS;Initial Catalog=LNB_AirlinesDB;Integrated Security=True;TrustServerCertificate=True";


        public Login()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);

        }

        private bool ValidateUser(string username, string password, string role)
        {
            // Open the SQL connection
            sqlConnection.Open();

            // Update the query to check against the Users table and include role
            string query = @"SELECT COUNT(*) AS UserCount 
                     FROM Users 
                     WHERE Username = @username 
                     AND Password = @password 
                     AND Role = @role";

            // Create and configure the SQL command
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@role", role);

            // Execute the query and get the user count
            int userCount = (int)command.ExecuteScalar();

            // Close the connection
            sqlConnection.Close();

            // Return true if a user is found, false otherwise
            return userCount > 0;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // Step 1: Check if a role is selected
            if (!rdEmployee.Checked && !rdAdmin.Checked)
            {
                MessageBox.Show("Please select a valid role type."); // Debug message
                return;
            }

            // Step 2: Determine the selected role
            string userSelectedRole = rdEmployee.Checked ? "Employee" : "Admin";
            //MessageBox.Show($"Role selected: {userSelectedRole}"); // Debug message

            // Step 3: Validate the user credentials using the ValidateUser method
            bool isValidUser = ValidateUser(txtUsername.Text, txtPassword.Text, userSelectedRole);
            //MessageBox.Show($"User valid: {isValidUser}"); // Debug message

            if (isValidUser)
            {
                // Step 4: User role is correct, proceed based on the role
                if (userSelectedRole == "Admin")
                {
                    //MessageBox.Show("Navigating to Admin Form"); // Debug message
                    AdminForm adminForm = new AdminForm(); // Instantiate the AdminForm
                    adminForm.Show(); // Show the AdminForm
                    this.Hide(); // Hide the login form
                }
                else if (userSelectedRole == "Employee")
                {
                    //MessageBox.Show("Navigating to Employee Form"); // Debug message
                    EmployeeForm employeeForm = new EmployeeForm(); // Instantiate the EmployeeForm
                    employeeForm.Show(); // Show the EmployeeForm
                    this.Hide(); // Hide the login form
                }
            }
            else
            {
                // Step 5: Handle incorrect username or password
                MessageBox.Show("Incorrect username or password!"); // Debug message
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }

        private void rdAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
