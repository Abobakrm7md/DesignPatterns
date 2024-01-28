using DecoratorPattern.Component;

namespace DecoratorPattern.ComponentTypes
{
    public class DeCafe : Beverage
    {
        public override string GetDescription()
        {
            return base.GetDescription() + "Decafe";
        }
        public override int GetCost()
        {
            return 5;
        }
    }

    public class Class1
    {
    }
}
