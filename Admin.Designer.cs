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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShiftApprove = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPickups = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblShiftReq = new System.Windows.Forms.Label();
            this.lblLeave = new System.Windows.Forms.Label();
            this.LblVacant = new System.Windows.Forms.Label();
            this.lNBrootDataSet = new LNB_Airlines.LNBrootDataSet();
            this.lNBrootDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveRequestsTableAdapter = new LNB_Airlines.LNBrootDataSetTableAdapters.LeaveRequestsTableAdapter();
            this.leaveidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNBrootDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNBrootDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveRequestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(633, 398);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(569, 244);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 75);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(573, 102);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(66, 75);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnShiftApprove
            // 
            this.btnShiftApprove.BackColor = System.Drawing.Color.LimeGreen;
            this.btnShiftApprove.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnShiftApprove.Location = new System.Drawing.Point(8, 385);
            this.btnShiftApprove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShiftApprove.Name = "btnShiftApprove";
            this.btnShiftApprove.Size = new System.Drawing.Size(59, 23);
            this.btnShiftApprove.TabIndex = 13;
            this.btnShiftApprove.Text = "Approve";
            this.btnShiftApprove.UseVisualStyleBackColor = false;
            this.btnShiftApprove.Click += new System.EventHandler(this.btnShiftApprove_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLeave.Location = new System.Drawing.Point(8, 102);
            this.btnLeave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(117, 31);
            this.btnLeave.TabIndex = 12;
            this.btnLeave.Text = "Leave Requests";
            this.btnLeave.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leaveidDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.leaveRequestsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 189);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(465, 190);
            this.dataGridView1.TabIndex = 12;
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(135, 385);
            this.txtReason.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(339, 24);
            this.txtReason.TabIndex = 9;
            this.txtReason.Text = "Reason...";
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(71, 385);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Decline";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Admin Page";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(8, 61);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(661, 29);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.Text = "Search....";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnPickups
            // 
            this.btnPickups.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPickups.Location = new System.Drawing.Point(129, 102);
            this.btnPickups.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPickups.Name = "btnPickups";
            this.btnPickups.Size = new System.Drawing.Size(117, 31);
            this.btnPickups.TabIndex = 22;
            this.btnPickups.Text = "Shift Pickups";
            this.btnPickups.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(249, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Vacant Shifts";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(569, 189);
            this.btnMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(66, 51);
            this.btnMain.TabIndex = 24;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(807, 16);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LNB ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblShiftReq
            // 
            this.lblShiftReq.AutoSize = true;
            this.lblShiftReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftReq.Location = new System.Drawing.Point(160, 148);
            this.lblShiftReq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShiftReq.Name = "lblShiftReq";
            this.lblShiftReq.Size = new System.Drawing.Size(129, 24);
            this.lblShiftReq.TabIndex = 25;
            this.lblShiftReq.Text = "Shift Requests";
            // 
            // lblLeave
            // 
            this.lblLeave.AutoSize = true;
            this.lblLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeave.Location = new System.Drawing.Point(4, 148);
            this.lblLeave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeave.Name = "lblLeave";
            this.lblLeave.Size = new System.Drawing.Size(145, 24);
            this.lblLeave.TabIndex = 26;
            this.lblLeave.Text = "Leave Requests";
            // 
            // LblVacant
            // 
            this.LblVacant.AutoSize = true;
            this.LblVacant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVacant.Location = new System.Drawing.Point(314, 148);
            this.LblVacant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblVacant.Name = "LblVacant";
            this.LblVacant.Size = new System.Drawing.Size(117, 24);
            this.LblVacant.TabIndex = 27;
            this.LblVacant.Text = "Vacant Shifts";
            // 
            // lNBrootDataSet
            // 
            this.lNBrootDataSet.DataSetName = "LNBrootDataSet";
            this.lNBrootDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lNBrootDataSetBindingSource
            // 
            this.lNBrootDataSetBindingSource.DataSource = this.lNBrootDataSet;
            this.lNBrootDataSetBindingSource.Position = 0;
            // 
            // leaveRequestsBindingSource
            // 
            this.leaveRequestsBindingSource.DataMember = "LeaveRequests";
            this.leaveRequestsBindingSource.DataSource = this.lNBrootDataSetBindingSource;
            // 
            // leaveRequestsTableAdapter
            // 
            this.leaveRequestsTableAdapter.ClearBeforeFill = true;
            // 
            // leaveidDataGridViewTextBoxColumn
            // 
            this.leaveidDataGridViewTextBoxColumn.DataPropertyName = "leave_id";
            this.leaveidDataGridViewTextBoxColumn.HeaderText = "leave_id";
            this.leaveidDataGridViewTextBoxColumn.Name = "leaveidDataGridViewTextBoxColumn";
            this.leaveidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "end_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "end_date";
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            this.updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 445);
            this.Controls.Add(this.LblVacant);
            this.Controls.Add(this.lblLeave);
            this.Controls.Add(this.lblShiftReq);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPickups);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShiftApprove);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNBrootDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNBrootDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveRequestsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnShiftApprove;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPickups;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblShiftReq;
        private System.Windows.Forms.Label lblLeave;
        private System.Windows.Forms.Label LblVacant;
        private System.Windows.Forms.BindingSource lNBrootDataSetBindingSource;
        private LNBrootDataSet lNBrootDataSet;
        private System.Windows.Forms.BindingSource leaveRequestsBindingSource;
        private LNBrootDataSetTableAdapters.LeaveRequestsTableAdapter leaveRequestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
    }
}