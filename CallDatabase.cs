using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LNB_Airlines
{
    public static class DatabaseConnection
    {
        // Method to establish a database connection
        public static SqlConnection ConnectToDatabase()
        {
            List<string> connectionStrings = new List<string>
            {//Andrews
                "Server=DESKTOP-VEH3C8M\\SQLEXPRESS01;Database=Test;Integrated Security=True;",
                //jakes
                "Server=JAKESLAPTOP\\SQLEXPRESS01;Database=LNBroot;Integrated Security=True;",
                "Server=(LocalDb)\\LNBroot;Database=LNBairlines;Integrated Security=True;",
            };

            SqlConnection connection = null;

            foreach (var connectionString in connectionStrings)
            {
                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    //MessageBox.Show($"Connected using: {connectionString}");
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to connect using connection string: {connectionString}\nError: {ex.Message}");
                    connection?.Dispose();
                    connection = null;
                }
            }

            if (connection == null)
            {
                throw new Exception("Unable to connect to any database.");
            }

            return connection;
        }

        // Method to validate user credentials and return employee ID
        public static int ValidateUser(string username, string password, string role)
        {
            int employeeId = -1; // Default to -1 for invalid credentials

            using (SqlConnection connection = ConnectToDatabase())
            {
                string query = "SELECT employee_id FROM Users WHERE Username = @Username AND Password = @Password AND Role = @Role";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Role", role);

                try
                {
                    //MessageBox.Show($"Executing query with parameters: Username={username}, Password={password}, Role={role}");
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        employeeId = Convert.ToInt32(result);
                    }
                    //MessageBox.Show($"Query Result: {result}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            return employeeId;
        }
    }
}
