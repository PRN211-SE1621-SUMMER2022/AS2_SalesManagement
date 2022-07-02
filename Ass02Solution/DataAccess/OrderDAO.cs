using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO : BaseDAO<Order>, IOrderRepository
    {
        private static readonly object instanceLock = new object();
        public static OrderDAO instance = null;
        private OrderDAO() { }
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
                }
                return instance;
            }
        }
        public void DeleteOrder(Order order) => base.DeleteEntity(order);

        public Order GetOrderByID(int orderID) => base.GetEntityById(orderID);

        public IEnumerable<Order> GetAllOrder() => base.GetAllEntity();

        public void InsertOrder(Order order) => base.SaveEntity(order);

        public void UpdateOrder(Order order) => base.UpdateEntity(order);
    }
}
