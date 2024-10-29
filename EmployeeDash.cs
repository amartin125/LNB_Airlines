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
using System.Windows.Forms;

namespace LNB_Airlines
{
    public partial class EmployeeDash : Form
    {
        public EmployeeDash()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // test button can be used for anything
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

    // database stuff

        private string connectionString = "connection strinf";
        private void LoadUpcomingShifts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    
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
    }
}
