using BusinessObject;
using DataAcess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmAdminHome : Form
    {
        private int memberId;
        BindingSource source;

        IMemberRepository memberRepository = new MemberRepository();
        public frmAdminHome(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
            var listCountry = memberRepository.getMemberList().Select(x => x.Country).Distinct().ToList();
            cboFilter.Items.Add("All");
            foreach (var country in listCountry)
            {
                cboFilter.Items.Add(country);
            }
            cboFilter.SelectedIndexChanged += cboFilter_SelectedIndexChanged_1;

        }




        private Form currentFormChild;
        private void openChildForm(Form childForm, Boolean topLevel)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = topLevel;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void frmAdminHome_Load(object sender, EventArgs e)
        {
            loadMemberList();
        }

        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPassword.Text = string.Empty;

        }

        public Member getMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    Country = txtCountry.Text,
                    City = txtCity.Text,
                    Password = txtPassword.Text

                };
                return member;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Car");
            }

            return null;

        }

        private void ClearDataBindings()
        {
            txtMemberID.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCompanyName.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
        }

        public void loadMemberList()
        {

            var members = memberRepository.getMemberList();
            try
            {
                source = new BindingSource();

                if (memberRepository.GetMemberByID(memberId).Email == MemberDAO.Instance.getAdminAccount().Email)
                {
                    ClearDataBindings();
                    if (txtSearch.Text.Length > 0)
                    {
                        var listNew = members.Where(x => x.Email.Contains(txtSearch.Text)).ToList();
                        source.DataSource = listNew;
                    }
                    else
                    {
                        source.DataSource = members;
                    }
                    btnAdd.Visible = true;

                }
                else
                {
                    ClearDataBindings();
                    var members1 = memberRepository.GetMemberByID(memberId);
                    source.DataSource = members1;

                    if (members.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Visible = false;
                        btnUpdate.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Visible = false;
                        btnUpdate.Enabled = true;
                        btnAdd.Visible = false;
                    }
                }
                txtMemberID.DataBindings.Add("Text", source, "MemberId");
                txtMemberID.ReadOnly = true;
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtCity.DataBindings.Add("Text", source, "City");
                txtPassword.DataBindings.Add("Text", source, "Password");
                dgvListMember.DataSource = null;
                dgvListMember.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            memberRepository.updateMember(getMemberObject());
        }

        private void manageProduct_Click(object sender, EventArgs e)
        {
            if (memberRepository.GetMemberByID(memberId).Email == MemberDAO.Instance.getAdminAccount().Email)
            {
                openChildForm(new frmProductManagement(), false);
            }
            else
            {
                MessageBox.Show("Only admins can use this feature!");
            }

        }

        private void manageMember_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmOrderManage(memberId), false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Add member",
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                loadMemberList();

                //set focus car inserted
                source.Position = source.Count - 1;
            }
            else
            {
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = getMemberObject();
                memberRepository.deleteMember(member.MemberId);
                loadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMemberLogin frmMemberLogin = new frmMemberLogin();
            this.Hide();
            frmMemberLogin.ShowDialog();
        }

        private void cboFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (memberRepository.GetMemberByID(memberId).Email == MemberDAO.Instance.getAdminAccount().Email)
            {
                source = new BindingSource();
                var list = memberRepository.getMemberList();

                if (cboFilter.SelectedItem != null && cboFilter.SelectedItem.ToString() == "All")
                {
                    source.DataSource = list;
                }
                else if (cboFilter.SelectedItem != null)
                {
                    source.DataSource = list.Where(x => x.Country == cboFilter.SelectedItem.ToString()).ToList();
                }
                ClearDataBindings();
                txtMemberID.DataBindings.Add("Text", source, "MemberId");
                txtMemberID.ReadOnly = true;
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtCity.DataBindings.Add("Text", source, "City");
                txtPassword.DataBindings.Add("Text", source, "Password");
                dgvListMember.DataSource = source;
            }
            else
            {
                cboFilter.Visible = false;
            }


        }

        private void dgvListMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}