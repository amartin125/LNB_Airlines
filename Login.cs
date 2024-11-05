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

namespace  LNB_Airlines

{
    public partial class Login : Form
    {

        // Create SQL Application
        //private SqlConnection sqlConnection;
        //private string connectionString = @"Data Source=DESKTOP-VEH3C8M\SQLEXPRESS01;Initial Catalog=VendorLogin;Integrated Security=True";


        public Login()
        {
            InitializeComponent();
            //sqlConnection = new SqlConnection();

        }

        //private bool ValidateUser(string username, string password, string role)
        //{
        //    // Open the SQL connection
        //    sqlConnection.Open();

        //    // Update the query to check against the Users table and include role
        //    string query = @"SELECT COUNT(*) AS UserCount 
        //             FROM Users 
        //             WHERE Username = @username 
        //             AND Password = @password 
        //             AND Role = @role";

        //    // Create and configure the SQL command
        //    SqlCommand command = new SqlCommand(query, sqlConnection);
        //    command.Parameters.AddWithValue("@username", username);
        //    command.Parameters.AddWithValue("@password", password);
        //    command.Parameters.AddWithValue("@role", role);

        //    // Execute the query and get the user count
        //    int userCount = (int)command.ExecuteScalar();

        //    // Close the connection
        //    sqlConnection.Close();

        //    // Return true if a user is found, false otherwise
        //    return userCount > 0;
        //}


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
            //// Temporary until everyone can connect their database
            //if (!rdEmployee.Checked && !rdAdmin.Checked)
            //{
            //    MessageBox.Show("Please select a valid role type."); // Debug message
            //    return;
            //}
            //if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            //{
            //    Admin adminForm = new Admin(); // Instantiate the AdminForm
            //    adminForm.Show(); // Show the AdminFor
            //    this.Hide();

            //}
            //else if (txtUsername.Text == "emp" && txtPassword.Text == "emp")
            //{
            //    EmployeeDash emp = new EmployeeDash(); // Instantiate the AdminForm
            //    emp.Show(); 
            //    this.Hide();

            //}
            //else
            //{
            //    MessageBox.Show("Sorry we don't have your username or password. " +
            //                    "Please contact your supervisor.");
            //}



           
                // Ensure a role is selected
                if (!rdEmployee.Checked && !rdAdmin.Checked)
                {
                    MessageBox.Show("Please select a valid role type.");
                    return;
                }

                // Determine selected role
                string userSelectedRole = rdEmployee.Checked ? "Employee" : "Admin";

                // Validate user credentials
                bool isValidUser = DatabaseConnection.ValidateUser(txtUsername.Text, txtPassword.Text, userSelectedRole);

                if (isValidUser)
                {
                    // Navigate based on role
                    if (userSelectedRole == "Admin")
                    {
                        Admin adminForm = new Admin();
                        adminForm.Show();
                        this.Hide();
                    }
                    else if (userSelectedRole == "Employee")
                    {
                        EmployeeDash emp = new EmployeeDash();
                        emp.Show();
                        this.Hide();
                    }
                }
                else
                {
                    // Show error if credentials are incorrect
                    MessageBox.Show("Incorrect username or password! Please try again.");
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
