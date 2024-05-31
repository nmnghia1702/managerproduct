namespace SaleWinApp
{
    partial class frmProductDetails
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
            txtUnitPrice = new TextBox();
            txtUnitsInStock = new TextBox();
            txtWeight = new TextBox();
            txtProductName = new TextBox();
            lbUnitsInStock = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtProductID = new TextBox();
            lbWeight = new Label();
            lbProductName = new Label();
            lbEmail = new Label();
            lbUnitPrice = new Label();
            lbProductID = new Label();
            cboCategory = new ComboBox();
            SuspendLayout();
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(225, 227);
            txtUnitPrice.Margin = new Padding(2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(237, 23);
            txtUnitPrice.TabIndex = 72;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(225, 264);
            txtUnitsInStock.Margin = new Padding(2);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(237, 23);
            txtUnitsInStock.TabIndex = 71;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(225, 185);
            txtWeight.Margin = new Padding(2);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(237, 23);
            txtWeight.TabIndex = 70;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(225, 147);
            txtProductName.Margin = new Padding(2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(237, 23);
            txtProductName.TabIndex = 69;
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new Point(118, 267);
            lbUnitsInStock.Margin = new Padding(2, 0, 2, 0);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new Size(79, 15);
            lbUnitsInStock.TabIndex = 67;
            lbUnitsInStock.Text = "Units In Stock";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(359, 309);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 25);
            btnCancel.TabIndex = 66;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(179, 309);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 25);
            btnSave.TabIndex = 65;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(225, 71);
            txtProductID.Margin = new Padding(2);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(237, 23);
            txtProductID.TabIndex = 64;
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(118, 188);
            lbWeight.Margin = new Padding(2, 0, 2, 0);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(45, 15);
            lbWeight.TabIndex = 63;
            lbWeight.Text = "Weight";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(118, 150);
            lbProductName.Margin = new Padding(2, 0, 2, 0);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(84, 15);
            lbProductName.TabIndex = 62;
            lbProductName.Text = "Product Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(118, 113);
            lbEmail.Margin = new Padding(2, 0, 2, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(55, 15);
            lbEmail.TabIndex = 61;
            lbEmail.Text = "Category";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(118, 230);
            lbUnitPrice.Margin = new Padding(2, 0, 2, 0);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(55, 15);
            lbUnitPrice.TabIndex = 60;
            lbUnitPrice.Text = "UnitPrice";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(118, 74);
            lbProductID.Margin = new Padding(2, 0, 2, 0);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(63, 15);
            lbProductID.TabIndex = 59;
            lbProductID.Text = "Product ID";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "1", "2", "3" });
            cboCategory.Location = new Point(225, 109);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(237, 23);
            cboCategory.TabIndex = 73;
            // 
            // frmProductDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 405);
            Controls.Add(cboCategory);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtWeight);
            Controls.Add(txtProductName);
            Controls.Add(lbUnitsInStock);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtProductID);
            Controls.Add(lbWeight);
            Controls.Add(lbProductName);
            Controls.Add(lbEmail);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbProductID);
            Name = "frmProductDetails";
            Text = "Product details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUnitPrice;
        private TextBox txtUnitsInStock;
        private TextBox txtWeight;
        private TextBox txtProductName;
        private Label lbUnitsInStock;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtProductID;
        private Label lbWeight;
        private Label lbProductName;
        private Label lbEmail;
        private Label lbUnitPrice;
        private Label lbProductID;
        private ComboBox cboCategory;
    }
}