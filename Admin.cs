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
        public Admin()
        {
            InitializeComponent();
            dataLeaveReq.Show();
            dataShiftPick.Hide();
            dataPowerBI.Hide();
            dataVacant.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // Load all data into the respective tables
            this.shiftPickupsTableAdapter1.Fill(this.testDataSet7.ShiftPickups);
            this.shiftPickupsTableAdapter.Fill(this.testDataSet4.ShiftPickups);
            this.leaveRequestsTableAdapter1.Fill(this.testDataSet3.LeaveRequests);
            // Add any additional data loading here
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear any filters or selections
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // Test button functionality
        }

        private void btnChatbot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chatbot emp = new Chatbot();
            emp.Show();
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
            int defaultUserId = 0; // Replace with an appropriate default user ID
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Button 4 click event
        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            // Reason text changed event
        }

        private void PowerBIBTN_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\titan\Documents\TESTPOWERBI.pbix"; // Replace with the actual path to your Power BI file

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
            dataShiftPick.Show();
            dataLeaveReq.Hide();
            dataPowerBI.Hide();
            dataVacant.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show vacant shifts
            dataVacant.Show();
            dataShiftPick.Hide();
            dataPowerBI.Hide();
            dataLeaveReq.Hide();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            dataLeaveReq.Show();
            dataShiftPick.Hide();
            dataPowerBI.Hide();
            dataVacant.Hide();
        }
    }
}
