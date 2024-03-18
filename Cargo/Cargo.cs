namespace Cwiczenia2.Cargo;

public abstract class Cargo
{
    protected Cargo(string type, int amount)
    {
        Type = type;
        Amount = amount;
    }

    public String Type { get; set; }
    public int Amount { get; set; }
    
}