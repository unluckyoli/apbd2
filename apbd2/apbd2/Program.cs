

public enum ContainerType
{
    chlodniczy,
    plynny,
    gazowy
}

class Container
{
    private static int ContainerSerialNumber = 0;
    
    public string ShipSerialNumber { get; private set;}
    public double PackageMassInKg { get; private set; }
    public double Height { get; private set; }
    public double OwnMass { get; private set; }
    public double Depth { get; private set; }
    
    public ContainerType Type { get; private set; }


    Container(ContainerType type, double packageMassInKg, double ownMass, double height,
        double depth)
    {
        Type = type;
        ShipSerialNumber = CreateNewSerialNumber();
        PackageMassInKg = packageMassInKg;
        OwnMass = ownMass;
        Height = height;
        Depth = depth;
    }

    private string CreateNewSerialNumber()
    {
        string SerialNumber = Type switch
        {
            ContainerType.chlodniczy => "C",
            ContainerType.plynny => "P",
            ContainerType.gazowy => "G"
        };
        return $"KON-{SerialNumber}-{ContainerSerialNumber++}";
    }
    
    
    
}

