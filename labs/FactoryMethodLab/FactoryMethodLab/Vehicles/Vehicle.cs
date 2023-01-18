namespace FactoryMethodLab.Vehicles;

public abstract class Vehicle
{
    public void Build()
    {
        Console.WriteLine($"Building {this.GetType().Name}");
    }

    public void Prepare()
    {
        Console.WriteLine($"Preparing {this.GetType().Name}");
    }

    public void Deliver()
    {
        Console.WriteLine($"Delivering {this.GetType().Name}");
    }
}