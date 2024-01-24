using AbstractFactoryPattern.FactoryInterface;
using AbstractFactoryPattern.SubSystem;
using AbstractFactoryPattern.SubSystemInterface;

namespace AbstractFactoryPattern.Factories
{
    public class AbstractFactory1 : IFactory
    {
        public IBackground CreateBackground()
        {
            return new BlackBackground();
        }

        IColor IFactory.CreateColor()
        {
            return new WhiteColor();
        }
    }
}
