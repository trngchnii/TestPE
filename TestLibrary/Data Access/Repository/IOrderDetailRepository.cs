using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary.Models;

namespace TestLibrary.Data_Access.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetOrderDetails(int ProductID);
        void Insert(OrderDetail orderDetail);
        void Update(OrderDetail orderDetail);
        void Remove(OrderDetail orderDetail);
    }
}
