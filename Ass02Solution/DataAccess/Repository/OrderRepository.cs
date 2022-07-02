using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOrder(Order order) => OrderDAO.Instance.DeleteOrder(order);

        public IEnumerable<Order> GetAllOrder() => OrderDAO.Instance.GetAllOrder();

        public Order GetOrderByID(int orderID) => OrderDAO.Instance.GetOrderByID(orderID);

        public void InsertOrder(Order order) => OrderDAO.Instance.InsertOrder(order);

        public void UpdateOrder(Order order) => OrderDAO.Instance.UpdateOrder(order);
    }
}
