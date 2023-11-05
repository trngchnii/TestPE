using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary.Models;

namespace TestLibrary.Data_Access
{
    public class ProductDAO
    {
        LuyenOnThiDbContext context = new LuyenOnThiDbContext();
        private static ProductDAO instance;
        private static readonly Object instancelock = new Object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Product> GetProducts()
        {
            return context.Products.Include(x=> x.Category).ToList();
        }

        public Product GetProductByID(int pid)
        {
            return context.Products.Include(x=>x.OrderDetails).FirstOrDefault(x => x.ProductId == pid);
        }

        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            Product p = context.Products.FirstOrDefault(x => x.ProductId == product.ProductId);
            if (p != null)
            {
                p.ProductId = product.ProductId;
                p.ProductName = product.ProductName;
                p.UnitPrice = product.UnitPrice;
                context.SaveChanges();
            }
        }
        public void RemoveProduct(int productid)
        {
            Product product1 = GetProductByID(productid);
            if(product1 != null)
            {
                context.OrderDetails.RemoveRange(product1.OrderDetails);
                context.Products.Remove(product1);
                context.SaveChanges();
            }

        }

    }
}
