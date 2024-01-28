using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    public abstract class AddonDecorator : Beverage
    {
        private Beverage _bevarage;

        protected AddonDecorator(Beverage bevarage)
        {
            _bevarage = bevarage;
        }
        public override string GetDescription()
        {
            return _bevarage.GetDescription();
        }
        public virtual int Cost()
        {
            return _bevarage.GetCost();
        }

    }
}
