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
        private int employeeId;
        private string connectionString = "Server=DESKTOP-VEH3C8M\\SQLEXPRESS01;Database=Test;Integrated Security=True;";

            
                


        // Constructor that accepts an int parameter for employee ID
        public EmployeeDash(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            // Load data for the specific employee
            LoadEmployeeData();
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

        private void btnChatbot_Click(object sender, EventArgs e)
        {
            Chatbot chatbot = new Chatbot();
            chatbot.Show();
            this.Hide();
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

        private void EmployeeDash_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet8.Analytics' table. You can move, or remove it, as needed.
            this.analyticsTableAdapter.Fill(this.testDataSet8.Analytics);
            // TODO: This line of code loads data into the 'testDataSet6.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter1.Fill(this.testDataSet6.Employees);
            // TODO: This line of code loads data into the 'testDataSet5.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.testDataSet5.Employees);
            // TODO: This line of code loads data into the 'testDataSet2.Shifts' table. You can move, or remove it, as needed.
            this.shiftsTableAdapter.Fill(this.testDataSet2.Shifts);
            // TODO: This line of code loads data into the 'testDataSet1.ShiftPickups' table. You can move, or remove it, as needed.
            this.shiftPickupsTableAdapter.Fill(this.testDataSet1.ShiftPickups);
            // TODO: This line of code loads data into the 'testDataSet.LeaveRequests' table. You can move, or remove it, as needed.
            this.leaveRequestsTableAdapter.Fill(this.testDataSet.LeaveRequests);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            try
            {
                MessageBox.Show($"Using connection string: {connectionString}");
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Employees WHERE employee_id = @EmployeeId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee data: " + ex.Message);
            }
        }
    }
}
