using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary.Models;

namespace TestLibrary.Data_Access
{
    public class CategoryDAO
    {
        LuyenOnThiDbContext context = new LuyenOnThiDbContext();
        private static CategoryDAO instance;
        private static readonly Object instancelock = new Object();
        private CategoryDAO() { }
        public static CategoryDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }

        //public void AddCategory(Category category)
        //{
        //    context.Products.Add(category);
        //    context.SaveChanges();
        //}
        //public void UpdateCategory(Category category)
        //{
        //    Product p = context.Products.FirstOrDefault(x => x.ProductId == product.ProductId);
        //    if (p != null)
        //    {
        //        p.ProductId = product.ProductId;
        //        p.ProductName = product.ProductName;
        //        p.UnitPrice = product.UnitPrice;
        //        context.SaveChanges();
        //    }
        //}
        //public void RemoveProduct(Product product)
        //{
        //    Product product1 = context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
        //    context.Products.Remove(product1);
        //    context.SaveChanges();
        //}
    }
}
