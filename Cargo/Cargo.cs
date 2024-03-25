using Cwiczenia2.Enums;

namespace Cwiczenia2.Cargo;

public abstract class Cargo
{
    protected Cargo(string type, double amount)
    {
        Type = type;
        Amount = amount;
    }

    public String Type { get; set; }
    public double Amount { get; set; }
}