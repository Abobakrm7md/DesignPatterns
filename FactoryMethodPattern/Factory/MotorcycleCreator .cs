using FactoryMethodPattern.ConcreteProduct;
using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Factory
{
    public class MotorcycleCreator : IVehicleCreator
    {
        public IVehicle CreateVehicle()
        {
            return new Motorcycle();
        }
    }
}
