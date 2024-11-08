using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
