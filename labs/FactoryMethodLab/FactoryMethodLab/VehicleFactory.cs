using FactoryMethodLab.Vehicles;

namespace FactoryMethodLab;

public abstract class VehicleFactory
{
    public Vehicle OrderVehicle(string vehicleType)
    {
        var vehicle = Create(vehicleType);
        
        vehicle.Build();
        vehicle.Prepare();
        vehicle.Deliver();

        Console.WriteLine("Congrats on the new car!");
        return vehicle;
    }

    protected abstract Vehicle Create(string carType);
}