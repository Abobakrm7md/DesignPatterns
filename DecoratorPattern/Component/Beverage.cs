namespace DecoratorPattern.Component
{
    public abstract class Beverage
    {
        public virtual string GetDescription()
        {
            return "Original type";
        }
        public abstract int GetCost();
    }

    internal class Class1
    {
    }
}
