using System;
using System.Collections.Generic;
using System.Data;
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
                    MessageBox.Show($"Connected using: {connectionString}");
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
                    MessageBox.Show($"Executing query with parameters: Username={username}, Password={password}, Role={role}");
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        employeeId = Convert.ToInt32(result);
                    }
                    MessageBox.Show($"Query Result: {result}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            return employeeId;
        }

        // Method to retrieve all leave requests
        public static DataTable GetLeaveRequests()
        {
            DataTable leaveRequests = new DataTable();
            using (SqlConnection connection = ConnectToDatabase())
            {
                string query = "SELECT leave_id, employee_id, start_date, end_date, reason, status FROM LeaveRequests";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(leaveRequests);
                }
            }
            return leaveRequests;
        }

        // Method to update leave request status and reason
        public static void UpdateLeaveRequestStatus(int leaveId, string status, string reason)
        {
            using (SqlConnection connection = ConnectToDatabase())
            {
                string query = "UPDATE LeaveRequests SET status = @Status, reason = @Reason, updated_at = GETDATE() WHERE leave_id = @LeaveId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Reason", reason);
                    command.Parameters.AddWithValue("@LeaveId", leaveId);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Method to retrieve all shift pickups
        public static DataTable GetShiftPickups()
        {
            DataTable shiftPickups = new DataTable();
            using (SqlConnection connection = ConnectToDatabase())
            {
                string query = @"
                    SELECT sp.pickup_id, sp.employee_id, sp.shift_id, sp.pickup_status, sp.created_at, sp.updated_at
                    FROM ShiftPickups sp
                    JOIN Shifts s ON sp.shift_id = s.shift_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(shiftPickups);
                }
            }
            return shiftPickups;
        }

        // Method to retrieve all shifts
        public static DataTable GetShifts()
        {
            DataTable shifts = new DataTable();
            using (SqlConnection connection = ConnectToDatabase())
            {
                string query = @"
                    SELECT shift_id, department, shift_date, shift_time_start, shift_time_end, required_staff, available_slots, approval_status
                    FROM Shifts";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(shifts);
                }
            }
            return shifts;
        }

        // Method to update shift pickup status and reason
        public static void UpdateShiftPickupStatus(int pickupId, string status, string reason)
        {
            using (SqlConnection connection = ConnectToDatabase())
            {
                string query = "UPDATE ShiftPickups SET pickup_status = @Status, reason = @Reason, updated_at = GETDATE() WHERE pickup_id = @PickupId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Reason", reason);
                    command.Parameters.AddWithValue("@PickupId", pickupId);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Method to update shift status and reason
        public static void UpdateShiftStatus(int shiftId, string status, string reason)
        {
            using (SqlConnection connection = ConnectToDatabase())
            {
                string query = "UPDATE Shifts SET approval_status = @Status, approval_reason = @Reason, updated_at = GETDATE() WHERE shift_id = @ShiftId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Reason", reason);
                    command.Parameters.AddWithValue("@ShiftId", shiftId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
