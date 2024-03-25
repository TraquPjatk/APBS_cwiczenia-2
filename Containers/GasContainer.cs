using Cwiczenia2.BaseClasses;
using Cwiczenia2.Cargo;
using Cwiczenia2.Exceptions;
using Cwiczenia2.Interfaces;

namespace Cwiczenia2.Containers
{
    public class GasContainer : Container<Gas>, IHazardNotifier
    {
        public GasContainer(int height, int containerWeight, int containerDepth, int maxPayloadWeight) : base(height,
            containerWeight, containerDepth, maxPayloadWeight)
        {
            Atmospheres = 1.0;
            SerialNuber = SerialNuber;
        }

        public override void UnloadWeight()
        {
            PayloadWeight = PayloadWeight * 0.05;
            NotifyHazadr(
                $"Something dangerous might have just happened to container {SerialNuber}, during unloading process!");
        }

        public override void LoadWeight(Gas cargo)
        {
            if (cargo.Amount > MaxPayloadWeight)
            {
                try
                {
                    throw new OverfillException("Maximal payload weight has been exceeded.\n\t Cargo will not be loaded!");
                }
                catch (OverfillException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: " + e.Message);
                    Console.ResetColor();
                }
            }
            else
            {
                PayloadWeight = cargo.Amount;
            }
        }

        public void NotifyHazadr(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public double Atmospheres { get; set; }
    }
}