namespace apbd2;

public class GazContainer : Container, IHazardNotifier
{
    
    public double Cisnienie { get; set; }


    public GazContainer(double cisnienie, double packageMassInKg, double ownMass, double height,
        double depth) : base(ContainerType.gazowy, packageMassInKg, ownMass, height, depth)
    {
        Cisnienie = cisnienie;
    }

    public void DangerMessage(string containerNumber)
    {
        Console.WriteLine($"UWAGA!!!!! kontener numer {containerNumber} zawiera niebezpieczne substancje");
    }
    
    
    public void Load(double m)
    {
        if (m > MaximumLoadWeight())
        {
            DangerMessage(ShipSerialNumber);
            throw new Exception("za duza waga dla niebezpiecznego plynu");
        }
        else
        {
            PackageMassInKg = m;
        }
    }

    public double Deload()
    {
        return PackageMassInKg * 0.05;
    }
    
}