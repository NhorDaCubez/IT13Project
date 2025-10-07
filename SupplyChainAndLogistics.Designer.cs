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
            SCnLButton = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(609, 504);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 189);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 0;
            label1.Text = "Active Deliveries";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(609, 224);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 189);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 16);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 1;
            label2.Text = "Completed Today";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonFace;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label5);
            panel5.Location = new Point(29, 113);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(535, 703);
            panel5.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(167, 32);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(214, 28);
            label5.TabIndex = 4;
            label5.Text = "Supplier Management";
            // 
            // SCnLButton
            // 
            SCnLButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SCnLButton.Location = new Point(1074, 20);
            SCnLButton.Margin = new Padding(4, 5, 4, 5);
            SCnLButton.Name = "SCnLButton";
            SCnLButton.Size = new Size(87, 58);
            SCnLButton.TabIndex = 9;
            SCnLButton.Text = "Exit";
            SCnLButton.UseVisualStyleBackColor = true;
            SCnLButton.Click += ExitSCnL;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 37);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(382, 40);
            label4.TabIndex = 14;
            label4.Text = "Supply Chain and Logistics";
            // 
            // SupplyChainAndLogistics
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1181, 830);
            Controls.Add(label4);
            Controls.Add(SCnLButton);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SupplyChainAndLogistics";
            Text = "SupplyChainAndLogistics";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Button SCnLButton;
        private Label label4;
    }
}