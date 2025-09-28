namespace FinalProj
{
    partial class HumanResources
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
            lblTotalEmployees = new Panel();
            label1 = new Label();
            lblPresentToday = new Panel();
            label2 = new Label();
            lblMonthlyPayroll = new Panel();
            label3 = new Label();
            lblAvgPerformance = new Panel();
            label4 = new Label();
            vScrollBar1 = new VScrollBar();
            panel6 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            dgvAttendance = new DataGridView();
            lblTotalEmployees.SuspendLayout();
            lblPresentToday.SuspendLayout();
            lblMonthlyPayroll.SuspendLayout();
            lblAvgPerformance.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // HrExitBtn
            // 
            HrExitBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HrExitBtn.Location = new Point(1171, 40);
            HrExitBtn.Margin = new Padding(4, 5, 4, 5);
            HrExitBtn.Name = "HrExitBtn";
            HrExitBtn.Size = new Size(87, 58);
            HrExitBtn.TabIndex = 10;
            HrExitBtn.Text = "Exit";
            HrExitBtn.UseVisualStyleBackColor = true;
            HrExitBtn.Click += HrExit;
            // 
            // lblTotalEmployees
            // 
            lblTotalEmployees.BorderStyle = BorderStyle.FixedSingle;
            lblTotalEmployees.Controls.Add(label1);
            lblTotalEmployees.Location = new Point(17, 152);
            lblTotalEmployees.Margin = new Padding(4, 5, 4, 5);
            lblTotalEmployees.Name = "lblTotalEmployees";
            lblTotalEmployees.Size = new Size(269, 189);
            lblTotalEmployees.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 0;
            label1.Text = "Total Employees";
            // 
            // lblPresentToday
            // 
            lblPresentToday.BorderStyle = BorderStyle.FixedSingle;
            lblPresentToday.Controls.Add(label2);
            lblPresentToday.Location = new Point(310, 152);
            lblPresentToday.Margin = new Padding(4, 5, 4, 5);
            lblPresentToday.Name = "lblPresentToday";
            lblPresentToday.Size = new Size(316, 189);
            lblPresentToday.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 30);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 0;
            label2.Text = "Present Today";
            // 
            // lblMonthlyPayroll
            // 
            lblMonthlyPayroll.BorderStyle = BorderStyle.FixedSingle;
            lblMonthlyPayroll.Controls.Add(label3);
            lblMonthlyPayroll.Location = new Point(653, 152);
            lblMonthlyPayroll.Margin = new Padding(4, 5, 4, 5);
            lblMonthlyPayroll.Name = "lblMonthlyPayroll";
            lblMonthlyPayroll.Size = new Size(279, 189);
            lblMonthlyPayroll.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 30);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 28);
            label3.TabIndex = 0;
            label3.Text = "Monthly Payroll";
            // 
            // lblAvgPerformance
            // 
            lblAvgPerformance.BorderStyle = BorderStyle.FixedSingle;
            lblAvgPerformance.Controls.Add(label4);
            lblAvgPerformance.Location = new Point(956, 152);
            lblAvgPerformance.Margin = new Padding(4, 5, 4, 5);
            lblAvgPerformance.Name = "lblAvgPerformance";
            lblAvgPerformance.Size = new Size(302, 189);
            lblAvgPerformance.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(172, 28);
            label4.TabIndex = 0;
            label4.Text = "AVG Performance";
            // 
            // vScrollBar1
            // 
            vScrollBar1.AllowDrop = true;
            vScrollBar1.Location = new Point(894, 224);
            vScrollBar1.Maximum = 50;
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.ScaleScrollBarForDpiChange = false;
            vScrollBar1.Size = new Size(17, 311);
            vScrollBar1.TabIndex = 13;
            vScrollBar1.Scroll += InitializeHorizontalScroll;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(button2);
            panel6.Controls.Add(button1);
            panel6.Location = new Point(890, 373);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(368, 337);
            panel6.TabIndex = 12;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(40, 188);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(283, 58);
            button2.TabIndex = 1;
            button2.Text = "Payroll Tracking";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(40, 92);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(283, 58);
            button1.TabIndex = 0;
            button1.Text = "Employee Management";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 57);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(264, 40);
            label5.TabIndex = 14;
            label5.Text = "Human Resources";
            // 
            // dgvAttendance
            // 
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Location = new Point(17, 373);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 62;
            dgvAttendance.Size = new Size(828, 474);
            dgvAttendance.TabIndex = 15;
            // 
            // HumanResources
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 925);
            Controls.Add(dgvAttendance);
            Controls.Add(label5);
            Controls.Add(panel6);
            Controls.Add(vScrollBar1);
            Controls.Add(lblAvgPerformance);
            Controls.Add(lblMonthlyPayroll);
            Controls.Add(lblPresentToday);
            Controls.Add(lblTotalEmployees);
            Controls.Add(HrExitBtn);
            Margin = new Padding(4, 5, 4, 5);
            Name = "HumanResources";
            Text = "HumanResources";
            lblTotalEmployees.ResumeLayout(false);
            lblTotalEmployees.PerformLayout();
            lblPresentToday.ResumeLayout(false);
            lblPresentToday.PerformLayout();
            lblMonthlyPayroll.ResumeLayout(false);
            lblMonthlyPayroll.PerformLayout();
            lblAvgPerformance.ResumeLayout(false);
            lblAvgPerformance.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HrExitBtn;
        private Panel lblTotalEmployees;
        private Label label1;
        private Panel lblPresentToday;
        private Label label2;
        private Panel lblMonthlyPayroll;
        private Label label3;
        private Panel lblAvgPerformance;
        private Label label4;
        private VScrollBar vScrollBar1;
        private Panel panel6;
        private Button button1;
        private Button button2;
        private Label label5;
        private DataGridView dgvAttendance;
    }
}