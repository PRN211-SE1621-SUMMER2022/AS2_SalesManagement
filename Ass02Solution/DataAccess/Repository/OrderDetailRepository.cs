using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void DeleteOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.DeleteOrderDetail(orderDetail);

        public IEnumerable<OrderDetail> GetAllOrderDetail() => OrderDetailDAO.Instance.GetAllOrderDetail();

        public OrderDetail GetOrderDetailByID(int orderID, int productID)
        {
            throw new NotImplementedException();
        }

        public void InsertOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.InsertOrderDetail(orderDetail);

        public void UpdateOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.UpdateOrderDetail(orderDetail);
    }
}
