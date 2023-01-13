# Factory Method Lab - Notes

## Setting up the repo and creating your branch

If you haven't done so already:
- Clone the repo your instructor has already linked you
- Create a feature branch in the following naming convention: 
  - feature/[date in 'yyyymmdd' format]-[name of student(s)]
  - E.g. `feature/20220820-Milan`
  - or if working in a pair `feature/20220820-DavidHelen`

## Open the solution

Solution location: `FactoryMethodLab.sln`

1. Open the `Vehicles` folder and observe the abstract `Vehicle` class. This file should not be changed.

1. Observe the 4 concrete classes that extend `Vehicle`. These files should not be changed.

Currently, calling code would need to construct the concrete classes directly using the `new` keyword which would cause tightly coupled code. How could you implement the factory method pattern here to reduce the tight coupling?

Create separate classes to deal with Lamborghini vehicles and Porsche vehicles.

Note: Ensure you implement the factory method pattern and not the simple factory technique.

Insert some debug `Console.WriteLine` statements within your factory to output the concrete type being constructed as well as various other points that show the path of execution. Then write some code in `Program.cs` to construct some classes using a specific factory. Run the application and observe the output.

Switch to using a different factory and re-run the application to see the change in debug output.

## If you get stuck

Optional guide if you get stuck: `FactoryMethodLab optional guide - if you get stuck.md`