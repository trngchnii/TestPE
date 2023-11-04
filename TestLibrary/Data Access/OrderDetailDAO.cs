using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary.Models;

namespace TestLibrary.Data_Access
{
    public class OrderDetailDAO
    {
        LuyenOnThiDbContext context = new LuyenOnThiDbContext();
        private static OrderDetailDAO instance;
        private static readonly Object instancelock = new Object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        public List<OrderDetail> GetOrderDetails(int idProduct)
        {
            return context.OrderDetails.Where(x => x.ProductId == idProduct).ToList();
        }

        public void AddNew(OrderDetail orderDetail)
        {
            context.OrderDetails.Add(orderDetail);
            context.SaveChanges();
        }
        public void Update(OrderDetail orderDetail)
        {
            OrderDetail mo = context.OrderDetails.FirstOrDefault(x => x.ProductId == orderDetail.ProductId);
            if (mo != null)
            {
                mo.ProductId = orderDetail.ProductId;
                mo.UnitPrice = orderDetail.UnitPrice;
                context.SaveChanges();
            }
        }
        public void Remove(OrderDetail orderDetail)
        {
            OrderDetail mo1 = context.OrderDetails.FirstOrDefault(x => x.ProductId == orderDetail.ProductId);
            context.OrderDetails.Remove(mo1);
            context.SaveChanges();
        }
        
    }
}
