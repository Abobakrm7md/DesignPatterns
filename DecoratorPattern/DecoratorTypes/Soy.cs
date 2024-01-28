using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.DecoratorTypes
{
    public class Soy : AddonDecorator
    {
        public Soy(Beverage bevarage) : base(bevarage)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + "with Soy ";
        }
        public override int GetCost()
        {
            return base.Cost() + 11;
        }
    }
}
