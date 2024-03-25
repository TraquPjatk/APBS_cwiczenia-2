using System.ComponentModel;

namespace Cwiczenia2.Transporters;

public class Transporter
{
    public List<Container> Containers { get; set; }
    public double MaxSpeed { get; set; }
    public int MaxContainersAmt { get; set; }
    public int MaxPayload { get; set; }

    public Transporter(double maxSpeed, int maxContainersAmt, int maxPayload)
    {
        MaxSpeed = maxSpeed;
        MaxContainersAmt = maxContainersAmt;
        MaxPayload = maxPayload;
    }

    public void LoadContainer(Container container)
    {
        
        Containers.Add(container);
    }
    
}