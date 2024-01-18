using FactoryMethodPattern.ConcreteProduct;
using FactoryMethodPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Factory
{
    public class VehicleCreator2 : IVehicleCreator2
    {
        public IVehicle CreateVehicle(string type)
        {
            switch (type)
            {
                case "c":
                    return new Car();
                case "m":
                    return new Motorcycle();
                default: throw new NullReferenceException();
            }
        }
    }
}
