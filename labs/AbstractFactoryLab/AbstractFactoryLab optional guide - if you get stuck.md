# Abstract Factory Lab - Optional Guide If You Get Stuck

## Introduction

This lab is intended to be completed without this guide. Try to use the knowledge the instructor has given you already.

However, if you are stuck then please use this guide to help you along. 

If you do use the guide, then keep usage to the bare minimum to unblock yourself so that you can achieve maximum learning.

## Guide

1. Create an interface called `IFurnitureFactory` which has 3 create methods that each return one of the furniture interfaces.

1. The interface should look like this:

    ```c#
    public interface IFurnitureFactory
    {
        IChair CreateChair();
    
        ISofa CreateSofa();
    
        ITable CreateTable();
    }
    ```

1. Create a `ModernFurnitureFactory` that extends `IFurnitureFactory` and for each of the methods it constructs a concrete modern furniture class.

1. The implementation should look something like this:

    ```c#
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new ModernChair();

        public ISofa CreateSofa() => new ModernSofa();

        public ITable CreateTable() => new ModernTable();
    }
    ```

1. Make a similar factor as above for `RetroFurnitureFactory` and `UrbanFurnitureFactory` as well.

1. Write some code in `Program.cs` to construct some classes using a specific factory and output some debug output to show what it is doing.

1. Observe the changes to the application output when you switch to using the other factories.

## End of the lab