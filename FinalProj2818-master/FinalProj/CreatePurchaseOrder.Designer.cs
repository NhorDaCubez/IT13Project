namespace FinalProj
{
    partial class CreatePurchaseOrder
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
            txtVendorName = new DataGridView();
            txtItemName = new TextBox();
            AddItemBtn = new Button();
            SubmitBtn = new Button();
            ExitBtn = new Button();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txtVendorName).BeginInit();
            SuspendLayout();
            // 
            // txtVendorName
            // 
            txtVendorName.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            txtVendorName.Location = new Point(344, 12);
            txtVendorName.Name = "txtVendorName";
            txtVendorName.RowHeadersWidth = 62;
            txtVendorName.Size = new Size(258, 426);
            txtVendorName.TabIndex = 0;
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(39, 61);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(232, 31);
            txtItemName.TabIndex = 1;
            // 
            // AddItemBtn
            // 
            AddItemBtn.Location = new Point(201, 325);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.Size = new Size(112, 34);
            AddItemBtn.TabIndex = 2;
            AddItemBtn.Text = "ADD";
            AddItemBtn.UseVisualStyleBackColor = true;
            AddItemBtn.Click += AddItemBtn_Click;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(201, 375);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(112, 34);
            SubmitBtn.TabIndex = 3;
            SubmitBtn.Text = "SUBMIT";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(12, 375);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(112, 34);
            ExitBtn.TabIndex = 4;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(39, 123);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(232, 31);
            txtQuantity.TabIndex = 5;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(39, 179);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(232, 31);
            txtUnitPrice.TabIndex = 6;
            // 
            // CreatePurchaseOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 450);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtQuantity);
            Controls.Add(ExitBtn);
            Controls.Add(SubmitBtn);
            Controls.Add(AddItemBtn);
            Controls.Add(txtItemName);
            Controls.Add(txtVendorName);
            Name = "CreatePurchaseOrder";
            Text = "Create Purchase Order";
            ((System.ComponentModel.ISupportInitialize)txtVendorName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView txtVendorName;
        private TextBox txtItemName;
        private Button AddItemBtn;
        private Button SubmitBtn;
        private Button ExitBtn;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
    }
}