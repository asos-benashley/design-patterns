# Abstract Factory Lab - Notes

## Setting up the repo and creating your branch

If you haven't done so already:
- Clone the repo your instructor has already linked you
- Create a feature branch in the following naming convention: 
  - feature/[date in 'yyyymmdd' format]-[name of student(s)]
  - E.g. `feature/20220820-Milan`
  - or if working in a pair `feature/20220820-DavidHelen`

## Open the solution

Solution location: `AbstractFactoryLab.sln`

1. Open the `Furniture` folder and observe the 3 interfaces `IChair`, `ISofa` and `ITable`. Although they share the same `Description` property, imagine there to be many properties/methods that are specific to each. These files should not be changed.

1. Observe the 9 concrete classes that extend these interfaces. There are 3 groups of 3. These files should not be changed either.

1. Each group is a style of furniture: Modern, Retro and Urban.

Implement the abstract factory pattern such that each factory handles one style of furniture.

Implement some display logic in `Program.cs` that uses one specific factory via the interface and outputs the description from the Chair, Sofa and Table. Run the application to see the output.

Switch to using a different factory and re-run the application to see the change in debug output.

## If you get stuck

Optional guide if you get stuck: `AbstractFactoryLab optional guide - if you get stuck.md`