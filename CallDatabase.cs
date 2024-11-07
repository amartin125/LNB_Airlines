using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace LNB_Airlines
{
    public class DatabaseConnection
    {
        // Method to establish a database connection
        public static SqlConnection ConnectToDatabase()
        {
            List<string> connectionStrings = new List<string>
            {
                "Server=JAKESLAPTOP\\SQLEXPRESS01;Database=LNBroot;Integrated Security=True;",
                "Server=(LocalDb)\\LNBroot;Database=LNBairlines;Integrated Security=True;"

            };

            SqlConnection connection = null;

            foreach (var connectionString in connectionStrings)
            {
                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    break;
                }
                catch
                {
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

        // Method to validate user credentials
        public static bool ValidateUser(string username, string password, string role)
        {
            using (SqlConnection connection = ConnectToDatabase())
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password AND Role = @Role";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Role", role);

                int result = Convert.ToInt32(command.ExecuteScalar());
                return result == 1;
            }
        }
    }
}

