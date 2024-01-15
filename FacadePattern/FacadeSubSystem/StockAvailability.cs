using FacadePattern.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.FacadeSubSystem
{
    public class StockAvailability
    {
        public List<Product> CheckAvailablityAndGetProducts(List<int> ids)
        {
            return StockData.Products.Where(x => ids.Contains(x.Id)).ToList();
        }
    }
}
