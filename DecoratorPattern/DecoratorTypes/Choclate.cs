using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.DecoratorTypes
{
    public class Choclate : AddonDecorator
    {
        public Choclate(Beverage bevarage) : base(bevarage)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + "with Choclate ";
        }
        public override int GetCost()
        {
            return base.Cost() + 12;
        }
    }
}
