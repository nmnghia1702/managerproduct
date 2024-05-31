using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> getOrderDetailsList();

        OrderDetail GetOrderDetailByOrderIdAndProductId(int orderid, int productid);
        void InsertOrderDetails(OrderDetail orderDetail);
        void updateOrderDetails(OrderDetail orderDetail);
        void deleteOrderDetails(int oid, int pid);
    }
}
