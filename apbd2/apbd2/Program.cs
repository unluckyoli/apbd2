

public enum ContainerType
{
    Chlodniczy,
    Plynny,
    Gazowy
}

class Container
{
    private static int ContainerSerialNumber = 1;
    
    public string SerialNumber { get; private set;}
    public double PackageMassInKg { get; private set; }
    public double Height { get; private set; }
    public double OwnMass { get; private set; }
    public double Depth { get; private set; }
    
    public ContainerType Type { get; private set; }


    Container(ContainerType type, string serialNumber, double packageMassInKg, double ownMass, double height,
        double depth)
    {
        Type = type;
        SerialNumber = serialNumber;
        PackageMassInKg = packageMassInKg;
        OwnMass = ownMass;
        Height = height;
        Depth = depth;
    }
}

