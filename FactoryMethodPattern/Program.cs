


using FactoryMethodPattern.Factory;




    // Using CarCreator to create a Car
    ClientCode(new CarCreator());

    // Using MotorcycleCreator to create a Motorcycle
    ClientCode(new MotorcycleCreator());

Console.WriteLine("*******************************");

ClientCode2(new VehicleCreator2() , "m");
ClientCode2(new VehicleCreator2() , "c");

static void ClientCode(IVehicleCreator creator)
{
    var vehicle = creator.CreateVehicle();
    Console.WriteLine($"Creator: {vehicle.Drive()}");
}


static void ClientCode2(IVehicleCreator2 creator, string productType)
{
    var product = creator.CreateVehicle(productType);
    Console.WriteLine($"Creator: {product.Drive()}");
}