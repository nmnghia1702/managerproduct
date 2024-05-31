namespace SaleWinApp
{
    partial class frmOrderDetails
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
            txtFreight = new TextBox();
            txtOrderDate = new TextBox();
            lbFreight = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtOrderID = new TextBox();
            lbRequiredDate = new Label();
            lbOrderDate = new Label();
            lbMemberID = new Label();
            lbShippedDate = new Label();
            lbOrderID = new Label();
            cboRequiredDate = new ComboBox();
            cboShippedDate = new ComboBox();
            txtMemberId = new TextBox();
            SuspendLayout();
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(309, 463);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(337, 31);
            txtFreight.TabIndex = 85;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(309, 268);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.ReadOnly = true;
            txtOrderDate.Size = new Size(337, 31);
            txtOrderDate.TabIndex = 83;
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new Point(156, 468);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new Size(67, 25);
            lbFreight.TabIndex = 82;
            lbFreight.Text = "Freight";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(501, 573);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 42);
            btnCancel.TabIndex = 81;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(236, 573);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 42);
            btnSave.TabIndex = 80;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(309, 142);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.ReadOnly = true;
            txtOrderID.Size = new Size(337, 31);
            txtOrderID.TabIndex = 79;
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new Point(156, 337);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new Size(124, 25);
            lbRequiredDate.TabIndex = 78;
            lbRequiredDate.Text = "Required Date";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(156, 273);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(100, 25);
            lbOrderDate.TabIndex = 77;
            lbOrderDate.Text = "Order Date";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(156, 212);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(102, 25);
            lbMemberID.TabIndex = 76;
            lbMemberID.Text = "Member ID";
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(156, 407);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(120, 25);
            lbShippedDate.TabIndex = 75;
            lbShippedDate.Text = "Shipped Date";
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(156, 147);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(81, 25);
            lbOrderID.TabIndex = 74;
            lbOrderID.Text = "Order ID";
            // 
            // cboRequiredDate
            // 
            cboRequiredDate.FormattingEnabled = true;
            cboRequiredDate.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            cboRequiredDate.Location = new Point(309, 332);
            cboRequiredDate.Margin = new Padding(4, 5, 4, 5);
            cboRequiredDate.Name = "cboRequiredDate";
            cboRequiredDate.Size = new Size(337, 33);
            cboRequiredDate.TabIndex = 88;
            // 
            // cboShippedDate
            // 
            cboShippedDate.FormattingEnabled = true;
            cboShippedDate.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            cboShippedDate.Location = new Point(309, 402);
            cboShippedDate.Margin = new Padding(4, 5, 4, 5);
            cboShippedDate.Name = "cboShippedDate";
            cboShippedDate.Size = new Size(337, 33);
            cboShippedDate.TabIndex = 89;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(309, 207);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(337, 31);
            txtMemberId.TabIndex = 87;
            // 
            // frmOrderDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 750);
            Controls.Add(cboShippedDate);
            Controls.Add(cboRequiredDate);
            Controls.Add(txtMemberId);
            Controls.Add(txtFreight);
            Controls.Add(txtOrderDate);
            Controls.Add(lbFreight);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtOrderID);
            Controls.Add(lbRequiredDate);
            Controls.Add(lbOrderDate);
            Controls.Add(lbMemberID);
            Controls.Add(lbShippedDate);
            Controls.Add(lbOrderID);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmOrderDetails";
            Text = "Order details";
            Load += frmOrderDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFreight;
        private TextBox txtOrderDate;
        private Label lbFreight;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtOrderID;
        private Label lbRequiredDate;
        private Label lbOrderDate;
        private Label lbMemberID;
        private Label lbShippedDate;
        private Label lbOrderID;
        private ComboBox cboRequiredDate;
        private ComboBox cboShippedDate;
        private TextBox txtMemberId;
    }
}