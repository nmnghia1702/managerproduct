using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;

        private static readonly object instanceLock = new object();

        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<OrderDetail> getOrderDetails()
        {
            var orders = new List<OrderDetail>();

            try
            {
                using var context = new Ass02Context();
                orders = context.OrderDetails.ToList();
                orders.ForEach(o =>
                {
                    o.UnitPrice = ProductDAO.Instance.GetProductByID(o.ProductId).UnitPrice;
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public void addNewOrderDetail(OrderDetail order)
        {
            try
            {
                using var context = new Ass02Context();
                context.OrderDetails.Add(order);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(OrderDetail order)
        {
            try
            {
                using var context = new Ass02Context();
                context.OrderDetails.Update(order);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int orderID, int productId)
        {
            try
            {
                OrderDetail product = GetOrderDetailByOrderIdAndProductId(orderID, productId);
                if (product != null)
                {
                    using var context = new Ass02Context();
                    context.OrderDetails.Remove(product);
                    context.SaveChanges();
                }
                else throw new Exception("The OrderDetail does not already exist!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public OrderDetail GetOrderDetailByOrderIdAndProductId(int orderId, int productId)
        {
            OrderDetail orderDetail = null;
            try
            {
                using (var context = new Ass02Context())
                {
                    orderDetail = context.OrderDetails.SingleOrDefault(p => p.OrderId == orderId && p.ProductId == productId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin đơn hàng: " + ex.Message);
            }
            return orderDetail;
        }
        public IEnumerable<OrderDetail> GetOrderDetailByProductId( int productId)
        {
            var orderDetail = new List<OrderDetail>();
            try
            {
                using (var context = new Ass02Context())
                {
                    orderDetail = context.OrderDetails.Where(p => p.ProductId == productId).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin đơn hàng: " + ex.Message);
            }
            return orderDetail;
        }


        public List<OrderDetail> getOrderDetailsByOrderID(int orderID)
        {
            List<OrderDetail> orders = null;
            try
            {
                using (var context = new Ass02Context())
                {
                    orders = context.OrderDetails.Where(p => p.OrderId == orderID).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }


    }
}

