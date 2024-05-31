using BusinessObject;
using DataAcess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SaleWinApp
{
    public partial class frmOrderDetails : Form
    {
        public int OrderId { get; set; }

        public IOrderRepository OrderRepository { get; set; }

        public bool InsertOrUpdate { get; set; } // false is insert, true is update

        public Order OrderInfo { get; set; }

        public frmOrderDetails(int orderId, bool insertOrUpdate, IOrderRepository orderRepository)
        {
            InitializeComponent();
            this.OrderId = orderId;
            this.InsertOrUpdate = insertOrUpdate;
            this.OrderRepository = orderRepository;

        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            txtOrderID.Enabled = !InsertOrUpdate;

            if (InsertOrUpdate)
            {
                OrderInfo = OrderRepository.GetOrderByID(OrderId);
                DateTime orderDate = OrderInfo.OrderDate ?? DateTime.MinValue;
                DateTime requiredDate = OrderInfo.RequiredDate ?? DateTime.MinValue;
                DateTime shippedDate = OrderInfo.ShippedDate ?? DateTime.MinValue;
                TimeSpan daysDifference1 = requiredDate - orderDate;
                TimeSpan daysDifference2 = shippedDate - orderDate;
                int requiredDate1 = (int)daysDifference1.TotalDays;
                int shippedDate1 = (int)daysDifference2.TotalDays;

                if (OrderInfo != null)
                {
                    txtOrderID.Text = OrderInfo.OrderId.ToString();
                    txtMemberId.Text = OrderInfo.MemberId.ToString();
                    txtOrderDate.Text = orderDate.ToString("yyyy-MM-dd HH:mm:ss");
                    cboRequiredDate.Text = requiredDate1.ToString();
                    cboShippedDate.Text = shippedDate1.ToString();
                    txtFreight.Text = OrderInfo.Freight.ToString();
                }

            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Order orderInfo = OrderRepository.GetOrderByID(OrderId);
                if (orderInfo != null)
                {
                    var order = new Order
                    {
                        OrderId = orderInfo.OrderId,
                        MemberId = int.Parse(txtMemberId.Text),
                        OrderDate = DateTime.Now,
                        RequiredDate = DateTime.Now.AddDays(int.Parse(cboRequiredDate.Text)),
                        ShippedDate = DateTime.Now.AddDays(int.Parse(cboShippedDate.Text)),
                        Freight = decimal.Parse(txtFreight.Text)
                    };
                    if (MemberDAO.Instance.GetMemberByID(int.Parse(txtMemberId.Text)) != null)
                    {
                        OrderRepository.updateOrder(order);
                        MessageBox.Show("Sửa order thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại member");

                    }

                }
                else
                {
                    var order = new Order
                    {
                        MemberId = int.Parse(txtMemberId.Text),
                        OrderDate = DateTime.Now,
                        RequiredDate = DateTime.Now.AddDays(int.Parse(cboRequiredDate.Text)),
                        ShippedDate = DateTime.Now.AddDays(int.Parse(cboShippedDate.Text)),
                        Freight = decimal.Parse(txtFreight.Text)
                    };
                    if (MemberDAO.Instance.GetMemberByID(int.Parse(txtMemberId.Text)) != null)
                    {
                        OrderRepository.InsertOrder(order);
                        MessageBox.Show("Thêm order thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại member");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new order" : "Update a member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
