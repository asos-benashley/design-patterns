using FactoryMethodLab;

var vehicleStore = new LamborghiniFactory();

vehicleStore.OrderVehicle("Sports");
vehicleStore.OrderVehicle("Suv");

Console.Read();