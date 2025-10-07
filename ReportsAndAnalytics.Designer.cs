namespace FinalProj
{
    partial class ReportsAndAnalytics
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
            InvExit = new Button();
            panel1 = new Panel();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // InvExit
            // 
            InvExit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvExit.Location = new Point(930, 62);
            InvExit.Margin = new Padding(4, 5, 4, 5);
            InvExit.Name = "InvExit";
            InvExit.Size = new Size(87, 58);
            InvExit.TabIndex = 9;
            InvExit.Text = "Exit";
            InvExit.UseVisualStyleBackColor = true;
            InvExit.Click += InvExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(56, 162);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 465);
            panel1.TabIndex = 10;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(29, 350);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(406, 62);
            button4.TabIndex = 3;
            button4.Text = "Product Performance";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(28, 202);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(406, 62);
            button2.TabIndex = 1;
            button2.Text = "Weekly Performance";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(29, 68);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(406, 62);
            button1.TabIndex = 0;
            button1.Text = "Daily Sales Report";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(549, 162);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(468, 291);
            panel2.TabIndex = 11;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(29, 202);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(406, 62);
            button6.TabIndex = 5;
            button6.Text = "Expiry Tracking";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(28, 68);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(406, 62);
            button5.TabIndex = 4;
            button5.Text = "Stock Levels";
            button5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(56, 78);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(320, 40);
            label6.TabIndex = 15;
            label6.Text = "Reports And Analytics";
            // 
            // ReportsAndAnalytics
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1080, 705);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(InvExit);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ReportsAndAnalytics";
            Text = "ReportsAndAnalytics";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InvExit;
        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Label label6;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}