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
    public partial class frmOrderManage : Form
    {
        private int memberId;
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository detailRepository = new OrderDetailRepository();
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source1;
        BindingSource source2;
        public frmOrderManage(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;


        }

        private void frmOrderManage_Load(object sender, EventArgs e)
        {
            loadOrderList();
            loadOrderDetailsList();
        }


        public void loadOrderList()
        {
            var orders = orderRepository.getOrderList();
            try
            {
                source1 = new BindingSource();

                if (memberRepository.GetMemberByID(memberId).Email == MemberDAO.Instance.getAdminAccount().Email)
                {
                    if (txtSearchOrder.Text.Length > 0)
                    {
                        var orderSearch = orders.Where(x => x.OrderId == int.Parse(txtSearchOrder.Text) || x.MemberId == int.Parse(txtSearchOrder.Text));
                        source1.DataSource = orderSearch;
                    }
                    else
                    {
                        source1.DataSource = orders;
                    }


                    btnDeleteOrder.Visible = true;
                    btnDeleteOrder.Enabled = true;
                    btnAddOrder.Visible = true;
                }


                else
                {
                    var orders2 = OrderDAO.Instance.getOrdersByMemberID(memberId);
                    if (txtSearchOrder.Text.Length > 0)
                    {
                        var orderSearch = orders2.Where(x => x.OrderId == int.Parse(txtSearchOrder.Text) || x.MemberId == int.Parse(txtSearchOrder.Text));
                        source1.DataSource = orderSearch;
                    }
                    else
                    {
                        source1.DataSource = orders2;
                    }
                    source1 = new BindingSource();
                    source1.DataSource = orders2;




                    btnDeleteOrder.Visible = false;
                    btnUpdateOrder.Visible = false;
                    btnAddOrder.Visible = false;
                }
                dgvListOrder.DataSource = null;
                dgvListOrder.DataSource = source1;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order list");
            }
        }

        public void loadOrderDetailsList()
        {
            var orders1 = detailRepository.getOrderDetailsList();
            source2 = new BindingSource();
            try
            {


                if (memberRepository.GetMemberByID(memberId).Email == MemberDAO.Instance.getAdminAccount().Email)
                {

                    if (txtSearchOrderDetail.Text.Length > 0)
                    {
                        var orderDetailList = OrderDetailDAO.Instance.getOrderDetails().Where(x => x.OrderId == int.Parse(txtSearchOrderDetail.Text)).ToList();
                        source2.DataSource = orderDetailList;
                    }
                    else
                    {
                        source2.DataSource = orders1;
                    }



                    btnDeleteOrderDetails.Visible = true;
                    btnUpdateOrderDetails.Visible = true;
                    btnAddOrderDetails.Visible = true;
                }


                else
                {


                    var orders2 = OrderDAO.Instance.getOrdersByMemberID(memberId);
                    List<OrderDetail> allOrderDetails = new List<OrderDetail>();
                    foreach (Order order in orders2)
                    {
                        var orderDetails = OrderDetailDAO.Instance.getOrderDetailsByOrderID(order.OrderId);
                        allOrderDetails.AddRange(orderDetails);
                    }
                    if (txtSearchOrderDetail.Text.Length > 0)
                    {
                        var orderDetailList = allOrderDetails.Where(x => x.OrderId == int.Parse(txtSearchOrderDetail.Text)).ToList();
                        source2.DataSource = orderDetailList;
                    }
                    else
                    {
                        source2.DataSource = allOrderDetails;
                    }

                    btnDeleteOrderDetails.Visible = false;
                    btnUpdateOrderDetails.Visible = false;
                    btnAddOrderDetails.Visible = false;
                }
                dgvListOrderDetails.DataSource = null;
                dgvListOrderDetails.DataSource = source2;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order detail list");
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            frmOrderDetails frmOrderDetails = new frmOrderDetails(0, false, orderRepository);
            frmOrderDetails.Text = "Add order";
            if (frmOrderDetails.ShowDialog() == DialogResult.OK)
            {
                loadOrderList();

                //set focus car inserted
                source1.Position = source1.Count - 1;
            }
            else
            {
                this.Hide();
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (dgvListOrder.SelectedRows.Count > 0)
            {
                // Lấy hàng đầu tiên được chọn
                DataGridViewRow selectedRow = dgvListOrder.SelectedRows[0];

                // Lấy giá trị của ô có tên cột là "OrderId"
                int orderId = Convert.ToInt32(selectedRow.Cells["OrderId"].Value);
                frmOrderDetails frmOrderDetails = new frmOrderDetails(orderId, true, orderRepository);
                frmOrderDetails.Text = "Update order";
                if (frmOrderDetails.ShowDialog() == DialogResult.OK)
                {
                    loadOrderList();

                    //set focus car inserted
                    source1.Position = source1.Count - 1;
                }
                else
                {
                    this.Hide();
                }
            }
        }

        private void btnAddOrderDetail_Click(object sender, EventArgs e)
        {
            frmDetailOrder frmDetailOrders = new frmDetailOrder(0, 0, false, detailRepository);
            frmDetailOrders.Text = "Add order detail";
            if (frmDetailOrders.ShowDialog() == DialogResult.OK)
            {
                loadOrderDetailsList();

                //set focus car inserted
                source2.Position = source2.Count - 1;
            }
            else
            {
                this.Hide();
            }
        }

        private void btnUpdateOrderDetail_Click(object sender, EventArgs e)
        {
            if (dgvListOrder.SelectedRows.Count > 0)
            {
                // Lấy hàng đầu tiên được chọn
                DataGridViewRow selectedRow = dgvListOrderDetails.SelectedRows[0];

                // Lấy giá trị của ô có tên cột là "OrderId"
                int orderId = Convert.ToInt32(selectedRow.Cells["OrderId"].Value);
                int productId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);
                frmDetailOrder frmOrderDetails = new frmDetailOrder(orderId, productId, true, detailRepository);
                frmOrderDetails.Text = "Update order detail";
                if (frmOrderDetails.ShowDialog() == DialogResult.OK)
                {
                    loadOrderDetailsList();
                }
                else
                {
                    this.Hide();
                }
            }
        }

        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            if (dgvListOrderDetails.SelectedRows.Count > 0)
            {
                // Lấy hàng đầu tiên được chọn
                DataGridViewRow selectedRow = dgvListOrderDetails.SelectedRows[0];

                // Lấy giá trị của ô có tên cột là "OrderId"
                int orderId = Convert.ToInt32(selectedRow.Cells["OrderId"].Value);
                int productId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);
                detailRepository.deleteOrderDetails(orderId, productId);
                loadOrderDetailsList();
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dgvListOrder.SelectedRows.Count > 0)
            {
                // Lấy hàng đầu tiên được chọn
                DataGridViewRow selectedRow = dgvListOrder.SelectedRows[0];

                // Lấy giá trị của ô có tên cột là "OrderId"
                int orderId = Convert.ToInt32(selectedRow.Cells["OrderId"].Value);
                orderRepository.deleteOrder(orderId);
                loadOrderList();
            }
        }

        private void btnFilterOrderDetail_Click(object sender, EventArgs e)
        {
            dgvListOrderDetails.DataSource = null;

            var orders1 = detailRepository.getOrderDetailsList();
            source2 = new BindingSource();
            try
            {


                if (memberRepository.GetMemberByID(memberId).Email == MemberDAO.Instance.getAdminAccount().Email)
                {

                    decimal unitPriceFrom = decimal.Parse(txtUnitPriceFrom.Text);
                    decimal unitPriceTo = decimal.Parse(txtUnitPriceTo.Text);
                    if (unitPriceFrom > 0 && unitPriceFrom < unitPriceTo)
                    {
                        var listOrderDetailFilter = orders1.Where(x => x.UnitPrice > unitPriceFrom && x.UnitPrice < unitPriceTo).ToList();
                        source2.DataSource = listOrderDetailFilter;
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                        source2.DataSource = null;
                    }


                    btnDeleteOrderDetails.Visible = true;
                    btnUpdateOrderDetails.Visible = true;
                    btnAddOrderDetails.Visible = true;
                }


                else
                {


                    var orders2 = OrderDAO.Instance.getOrdersByMemberID(memberId);
                    List<OrderDetail> allOrderDetails = new List<OrderDetail>();
                    foreach (Order order in orders2)
                    {
                        var orderDetails = OrderDetailDAO.Instance.getOrderDetailsByOrderID(order.OrderId);
                        allOrderDetails.AddRange(orderDetails);
                    }
                    decimal unitPriceFrom = decimal.Parse(txtUnitPriceFrom.Text);
                    decimal unitPriceTo = decimal.Parse(txtUnitPriceTo.Text);
                    if (unitPriceFrom > 0 && unitPriceFrom < unitPriceTo)
                    {
                        var listOrderDetailFilter = allOrderDetails.Where(x => x.UnitPrice > unitPriceFrom && x.UnitPrice < unitPriceTo).ToList();
                        source2.DataSource = listOrderDetailFilter;
                    }
                    else
                    {
                        source2.DataSource = null;
                    }

                    btnDeleteOrderDetails.Visible = false;
                    btnUpdateOrderDetails.Visible = false;
                    btnAddOrderDetails.Visible = false;
                }
                dgvListOrderDetails.DataSource = null;
                dgvListOrderDetails.DataSource = source2;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order detail list");
            }

        }

        private void btnFilterOrder_Click(object sender, EventArgs e)
        {
            dgvListOrder.DataSource = null;

            var orders = orderRepository.getOrderList();
            try
            {
                source1 = new BindingSource();

                if (memberRepository.GetMemberByID(memberId).Email == MemberDAO.Instance.getAdminAccount().Email)
                {
                    DateTime from = dtStartDate.Value.Date;
                    DateTime to = dtEndDate.Value.Date;
                    if (from <= to)
                    {
                        var listOrderFilter = orders.Where(x => x.OrderDate >= from && x.OrderDate <= to).ToList();
                        source1.DataSource = listOrderFilter;
                    }
                    else
                    {
                        source1.DataSource = null;
                    }

                    btnDeleteOrder.Visible = true;
                    btnDeleteOrder.Enabled = true;
                    btnAddOrder.Visible = true;
                }


                else
                {
                    var orders2 = OrderDAO.Instance.getOrdersByMemberID(memberId);
                    DateTime from = dtStartDate.Value.Date;
                    DateTime to = dtEndDate.Value.Date;
                    if (from <= to)
                    {
                        var listOrderFilter = orders2.Where(x => x.OrderDate >= from && x.OrderDate <= to).ToList();
                        source1.DataSource = listOrderFilter;
                    }
                    else
                    {
                        source1.DataSource = null;
                    }

                    btnDeleteOrder.Visible = false;
                    btnUpdateOrder.Visible = false;
                    btnAddOrder.Visible = false;
                }
                dgvListOrder.DataSource = null;
                dgvListOrder.DataSource = source1;
            }
            // x.OrderDate.Value.Date

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order list");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmOrderManage_Load(sender, e);
        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    /*DateTime dateTime = DateTime.Now;
    string ngayThangNam = dateTime.ToString("dd/MM/yyyy");
    Console.WriteLine(ngayThangNam); // In ra: 21/03/2024*/

}
