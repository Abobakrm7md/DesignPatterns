using FactoryMethodPattern.ConcreteProduct;
using FactoryMethodPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Factory
{
    public class CarCreator : IVehicleCreator
    {
        public IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
