using System;
using System.Collections.Generic;
using Cwiczenia2.BaseClasses;
using Cwiczenia2.Exceptions;

namespace Cwiczenia2.Transporters
{
    public class Transporter<T> where T : Cargo.Cargo
    {
        public List<Container<T>> Containers { get; set; }
        public double MaxSpeed { get; set; }
        public int MaxContainersAmt { get; set; }
        public int MaxPayload { get; set; }
        public double Payload { get; set; }

        public Transporter(double maxSpeed, int maxContainersAmt, int maxPayload)
        {
            MaxSpeed = maxSpeed;
            MaxContainersAmt = maxContainersAmt;
            MaxPayload = maxPayload;
            Containers = new List<Container<T>>();
        }

        public void LoadContainer(Container<T> container)
        {
            try
            {
                if (Payload + container.PayloadWeight > MaxPayload)
                {
                    throw new OverfillException(
                        $"You can not load more containers!\n\tCarry capacity left: {MaxPayload - Payload} kg. You are trying to load {container.PayloadWeight}");
                }
            }
            catch (OverfillException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: " + e.Message);
                Console.ResetColor();
            }

            Console.WriteLine("Added new container.");
            // Containers.Add(container);
        }
    }
}