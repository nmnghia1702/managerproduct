namespace SaleWinApp
{
    partial class frmAdminHome
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
            statusStrip = new StatusStrip();
            toolTip = new ToolTip(components);
            btnLogout = new Button();
            dgvListMember = new DataGridView();
            grbDetailMember = new GroupBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtCompanyName = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtMemberID = new TextBox();
            lbCountry = new Label();
            lbCity = new Label();
            lbCompanyName = new Label();
            lbPassword = new Label();
            lbEmail = new Label();
            lbMemberID = new Label();
            lbMemberMamagement = new Label();
            panel_Body = new Panel();
            cboFilter = new ComboBox();
            txtSearch = new TextBox();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListMember).BeginInit();
            grbDetailMember.SuspendLayout();
            panel_Body.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip
            // 
            toolStrip.BackColor = Color.DarkSlateGray;
            toolStrip.Dock = DockStyle.None;
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator2 });
            toolStrip.Location = new Point(9, 9);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new Padding(2, 2, 2, 2);
            toolStrip.Size = new Size(128, 42);
            toolStrip.TabIndex = 1;
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
            toolStripDropDownButton1.Size = new Size(107, 35);
            toolStripDropDownButton1.Text = "Manage ";
            // 
            // memberToolStripMenuItem
            // 
            memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            memberToolStripMenuItem.Size = new Size(149, 26);
            memberToolStripMenuItem.Text = "Member";
            memberToolStripMenuItem.Click += manageMember_Click;
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(149, 26);
            orderToolStripMenuItem.Text = "Order";
            orderToolStripMenuItem.Click += orderToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(149, 26);
            productToolStripMenuItem.Text = "Product";
            productToolStripMenuItem.Click += manageProduct_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 38);
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Location = new Point(0, 615);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1644, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(1486, 19);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(80, 32);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvListMember
            // 
            dgvListMember.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListMember.BackgroundColor = SystemColors.ControlLightLight;
            dgvListMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListMember.GridColor = SystemColors.Control;
            dgvListMember.Location = new Point(10, 84);
            dgvListMember.Name = "dgvListMember";
            dgvListMember.RowHeadersWidth = 62;
            dgvListMember.RowTemplate.Height = 25;
            dgvListMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListMember.Size = new Size(1193, 487);
            dgvListMember.TabIndex = 6;
            dgvListMember.CellContentClick += dgvListMember_CellContentClick;
            // 
            // grbDetailMember
            // 
            grbDetailMember.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grbDetailMember.AutoSize = true;
            grbDetailMember.BackColor = SystemColors.HighlightText;
            grbDetailMember.Controls.Add(btnUpdate);
            grbDetailMember.Controls.Add(btnDelete);
            grbDetailMember.Controls.Add(btnAdd);
            grbDetailMember.Controls.Add(txtCountry);
            grbDetailMember.Controls.Add(txtCity);
            grbDetailMember.Controls.Add(txtCompanyName);
            grbDetailMember.Controls.Add(txtPassword);
            grbDetailMember.Controls.Add(txtEmail);
            grbDetailMember.Controls.Add(txtMemberID);
            grbDetailMember.Controls.Add(lbCountry);
            grbDetailMember.Controls.Add(lbCity);
            grbDetailMember.Controls.Add(lbCompanyName);
            grbDetailMember.Controls.Add(lbPassword);
            grbDetailMember.Controls.Add(lbEmail);
            grbDetailMember.Controls.Add(lbMemberID);
            grbDetailMember.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbDetailMember.Location = new Point(1225, 84);
            grbDetailMember.Name = "grbDetailMember";
            grbDetailMember.Size = new Size(406, 487);
            grbDetailMember.TabIndex = 7;
            grbDetailMember.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(250, 310);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(57, 30);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(131, 310);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(57, 30);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(7, 310);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(57, 30);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(142, 257);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(159, 23);
            txtCountry.TabIndex = 11;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(142, 204);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(159, 23);
            txtCity.TabIndex = 10;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(142, 153);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(159, 23);
            txtCompanyName.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(142, 103);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(159, 23);
            txtPassword.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(142, 60);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(159, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(142, 22);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.ReadOnly = true;
            txtMemberID.Size = new Size(159, 23);
            txtMemberID.TabIndex = 6;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(7, 265);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(49, 15);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(7, 212);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(27, 15);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(7, 161);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(93, 15);
            lbCompanyName.TabIndex = 3;
            lbCompanyName.Text = "Company Name";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(7, 111);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(6, 68);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(7, 30);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(68, 15);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // lbMemberMamagement
            // 
            lbMemberMamagement.AutoSize = true;
            lbMemberMamagement.BackColor = Color.SeaGreen;
            lbMemberMamagement.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbMemberMamagement.ForeColor = SystemColors.ControlLightLight;
            lbMemberMamagement.Location = new Point(451, 35);
            lbMemberMamagement.Name = "lbMemberMamagement";
            lbMemberMamagement.Size = new Size(218, 24);
            lbMemberMamagement.TabIndex = 9;
            lbMemberMamagement.Text = "Member Mamagement";
            // 
            // panel_Body
            // 
            panel_Body.AutoSize = true;
            panel_Body.BackColor = SystemColors.ActiveCaption;
            panel_Body.BorderStyle = BorderStyle.Fixed3D;
            panel_Body.Controls.Add(cboFilter);
            panel_Body.Controls.Add(txtSearch);
            panel_Body.Controls.Add(lbMemberMamagement);
            panel_Body.Controls.Add(dgvListMember);
            panel_Body.Controls.Add(grbDetailMember);
            panel_Body.Location = new Point(0, 54);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1644, 617);
            panel_Body.TabIndex = 11;
            // 
            // cboFilter
            // 
            cboFilter.FormattingEnabled = true;
            cboFilter.Location = new Point(10, 54);
            cboFilter.Margin = new Padding(2, 2, 2, 2);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(129, 23);
            cboFilter.TabIndex = 11;
            cboFilter.SelectedIndexChanged += cboFilter_SelectedIndexChanged_1;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(1019, 55);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by email";
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.Size = new Size(184, 23);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += frmAdminHome_Load;
            // 
            // frmAdminHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1644, 637);
            Controls.Add(panel_Body);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(btnLogout);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAdminHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager System";
            TransparencyKey = Color.LightGray;
            Load += frmAdminHome_Load;
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListMember).EndInit();
            grbDetailMember.ResumeLayout(false);
            grbDetailMember.PerformLayout();
            panel_Body.ResumeLayout(false);
            panel_Body.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private Button btnLogout;
        private DataGridView dgvListMember;
        private GroupBox grbDetailMember;
        private Label lbCountry;
        private Label lbCity;
        private Label lbCompanyName;
        private Label lbPassword;
        private Label lbEmail;
        private Label lbMemberID;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtCompanyName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtMemberID;
        private Label lbMemberMamagement;
        private Panel panel_Body;
        private TextBox txtSearch;
        private ComboBox cboFilter;
    }
}



