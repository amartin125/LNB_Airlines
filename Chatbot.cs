using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNB_Airlines
{
    public partial class Chatbot : Form
    {
        private int employeeId;
        private EmployeeDash employeeDash;
        public Chatbot(int loggedInEmployeeId, EmployeeDash empDash)
        {
            InitializeComponent();
            employeeId = loggedInEmployeeId;
            employeeDash = empDash; // Store reference to EmployeeDash
            rtbChatHistory.AppendText("Bot: Hello! You can ask me about your shifts, request time off, or just chat.\n");
        }

        // Event handler for sending a message
        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtUserInput.Text.Trim();
            if (!string.IsNullOrEmpty(userInput))
            {
                rtbChatHistory.AppendText($"You: {userInput}\n");
                string botResponse = GetChatbotResponse(userInput);
                rtbChatHistory.AppendText($"Bot: {botResponse}\n");
                txtUserInput.Clear();
            }
        }
        private string DropShift(string userInput)
        {
            // Implement logic for dropping a shift or return a placeholder response
            return "Feature to drop shifts is currently under development.";
        }

        private string GetChatbotResponse(string userInput)
        {
            userInput = userInput.ToLower();

            if (userInput.Contains("pick up"))
                return PickUpShift(userInput);
            if (userInput.Contains("drop"))
                return DropShift(userInput);
            if (userInput.Contains("view shifts"))
                return ListAvailableShifts();
            if (userInput.Contains("request time off"))
                return RequestTimeOff(userInput);
            if (userInput.Contains("notifications"))
                return GetNotifications();

            return "I'm sorry, I didn't understand that. Try asking about shifts, leave requests, or notifications.";
        }

        private List<Shift> GetAvailableShifts()
        {
            List<Shift> shifts = new List<Shift>();
            try
            {
                using (SqlConnection connection = DatabaseConnection.ConnectToDatabase())
                {
                    string query = "SELECT department, shift_date, shift_time_start FROM Shifts WHERE available_slots > 0";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string department = reader["department"].ToString();
                            DateTime date = Convert.ToDateTime(reader["shift_date"]);
                            string time = reader["shift_time_start"].ToString();
                            shifts.Add(new Shift(department, date, time));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                rtbChatHistory.AppendText($"Bot: Error fetching shifts: {ex.Message}\n");
            }
            return shifts;
        }

        private string ListAvailableShifts()
        {
            List<Shift> shifts = GetAvailableShifts();
            if (shifts.Count == 0) return "No shifts are currently available.";
            StringBuilder shiftList = new StringBuilder("Available shifts:\n");
            foreach (var shift in shifts) shiftList.AppendLine(shift.ToString());
            return shiftList.ToString();
        }

        private string PickUpShift(string userInput)
        {
            // Simplify parsing or validate userInput if needed.
            try
            {
                using (SqlConnection connection = DatabaseConnection.ConnectToDatabase())
                {
                    string query = "SELECT shift_id, available_slots FROM Shifts WHERE available_slots > 0";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters if needed based on userInput parsing.
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int shiftId = Convert.ToInt32(reader["shift_id"]);
                                reader.Close();

                                string updateQuery = "UPDATE Shifts SET available_slots = available_slots - 1 WHERE shift_id = @ShiftId";
                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@ShiftId", shiftId);
                                    updateCommand.ExecuteNonQuery();
                                }

                                string insertQuery = "INSERT INTO ShiftPickups (shift_id, employee_id, pickup_status) VALUES (@ShiftId, @EmployeeId, 'pending')";
                                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                                {
                                    insertCommand.Parameters.AddWithValue("@ShiftId", shiftId);
                                    insertCommand.Parameters.AddWithValue("@EmployeeId", employeeId);
                                    insertCommand.ExecuteNonQuery();
                                }

                                return "You have successfully picked up a shift.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
            return "No shifts are available.";
        }

        private string RequestTimeOff(string userInput)
        {
            // Parse userInput for startDate, endDate, and reason.
            DateTime startDate = DateTime.Now; // Replace with parsed input.
            DateTime endDate = DateTime.Now; // Replace with parsed input.
            string reason = "Personal"; // Replace with parsed input.

            try
            {
                using (SqlConnection connection = DatabaseConnection.ConnectToDatabase())
                {
                    string insertQuery = "INSERT INTO LeaveRequests (employee_id, start_date, end_date, reason, status) VALUES (@EmployeeId, @StartDate, @EndDate, @Reason, 'pending')";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);
                        command.Parameters.AddWithValue("@Reason", reason);
                        command.ExecuteNonQuery();
                    }
                }
                return $"Your time-off request from {startDate.ToShortDateString()} to {endDate.ToShortDateString()} has been submitted.";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        private string GetNotifications()
        {
            StringBuilder notifications = new StringBuilder();
            try
            {
                using (SqlConnection connection = DatabaseConnection.ConnectToDatabase())
                {
                    string query = "SELECT message, is_read FROM Notifications WHERE employee_id = @EmployeeId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string message = reader["message"].ToString();
                                bool isRead = Convert.ToBoolean(reader["is_read"]);
                                notifications.AppendLine($"{message} (Read: {isRead})");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error fetching notifications: {ex.Message}";
            }
            return notifications.Length > 0 ? notifications.ToString() : "No notifications.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the Chatbot form
            employeeDash.Show(); // Show the EmployeeDash form
        }
        private void Chatbot_FormClosed(object sender, FormClosedEventArgs e)
        {
            employeeDash.Show(); // Ensure EmployeeDash is shown when Chatbot is closed
        }
    }
    

    public class Shift
    {
        public string Role { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }

        public Shift(string role, DateTime date, string time)
        {
            Role = role;
            Date = date;
            Time = time;
        }

        public override string ToString()
        {
            return $"{Role} shift on {Date.ToShortDateString()} at {Time}";
        }
    }
}
