using Dependency_Injection_Code.Entity;
using Dependency_Injection_Code.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection_Code.Services
{
    public class ProductService : IProducts
    {
        private List<Product> prdList = new List<Product>()
        {
            new Product{Id=1,Name="Product 1",Description="Product 1 Description",Price=1000},
            new Product{Id=2,Name="Product 2",Description="Product 2 Description",Price=1002}
        };

        public Product Detail(int id)
        {
            return prdList.Where(i => i.Id == id).FirstOrDefault();
        }

        public IEnumerable<Product> List()
        {
           return prdList;
        }
    }
}
