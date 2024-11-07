namespace LNB_Airlines
{
    partial class EmployeeDash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupboxUpcoming = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupboxStaffNeeds = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupboxRequests = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBreakdown = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupAvailableNeed = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChatbot = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new LNB_Airlines.LNBrootDataSetTableAdapters.TableAdapterManager();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupboxUpcoming.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupboxStaffNeeds.SuspendLayout();
            this.groupboxRequests.SuspendLayout();
            this.groupBreakdown.SuspendLayout();
            this.groupAvailableNeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(807, 16);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LNB ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupboxRequests);
            this.groupBox2.Controls.Add(this.groupBreakdown);
            this.groupBox2.Controls.Add(this.groupAvailableNeed);
            this.groupBox2.Location = new System.Drawing.Point(1, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(526, 350);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Controls.Add(this.groupboxUpcoming);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(268, 92);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(235, 150);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            // 
            // groupboxUpcoming
            // 
            this.groupboxUpcoming.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupboxUpcoming.Controls.Add(this.label8);
            this.groupboxUpcoming.Location = new System.Drawing.Point(4, 23);
            this.groupboxUpcoming.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupboxUpcoming.Name = "groupboxUpcoming";
            this.groupboxUpcoming.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupboxUpcoming.Size = new System.Drawing.Size(227, 114);
            this.groupboxUpcoming.TabIndex = 2;
            this.groupboxUpcoming.TabStop = false;
            this.groupboxUpcoming.Enter += new System.EventHandler(this.groupboxUpcoming_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "All upcoming shifts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Upcoming Shifts";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.groupboxStaffNeeds);
            this.groupBox5.Location = new System.Drawing.Point(22, 92);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(235, 150);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Staffing Needs";
            // 
            // groupboxStaffNeeds
            // 
            this.groupboxStaffNeeds.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupboxStaffNeeds.Controls.Add(this.label7);
            this.groupboxStaffNeeds.Location = new System.Drawing.Point(4, 23);
            this.groupboxStaffNeeds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupboxStaffNeeds.Name = "groupboxStaffNeeds";
            this.groupboxStaffNeeds.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupboxStaffNeeds.Size = new System.Drawing.Size(227, 114);
            this.groupboxStaffNeeds.TabIndex = 2;
            this.groupboxStaffNeeds.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Shifts availabel to pick up";
            // 
            // groupboxRequests
            // 
            this.groupboxRequests.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupboxRequests.Controls.Add(this.label9);
            this.groupboxRequests.Controls.Add(this.label4);
            this.groupboxRequests.Location = new System.Drawing.Point(22, 246);
            this.groupboxRequests.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupboxRequests.Name = "groupboxRequests";
            this.groupboxRequests.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupboxRequests.Size = new System.Drawing.Size(481, 103);
            this.groupboxRequests.TabIndex = 8;
            this.groupboxRequests.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "approved and declined shifts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Leave Requests";
            // 
            // groupBreakdown
            // 
            this.groupBreakdown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBreakdown.Controls.Add(this.label11);
            this.groupBreakdown.Controls.Add(this.label6);
            this.groupBreakdown.Location = new System.Drawing.Point(268, 16);
            this.groupBreakdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBreakdown.Name = "groupBreakdown";
            this.groupBreakdown.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBreakdown.Size = new System.Drawing.Size(235, 72);
            this.groupBreakdown.TabIndex = 4;
            this.groupBreakdown.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-3, 51);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(245, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "pilots ground and everything else percentages off?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Department Breakdown";
            // 
            // groupAvailableNeed
            // 
            this.groupAvailableNeed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupAvailableNeed.Controls.Add(this.label10);
            this.groupAvailableNeed.Controls.Add(this.label3);
            this.groupAvailableNeed.Location = new System.Drawing.Point(22, 16);
            this.groupAvailableNeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupAvailableNeed.Name = "groupAvailableNeed";
            this.groupAvailableNeed.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupAvailableNeed.Size = new System.Drawing.Size(235, 72);
            this.groupAvailableNeed.TabIndex = 0;
            this.groupAvailableNeed.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "IDK yet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Available needs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quick Actions:";
            // 
            // btnChatbot
            // 
            this.btnChatbot.Location = new System.Drawing.Point(369, 20);
            this.btnChatbot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChatbot.Name = "btnChatbot";
            this.btnChatbot.Size = new System.Drawing.Size(158, 21);
            this.btnChatbot.TabIndex = 3;
            this.btnChatbot.Text = "Shift Managment Chatbot";
            this.btnChatbot.UseVisualStyleBackColor = true;
            this.btnChatbot.Click += new System.EventHandler(this.btnChatbot_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(574, 101);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(66, 75);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(574, 206);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 75);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(574, 289);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(66, 75);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AnalyticsTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.EmployeesTableAdapter = null;
            this.tableAdapterManager1.LeaveRequestsTableAdapter = null;
            this.tableAdapterManager1.NotificationsTableAdapter = null;
            this.tableAdapterManager1.RolesTableAdapter = null;
            this.tableAdapterManager1.ShiftPickupsTableAdapter = null;
            this.tableAdapterManager1.ShiftsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = LNB_Airlines.LNBrootDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = null;
            // 
            // EmployeeDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 406);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnChatbot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeeDash";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupboxUpcoming.ResumeLayout(false);
            this.groupboxUpcoming.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupboxStaffNeeds.ResumeLayout(false);
            this.groupboxStaffNeeds.PerformLayout();
            this.groupboxRequests.ResumeLayout(false);
            this.groupboxRequests.PerformLayout();
            this.groupBreakdown.ResumeLayout(false);
            this.groupBreakdown.PerformLayout();
            this.groupAvailableNeed.ResumeLayout(false);
            this.groupAvailableNeed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupAvailableNeed;
        private System.Windows.Forms.GroupBox groupboxRequests;
        private System.Windows.Forms.GroupBox groupBreakdown;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupboxStaffNeeds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChatbot;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupboxUpcoming;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdmin;
        private LNBrootDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}

