using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LNB_Airlines
{
    public partial class EmployeeDash : Form
    {
        private string connectionString = "Server=DESKTOP-VEH3C8M\\SQLEXPRESS01;Database=Test;Integrated Security=True;";
        private int _employeeId;

        // Constructor that accepts an int parameter for employee ID
        public EmployeeDash(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
        }
        private void EmployeeDash_Load(object sender, EventArgs e)
        {
            LoadEmployeeLeaveRequests(); // For leave requests
            LoadUpcomingShifts();        // For all shifts
            LoadShiftPickups();          // For filtered shift pickups
            LoadNotifications();         // For notifications
        }


        // Method to load employee-specific leave requests
        private void LoadEmployeeLeaveRequests()
        {
            try
            {
                DataTable leaveRequests = DatabaseConnection.GetLeaveRequestsDASH(_employeeId);
                dataLeaveReqDASH.DataSource = leaveRequests;

                // Customize column headers
                if (dataLeaveReqDASH.Columns.Count > 0)
                {
                    dataLeaveReqDASH.Columns["leave_id"].HeaderText = "Leave ID";
                    dataLeaveReqDASH.Columns["start_date"].HeaderText = "Start Date";
                    dataLeaveReqDASH.Columns["end_date"].HeaderText = "End Date";
                    dataLeaveReqDASH.Columns["reason"].HeaderText = "Reason";
                    dataLeaveReqDASH.Columns["status"].HeaderText = "Status";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading leave requests: {ex.Message}");
            }
        }
        // Method to load employee-specific data
        private void LoadEmployeeData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Employees WHERE employee_id = @EmployeeId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmployeeId", _employeeId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataLeaveReqDASH.DataSource = dt; // Ensure this is the correct DataGridView for employee data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee data: " + ex.Message);
            }
        }

        private void btnChatbot_Click(object sender, EventArgs e)
        {
            btnChatbot.Enabled = false; // Disable Chatbot button
            int loggedInEmployeeId = _employeeId;
            Chatbot chatbot = new Chatbot(loggedInEmployeeId, this);
            chatbot.FormClosed += (s, args) => btnChatbot.Enabled = true; // Re-enable button when Chatbot closes
            this.Hide();
            chatbot.Show();
        }
     
        // Default constructor
        

        public EmployeeDash()
        {
            InitializeComponent();
            // Handle cases where employeeId is not provided
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void LoadUpcomingShifts()
        {
            try
            {
                // Retrieve all shifts
                DataTable shifts = DatabaseConnection.GetShifts(); // Unfiltered shifts
                ShiftDG.DataSource = shifts;

                // Debug: Print column names to verify correctness
                foreach (DataColumn column in shifts.Columns)
                {
                    Console.WriteLine("Shifts Column: " + column.ColumnName);
                }

                //// Customize column headers

                //    ShiftDG.Columns["shift_id"].HeaderText = "Shift ID";
                //    ShiftDG.Columns["department"].HeaderText = "Department";
                //    ShiftDG.Columns["shift_date"].HeaderText = "Date";
                //    ShiftDG .Columns["shift_time_start"].HeaderText = "Start Time";
                //    ShiftDG.Columns["shift_time_end"].HeaderText = "End Time";
                //    ShiftDG.Columns["required_staff"].HeaderText = "Required Staff";
                //    ShiftDG.Columns["available_slots"].HeaderText = "Available Slots";
                //    ShiftDG.Columns["approval_status"].HeaderText = "Approval Status";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading shifts: {ex.Message}");
            }
        }


        private void LoadShiftPickups()
        {
            try
            {
                // Retrieve shift pickups for the logged-in employee
                DataTable shiftPickups = DatabaseConnection.GetEmployeeShiftPickups(_employeeId);
                ShiftPickupsDG.DataSource = shiftPickups;

                // Customize column headers
                
                    //ShiftPickupsDG.Columns["pickup_id"].HeaderText = "Pickup ID";
                    //ShiftPickupsDG.Columns["shift_id"].HeaderText = "Shift ID";
                    //ShiftPickupsDG.Columns["pickup_status"].HeaderText = "Status";
                    //ShiftPickupsDG.Columns["reason"].HeaderText = "Reason";
                    //ShiftPickupsDG.Columns["shift_date"].HeaderText = "Date";
                    //ShiftPickupsDG.Columns["shift_time_start"].HeaderText = "Start Time";
                    //ShiftPickupsDG.Columns["shift_time_end"].HeaderText = "End Time";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading shift pickups: {ex.Message}");
            }
        }


        private void LoadNotifications()
        {
            try
            {
                // Retrieve notifications for the logged-in employee
                DataTable notifications = DatabaseConnection.GetEmployeeNotifications(_employeeId);
                notificationsDG.DataSource = notifications;

                // Customize column headers
                if (notificationsDG.Columns.Count > 0)
                {
                    notificationsDG.Columns["notification_id"].HeaderText = "Notification ID";
                    notificationsDG.Columns["message"].HeaderText = "Message";
                    notificationsDG.Columns["is_read"].HeaderText = "Read";
                    notificationsDG.Columns["created_at"].HeaderText = "Date";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notifications: {ex.Message}");
            }
        }


        private void LoadTimeOffRequests()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // time off requests
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading time off requests: " + ex.Message);
                }
            }
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupboxUpcoming_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataLeaveReqDASH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (ShiftDG.Columns.Contains("shift_date"))
            {
                ShiftDG.Columns["shift_date"].DefaultCellStyle.Format = "yyyy-MM-dd"; // Adjust format as needed
                ShiftDG.Columns["shift_date"].HeaderText = "Date";
            }

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void notificationsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
