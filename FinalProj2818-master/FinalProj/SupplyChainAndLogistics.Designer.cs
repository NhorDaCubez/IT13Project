namespace FinalProj
{
    partial class SupplyChainAndLogistics
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
            panel5 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            SCnLButton = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 114);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 11);
            label1.Name = "label1";
            label1.Size = new Size(106, 17);
            label1.TabIndex = 0;
            label1.Text = "Active Deliveries";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(282, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 114);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 11);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 1;
            label2.Text = "Completed Today";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonFace;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 182);
            panel5.Name = "panel5";
            panel5.Size = new Size(375, 303);
            panel5.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(110, 17);
            label5.Name = "label5";
            label5.Size = new Size(142, 17);
            label5.TabIndex = 4;
            label5.Text = "Supplier Management";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonFace;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label6);
            panel6.Location = new Point(393, 182);
            panel6.Name = "panel6";
            panel6.Size = new Size(420, 303);
            panel6.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(86, 17);
            label6.Name = "label6";
            label6.Size = new Size(251, 17);
            label6.TabIndex = 5;
            label6.Text = "Delivery Scheduling and Route Planning";
            label6.Click += DeliverScheduling;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(560, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(253, 114);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 11);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 1;
            label3.Text = "Active Suppliers";
            // 
            // SCnLButton
            // 
            SCnLButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SCnLButton.Location = new Point(752, 12);
            SCnLButton.Name = "SCnLButton";
            SCnLButton.Size = new Size(61, 35);
            SCnLButton.TabIndex = 9;
            SCnLButton.Text = "Exit";
            SCnLButton.UseVisualStyleBackColor = true;
            SCnLButton.Click += ExitSCnL;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 22);
            label4.Name = "label4";
            label4.Size = new Size(249, 25);
            label4.TabIndex = 14;
            label4.Text = "Supply Chain and Logistics";
            // 
            // SupplyChainAndLogistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(827, 498);
            Controls.Add(label4);
            Controls.Add(SCnLButton);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SupplyChainAndLogistics";
            Text = "SupplyChainAndLogistics";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Label label1;
        private Label label2;
        private Label label5;
        private Panel panel6;
        private Label label6;
        private Panel panel3;
        private Label label3;
        private Button SCnLButton;
        private Label label4;
    }
}