using Cwiczenia2.Cargo;
using Cwiczenia2.Interfaces;

namespace Cwiczenia2.BaseClasses;

public class FluidContainer : Container<Fluid>, IHazardNotifier
{
    public FluidContainer(int weight, int height, int containerWeight, int containerDepth, int maxWeight, string serialNumber) : base(weight, height, containerWeight, containerDepth, maxWeight, serialNumber)
    {
    }

    public override void UnloadWeight()
    {
        Weight = 0;
    }

    public override void LoadWeight(Fluid cargo)
    {
        //TODO jeśli ilość cargo jest większa niż maxPoj kontenera - OverfillException, itp.
        Weight = cargo.Amount;
    }

    public void NotifyHazadr(string message)
    {
        Console.WriteLine(($"{SerialNuber}: {message}"));
    }
}