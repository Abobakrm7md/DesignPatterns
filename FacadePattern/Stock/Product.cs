using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Stock
{
    public class Product
    {
        public Product(int id, decimal price)
        {
            this.Id = id;
            this.Price = price;
        }
        public int Id { get; set; }
        public decimal Price { get; set; }
    }
}
