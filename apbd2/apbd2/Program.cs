

public enum ContainerType
{
    chlodniczy,
    plynny,
    gazowy
}

class Container
{
    protected static int ContainerSerialNumber = 0;
    
    public string ShipSerialNumber { get; private set;}
    public double PackageMassInKg { get; private set; }
    public double Height { get; private set; }
    public double OwnMass { get; private set; }
    public double Depth { get; private set; }
    
    public ContainerType Type { get; private set; }


    public Container(ContainerType type, double packageMassInKg, double ownMass, double height,
        double depth)
    {
        Type = type;
        ShipSerialNumber = CreateNewSerialNumber();
        PackageMassInKg = packageMassInKg;
        OwnMass = ownMass;
        Height = height;
        Depth = depth;
    }

    protected string CreateNewSerialNumber()
    {
        string SerialNumber = Type switch
        {
            ContainerType.chlodniczy => "C",
            ContainerType.plynny => "P",
            ContainerType.gazowy => "G"
        };
        return $"KON-{SerialNumber}-{ContainerSerialNumber++}";
    }
    
    public override string ToString()
    {
        return $"=====================\nnumer seryjny: {ShipSerialNumber}, \ntyp kontenera: {Type}, \nmasa ladunku: {PackageMassInKg} kg, \nwysokosc: {Height} cm, \nwaga wlasna: {OwnMass} kg, \nglebokosc: {Depth} cm\n=====================\n";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        
    
    Container container1 = new Container(ContainerType.chlodniczy, 500, 200, 100, 150);
    Console.WriteLine(container1);
    
    }
}

    


