namespace FinalProj
{
    partial class SalesAndCustomers
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
            lblTotalCustomers = new Panel();
            label5 = new Label();
            label1 = new Label();
            lblOrdersToday = new Panel();
            label7 = new Label();
            label2 = new Label();
            panel6 = new Panel();
            dgvOrderManagement = new DataGridView();
            label4 = new Label();
            Exx = new Button();
            label6 = new Label();
            lblTotalCustomers.SuspendLayout();
            lblOrdersToday.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderManagement).BeginInit();
            SuspendLayout();
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.BackColor = SystemColors.ButtonFace;
            lblTotalCustomers.BorderStyle = BorderStyle.FixedSingle;
            lblTotalCustomers.Controls.Add(label5);
            lblTotalCustomers.Controls.Add(label1);
            lblTotalCustomers.Location = new Point(122, 113);
            lblTotalCustomers.Margin = new Padding(4, 5, 4, 5);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(392, 165);
            lblTotalCustomers.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(164, 82);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(23, 28);
            label5.TabIndex = 1;
            label5.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 28);
            label1.TabIndex = 0;
            label1.Text = "Total Customers";
            // 
            // lblOrdersToday
            // 
            lblOrdersToday.BackColor = SystemColors.ButtonFace;
            lblOrdersToday.BorderStyle = BorderStyle.FixedSingle;
            lblOrdersToday.Controls.Add(label7);
            lblOrdersToday.Controls.Add(label2);
            lblOrdersToday.Location = new Point(717, 113);
            lblOrdersToday.Margin = new Padding(4, 5, 4, 5);
            lblOrdersToday.Name = "lblOrdersToday";
            lblOrdersToday.Size = new Size(383, 165);
            lblOrdersToday.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(175, 82);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(23, 28);
            label7.TabIndex = 2;
            label7.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 0;
            label2.Text = "Orders Today";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonFace;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(dgvOrderManagement);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(330, 297);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(573, 612);
            panel6.TabIndex = 1;
            // 
            // dgvOrderManagement
            // 
            dgvOrderManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderManagement.Location = new Point(21, 85);
            dgvOrderManagement.Margin = new Padding(4, 5, 4, 5);
            dgvOrderManagement.Name = "dgvOrderManagement";
            dgvOrderManagement.RowHeadersWidth = 62;
            dgvOrderManagement.Size = new Size(524, 497);
            dgvOrderManagement.TabIndex = 2;
            dgvOrderManagement.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(195, 19);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(191, 28);
            label4.TabIndex = 1;
            label4.Text = "Order Management";
            // 
            // Exx
            // 
            Exx.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exx.Location = new Point(1137, 20);
            Exx.Margin = new Padding(4, 5, 4, 5);
            Exx.Name = "Exx";
            Exx.Size = new Size(87, 58);
            Exx.TabIndex = 8;
            Exx.Text = "Exit";
            Exx.UseVisualStyleBackColor = true;
            Exx.Click += Exx_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 37);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 40);
            label6.TabIndex = 14;
            label6.Text = "Sales ";
            // 
            // SalesAndCustomers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1249, 923);
            Controls.Add(label6);
            Controls.Add(Exx);
            Controls.Add(panel6);
            Controls.Add(lblOrdersToday);
            Controls.Add(lblTotalCustomers);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SalesAndCustomers";
            Text = "SalesAndCustomers";
            lblTotalCustomers.ResumeLayout(false);
            lblTotalCustomers.PerformLayout();
            lblOrdersToday.ResumeLayout(false);
            lblOrdersToday.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderManagement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel lblTotalCustomers;
        private Label label1;
        private Panel lblOrdersToday;
        private Label label2;
        private Panel panel6;
        private Label label4;
        private Button Exx;
        private Button button2;
        private Button button1;
        private DataGridView dgvOrderManagement;
        private Label label6;
        private Label label5;
        private Label label7;
    }
}