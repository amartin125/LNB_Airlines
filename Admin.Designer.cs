namespace LNB_Airlines
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnChatbot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBreakdown = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupAvailableNeed = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnShiftApprove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBreakdown.SuspendLayout();
            this.groupAvailableNeed.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(924, 569);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 56);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(860, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 115);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(860, 157);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(99, 115);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnChatbot
            // 
            this.btnChatbot.Location = new System.Drawing.Point(553, 31);
            this.btnChatbot.Name = "btnChatbot";
            this.btnChatbot.Size = new System.Drawing.Size(237, 32);
            this.btnChatbot.TabIndex = 9;
            this.btnChatbot.Text = "Shift Managment Chatbot";
            this.btnChatbot.UseVisualStyleBackColor = true;
            this.btnChatbot.Click += new System.EventHandler(this.btnChatbot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quick Actions:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBreakdown);
            this.groupBox2.Controls.Add(this.groupAvailableNeed);
            this.groupBox2.Location = new System.Drawing.Point(1, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 619);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBreakdown
            // 
            this.groupBreakdown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBreakdown.Controls.Add(this.label11);
            this.groupBreakdown.Controls.Add(this.label6);
            this.groupBreakdown.Location = new System.Drawing.Point(402, 25);
            this.groupBreakdown.Name = "groupBreakdown";
            this.groupBreakdown.Size = new System.Drawing.Size(353, 161);
            this.groupBreakdown.TabIndex = 4;
            this.groupBreakdown.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "How many people by department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Department Breakdown";
            // 
            // groupAvailableNeed
            // 
            this.groupAvailableNeed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupAvailableNeed.Controls.Add(this.label10);
            this.groupAvailableNeed.Controls.Add(this.label3);
            this.groupAvailableNeed.Location = new System.Drawing.Point(33, 25);
            this.groupAvailableNeed.Name = "groupAvailableNeed";
            this.groupAvailableNeed.Size = new System.Drawing.Size(353, 161);
            this.groupAvailableNeed.TabIndex = 0;
            this.groupAvailableNeed.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Needs for the week";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Available needs";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1210, 24);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LNB ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.btnShiftApprove);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(33, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(722, 342);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // btnShiftApprove
            // 
            this.btnShiftApprove.Location = new System.Drawing.Point(19, 266);
            this.btnShiftApprove.Name = "btnShiftApprove";
            this.btnShiftApprove.Size = new System.Drawing.Size(89, 56);
            this.btnShiftApprove.TabIndex = 13;
            this.btnShiftApprove.Text = "Approve";
            this.btnShiftApprove.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(697, 222);
            this.dataGridView1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Reason";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(209, 282);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(507, 38);
            this.textBox1.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 56);
            this.button4.TabIndex = 10;
            this.button4.Text = "Decline";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "The Admin will aprove or decline here";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Shift Request";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 48);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(552, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 48);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 685);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnChatbot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBreakdown.ResumeLayout(false);
            this.groupBreakdown.PerformLayout();
            this.groupAvailableNeed.ResumeLayout(false);
            this.groupAvailableNeed.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnChatbot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBreakdown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupAvailableNeed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnShiftApprove;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}