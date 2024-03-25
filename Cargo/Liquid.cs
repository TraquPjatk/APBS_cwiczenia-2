using Cwiczenia2.Enums;

namespace Cwiczenia2.Cargo;

public class Liquid : Cargo
{
    public Liquid(string type, int amount, Safety safety) : base(type, amount)
    {
        this.Safety = safety;
    }

    public Safety Safety { get; set; }
}