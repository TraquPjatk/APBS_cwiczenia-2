using Cwiczenia2.BaseClasses;
using Cwiczenia2.Cargo;
using Cwiczenia2.Interfaces;

namespace Cwiczenia2.Containers;

public class CoolingContainer : Container<Food>, IHazardNotifier
{
    public CoolingContainer(int height, int containerWeight, int containerDepth, int maxPayloadWeight,
        string productType) : base(height, containerWeight, containerDepth, maxPayloadWeight)
    {
        ProductType = productType;

        switch (productType)
        {
            case "Bananas":
                Temperature = 13.3;
                break;
            case "Chocolate":
                Temperature = 18.0;
                break;
            case "Fish":
                Temperature = 2.0;
                break;
            case "Meat":
                Temperature = -15.0;
                break;
            case "Ice cream":
                Temperature = -18.0;
                break;
            case "Frozen pizza":
                Temperature = -30.0;
                break;
            case "Cheese":
                Temperature = 7.2;
                break;
            case "Sausages":
                Temperature = 5.0;
                break;
            case "Butter":
                Temperature = 20.5;
                break;
            case "Eggs":
                Temperature = 19.0;
                break;
        }
    }

    public string ProductType { get; set; }

    public double Temperature { get; set; }


    public override void UnloadWeight()
    {
        PayloadWeight = 0.0;
    }

    public override void LoadWeight(Food cargo)
    {
        if (cargo.Type != ProductType)
        {
            NotifyHazadr("You can not combine different food types within one container!");
        }
        else
        {
            PayloadWeight = PayloadWeight + cargo.Amount;
        }
    }

    public void NotifyHazadr(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}