using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;

        private static readonly object instanceLock = new object();
        
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Order> getOrders()
        {
            var orders = new List<Order>();

            try
            {
                using var context = new Ass02Context();
                orders = context.Orders.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public Order GetOrderByID(int orderID)
        {
            Order orders = null;
            try
            {
                using var context = new Ass02Context();
                orders = context.Orders.SingleOrDefault(p => p.OrderId == orderID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public void addNew(Order order)
        {
            try
            {
                Order _order = GetOrderByID(order.OrderId);
                if (_order == null)
                {
                    using var context = new Ass02Context();
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
                else throw new Exception("The order is already exist!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Order order)
        {
            try
            {
                Order _order = GetOrderByID(order.OrderId);
                if (_order != null)
                {
                    using var context = new Ass02Context();
                    context.Orders.Update(order);
                    context.SaveChanges();
                }
                else throw new Exception("The order does not already exist!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int orderID)
        {
            try
            {
                Order order = GetOrderByID(orderID);
                var detail = OrderDetailDAO.Instance.getOrderDetailsByOrderID(orderID);
                if (order != null)
                {
                    using var context = new Ass02Context();
                    context.Orders.Remove(order);
                    foreach (var item in detail)
                    {
                        context.Remove(item);
                    }
                    context.SaveChanges();
                }
                else throw new Exception("The order does not already exist!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<Order> getOrdersByMemberID(int memberID)
        {
            List<Order> orders = null;
            try
            {
                using (var context = new Ass02Context())
                {
                    orders = context.Orders.Where(p => p.MemberId == memberID).ToList();
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

