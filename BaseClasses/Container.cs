using Cwiczenia2.Database;

namespace Cwiczenia2.BaseClasses;

public abstract class Container<T>
{
    protected Container(int weight, int height, int containerWeight, int containerDepth, int maxWeight,
        String serialNumber)
    {
        Weight = weight;
        Height = height;
        ContainerWeight = containerWeight;
        ContainerDepth = containerDepth;
        MaxWeight = maxWeight;
        SerialNuber = serialNumber;
    }

    public int Weight { get; set; }
    public int Height { get; set; }
    public int ContainerWeight { get; set; }
    public int ContainerDepth { get; set; }
    public int MaxWeight { get; set; }
    public String _serialNumber { get; set; }

    public String SerialNuber
    {
        get
        {
            return this._serialNumber;
        }
        set
        {
            _serialNumber = $"KON-C-{value}--{Singleton.GenerateUniqueId()}";
        }
    }

    public abstract void UnloadWeight();
    public abstract void LoadWeight(T cargo);
    
}