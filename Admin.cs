using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNB_Airlines
{
    public partial class Admin : Form
    {
        private int selectedRequestId = -1;
        private string activeRequestType = ""; // Tracks whether the selected request is "leave" or "shift"
        private int loggedInEmployeeId;

        public Admin(int employeeId)
        {
            InitializeComponent();
            loggedInEmployeeId = employeeId; // Store the logged-in employee's ID
        }
        public Admin()
        {
            InitializeComponent();
            dataLeaveReq.Show();
            dataShiftPickups.Hide();
            dataPowerBI.Hide();
            dataShifts.Hide();

            // Attach the CellClick event handlers
            dataLeaveReq.CellClick += dataLeaveReq_CellClick;
            dataShiftPickups.CellClick += dataShiftPick_CellClick;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
           
            // Load all data into the respective tables
            RefreshLeaveRequests();
            RefreshShiftPickups();
            RefreshShifts();
            // Add any additional data loading here
        }
        private void RefreshLeaveRequests()
        {
            DataTable leaveRequests = DatabaseConnection.GetLeaveRequests();
            dataLeaveReq.DataSource = leaveRequests;

            // Debug: Print column names to verify if "leave_id" is correct
            foreach (DataColumn column in leaveRequests.Columns)
            {
                Console.WriteLine("LeaveRequests Column: " + column.ColumnName);
            }

            // Optional: Customize column headers if necessary
            dataLeaveReq.Columns["leave_id"].HeaderText = "Leave ID";
            dataLeaveReq.Columns["employee_id"].HeaderText = "Employee ID";
            dataLeaveReq.Columns["start_date"].HeaderText = "Start Date";
            dataLeaveReq.Columns["end_date"].HeaderText = "End Date";
            dataLeaveReq.Columns["reason"].HeaderText = "Reason";
            dataLeaveReq.Columns["status"].HeaderText = "Status";
        }

        private void RefreshShifts()
        {
            DataTable shifts = DatabaseConnection.GetShifts();
            dataShifts.DataSource = shifts;

            // Debug: Print column names to verify if "shift_id" is correct
            foreach (DataColumn column in shifts.Columns)
            {
                Console.WriteLine("Shifts Column: " + column.ColumnName);
            }

            // Optional: Customize column headers if necessary
            dataShifts.Columns["shift_id"].HeaderText = "Shift ID";
            dataShifts.Columns["department"].HeaderText = "Department";
            dataShifts.Columns["shift_date"].HeaderText = "Date";
            dataShifts.Columns["shift_time_start"].HeaderText = "Start Time";
            dataShifts.Columns["shift_time_end"].HeaderText = "End Time";
            dataShifts.Columns["required_staff"].HeaderText = "Required Staff";
            dataShifts.Columns["available_slots"].HeaderText = "Available Slots";
            dataShifts.Columns["approval_status"].HeaderText = "Approval Status";
        }

        // Event to handle selection of leave requests
        private void dataLeaveReq_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataLeaveReq.Rows[e.RowIndex];

                // Debugging output
                MessageBox.Show("Leave request selected");

                // Make sure "leave_id" is the correct column name
                selectedRequestId = Convert.ToInt32(row.Cells["leave_id"].Value);
                txtReason.Text = row.Cells["reason"].Value.ToString();
                activeRequestType = "leave";
            }
        }

        // Event to handle selection of shift pickups
        private void dataShiftPick_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataShiftPickups.Rows[e.RowIndex];

                // Debugging output
                MessageBox.Show("Shift pickup selected");

                // Make sure "pickup_id" is the correct column name
                selectedRequestId = Convert.ToInt32(row.Cells["pickup_id"].Value);
                txtReason.Text = row.Cells["pickup_status"].Value.ToString();
                activeRequestType = "shift";
            }
        }

        // Cell click event for Shifts
        private void dataShifts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataShifts.Rows[e.RowIndex];

                // Debugging output
                MessageBox.Show("Shift selected");

                // Make sure "shift_id" is the correct column name
                selectedRequestId = Convert.ToInt32(row.Cells["shift_id"].Value);
                txtReason.Text = row.Cells["approval_status"].Value.ToString();
                activeRequestType = "shift";
            }
        }

        private void RefreshShiftPickups()
        {
            DataTable shiftPickups = DatabaseConnection.GetShiftPickups();
            dataShiftPickups.DataSource = shiftPickups;

            // Debug: Print column names to verify if "pickup_id" is correct
            foreach (DataColumn column in shiftPickups.Columns)
            {
                Console.WriteLine("ShiftPickups Column: " + column.ColumnName);
            }

            // Optional: Customize column headers if necessary
            dataShiftPickups.Columns["pickup_id"].HeaderText = "Pickup ID";
            dataShiftPickups.Columns["employee_id"].HeaderText = "Employee ID";
            dataShiftPickups.Columns["shift_id"].HeaderText = "Shift ID";
            dataShiftPickups.Columns["pickup_status"].HeaderText = "Status";
            dataShiftPickups.Columns["created_at"].HeaderText = "Created At";
            dataShiftPickups.Columns["updated_at"].HeaderText = "Updated At";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear selections and reset form
            selectedRequestId = -1;
            activeRequestType = "";
            txtReason.Clear();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // Test button functionality
        }

        private void btnChatbot_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Label click event
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // GroupBox enter event
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // GroupBox enter event
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            int defaultUserId = 1; // Replace with an appropriate default user ID
            this.Hide();
            EmployeeDash emp = new EmployeeDash(defaultUserId);
            emp.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Search text changed event
        }

        private void btnShiftApprove_Click(object sender, EventArgs e)
        {
            // Shift approve button click event
            MessageBox.Show($"selectedRequestId: {selectedRequestId}, activeRequestType: {activeRequestType}, Reason: {txtReason.Text}");

            if (selectedRequestId > 0 && !string.IsNullOrWhiteSpace(txtReason.Text))
            {
                if (activeRequestType == "leave")
                {
                    DatabaseConnection.UpdateLeaveRequestStatus(selectedRequestId, "approved", txtReason.Text);
                    MessageBox.Show("Leave request approved.");
                    RefreshLeaveRequests();
                }
                else if (activeRequestType == "shift")
                {
                    DatabaseConnection.UpdateShiftPickupStatus(selectedRequestId, "approved", txtReason.Text);
                    MessageBox.Show("Shift approved.");
                    RefreshShiftPickups();
                }
                else
                {
                    MessageBox.Show("Please select a leave request or shift to approve.");
                }
            }
            else
            {
                MessageBox.Show("Please select a request to approve and ensure a reason is provided.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //TESTING REASON BOX
            MessageBox.Show($"selectedRequestId: {selectedRequestId}, activeRequestType: {activeRequestType}, Reason: {txtReason.Text}");

            // Deny button click event
            if (selectedRequestId > 0 && !string.IsNullOrWhiteSpace(txtReason.Text))
            {
                if (activeRequestType == "leave")
                {
                    DatabaseConnection.UpdateLeaveRequestStatus(selectedRequestId, "denied", txtReason.Text);
                    MessageBox.Show("Leave request denied.");
                    RefreshLeaveRequests();
                }
                else if (activeRequestType == "shift")
                {
                    DatabaseConnection.UpdateShiftPickupStatus(selectedRequestId, "denied", txtReason.Text);
                    MessageBox.Show("Shift denied.");
                    RefreshShiftPickups();
                }
                else
                {
                    MessageBox.Show("Please select a leave request or shift to deny.");
                }
            }
            else
            {
                MessageBox.Show("Please select a request to deny and ensure a reason is provided.");
            }
        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            // Reason text changed event
        }

        private void PowerBIBTN_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\User\Desktop\School\Scrum\LNB_Airlines\LNBBI.pbix"; // Replace with the actual path to your Power BI file

            try
            {
                if (File.Exists(filePath))
                {
                    // Start the Power BI file in its default application (Power BI Desktop)
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                    MessageBox.Show("Power BI file opened successfully.");
                }
                else
                {
                    MessageBox.Show("Power BI file not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the Power BI file: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView cell content click event
        }

        private void btnPickups_Click(object sender, EventArgs e)
        {
            dataShiftPickups.Show();
            dataShifts.Hide();
            dataLeaveReq.Hide();
            dataPowerBI.Hide();
            

            // Clear selections and load Shift Pickups data
            selectedRequestId = -1;
            activeRequestType = "";
            txtReason.Clear();
            RefreshShiftPickups();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataShifts.Show();
            dataShiftPickups.Hide();
            dataLeaveReq.Hide();
            dataPowerBI.Hide();
            

            // Clear selections and load Shifts data
            selectedRequestId = -1;
            activeRequestType = "";
            txtReason.Clear();
            RefreshShifts();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            dataLeaveReq.Show();
            dataShiftPickups.Hide();
            dataPowerBI.Hide();
            dataShifts.Hide();
            selectedRequestId = -1;
            activeRequestType = "";
            txtReason.Clear();
            btnClear_Click(sender, e); // Clear selection
        }

        private void dataShiftPick_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {  
                
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
