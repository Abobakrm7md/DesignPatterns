using AbstractFactoryPattern.SubSystemInterface;

namespace AbstractFactoryPattern.FactoryInterface
{
    public interface IFactory
    {
        IBackground CreateBackground();
        IColor CreateColor();
    }
}
