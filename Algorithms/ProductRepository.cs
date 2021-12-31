using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class ProductRepository
    {
        List<Product> products = new List<Product>()
 {
 new Product("woda żywiec 0.5L", 1.00m, DateTime.Parse("10-05-2022")),
 new Product("woda Nałęczowianka 1L", 2.00m, DateTime.Parse("18-01-2022")),
 new Product("bułka pszenna 50g", 0.20m, DateTime.Parse("20-09-2021")),
 new Product("chleb krojony 600g", 2.45m, null)
 };
        public IEnumerable<Product> FindProducts(string name)
        {
            return products.Where(product => product.Name == name);
        }
    }
}
