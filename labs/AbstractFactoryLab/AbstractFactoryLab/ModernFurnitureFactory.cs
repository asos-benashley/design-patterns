using AbstractFactoryLab.Furniture;
using AbstractFactoryLab.Furniture.Interfaces;

namespace AbstractFactoryLab;

public class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new ModernChair();

    public ISofa CreateSofa() => new ModernSofa();

    public ITable CreateTable() => new ModernTable();
}