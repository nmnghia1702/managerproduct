using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void deleteOrderDetails(int oid, int pid)
        {
            OrderDetailDAO.Instance.Remove(oid, pid);
        }

        public OrderDetail GetOrderDetailByOrderIdAndProductId(int oid, int pid)
        {
            return OrderDetailDAO.Instance.GetOrderDetailByOrderIdAndProductId(oid, pid);
        }

        public IEnumerable<OrderDetail> getOrderDetailsList()
        {
            return OrderDetailDAO.Instance.getOrderDetails();
        }

        public void InsertOrderDetails(OrderDetail orderDetail)
        {
            OrderDetailDAO.Instance.addNewOrderDetail(orderDetail);
        }

        public void updateOrderDetails(OrderDetail orderDetail)
        {
            OrderDetailDAO.Instance.Update(orderDetail);
        }
    }
}
