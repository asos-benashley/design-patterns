using AbstractFactoryLab;

IFurnitureFactory furnitureFactory = new UrbanFurnitureFactory();

var furnitureStore = new FurnitureStore(furnitureFactory);

furnitureStore.GetFurniture();

Console.Read();