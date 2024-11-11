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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShiftApprove = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.dataLeaveReq = new System.Windows.Forms.DataGridView();
            this.leaveRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtReason = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPickups = new System.Windows.Forms.Button();
            this.btnVacant = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblShiftReq = new System.Windows.Forms.Label();
            this.lblLeave = new System.Windows.Forms.Label();
            this.LblVacant = new System.Windows.Forms.Label();
            this.PowerBIBTN = new System.Windows.Forms.Button();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lNBrootDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lNBrootDataSet = new LNB_Airlines.LNBrootDataSet();
            this.leaveRequestsTableAdapter = new LNB_Airlines.LNBrootDataSetTableAdapters.LeaveRequestsTableAdapter();
            this.usersTableAdapter = new LNB_Airlines.LNBrootDataSetTableAdapters.UsersTableAdapter();
            this.testDataSet3 = new LNB_Airlines.TestDataSet3();
            this.leaveRequestsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.leaveRequestsTableAdapter1 = new LNB_Airlines.TestDataSet3TableAdapters.LeaveRequestsTableAdapter();
            this.dataShiftPick = new System.Windows.Forms.DataGridView();
            this.testDataSet4 = new LNB_Airlines.TestDataSet4();
            this.shiftPickupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shiftPickupsTableAdapter = new LNB_Airlines.TestDataSet4TableAdapters.ShiftPickupsTableAdapter();
            this.dataVacant = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPowerBI = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickup_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDataSet7 = new LNB_Airlines.TestDataSet7();
            this.shiftPickupsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shiftPickupsTableAdapter1 = new LNB_Airlines.TestDataSet7TableAdapters.ShiftPickupsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLeaveReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNBrootDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNBrootDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveRequestsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataShiftPick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftPickupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVacant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPowerBI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftPickupsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(950, 612);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 55);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(854, 375);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 115);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnShiftApprove.Location = new System.Drawing.Point(12, 592);
            this.btnShiftApprove.Name = "btnShiftApprove";
            this.btnShiftApprove.Size = new System.Drawing.Size(88, 35);
            this.btnShiftApprove.TabIndex = 13;
            this.btnShiftApprove.Text = "Approve";
            this.btnShiftApprove.UseVisualStyleBackColor = false;
            this.btnShiftApprove.Click += new System.EventHandler(this.btnShiftApprove_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLeave.Location = new System.Drawing.Point(12, 157);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(176, 48);
            this.btnLeave.TabIndex = 12;
            this.btnLeave.Text = "Leave Requests";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // dataLeaveReq
            // 
            this.dataLeaveReq.AutoGenerateColumns = false;
            this.dataLeaveReq.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataLeaveReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLeaveReq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeidDataGridViewTextBoxColumn,
            this.status,
            this.reason,
            this.createdatDataGridViewTextBoxColumn});
            this.dataLeaveReq.DataSource = this.leaveRequestsBindingSource1;
            this.dataLeaveReq.Location = new System.Drawing.Point(10, 290);
            this.dataLeaveReq.Name = "dataLeaveReq";
            this.dataLeaveReq.RowHeadersWidth = 62;
            this.dataLeaveReq.RowTemplate.Height = 28;
            this.dataLeaveReq.Size = new System.Drawing.Size(698, 292);
            this.dataLeaveReq.TabIndex = 12;
            this.dataLeaveReq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // leaveRequestsBindingSource
            // 
            this.leaveRequestsBindingSource.DataMember = "LeaveRequests";
            this.leaveRequestsBindingSource.DataSource = this.lNBrootDataSetBindingSource;
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(202, 592);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(508, 36);
            this.txtReason.TabIndex = 9;
            this.txtReason.Text = "Reason...";
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(106, 592);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 35);
            this.button4.TabIndex = 10;
            this.button4.Text = "Decline";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 46);
            this.label3.TabIndex = 20;
            this.label3.Text = "Admin Page";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 94);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(990, 42);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.Text = "Search....";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnPickups
            // 
            this.btnPickups.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPickups.Location = new System.Drawing.Point(194, 157);
            this.btnPickups.Name = "btnPickups";
            this.btnPickups.Size = new System.Drawing.Size(176, 48);
            this.btnPickups.TabIndex = 22;
            this.btnPickups.Text = "Shift Pickups";
            this.btnPickups.UseVisualStyleBackColor = true;
            this.btnPickups.Click += new System.EventHandler(this.btnPickups_Click);
            // 
            // btnVacant
            // 
            this.btnVacant.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVacant.Location = new System.Drawing.Point(374, 157);
            this.btnVacant.Name = "btnVacant";
            this.btnVacant.Size = new System.Drawing.Size(176, 48);
            this.btnVacant.TabIndex = 23;
            this.btnVacant.Text = "Vacant Shifts";
            this.btnVacant.UseVisualStyleBackColor = true;
            this.btnVacant.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(854, 290);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(99, 78);
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
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1210, 25);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LNB ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblShiftReq
            // 
            this.lblShiftReq.AutoSize = true;
            this.lblShiftReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftReq.Location = new System.Drawing.Point(240, 228);
            this.lblShiftReq.Name = "lblShiftReq";
            this.lblShiftReq.Size = new System.Drawing.Size(199, 32);
            this.lblShiftReq.TabIndex = 25;
            this.lblShiftReq.Text = "Shift Requests";
            // 
            // lblLeave
            // 
            this.lblLeave.AutoSize = true;
            this.lblLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeave.Location = new System.Drawing.Point(6, 228);
            this.lblLeave.Name = "lblLeave";
            this.lblLeave.Size = new System.Drawing.Size(219, 32);
            this.lblLeave.TabIndex = 26;
            this.lblLeave.Text = "Leave Requests";
            // 
            // LblVacant
            // 
            this.LblVacant.AutoSize = true;
            this.LblVacant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVacant.Location = new System.Drawing.Point(471, 228);
            this.LblVacant.Name = "LblVacant";
            this.LblVacant.Size = new System.Drawing.Size(182, 32);
            this.LblVacant.TabIndex = 27;
            this.LblVacant.Text = "Vacant Shifts";
            // 
            // PowerBIBTN
            // 
            this.PowerBIBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PowerBIBTN.Location = new System.Drawing.Point(555, 157);
            this.PowerBIBTN.Name = "PowerBIBTN";
            this.PowerBIBTN.Size = new System.Drawing.Size(176, 48);
            this.PowerBIBTN.TabIndex = 23;
            this.PowerBIBTN.Text = "Power BI";
            this.PowerBIBTN.UseVisualStyleBackColor = true;
            this.PowerBIBTN.Click += new System.EventHandler(this.PowerBIBTN_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.lNBrootDataSetBindingSource;
            // 
            // lNBrootDataSetBindingSource
            // 
            this.lNBrootDataSetBindingSource.DataSource = this.lNBrootDataSet;
            this.lNBrootDataSetBindingSource.Position = 0;
            // 
            // lNBrootDataSet
            // 
            this.lNBrootDataSet.DataSetName = "LNBrootDataSet";
            this.lNBrootDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaveRequestsTableAdapter
            // 
            this.leaveRequestsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // testDataSet3
            // 
            this.testDataSet3.DataSetName = "TestDataSet3";
            this.testDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaveRequestsBindingSource1
            // 
            this.leaveRequestsBindingSource1.DataMember = "LeaveRequests";
            this.leaveRequestsBindingSource1.DataSource = this.testDataSet3;
            // 
            // leaveRequestsTableAdapter1
            // 
            this.leaveRequestsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataShiftPick
            // 
            this.dataShiftPick.AutoGenerateColumns = false;
            this.dataShiftPick.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataShiftPick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShiftPick.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shift_id,
            this.employee_id,
            this.pickup_status,
            this.created_at,
            this.updated_at});
            this.dataShiftPick.DataSource = this.shiftPickupsBindingSource;
            this.dataShiftPick.Location = new System.Drawing.Point(12, 350);
            this.dataShiftPick.Name = "dataShiftPick";
            this.dataShiftPick.RowHeadersWidth = 62;
            this.dataShiftPick.RowTemplate.Height = 28;
            this.dataShiftPick.Size = new System.Drawing.Size(698, 292);
            this.dataShiftPick.TabIndex = 28;
            // 
            // testDataSet4
            // 
            this.testDataSet4.DataSetName = "TestDataSet4";
            this.testDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shiftPickupsBindingSource
            // 
            this.shiftPickupsBindingSource.DataMember = "ShiftPickups";
            this.shiftPickupsBindingSource.DataSource = this.testDataSet4;
            // 
            // shiftPickupsTableAdapter
            // 
            this.shiftPickupsTableAdapter.ClearBeforeFill = true;
            // 
            // dataVacant
            // 
            this.dataVacant.AutoGenerateColumns = false;
            this.dataVacant.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataVacant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVacant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataVacant.DataSource = this.shiftPickupsBindingSource1;
            this.dataVacant.Location = new System.Drawing.Point(12, 421);
            this.dataVacant.Name = "dataVacant";
            this.dataVacant.RowHeadersWidth = 62;
            this.dataVacant.RowTemplate.Height = 28;
            this.dataVacant.Size = new System.Drawing.Size(698, 292);
            this.dataVacant.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "employee_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "employee_id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "created_at";
            this.dataGridViewTextBoxColumn4.HeaderText = "created_at";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataPowerBI
            // 
            this.dataPowerBI.AutoGenerateColumns = false;
            this.dataPowerBI.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataPowerBI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPowerBI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataPowerBI.DataSource = this.shiftPickupsBindingSource;
            this.dataPowerBI.Location = new System.Drawing.Point(12, 491);
            this.dataPowerBI.Name = "dataPowerBI";
            this.dataPowerBI.RowHeadersWidth = 62;
            this.dataPowerBI.RowTemplate.Height = 28;
            this.dataPowerBI.Size = new System.Drawing.Size(698, 292);
            this.dataPowerBI.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "employee_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "employee_id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "created_at";
            this.dataGridViewTextBoxColumn6.HeaderText = "created_at";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.Width = 150;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.Width = 150;
            // 
            // reason
            // 
            this.reason.DataPropertyName = "reason";
            this.reason.HeaderText = "reason";
            this.reason.MinimumWidth = 8;
            this.reason.Name = "reason";
            this.reason.Width = 150;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.Width = 150;
            // 
            // shift_id
            // 
            this.shift_id.DataPropertyName = "shift_id";
            this.shift_id.HeaderText = "shift_id";
            this.shift_id.MinimumWidth = 8;
            this.shift_id.Name = "shift_id";
            this.shift_id.Width = 150;
            // 
            // employee_id
            // 
            this.employee_id.DataPropertyName = "employee_id";
            this.employee_id.HeaderText = "employee_id";
            this.employee_id.MinimumWidth = 8;
            this.employee_id.Name = "employee_id";
            this.employee_id.Width = 150;
            // 
            // pickup_status
            // 
            this.pickup_status.DataPropertyName = "pickup_status";
            this.pickup_status.HeaderText = "pickup_status";
            this.pickup_status.MinimumWidth = 8;
            this.pickup_status.Name = "pickup_status";
            this.pickup_status.Width = 150;
            // 
            // created_at
            // 
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "created_at";
            this.created_at.MinimumWidth = 8;
            this.created_at.Name = "created_at";
            this.created_at.Width = 150;
            // 
            // updated_at
            // 
            this.updated_at.DataPropertyName = "updated_at";
            this.updated_at.HeaderText = "updated_at";
            this.updated_at.MinimumWidth = 8;
            this.updated_at.Name = "updated_at";
            this.updated_at.Width = 150;
            // 
            // testDataSet7
            // 
            this.testDataSet7.DataSetName = "TestDataSet7";
            this.testDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shiftPickupsBindingSource1
            // 
            this.shiftPickupsBindingSource1.DataMember = "ShiftPickups";
            this.shiftPickupsBindingSource1.DataSource = this.testDataSet7;
            // 
            // shiftPickupsTableAdapter1
            // 
            this.shiftPickupsTableAdapter1.ClearBeforeFill = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 685);
            this.Controls.Add(this.dataPowerBI);
            this.Controls.Add(this.dataVacant);
            this.Controls.Add(this.dataShiftPick);
            this.Controls.Add(this.LblVacant);
            this.Controls.Add(this.lblLeave);
            this.Controls.Add(this.lblShiftReq);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.PowerBIBTN);
            this.Controls.Add(this.btnVacant);
            this.Controls.Add(this.btnPickups);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShiftApprove);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataLeaveReq);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLeaveReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNBrootDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNBrootDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveRequestsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataShiftPick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftPickupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVacant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPowerBI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftPickupsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnShiftApprove;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.DataGridView dataLeaveReq;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPickups;
        private System.Windows.Forms.Button btnVacant;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblShiftReq;
        private System.Windows.Forms.Label lblLeave;
        private System.Windows.Forms.Label LblVacant;
        private System.Windows.Forms.BindingSource lNBrootDataSetBindingSource;
        private LNBrootDataSet lNBrootDataSet;
        private System.Windows.Forms.BindingSource leaveRequestsBindingSource;
        private LNBrootDataSetTableAdapters.LeaveRequestsTableAdapter leaveRequestsTableAdapter;
        private System.Windows.Forms.Button PowerBIBTN;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private LNBrootDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private TestDataSet3 testDataSet3;
        private System.Windows.Forms.BindingSource leaveRequestsBindingSource1;
        private TestDataSet3TableAdapters.LeaveRequestsTableAdapter leaveRequestsTableAdapter1;
        private System.Windows.Forms.DataGridView dataShiftPick;
        private TestDataSet4 testDataSet4;
        private System.Windows.Forms.BindingSource shiftPickupsBindingSource;
        private TestDataSet4TableAdapters.ShiftPickupsTableAdapter shiftPickupsTableAdapter;
        private System.Windows.Forms.DataGridView dataVacant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataPowerBI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickup_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private TestDataSet7 testDataSet7;
        private System.Windows.Forms.BindingSource shiftPickupsBindingSource1;
        private TestDataSet7TableAdapters.ShiftPickupsTableAdapter shiftPickupsTableAdapter1;
    }
}