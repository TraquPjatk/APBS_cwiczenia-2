using System.Security.AccessControl;
using Cwiczenia2.BaseClasses;
using Cwiczenia2.Cargo;
using Cwiczenia2.Database;
using Cwiczenia2.Enums;
using Cwiczenia2.Exceptions;
using Cwiczenia2.Interfaces;

namespace Cwiczenia2.Containers;

public class LiquidContainer : Container<Liquid>, IHazardNotifier
{
    public Safety Type { get; set; }

    
    public LiquidContainer(int height, int containerWeight, int containerDepth, int maxPayloadWeight) :
        base(height, containerWeight, containerDepth, maxPayloadWeight)
    {
        SerialNuber = SerialNuber;
    }

    // public static FluidContainer Create(int height, int containerWeight, int containerDepth, int maxWeight, string serialNumber, Safety safety)
    // {
    //     return new FluidContainer(height, containerWeight, containerDepth, maxWeight, safety);
    // }


    public override void UnloadWeight()
    {
        PayloadWeight = 0;
    }

    public override void LoadWeight(Liquid cargo)
    {
        if (cargo.Safety == Safety.Hazardous)
        {
            if (cargo.Amount > MaxPayloadWeight / 2.0)
            {
                try
                {
                    throw new OverfillException(
                        $"This cargo is hazardous and exceeds 50% of the maximum payload allowed for the container. \n\t Only {MaxPayloadWeight / 2} kg has been loaded!");
                }
                catch (OverfillException ex)
                {
                    PayloadWeight = MaxPayloadWeight / 2.0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: " + ex.Message);
                    Console.ResetColor();
                }
            }
        }
        else if (cargo.Amount > MaxPayloadWeight * 0.9)
        {
            try
            {
                throw new OverfillException(
                    $"Container allowed payload mass exceeded. \n\t Only {cargo.Amount * 0.9} kg has been loaded.");
            }
            catch (OverfillException ex)
            {
                PayloadWeight = cargo.Amount * 0.9;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: " + ex.Message);
                Console.ResetColor();
            }
        }
    }

    public void NotifyHazadr(string message)
    {
        Console.WriteLine(($"{SerialNuber}: {message}"));
    }
}