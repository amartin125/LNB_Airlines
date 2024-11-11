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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lNBrootDataSet.LeaveRequests' table. You can move, or remove it, as needed.
     

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }

        private void btnChatbot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chatbot emp = new Chatbot();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
             this.Hide();
             EmployeeDash emp = new EmployeeDash();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShiftApprove_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {

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
    }
}
