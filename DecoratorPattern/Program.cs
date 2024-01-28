
//The decorator pattern is a design pattern that allows behavior to be added to an individual object,
//either statically or dynamically, without affecting the behavior of other objects from the same class

using DecoratorPattern.ComponentTypes;
using DecoratorPattern.DecoratorTypes;

Caramel caramel = new Caramel(new Soy(new Choclate(new Espresso())));
Console.WriteLine(caramel.GetDescription());
Console.WriteLine(caramel.GetCost());

Caramel caramel2 = new Caramel(new Choclate(new Espresso()));
Console.WriteLine(caramel2.GetDescription());
Console.WriteLine(caramel2.GetCost());