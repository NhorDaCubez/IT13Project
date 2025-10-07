namespace FinalProj
{
    partial class Inventory
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
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            dgvInventory = new DataGridView();
            label6 = new Label();
            panel7 = new Panel();
            CreatePurchaseOrderBtn = new Button();
            label7 = new Label();
            InvExit = new Button();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(17, 123);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 165);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 0;
            label1.Text = "Low Stock";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(258, 123);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 165);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 17);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 0;
            label2.Text = "Stock In";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(499, 123);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 165);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 17);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 0;
            label3.Text = "Stock Out";
            // 
            // panel6
            // 
            panel6.AutoScroll = true;
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(dgvInventory);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(17, 300);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.MaximumSize = new Size(1213, 665);
            panel6.Name = "panel6";
            panel6.Size = new Size(808, 509);
            panel6.TabIndex = 1;
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(24, 85);
            dgvInventory.Margin = new Padding(4, 5, 4, 5);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 62;
            dgvInventory.Size = new Size(760, 390);
            dgvInventory.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(240, 18);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(291, 28);
            label6.TabIndex = 0;
            label6.Text = "Wholesale Inventory Overview";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(CreatePurchaseOrderBtn);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(834, 300);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(388, 509);
            panel7.TabIndex = 1;
            // 
            // CreatePurchaseOrderBtn
            // 
            CreatePurchaseOrderBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatePurchaseOrderBtn.Location = new Point(26, 85);
            CreatePurchaseOrderBtn.Margin = new Padding(4, 5, 4, 5);
            CreatePurchaseOrderBtn.Name = "CreatePurchaseOrderBtn";
            CreatePurchaseOrderBtn.Size = new Size(340, 48);
            CreatePurchaseOrderBtn.TabIndex = 1;
            CreatePurchaseOrderBtn.Text = "Create Purchase Order";
            CreatePurchaseOrderBtn.UseVisualStyleBackColor = true;
            CreatePurchaseOrderBtn.Click += CreatePurchaseOrderBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(119, 18);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(137, 28);
            label7.TabIndex = 0;
            label7.Text = "Quick Actions";
            // 
            // InvExit
            // 
            InvExit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvExit.Location = new Point(1130, 20);
            InvExit.Margin = new Padding(4, 5, 4, 5);
            InvExit.Name = "InvExit";
            InvExit.Size = new Size(87, 58);
            InvExit.TabIndex = 8;
            InvExit.Text = "Exit";
            InvExit.UseVisualStyleBackColor = true;
            InvExit.Click += InvExit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 37);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(328, 40);
            label8.TabIndex = 16;
            label8.Text = "Inventory Managment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(101, 75);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(23, 28);
            label4.TabIndex = 1;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(105, 75);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(23, 28);
            label5.TabIndex = 2;
            label5.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(103, 75);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(23, 28);
            label10.TabIndex = 3;
            label10.Text = "0";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1244, 827);
            Controls.Add(label8);
            Controls.Add(InvExit);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Inventory";
            Text = "Inventory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel6;
        private Label label6;
        private Panel panel7;
        private Label label7;
        private Button InvExit;
        private Label label8;
        private Button CreatePurchaseOrderBtn;
        private DataGridView dgvInventory;
        private Label label4;
        private Label label5;
        private Label label10;
    }
}