namespace SaleWinApp
{
    partial class frmMemberDetails
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
            txtCompanyName = new TextBox();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lbCountry = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtMemberID = new TextBox();
            lbCity = new Label();
            lbPassword = new Label();
            lbEmail = new Label();
            lbCompanyName = new Label();
            lbMemberID = new Label();
            SuspendLayout();
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(231, 333);
            txtCompanyName.Margin = new Padding(2, 3, 2, 3);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(270, 27);
            txtCompanyName.TabIndex = 58;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(231, 383);
            txtCountry.Margin = new Padding(2, 3, 2, 3);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(270, 27);
            txtCountry.TabIndex = 57;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(231, 277);
            txtCity.Margin = new Padding(2, 3, 2, 3);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(270, 27);
            txtCity.TabIndex = 56;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(231, 227);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 27);
            txtPassword.TabIndex = 55;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(231, 177);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(270, 27);
            txtEmail.TabIndex = 54;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(109, 387);
            lbCountry.Margin = new Padding(2, 0, 2, 0);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 53;
            lbCountry.Text = "Country";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(384, 443);
            btnCancel.Margin = new Padding(2, 3, 2, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(91, 33);
            btnCancel.TabIndex = 52;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(178, 443);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 33);
            btnSave.TabIndex = 51;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(231, 125);
            txtMemberID.Margin = new Padding(2, 3, 2, 3);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.ReadOnly = true;
            txtMemberID.Size = new Size(270, 27);
            txtMemberID.TabIndex = 50;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(109, 281);
            lbCity.Margin = new Padding(2, 0, 2, 0);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 49;
            lbCity.Text = "City";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(109, 231);
            lbPassword.Margin = new Padding(2, 0, 2, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 48;
            lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(109, 181);
            lbEmail.Margin = new Padding(2, 0, 2, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 47;
            lbEmail.Text = "Email";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(109, 337);
            lbCompanyName.Margin = new Padding(2, 0, 2, 0);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(116, 20);
            lbCompanyName.TabIndex = 46;
            lbCompanyName.Text = "Company Name";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(109, 129);
            lbMemberID.Margin = new Padding(2, 0, 2, 0);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(84, 20);
            lbMemberID.TabIndex = 45;
            lbMemberID.Text = "Member ID";
            // 
            // frmMemberDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 551);
            Controls.Add(txtCompanyName);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbCountry);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtMemberID);
            Controls.Add(lbCity);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbCompanyName);
            Controls.Add(lbMemberID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMemberDetails";
            Text = "Member Detail";
            Load += frmMemberDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCompanyName;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lbCountry;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtMemberID;
        private Label lbCity;
        private Label lbPassword;
        private Label lbEmail;
        private Label lbCompanyName;
        private Label lbMemberID;
    }
}