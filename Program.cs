
using System.ComponentModel;
using Cwiczenia2.BaseClasses;
using Cwiczenia2.Cargo;
using Cwiczenia2.Containers;
using Cwiczenia2.Enums;
using Cwiczenia2.Exceptions;

LiquidContainer liquidContainerSafeExceeded = new LiquidContainer(200, 1000, 500, 2000);
liquidContainerSafeExceeded.LoadWeight(new Liquid("Fuel", 1001, Safety.Hazardous));
Console.WriteLine(liquidContainerSafeExceeded.PayloadWeight);

LiquidContainer liquidContainerHazardousExceeded = new LiquidContainer(200, 1000, 500, 2000);
liquidContainerHazardousExceeded.LoadWeight(new Liquid("Fuel", 2000, Safety.Safe));
Console.WriteLine(liquidContainerHazardousExceeded.PayloadWeight);