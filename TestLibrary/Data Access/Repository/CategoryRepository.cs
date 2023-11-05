using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary.Models;

namespace TestLibrary.Data_Access.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetCategories() => CategoryDAO.Instance.GetCategories();
    }
}
