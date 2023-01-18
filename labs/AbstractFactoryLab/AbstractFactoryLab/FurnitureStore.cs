using AbstractFactoryLab.Furniture.Interfaces;

namespace AbstractFactoryLab;

public class FurnitureStore
{
    private readonly IFurnitureFactory _furnitureFactory;
    public FurnitureStore(IFurnitureFactory furnitureFactory)
    {
        Console.WriteLine($"Welcome to the {furnitureFactory.GetType().Name}!");
        _furnitureFactory = furnitureFactory;
    }

    public void GetFurniture()
    {
        Console.WriteLine("Here's our catalogue of furniture: ");
        var chair = _furnitureFactory.CreateChair();
        Console.WriteLine(chair.Description);
        
        var sofa = _furnitureFactory.CreateSofa();
        Console.WriteLine(sofa.Description);
        
        var table = _furnitureFactory.CreateTable();
        Console.WriteLine(table.Description);
    }
}