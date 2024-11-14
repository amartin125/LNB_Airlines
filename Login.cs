using System;
using System.Windows.Forms;

namespace LNB_Airlines
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // Ensure a role is selected
            if (!rdEmployee.Checked && !rdAdmin.Checked)
            {
                MessageBox.Show("Please select a valid role type.");
                return;
            }

            // Determine selected role
            string userSelectedRole = rdEmployee.Checked ? "Employee" : "Admin";
            //MessageBox.Show($"Selected Role: {userSelectedRole}");

            try
            {
                // Validate user credentials and get the employee id
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                int employeeId = DatabaseConnection.ValidateUser(username, password, userSelectedRole);
                //MessageBox.Show($"Employee ID: {employeeId}");

                if (employeeId != -1)
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
                        EmployeeDash emp = new EmployeeDash(employeeId); // Pass employee id to EmployeeDash
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void rdAdmin_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
