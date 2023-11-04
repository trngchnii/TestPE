using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary.Models;

namespace TestLibrary.Data_Access.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrderDetails(int ProductID) => OrderDetailDAO.Instance.GetOrderDetails(ProductID);

        public void Insert(OrderDetail orderDetail) => OrderDetailDAO.Instance.AddNew(orderDetail);

        public void Remove(OrderDetail orderDetail) => OrderDetailDAO.Instance.Remove(orderDetail);

        public void Update(OrderDetail orderDetail) => OrderDetailDAO.Instance.Update(orderDetail);
    }
}
