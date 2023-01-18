using AbstractFactoryLab.Furniture.Interfaces;

namespace AbstractFactoryLab;

public interface IFurnitureFactory
{
    IChair CreateChair();
    ISofa CreateSofa();
    ITable CreateTable();
}