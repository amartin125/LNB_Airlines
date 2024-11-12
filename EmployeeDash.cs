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
            LoadEmployeeLeaveRequests();
        }

        // Method to load employee-specific leave requests
        private void LoadEmployeeLeaveRequests()
        {
            DataTable leaveRequests = DatabaseConnection.GetLeaveRequestsDASH(_employeeId);
            dataLeaveReqDASH.DataSource = leaveRequests; // Assuming dataLeaveReq is the correct DataGridView
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
            this.Hide();
            Chatbot chat = new Chatbot();
            chat.Show();
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

        // Test button can be used for anything
        private void btnTest_Click(object sender, EventArgs e)
        {
            groupboxUpcoming.Text = "stuff";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            groupboxUpcoming = null;
            groupboxStaffNeeds = null;
            groupboxRequests = null;
            groupAvailableNeed = null;
            groupBreakdown = null;
        }

        private void LoadUpcomingShifts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // load upcoming shifts
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading upcoming shifts: " + ex.Message);
                }
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
            LoadEmployeeData();
        }

       
    }
}
