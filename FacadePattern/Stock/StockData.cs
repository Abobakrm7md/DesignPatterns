using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Stock
{
    public class StockData
    {
        public static List<Product> Products = new List<Product>
        {
            new Product(1, 10),
            new Product(2, 11),
            new Product(3, 12),
            new Product(4, 13),
            new Product(5, 14),
            new Product(6, 15),
        };
    }
}
