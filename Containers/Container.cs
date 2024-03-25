using System.ComponentModel;
using Cwiczenia2.Database;

namespace Cwiczenia2.BaseClasses;

public abstract class Container<T>
{
    protected Container(int height, int containerWeight, int containerDepth, int maxPayloadWeight)
    {
        Height = height;
        ContainerWeight = containerWeight;
        ContainerDepth = containerDepth;
        MaxPayloadWeight = maxPayloadWeight;
        SerialNuber = SerialNuber;
    }

    public double PayloadWeight { get; set; }
    public int Height { get; set; }
    public int ContainerWeight { get; set; }
    public int ContainerDepth { get; set; }
    public int MaxPayloadWeight { get; set; }
    private String _serialNumber { get; set; }

    public String SerialNuber
    {
        get { return this._serialNumber; }
        set
        {
            switch (typeof(T).Name)
            {
                case "Liquid":
                    _serialNumber = $"KON-L-{Singleton.GenerateUniqueId()}";
                    break;
                case "Gas":
                    _serialNumber = $"KON-G-{Singleton.GenerateUniqueId()}";
                    break;
                case "Cooling":
                    _serialNumber = $"KON-C-{Singleton.GenerateUniqueId()}";
                    break;
                default:
                    Console.WriteLine("Container of type \"" + typeof(T).Name + "\" doesn't exist.");
                    break;
            }
        }
    }

    public abstract void UnloadWeight();
    public abstract void LoadWeight(T cargo);
}