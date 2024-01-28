using DecoratorPattern.Component;

namespace DecoratorPattern.ComponentTypes
{
    internal class Espresso : Beverage
    {
        public override string GetDescription()
        {
            return base.GetDescription() + "Espresso ";
        }
        public override int GetCost()
        {
            return 6;
        }
    }
}
