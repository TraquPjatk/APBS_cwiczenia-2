namespace Cwiczenia2.Cargo;

public class Fluid : Cargo
{
    public Fluid(string type, int amount, string example) : base(type, amount)
    {
        this.Example = example;
    }

    public String Example { get; set; }
}