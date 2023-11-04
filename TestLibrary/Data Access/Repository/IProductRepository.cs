using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary.Models;

namespace TestLibrary.Data_Access.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void RemoveProduct(Product product);
    }
}
