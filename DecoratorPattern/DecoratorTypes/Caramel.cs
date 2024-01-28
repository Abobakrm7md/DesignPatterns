using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.DecoratorTypes
{
    public class Caramel : AddonDecorator
    {
        public Caramel(Beverage bevarage) : base(bevarage)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + "with Caramel ";
        }
        public override int GetCost()
        {
            return base.Cost() + 10;
        }
    }
}
