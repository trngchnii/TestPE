using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary.Models;

namespace TestLibrary.Data_Access.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void RemoveProduct(Product product) => ProductDAO.Instance.RemoveProduct(product);

        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProducts();

        public void InsertProduct(Product product) => ProductDAO.Instance.AddProduct(product);

        public void UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);
    }
}
