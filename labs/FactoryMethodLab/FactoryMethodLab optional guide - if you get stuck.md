# Factory Method Lab - Optional Guide If You Get Stuck

## Introduction

This lab is intended to be completed without this guide. Try to use the knowledge the instructor has given you already.

However, if you are stuck then please use this guide to help you along. 

If you do use the guide, then keep usage to the bare minimum to unblock yourself so that you can achieve maximum learning.

## Guide

1. Create a new abstract class called `VehicleFactory`.

1. Add a public method to it called `public Vehicle CreateVehicle(string vehicleType)`.

1. Add a protect abstract method called `protected abstract Vehicle Create(string vehicleType)`

1. The full code will look something like:

    ```c#
    public abstract class VehicleFactory
    {
        public Vehicle CreateVehicle(string vehicleType)
        {
            var vehicle = Create(vehicleType);

            vehicle.Build();
            vehicle.Prepare();
            vehicle.Deliver();

            return vehicle;
        }

        protected abstract Vehicle Create(string vehicleType);
    }
    ```

1. Now create two sub-classes of this, one for constructing Lamborghini vehicles and the other to create Porsche vehicles.

1. Code for the `LamborghiniFactory` will look something like this:

    ```c#
    public class LamborghiniFactory : VehicleFactory
    {
        protected override Vehicle Create(string vehicleType)
        {
            return vehicleType switch
            {
                "sports" => new LamborghiniSportsCar(),
                "suv" => new LamborghiniSuv(),
                _ => throw new ArgumentException()
            };
        }
    }
    ```

1. Implementation of `PorscheFactory` will be similar but it will construct the Porsche concrete implementations.

1. Write some code in `Program.cs` to construct some classes using a specific factory and output some debug output to show what it is doing.

1. Observe the changes to the application output when you switch to using the other factory.

## End of the lab