using AbstractFactoryLab.Furniture;
using AbstractFactoryLab.Furniture.Interfaces;

namespace AbstractFactoryLab;

public class UrbanFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new UrbanChair();

    public ISofa CreateSofa() => new UrbanSofa();

    public ITable CreateTable() => new UrbanTable();
}