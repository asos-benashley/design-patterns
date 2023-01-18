using FactoryMethodLab.Vehicles;

namespace FactoryMethodLab;

public class PorscheFactory : VehicleFactory
{
    protected override Vehicle Create(string carType)
    {
        switch (carType)
        {
            case "Sports" : return new PorscheSportsCar();
            case "Suv" : return new PorscheSportsCar();
            default: throw new ArgumentException();
        }
    }
}