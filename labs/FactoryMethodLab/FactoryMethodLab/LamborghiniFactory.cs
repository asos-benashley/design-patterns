using FactoryMethodLab.Vehicles;

namespace FactoryMethodLab;

public class LamborghiniFactory : VehicleFactory
{
    protected override Vehicle Create(string carType)
    {
        switch (carType)
        {
            case "Sports" : return new LamborghiniSportsCar();
            case "Suv" : return new LamborghiniSuv();
            default: throw new ArgumentException();
        }
    }
}