using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> getOrderList();

        Order GetOrderByID(int id);
        void InsertOrder(Order product);
        void updateOrder(Order product);
        void deleteOrder(int id);
    }
}
