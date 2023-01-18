using AbstractFactoryLab.Furniture;
using AbstractFactoryLab.Furniture.Interfaces;

namespace AbstractFactoryLab;

public class RetroFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new RetroChair();

    public ISofa CreateSofa() => new RetroSofa();

    public ITable CreateTable() => new RetroTable();
}