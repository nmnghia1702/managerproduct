namespace SaleWinApp
{
    partial class frmDetailOrder
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
            btnCancel = new Button();
            btnSave = new Button();
            txtOrderID = new TextBox();
            lbQuantity = new Label();
            lbUnitPrice = new Label();
            lbProductID = new Label();
            lbOrderID = new Label();
            lbDiscount = new Label();
            txtQuantity = new TextBox();
            txtDiscount = new TextBox();
            cboProduct = new ComboBox();
            SuspendLayout();
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(297, 257);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(337, 31);
            txtUnitPrice.TabIndex = 99;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(490, 512);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 42);
            btnCancel.TabIndex = 97;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(219, 512);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 42);
            btnSave.TabIndex = 96;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(297, 130);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(337, 31);
            txtOrderID.TabIndex = 95;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(144, 325);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(80, 25);
            lbQuantity.TabIndex = 94;
            lbQuantity.Text = "Quantity";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(144, 262);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(86, 25);
            lbUnitPrice.TabIndex = 93;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(144, 200);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(97, 25);
            lbProductID.TabIndex = 92;
            lbProductID.Text = "Product ID";
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(144, 135);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(81, 25);
            lbOrderID.TabIndex = 90;
            lbOrderID.Text = "Order ID";
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Location = new Point(144, 395);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new Size(82, 25);
            lbDiscount.TabIndex = 91;
            lbDiscount.Text = "Discount";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(297, 320);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(337, 31);
            txtQuantity.TabIndex = 102;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(297, 390);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(337, 31);
            txtDiscount.TabIndex = 103;
            // 
            // cboProduct
            // 
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(297, 197);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(340, 33);
            cboProduct.TabIndex = 104;
            // 
            // frmDetailOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 660);
            Controls.Add(cboProduct);
            Controls.Add(txtDiscount);
            Controls.Add(txtQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtOrderID);
            Controls.Add(lbQuantity);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbProductID);
            Controls.Add(lbDiscount);
            Controls.Add(lbOrderID);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmDetailOrder";
            Text = "Detail Order";
            Load += frmDetailOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUnitPrice;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtOrderID;
        private Label lbQuantity;
        private Label lbUnitPrice;
        private Label lbProductID;
        private Label lbOrderID;
        private Label lbDiscount;
        private TextBox txtQuantity;
        private TextBox txtDiscount;
        private ComboBox cboProduct;
    }
}