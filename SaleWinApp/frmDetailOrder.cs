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
    public partial class frmDetailOrder : Form
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public IOrderDetailRepository OrderDetailRepository { get; set; }

        public bool InsertOrUpdate { get; set; } // false is insert, true is update

        public OrderDetail OrderDetailInfo { get; set; }

        public frmDetailOrder(int orderId,int productId, bool InsertOrUpdate, IOrderDetailRepository OrderDetailRepository)
        {

            InitializeComponent();
            this.OrderId = orderId;
            this.ProductId = productId; 
            this.InsertOrUpdate = InsertOrUpdate;
            this.OrderDetailRepository = OrderDetailRepository;
            var list = ProductDAO.Instance.getProducts().Select(x=>x.ProductId).Distinct().ToList();
            cboProduct.DataSource = list;
        }

        private void frmDetailOrder_Load(object sender, EventArgs e)
        {

            if (InsertOrUpdate)
            {
                OrderDetailInfo = OrderDetailDAO.Instance.GetOrderDetailByOrderIdAndProductId(OrderId, ProductId);
                if (OrderDetailInfo != null)
                {
                    var product = ProductDAO.Instance.GetProductByID((int)OrderDetailInfo.ProductId);
                    if (product != null)
                    {
                        txtOrderID.Text = OrderDetailInfo.OrderId.ToString();
                        cboProduct.Text = OrderDetailInfo.ProductId.ToString();
                        txtUnitPrice.Text = product.UnitPrice.ToString();
                        txtQuantity.Text = OrderDetailInfo.Quantity.ToString();
                        txtDiscount.Text = OrderDetailInfo.Discount.ToString();
                    }

                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!int.TryParse(txtOrderID.Text, out int orderId) ||
                    !int.TryParse(cboProduct.Text, out int productId) ||
                    !int.TryParse(txtQuantity.Text, out int quantity) ||
                    !double.TryParse(txtDiscount.Text, out double discount))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho các trường dữ liệu!");
                    return;
                }

                
                OrderDetail existingOrderDetail = OrderDetailDAO.Instance.GetOrderDetailByOrderIdAndProductId(orderId, productId);
                Order orders = OrderDAO.Instance.GetOrderByID(orderId);

                if (existingOrderDetail == null)
                {
                    var product = ProductDAO.Instance.GetProductByID(productId);

                    if (product != null)
                    {
                        var orderDetail = new OrderDetail
                        {
                            OrderId = orderId,
                            ProductId = productId,
                            UnitPrice = product.UnitPrice,
                            Quantity = quantity,
                            Discount = discount,
                        };

                        OrderDetailRepository.InsertOrderDetails(orderDetail);
                        MessageBox.Show("Thêm order detail thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại sản phẩm");
                    }
                }
                else
                {
                    var product = ProductDAO.Instance.GetProductByID(productId);

                    if (product != null)
                    {
                        var orderDetail = new OrderDetail
                        {
                            OrderId = orderId,
                            ProductId = productId,
                            UnitPrice = product.UnitPrice,
                            Quantity = quantity,
                            Discount = discount,
                        };

                        OrderDetailRepository.updateOrderDetails(orderDetail);
                        MessageBox.Show("Sửa order detail thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại sản phẩm");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm order detail: " + ex.Message);
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
