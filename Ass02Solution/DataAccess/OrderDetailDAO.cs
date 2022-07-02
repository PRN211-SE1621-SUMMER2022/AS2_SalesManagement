using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO : BaseDAO<OrderDetail>, IOrderDetailRepository
    {
        private static readonly object instanceLock = new object();
        public static OrderDetailDAO instance = null;
        private OrderDetailDAO() { }
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
                }
                return instance;
            }
        }
        public void DeleteOrderDetail(OrderDetail orderDetail) => base.DeleteEntity(orderDetail);

        public IEnumerable<OrderDetail> GetAllOrderDetail() => base.GetAllEntity();

        public OrderDetail GetOrderDetailByID(int orderID, int productID)
        {
            throw new NotImplementedException();
        }

        public void InsertOrderDetail(OrderDetail orderDetail) => base.SaveEntity(orderDetail);

        public void UpdateOrderDetail(OrderDetail orderDetail) => base.UpdateEntity(orderDetail);
    }
}
