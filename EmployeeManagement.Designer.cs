namespace FinalProj
{
    partial class EmployeeManagement
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
            HrExitBtn = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Employee = new DataGridViewTextBoxColumn();
            EmployeeID = new DataGridViewTextBoxColumn();
            EmployeePosition = new DataGridViewTextBoxColumn();
            Remarks = new DataGridViewComboBoxColumn();
            label5 = new Label();
            dataGridView2 = new DataGridView();
            EmployeeName = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            TimeIn = new DataGridViewTextBoxColumn();
            TimeOut = new DataGridViewTextBoxColumn();
            OperatingHours = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // HrExitBtn
            // 
            HrExitBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HrExitBtn.Location = new Point(682, 30);
            HrExitBtn.Name = "HrExitBtn";
            HrExitBtn.Size = new Size(61, 35);
            HrExitBtn.TabIndex = 11;
            HrExitBtn.Text = "Back";
            HrExitBtn.UseVisualStyleBackColor = true;
            HrExitBtn.Click += HrExitBtn_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoScrollMargin = new Size(100, 100);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(6, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 413);
            panel2.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Employee, EmployeeID, EmployeePosition, Remarks });
            dataGridView1.Location = new Point(67, 385);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 223);
            dataGridView1.TabIndex = 19;
            // 
            // Employee
            // 
            Employee.HeaderText = "Employee Name";
            Employee.Name = "Employee";
            // 
            // EmployeeID
            // 
            EmployeeID.HeaderText = "ID";
            EmployeeID.Name = "EmployeeID";
            // 
            // EmployeePosition
            // 
            EmployeePosition.HeaderText = "Position";
            EmployeePosition.Name = "EmployeePosition";
            // 
            // Remarks
            // 
            Remarks.HeaderText = "Remarks";
            Remarks.Items.AddRange(new object[] { "Not Good", "Good", "Very Good" });
            Remarks.Name = "Remarks";
            Remarks.Resizable = DataGridViewTriState.True;
            Remarks.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(63, 356);
            label5.Name = "label5";
            label5.Size = new Size(130, 17);
            label5.TabIndex = 18;
            label5.Text = "Performance Report";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { EmployeeName, ID, TimeIn, TimeOut, OperatingHours });
            dataGridView2.Location = new Point(67, 45);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(544, 298);
            dataGridView2.TabIndex = 17;
            // 
            // EmployeeName
            // 
            EmployeeName.HeaderText = "Employee Name";
            EmployeeName.Name = "EmployeeName";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // TimeIn
            // 
            TimeIn.HeaderText = "Time In";
            TimeIn.Name = "TimeIn";
            // 
            // TimeOut
            // 
            TimeOut.HeaderText = "TimeOut";
            TimeOut.Name = "TimeOut";
            // 
            // OperatingHours
            // 
            OperatingHours.HeaderText = "Operating Hours";
            OperatingHours.Name = "OperatingHours";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 13);
            label2.Name = "label2";
            label2.Size = new Size(78, 17);
            label2.TabIndex = 0;
            label2.Text = "Attendance";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(221, 25);
            label1.TabIndex = 14;
            label1.Text = "Employee Management";
            // 
            // EmployeeManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 515);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(HrExitBtn);
            Name = "EmployeeManagement";
            Text = "EmployeeManagement";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HrExitBtn;
        private Panel panel2;
        private Label label2;
        private Label label5;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TimeIn;
        private DataGridViewTextBoxColumn TimeOut;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Employee;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn EmployeePosition;
        private DataGridViewComboBoxColumn Remarks;
        private DataGridViewTextBoxColumn OperatingHours;
        private Label label1;
    }
}