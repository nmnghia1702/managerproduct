using BusinessObject;
using DataAcess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmMemberDetails : Form
    {

        public IMemberRepository MemberRepository { get; set; }

        public bool InsertOrUpdate { get; set; } // false is insert, true is update

        public Member MemberInfo { get; set; }

        public frmMemberDetails()
        {
            InitializeComponent();
            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member
                {
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text,
                };
                MemberRepository.InsertMember(member);
                MessageBox.Show("Thêm thành công");
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
