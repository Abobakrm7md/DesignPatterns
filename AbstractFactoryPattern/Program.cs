
//an interface for creating families of related or dependent objects without specifying their concrete classes

using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.FactoryInterface;

ClientMethod(new AbstractFactory2());

ClientMethod(new AbstractFactory1());





static void ClientMethod(IFactory factory)
{
    var f1 = factory.CreateBackground();
    var f2 = factory.CreateColor();


    f1.ChangeColor();
    f1.Write(f2);
}