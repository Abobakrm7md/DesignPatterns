using FactoryMethodPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class Motorcycle : IVehicle
    {
        public string Drive()
        {
            return "I'm drive a motorcycle";
        }
    }
}
