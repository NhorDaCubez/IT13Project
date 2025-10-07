namespace FinalProj
{
    partial class Financial
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
            DailyPerformance = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label11 = new Label();
            Exit2 = new Button();
            label4 = new Label();
            DailyPerformance.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // DailyPerformance
            // 
            DailyPerformance.BackColor = SystemColors.ButtonFace;
            DailyPerformance.BorderStyle = BorderStyle.FixedSingle;
            DailyPerformance.Controls.Add(label1);
            DailyPerformance.Location = new Point(688, 129);
            DailyPerformance.Margin = new Padding(4, 5, 4, 5);
            DailyPerformance.Name = "DailyPerformance";
            DailyPerformance.Size = new Size(371, 249);
            DailyPerformance.TabIndex = 0;
            DailyPerformance.Paint += GetDailyPerformance;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 28);
            label1.TabIndex = 0;
            label1.Text = "Daily Performance";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(688, 460);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 249);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, -2);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(199, 28);
            label2.TabIndex = 0;
            label2.Text = "Weekly Performance";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(688, 788);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(373, 249);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(84, -2);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(209, 28);
            label3.TabIndex = 0;
            label3.Text = "Monthly Performance";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonFace;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label11);
            panel4.Location = new Point(17, 129);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(576, 907);
            panel4.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(169, 10);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(249, 28);
            label11.TabIndex = 1;
            label11.Text = "Recent Sales and Revenue";
            // 
            // Exit2
            // 
            Exit2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit2.Location = new Point(1053, 20);
            Exit2.Margin = new Padding(4, 5, 4, 5);
            Exit2.Name = "Exit2";
            Exit2.Size = new Size(87, 58);
            Exit2.TabIndex = 5;
            Exit2.Text = "Exit";
            Exit2.UseVisualStyleBackColor = true;
            Exit2.Click += ExitBtn;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 37);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(330, 40);
            label4.TabIndex = 14;
            label4.Text = "Financial Management";
            // 
            // Financial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1160, 1050);
            Controls.Add(label4);
            Controls.Add(Exit2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(DailyPerformance);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Financial";
            Text = "Financial Management";
            DailyPerformance.ResumeLayout(false);
            DailyPerformance.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel DailyPerformance;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Button Exit2;
        private Label label11;
        private Label label4;
    }
}