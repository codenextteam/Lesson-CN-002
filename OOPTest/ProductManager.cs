using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine($"id: {product.Id} {product.ProductName} elave olundu");
        }

    }
}
