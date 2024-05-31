namespace SaleWinApp
{
    partial class frmMemberLogin
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
            lbTitle = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            btnLogin = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.None;
            lbTitle.AutoSize = true;
            lbTitle.BackColor = Color.SlateGray;
            lbTitle.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(179, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Padding = new Padding(24, 15, 24, 15);
            lbTitle.Size = new Size(160, 52);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Login Form";
            // 
            // lbEmail
            // 
            lbEmail.Anchor = AnchorStyles.None;
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(40, 97);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(39, 14);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.Anchor = AnchorStyles.None;
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(40, 148);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(66, 14);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.ForestGreen;
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.ImageAlign = ContentAlignment.BottomRight;
            btnLogin.Location = new Point(132, 208);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 35);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(151, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(225, 21);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(151, 141);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(225, 21);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.ImageAlign = ContentAlignment.BottomRight;
            btnClose.Location = new Point(289, 208);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(87, 35);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmMemberLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(507, 297);
            Controls.Add(btnClose);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnLogin);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbTitle);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmMemberLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbEmail;
        private Label lbPassword;
        private Button btnLogin;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnClose;
    }
}
