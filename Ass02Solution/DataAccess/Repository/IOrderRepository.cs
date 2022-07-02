using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrder();
        Order GetOrderByID(int orderID);
        void InsertOrder(Order order);
        void DeleteOrder(Order order);
        void UpdateOrder(Order order);

    }
}
