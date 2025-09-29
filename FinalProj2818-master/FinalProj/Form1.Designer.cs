namespace FinalProj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            Loginbtn = new Button();
            Username = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(301, 85);
            label1.TabIndex = 0;
            label1.Text = "Soda Pop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(231, 137);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(414, 32);
            label2.TabIndex = 1;
            label2.Text = "Wholesale Distribution Management";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Loginbtn);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(149, 217);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(583, 522);
            panel1.TabIndex = 2;
            // 
            // Loginbtn
            // 
            Loginbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbtn.Location = new Point(231, 390);
            Loginbtn.Margin = new Padding(4, 5, 4, 5);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(111, 65);
            Loginbtn.TabIndex = 3;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = true;
            Loginbtn.Click += Login;
            // 
            // Username
            // 
            Username.BackColor = SystemColors.InactiveCaption;
            Username.Location = new Point(66, 185);
            Username.Margin = new Padding(4, 5, 4, 5);
            Username.Name = "Username";
            Username.PlaceholderText = "Employee ID";
            Username.Size = new Size(453, 31);
            Username.TabIndex = 3;
            Username.TextChanged += Username_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(201, 17);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(158, 32);
            label4.TabIndex = 1;
            label4.Text = "System Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 138);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 32);
            label3.TabIndex = 0;
            label3.Text = "Employee ID";
            label3.Click += Login;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(887, 840);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button Loginbtn;
        private TextBox Username;
        private Label label4;
        private Label label3;
    }
}
