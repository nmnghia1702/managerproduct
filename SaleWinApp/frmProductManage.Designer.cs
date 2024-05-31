namespace SaleWinApp
{
    partial class frmProductManagement
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
            components = new System.ComponentModel.Container();
            toolStrip = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            memberToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolTip = new ToolTip(components);
            statusStrip = new StatusStrip();
            grbDetailMember = new GroupBox();
            txtProductID = new TextBox();
            lbProduct = new Label();
            cboCategory = new ComboBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtUnitsInStock = new TextBox();
            txtUnitPrice = new TextBox();
            txtWeight = new TextBox();
            txtProductName = new TextBox();
            lbUnitInStock = new Label();
            lbUnitPrice = new Label();
            lbWeight = new Label();
            lbCategory = new Label();
            lbProductName = new Label();
            dgvListProduct = new DataGridView();
            lbProductManagement = new Label();
            panel_Body = new Panel();
            cboCateogoryID = new ComboBox();
            comboBox1 = new ComboBox();
            toolStrip.SuspendLayout();
            grbDetailMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).BeginInit();
            panel_Body.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip
            // 
            toolStrip.BackColor = Color.DarkSlateGray;
            toolStrip.Dock = DockStyle.None;
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator2 });
            toolStrip.Location = new Point(-171, -62);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new Padding(2, 2, 2, 2);
            toolStrip.Size = new Size(151, 49);
            toolStrip.TabIndex = 12;
            toolStrip.Text = "ToolStrip";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.BackColor = Color.LightPink;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { memberToolStripMenuItem, orderToolStripMenuItem, productToolStripMenuItem });
            toolStripDropDownButton1.Font = new Font("Bauhaus 93", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripDropDownButton1.ForeColor = SystemColors.ControlLightLight;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Padding = new Padding(5);
            toolStripDropDownButton1.Size = new Size(129, 42);
            toolStripDropDownButton1.Text = "Manage ";
            // 
            // memberToolStripMenuItem
            // 
            memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            memberToolStripMenuItem.Size = new Size(184, 32);
            memberToolStripMenuItem.Text = "Member";
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(184, 32);
            orderToolStripMenuItem.Text = "Order";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(184, 32);
            productToolStripMenuItem.Text = "Product";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 45);
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Location = new Point(0, 822);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 18, 0);
            statusStrip.Size = new Size(1765, 22);
            statusStrip.TabIndex = 13;
            statusStrip.Text = "StatusStrip";
            // 
            // grbDetailMember
            // 
            grbDetailMember.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grbDetailMember.AutoSize = true;
            grbDetailMember.BackColor = SystemColors.HighlightText;
            grbDetailMember.Controls.Add(txtProductID);
            grbDetailMember.Controls.Add(lbProduct);
            grbDetailMember.Controls.Add(cboCategory);
            grbDetailMember.Controls.Add(btnUpdate);
            grbDetailMember.Controls.Add(btnDelete);
            grbDetailMember.Controls.Add(btnAdd);
            grbDetailMember.Controls.Add(txtUnitsInStock);
            grbDetailMember.Controls.Add(txtUnitPrice);
            grbDetailMember.Controls.Add(txtWeight);
            grbDetailMember.Controls.Add(txtProductName);
            grbDetailMember.Controls.Add(lbUnitInStock);
            grbDetailMember.Controls.Add(lbUnitPrice);
            grbDetailMember.Controls.Add(lbWeight);
            grbDetailMember.Controls.Add(lbCategory);
            grbDetailMember.Controls.Add(lbProductName);
            grbDetailMember.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbDetailMember.Location = new Point(1621, 194);
            grbDetailMember.Margin = new Padding(3, 4, 3, 4);
            grbDetailMember.Name = "grbDetailMember";
            grbDetailMember.Padding = new Padding(3, 4, 3, 4);
            grbDetailMember.Size = new Size(378, 572);
            grbDetailMember.TabIndex = 7;
            grbDetailMember.TabStop = false;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(162, 14);
            txtProductID.Margin = new Padding(3, 4, 3, 4);
            txtProductID.Multiline = true;
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(181, 30);
            txtProductID.TabIndex = 17;
            // 
            // lbProduct
            // 
            lbProduct.AutoSize = true;
            lbProduct.Location = new Point(7, 26);
            lbProduct.Name = "lbProduct";
            lbProduct.Size = new Size(82, 20);
            lbProduct.TabIndex = 16;
            lbProduct.Text = "Product ID";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "1", "2", "3" });
            cboCategory.Location = new Point(162, 138);
            cboCategory.Margin = new Padding(3, 4, 3, 4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(181, 28);
            cboCategory.TabIndex = 15;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(286, 414);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(65, 40);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdateProduct_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(150, 414);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 40);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(8, 414);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 40);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(162, 320);
            txtUnitsInStock.Margin = new Padding(3, 4, 3, 4);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(181, 27);
            txtUnitsInStock.TabIndex = 10;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(162, 262);
            txtUnitPrice.Margin = new Padding(3, 4, 3, 4);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(181, 27);
            txtUnitPrice.TabIndex = 9;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(162, 198);
            txtWeight.Margin = new Padding(3, 4, 3, 4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(181, 27);
            txtWeight.TabIndex = 8;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(162, 70);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(181, 27);
            txtProductName.TabIndex = 6;
            // 
            // lbUnitInStock
            // 
            lbUnitInStock.AutoSize = true;
            lbUnitInStock.Location = new Point(3, 330);
            lbUnitInStock.Name = "lbUnitInStock";
            lbUnitInStock.Size = new Size(102, 20);
            lbUnitInStock.TabIndex = 4;
            lbUnitInStock.Text = "Units In Stock";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(7, 272);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(76, 20);
            lbUnitPrice.TabIndex = 3;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(8, 210);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(58, 20);
            lbWeight.TabIndex = 2;
            lbWeight.Text = "Weight";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new Point(7, 148);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(72, 20);
            lbCategory.TabIndex = 1;
            lbCategory.Text = "Category";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(3, 80);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(108, 20);
            lbProductName.TabIndex = 0;
            lbProductName.Text = "Product Name";
            // 
            // dgvListProduct
            // 
            dgvListProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListProduct.BackgroundColor = SystemColors.ControlLightLight;
            dgvListProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListProduct.GridColor = SystemColors.Control;
            dgvListProduct.Location = new Point(189, 194);
            dgvListProduct.Margin = new Padding(3, 4, 3, 4);
            dgvListProduct.Name = "dgvListProduct";
            dgvListProduct.RowHeadersWidth = 62;
            dgvListProduct.RowTemplate.Height = 25;
            dgvListProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListProduct.Size = new Size(1350, 572);
            dgvListProduct.TabIndex = 6;
            // 
            // lbProductManagement
            // 
            lbProductManagement.AutoSize = true;
            lbProductManagement.BackColor = Color.SeaGreen;
            lbProductManagement.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbProductManagement.ForeColor = SystemColors.ControlLightLight;
            lbProductManagement.Location = new Point(693, 58);
            lbProductManagement.Name = "lbProductManagement";
            lbProductManagement.Size = new Size(280, 30);
            lbProductManagement.TabIndex = 9;
            lbProductManagement.Text = "Product Mamagement";
            // 
            // panel_Body
            // 
            panel_Body.AutoSize = true;
            panel_Body.BackColor = SystemColors.ActiveCaption;
            panel_Body.BorderStyle = BorderStyle.Fixed3D;
            panel_Body.Controls.Add(cboCateogoryID);
            panel_Body.Controls.Add(comboBox1);
            panel_Body.Controls.Add(lbProductManagement);
            panel_Body.Controls.Add(dgvListProduct);
            panel_Body.Controls.Add(grbDetailMember);
            panel_Body.Location = new Point(-182, 0);
            panel_Body.Margin = new Padding(3, 4, 3, 4);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(2060, 800);
            panel_Body.TabIndex = 14;
            panel_Body.Paint += panel_Body_Paint;
            // 
            // cboCateogoryID
            // 
            cboCateogoryID.FormattingEnabled = true;
            cboCateogoryID.Location = new Point(193, 154);
            cboCateogoryID.Margin = new Padding(3, 4, 3, 4);
            cboCateogoryID.Name = "cboCateogoryID";
            cboCateogoryID.Size = new Size(179, 28);
            cboCateogoryID.TabIndex = 12;
            cboCateogoryID.SelectedIndexChanged += cboCateogoryID_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 0);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 11;
            // 
            // frmProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1765, 844);
            Controls.Add(panel_Body);
            Controls.Add(toolStrip);
            Controls.Add(statusStrip);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProductManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Management";
            Load += frmProductManagement_Load;
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            grbDetailMember.ResumeLayout(false);
            grbDetailMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).EndInit();
            panel_Body.ResumeLayout(false);
            panel_Body.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbMemberMamagement;
        private TextBox txtEmail;
        private Label lbEmail;
        private Label lbMemberID;
        private Button btnLogout;
        private ToolStrip toolStrip;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolTip toolTip;
        private StatusStrip statusStrip;
        private Label lbProductID;
        private GroupBox grbDetailMember;
        private ComboBox cboCategory;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtUnitsInStock;
        private TextBox txtUnitPrice;
        private TextBox txtWeight;
        private TextBox txtProductName;
        private Label lbUnitInStock;
        private Label lbUnitPrice;
        private Label lbWeight;
        private Label lbCategory;
        private Label lbProductName;
        private DataGridView dgvListProduct;
        private Label lbProductManagement;
        private Panel panel_Body;
        private Label lbProduct;
        private TextBox txtProductID;
        private ComboBox cboCateogoryID;
        private ComboBox comboBox1;
    }
}