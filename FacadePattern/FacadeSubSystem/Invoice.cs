using FacadePattern.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.FacadeSubSystem
{
    public class Invoice
    {
        public void CreateInvoice(List<Product> products)
        {
            Console.WriteLine("Invoice");
            foreach (Product product in products)
            {
                Console.WriteLine(string.Format("Product {0}, {1}", product.Id, product.Price));
            }
        }
    }
}
