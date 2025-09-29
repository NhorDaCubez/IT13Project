namespace FinalProj
{
    partial class Mainform
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
            ReportsAndAnylyticsBtn = new Button();
            label1 = new Label();
            button9 = new Button();
            SSopen = new Button();
            button6 = new Button();
            button5 = new Button();
            Salesncust = new Button();
            Inv = new Button();
            bbt = new Button();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            panel7 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ReportsAndAnylyticsBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(SSopen);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(Salesncust);
            panel1.Controls.Add(Inv);
            panel1.Controls.Add(bbt);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 834);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // ReportsAndAnylyticsBtn
            // 
            ReportsAndAnylyticsBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReportsAndAnylyticsBtn.Location = new Point(17, 510);
            ReportsAndAnylyticsBtn.Margin = new Padding(4, 5, 4, 5);
            ReportsAndAnylyticsBtn.Name = "ReportsAndAnylyticsBtn";
            ReportsAndAnylyticsBtn.Size = new Size(323, 52);
            ReportsAndAnylyticsBtn.TabIndex = 11;
            ReportsAndAnylyticsBtn.Text = "Reports and Analytics";
            ReportsAndAnylyticsBtn.UseVisualStyleBackColor = true;
            ReportsAndAnylyticsBtn.Click += OpenReportsAndAnalytics;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(67, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 64);
            label1.TabIndex = 10;
            label1.Text = "Soda Pop";
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(103, 667);
            button9.Margin = new Padding(4, 5, 4, 5);
            button9.Name = "button9";
            button9.Size = new Size(153, 52);
            button9.TabIndex = 9;
            button9.Text = "Logout";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Logout;
            // 
            // SSopen
            // 
            SSopen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SSopen.Location = new Point(16, 587);
            SSopen.Margin = new Padding(4, 5, 4, 5);
            SSopen.Name = "SSopen";
            SSopen.Size = new Size(323, 52);
            SSopen.TabIndex = 8;
            SSopen.Text = "System Settings";
            SSopen.UseVisualStyleBackColor = true;
            SSopen.Click += OpenSSBtn;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(16, 430);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(323, 52);
            button6.TabIndex = 6;
            button6.Text = "Human Resources";
            button6.UseVisualStyleBackColor = true;
            button6.Click += HumanResourceBtn;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(16, 353);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(323, 52);
            button5.TabIndex = 5;
            button5.Text = "Logistics";
            button5.UseVisualStyleBackColor = true;
            button5.Click += SupplyChainAndLogistics_Click;
            // 
            // Salesncust
            // 
            Salesncust.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Salesncust.Location = new Point(17, 275);
            Salesncust.Margin = new Padding(4, 5, 4, 5);
            Salesncust.Name = "Salesncust";
            Salesncust.Size = new Size(323, 52);
            Salesncust.TabIndex = 4;
            Salesncust.Text = "Sales";
            Salesncust.UseVisualStyleBackColor = true;
            Salesncust.Click += SalesNCustomers;
            // 
            // Inv
            // 
            Inv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Inv.Location = new Point(17, 195);
            Inv.Margin = new Padding(4, 5, 4, 5);
            Inv.Name = "Inv";
            Inv.Size = new Size(323, 52);
            Inv.TabIndex = 3;
            Inv.Text = "Inventory";
            Inv.UseVisualStyleBackColor = true;
            Inv.Click += InventoryBtn;
            // 
            // bbt
            // 
            bbt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bbt.Location = new Point(16, 115);
            bbt.Margin = new Padding(4, 5, 4, 5);
            bbt.Name = "bbt";
            bbt.Size = new Size(323, 52);
            bbt.TabIndex = 2;
            bbt.Text = "Financial";
            bbt.UseVisualStyleBackColor = true;
            bbt.Click += FinancialBtn;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(371, 100);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 165);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 0;
            label2.Text = "Daily Sales";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label5);
            panel3.Location = new Point(1151, 100);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(251, 165);
            panel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 15);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 4;
            label5.Text = "Pending Deliveries";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonFace;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(631, 100);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(251, 165);
            panel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 15);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(142, 28);
            label3.TabIndex = 1;
            label3.Text = "Total Inventory";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonFace;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label4);
            panel5.Location = new Point(891, 100);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(251, 165);
            panel5.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 28);
            label4.TabIndex = 3;
            label4.Text = "Active Customers";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonFace;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label6);
            panel6.Location = new Point(371, 277);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(616, 522);
            panel6.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(214, 33);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(154, 28);
            label6.TabIndex = 1;
            label6.Text = "Recent Activities";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonFace;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label7);
            panel7.Location = new Point(997, 277);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(405, 522);
            panel7.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(119, 33);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(132, 28);
            label7.TabIndex = 2;
            label7.Text = "System Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(371, 38);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(166, 40);
            label8.TabIndex = 14;
            label8.Text = "Dashboard";
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1424, 827);
            Controls.Add(label8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Mainform";
            Text = "Main";
            Load += Mainform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button bbt;
        private Button button9;
        private Button SSopen;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button Inv;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label5;
        private Panel panel4;
        private Label label3;
        private Panel panel5;
        private Label label4;
        private Panel panel6;
        private Label label6;
        private Panel panel7;
        private Label label7;
        private Button Salesncust;
        private Label label8;
        private Button ReportsAndAnylyticsBtn;
    }
}