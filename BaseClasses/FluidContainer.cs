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
        throw new NotImplementedException();
    }

    public override void LoadWeight(Fluid cargo)
    {
        throw new NotImplementedException();
    }

    public void NotifyHazadr(string message)
    {
        throw new NotImplementedException();
    }
}