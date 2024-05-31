using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void deleteOrder(int id)
        {
            OrderDAO.Instance.Remove(id);
        }

        public Order GetOrderByID(int id)
        {
            return OrderDAO.Instance.GetOrderByID(id);
        }

        public IEnumerable<Order> getOrderList()
        {
            return OrderDAO.Instance.getOrders();
        }

        public void InsertOrder(Order order)
        {
            OrderDAO.Instance.addNew(order);
        }

        public void updateOrder(Order order)
        {
            OrderDAO.Instance.Update(order);
        }
    }
}
