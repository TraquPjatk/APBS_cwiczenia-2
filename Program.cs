
using System.ComponentModel;
using Cwiczenia2.BaseClasses;
using Cwiczenia2.Cargo;
using Cwiczenia2.Containers;
using Cwiczenia2.Enums;
using Cwiczenia2.Exceptions;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\nLiquid:");
Console.ResetColor();

LiquidContainer liquidContainerSafeExceeded = new LiquidContainer(200, 1000, 500, 2000);
liquidContainerSafeExceeded.LoadWeight(new Liquid("Fuel", 1001, Safety.Hazardous));
Console.WriteLine(liquidContainerSafeExceeded.PayloadWeight);

LiquidContainer liquidContainerHazardousExceeded = new LiquidContainer(200, 1000, 500, 2000);
liquidContainerHazardousExceeded.LoadWeight(new Liquid("Fuel", 2000, Safety.Safe));
Console.WriteLine(liquidContainerHazardousExceeded.PayloadWeight);

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\nGas:");
Console.ResetColor();

GasContainer gasContainer = new GasContainer(200, 1000, 500, 2000);
gasContainer.LoadWeight(new Gas("Nitrogenium", 1111));
Console.WriteLine(gasContainer.PayloadWeight);
gasContainer.UnloadWeight();
Console.WriteLine(gasContainer.PayloadWeight);