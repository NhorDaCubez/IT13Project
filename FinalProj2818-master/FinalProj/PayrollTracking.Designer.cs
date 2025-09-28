namespace FinalProj
{
    partial class PayrollTracking
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            PayrollExitBtn = new Button();
            label1 = new Label();
            EmployeeName = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            BasicPay = new DataGridViewTextBoxColumn();
            Overtime = new DataGridViewTextBoxColumn();
            Bonus = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Action = new DataGridViewCheckBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(16, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 356);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeName, ID, Position, BasicPay, Overtime, Bonus, Total, Action });
            dataGridView1.Location = new Point(17, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(726, 322);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // PayrollExitBtn
            // 
            PayrollExitBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PayrollExitBtn.Location = new Point(714, 22);
            PayrollExitBtn.Name = "PayrollExitBtn";
            PayrollExitBtn.Size = new Size(61, 35);
            PayrollExitBtn.TabIndex = 12;
            PayrollExitBtn.Text = "Back";
            PayrollExitBtn.UseVisualStyleBackColor = true;
            PayrollExitBtn.Click += PayrollExitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 13;
            label1.Text = "Payroll Tracking";
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
            // Position
            // 
            Position.HeaderText = "Position";
            Position.Name = "Position";
            // 
            // BasicPay
            // 
            BasicPay.HeaderText = "BasicPay";
            BasicPay.Name = "BasicPay";
            // 
            // Overtime
            // 
            Overtime.HeaderText = "Overtime";
            Overtime.Name = "Overtime";
            // 
            // Bonus
            // 
            Bonus.HeaderText = "Bonus";
            Bonus.Name = "Bonus";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.Name = "Action";
            Action.Resizable = DataGridViewTriState.True;
            Action.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // PayrollTracking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(PayrollExitBtn);
            Controls.Add(panel1);
            Name = "PayrollTracking";
            Text = "PayrollTracking";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button PayrollExitBtn;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn BasicPay;
        private DataGridViewTextBoxColumn Overtime;
        private DataGridViewTextBoxColumn Bonus;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewCheckBoxColumn Action;
    }
}