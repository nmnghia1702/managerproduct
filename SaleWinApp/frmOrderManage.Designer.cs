namespace SaleWinApp
{
    partial class frmOrderManage
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
            panel_Body = new Panel();
            btnRefresh = new Button();
            button1 = new Button();
            btnFilterOrder = new Button();
            btnFilter = new Button();
            txtUnitPriceTo = new TextBox();
            textBox3 = new TextBox();
            txtUnitPriceFrom = new TextBox();
            textBox1 = new TextBox();
            dtEndDate = new DateTimePicker();
            dtStartDate = new DateTimePicker();
            txtSearchOrderDetail = new TextBox();
            txtSearchOrder = new TextBox();
            lbOrderDetailManage = new Label();
            lbOrderManage = new Label();
            btnDeleteOrderDetails = new Button();
            btnUpdateOrderDetails = new Button();
            btnAddOrderDetails = new Button();
            btnDeleteOrder = new Button();
            btnUpdateOrder = new Button();
            btnAddOrder = new Button();
            dgvListOrderDetails = new DataGridView();
            lbOrderManagement = new Label();
            dgvListOrder = new DataGridView();
            panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListOrder).BeginInit();
            SuspendLayout();
            // 
            // panel_Body
            // 
            panel_Body.AutoSize = true;
            panel_Body.BackColor = SystemColors.ActiveCaption;
            panel_Body.BorderStyle = BorderStyle.Fixed3D;
            panel_Body.Controls.Add(btnRefresh);
            panel_Body.Controls.Add(button1);
            panel_Body.Controls.Add(btnFilterOrder);
            panel_Body.Controls.Add(btnFilter);
            panel_Body.Controls.Add(txtUnitPriceTo);
            panel_Body.Controls.Add(textBox3);
            panel_Body.Controls.Add(txtUnitPriceFrom);
            panel_Body.Controls.Add(textBox1);
            panel_Body.Controls.Add(dtEndDate);
            panel_Body.Controls.Add(dtStartDate);
            panel_Body.Controls.Add(txtSearchOrderDetail);
            panel_Body.Controls.Add(txtSearchOrder);
            panel_Body.Controls.Add(lbOrderDetailManage);
            panel_Body.Controls.Add(lbOrderManage);
            panel_Body.Controls.Add(btnDeleteOrderDetails);
            panel_Body.Controls.Add(btnUpdateOrderDetails);
            panel_Body.Controls.Add(btnAddOrderDetails);
            panel_Body.Controls.Add(btnDeleteOrder);
            panel_Body.Controls.Add(btnUpdateOrder);
            panel_Body.Controls.Add(btnAddOrder);
            panel_Body.Controls.Add(dgvListOrderDetails);
            panel_Body.Controls.Add(lbOrderManagement);
            panel_Body.Controls.Add(dgvListOrder);
            panel_Body.Location = new Point(-94, 1);
            panel_Body.Margin = new Padding(3, 4, 3, 4);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1972, 933);
            panel_Body.TabIndex = 15;
            panel_Body.Paint += panel_Body_Paint;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(963, 769);
            btnRefresh.Margin = new Padding(2, 3, 2, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(69, 35);
            btnRefresh.TabIndex = 32;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(89, 27);
            button1.TabIndex = 31;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnFilterOrder
            // 
            btnFilterOrder.Location = new Point(551, 116);
            btnFilterOrder.Margin = new Padding(3, 4, 3, 4);
            btnFilterOrder.Name = "btnFilterOrder";
            btnFilterOrder.Size = new Size(72, 31);
            btnFilterOrder.TabIndex = 30;
            btnFilterOrder.Text = "Filter";
            btnFilterOrder.UseVisualStyleBackColor = true;
            btnFilterOrder.Click += btnFilterOrder_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(1310, 116);
            btnFilter.Margin = new Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(72, 31);
            btnFilter.TabIndex = 29;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilterOrderDetail_Click;
            // 
            // txtUnitPriceTo
            // 
            txtUnitPriceTo.Location = new Point(1231, 116);
            txtUnitPriceTo.Margin = new Padding(3, 4, 3, 4);
            txtUnitPriceTo.Name = "txtUnitPriceTo";
            txtUnitPriceTo.Size = new Size(71, 27);
            txtUnitPriceTo.TabIndex = 28;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1200, 116);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "To";
            textBox3.Size = new Size(23, 27);
            textBox3.TabIndex = 27;
            // 
            // txtUnitPriceFrom
            // 
            txtUnitPriceFrom.Location = new Point(1121, 116);
            txtUnitPriceFrom.Margin = new Padding(3, 4, 3, 4);
            txtUnitPriceFrom.Name = "txtUnitPriceFrom";
            txtUnitPriceFrom.Size = new Size(71, 27);
            txtUnitPriceFrom.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(355, 116);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "To";
            textBox1.Size = new Size(23, 27);
            textBox1.TabIndex = 25;
            // 
            // dtEndDate
            // 
            dtEndDate.Location = new Point(386, 116);
            dtEndDate.Margin = new Padding(3, 4, 3, 4);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(157, 27);
            dtEndDate.TabIndex = 24;
            // 
            // dtStartDate
            // 
            dtStartDate.Location = new Point(191, 116);
            dtStartDate.Margin = new Padding(3, 4, 3, 4);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(157, 27);
            dtStartDate.TabIndex = 23;
            // 
            // txtSearchOrderDetail
            // 
            txtSearchOrderDetail.Location = new Point(1666, 116);
            txtSearchOrderDetail.Margin = new Padding(3, 4, 3, 4);
            txtSearchOrderDetail.Name = "txtSearchOrderDetail";
            txtSearchOrderDetail.PlaceholderText = "Search by orderDetailID";
            txtSearchOrderDetail.Size = new Size(203, 27);
            txtSearchOrderDetail.TabIndex = 21;
            txtSearchOrderDetail.TextChanged += frmOrderManage_Load;
            // 
            // txtSearchOrder
            // 
            txtSearchOrder.Location = new Point(736, 116);
            txtSearchOrder.Margin = new Padding(3, 4, 3, 4);
            txtSearchOrder.Name = "txtSearchOrder";
            txtSearchOrder.PlaceholderText = "Search by memberID or orderID";
            txtSearchOrder.Size = new Size(203, 27);
            txtSearchOrder.TabIndex = 19;
            txtSearchOrder.TextChanged += frmOrderManage_Load;
            // 
            // lbOrderDetailManage
            // 
            lbOrderDetailManage.AutoSize = true;
            lbOrderDetailManage.BackColor = Color.DarkBlue;
            lbOrderDetailManage.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbOrderDetailManage.ForeColor = SystemColors.ControlLightLight;
            lbOrderDetailManage.Location = new Point(1411, 27);
            lbOrderDetailManage.Name = "lbOrderDetailManage";
            lbOrderDetailManage.Size = new Size(175, 30);
            lbOrderDetailManage.TabIndex = 18;
            lbOrderDetailManage.Text = "Order Details";
            // 
            // lbOrderManage
            // 
            lbOrderManage.AutoSize = true;
            lbOrderManage.BackColor = Color.DarkBlue;
            lbOrderManage.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbOrderManage.ForeColor = SystemColors.ControlLightLight;
            lbOrderManage.Location = new Point(511, 27);
            lbOrderManage.Name = "lbOrderManage";
            lbOrderManage.Size = new Size(82, 30);
            lbOrderManage.TabIndex = 17;
            lbOrderManage.Text = "Order";
            // 
            // btnDeleteOrderDetails
            // 
            btnDeleteOrderDetails.Location = new Point(1720, 763);
            btnDeleteOrderDetails.Margin = new Padding(3, 4, 3, 4);
            btnDeleteOrderDetails.Name = "btnDeleteOrderDetails";
            btnDeleteOrderDetails.Size = new Size(103, 40);
            btnDeleteOrderDetails.TabIndex = 16;
            btnDeleteOrderDetails.Text = "Delete";
            btnDeleteOrderDetails.UseVisualStyleBackColor = true;
            btnDeleteOrderDetails.Click += btnDeleteOrderDetail_Click;
            // 
            // btnUpdateOrderDetails
            // 
            btnUpdateOrderDetails.Location = new Point(1463, 763);
            btnUpdateOrderDetails.Margin = new Padding(3, 4, 3, 4);
            btnUpdateOrderDetails.Name = "btnUpdateOrderDetails";
            btnUpdateOrderDetails.Size = new Size(103, 40);
            btnUpdateOrderDetails.TabIndex = 15;
            btnUpdateOrderDetails.Text = "Update";
            btnUpdateOrderDetails.UseVisualStyleBackColor = true;
            btnUpdateOrderDetails.Click += btnUpdateOrderDetail_Click;
            // 
            // btnAddOrderDetails
            // 
            btnAddOrderDetails.Location = new Point(1181, 763);
            btnAddOrderDetails.Margin = new Padding(3, 4, 3, 4);
            btnAddOrderDetails.Name = "btnAddOrderDetails";
            btnAddOrderDetails.Size = new Size(103, 40);
            btnAddOrderDetails.TabIndex = 14;
            btnAddOrderDetails.Text = "Add";
            btnAddOrderDetails.UseVisualStyleBackColor = true;
            btnAddOrderDetails.Click += btnAddOrderDetail_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(775, 763);
            btnDeleteOrder.Margin = new Padding(3, 4, 3, 4);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(103, 40);
            btnDeleteOrder.TabIndex = 13;
            btnDeleteOrder.Text = "Delete";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // btnUpdateOrder
            // 
            btnUpdateOrder.Location = new Point(511, 763);
            btnUpdateOrder.Margin = new Padding(3, 4, 3, 4);
            btnUpdateOrder.Name = "btnUpdateOrder";
            btnUpdateOrder.Size = new Size(103, 40);
            btnUpdateOrder.TabIndex = 12;
            btnUpdateOrder.Text = "Update";
            btnUpdateOrder.UseVisualStyleBackColor = true;
            btnUpdateOrder.Click += btnUpdateOrder_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(237, 763);
            btnAddOrder.Margin = new Padding(3, 4, 3, 4);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(103, 40);
            btnAddOrder.TabIndex = 11;
            btnAddOrder.Text = "Add";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // dgvListOrderDetails
            // 
            dgvListOrderDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListOrderDetails.BackgroundColor = SystemColors.ControlLightLight;
            dgvListOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListOrderDetails.GridColor = SystemColors.Control;
            dgvListOrderDetails.Location = new Point(1121, 155);
            dgvListOrderDetails.Margin = new Padding(3, 4, 3, 4);
            dgvListOrderDetails.Name = "dgvListOrderDetails";
            dgvListOrderDetails.RowHeadersWidth = 62;
            dgvListOrderDetails.RowTemplate.Height = 25;
            dgvListOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListOrderDetails.Size = new Size(749, 579);
            dgvListOrderDetails.TabIndex = 10;
            // 
            // lbOrderManagement
            // 
            lbOrderManagement.AutoSize = true;
            lbOrderManagement.BackColor = Color.SeaGreen;
            lbOrderManagement.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbOrderManagement.ForeColor = SystemColors.ControlLightLight;
            lbOrderManagement.Location = new Point(906, 27);
            lbOrderManagement.Name = "lbOrderManagement";
            lbOrderManagement.Size = new Size(255, 30);
            lbOrderManagement.TabIndex = 9;
            lbOrderManagement.Text = "Order Mamagement";
            // 
            // dgvListOrder
            // 
            dgvListOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListOrder.BackgroundColor = SystemColors.ControlLightLight;
            dgvListOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListOrder.GridColor = SystemColors.Control;
            dgvListOrder.Location = new Point(191, 155);
            dgvListOrder.Margin = new Padding(3, 4, 3, 4);
            dgvListOrder.Name = "dgvListOrder";
            dgvListOrder.RowHeadersWidth = 62;
            dgvListOrder.RowTemplate.Height = 25;
            dgvListOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListOrder.Size = new Size(749, 579);
            dgvListOrder.TabIndex = 6;
            // 
            // frmOrderManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1879, 849);
            Controls.Add(panel_Body);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmOrderManage";
            Text = "Order Management";
            Load += frmOrderManage_Load;
            panel_Body.ResumeLayout(false);
            panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Body;
        private Label lbOrderManagement;
        private DataGridView dgvListOrder;
        private DataGridView dgvListOrderDetails;
        private Button btnAddOrder;
        private Label lbOrderManage;
        private Button btnDeleteOrderDetails;
        private Button btnUpdateOrderDetails;
        private Button btnAddOrderDetails;
        private Button btnDeleteOrder;
        private Button btnUpdateOrder;
        private Label lbOrderDetailManage;
        private TextBox txtSearchOrder;
        private TextBox txtSearchOrderDetail;
        private TextBox textBox1;
        private DateTimePicker dtEndDate;
        private DateTimePicker dtStartDate;
        private TextBox txtUnitPriceFrom;
        private TextBox textBox3;
        private TextBox txtUnitPriceTo;
        private Button btnFilter;
        private Button btnFilterOrder;
        private Button btnRefresh;
        private Button button1;
    }
}