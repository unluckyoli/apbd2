namespace apbd2;

public enum ContainerType
{
    chlodniczy,
    plynny,
    gazowy
}

public enum PlynnyType
{
    niebezpieczny,
    zwykly
}


public class Container
{
    protected static int ContainerSerialNumber = 0;
    
    public string ShipSerialNumber { get; private set;}
    public double PackageMassInKg { get; set; }
    public double Height { get; private set; }
    public double OwnMass { get; private set; }
    public double Depth { get; private set; }
    
    public ContainerType Type { get; private set; }


    public Container(ContainerType type, double packageMassInKg, double ownMass, double height,
        double depth)
    {
        Type = type;
        ShipSerialNumber = CreateNewSerialNumber(type);
        PackageMassInKg = packageMassInKg;
        OwnMass = ownMass;
        Height = height;
        Depth = depth;
    }

    public string CreateNewSerialNumber(ContainerType type)
    {
        string SerialNumber = "";
        switch (type)
        {
            case ContainerType.chlodniczy:
                SerialNumber = "C";
                break;
            case ContainerType.plynny:
                SerialNumber = "L";
                break;
            case ContainerType.gazowy:
                SerialNumber = "G";
                break;
        }
        return $"KON-{SerialNumber}-{ContainerSerialNumber++}";
    }
    
    
    public double MaximumLoadWeight()
    {
        return Height * Depth * OwnMass;
    }

    public double Deload()
    {
        return PackageMassInKg = 0;
    }

    public void Load(double m)
    {
        if (m > MaximumLoadWeight())
        {
            throw new Exception("za duza waga:(");
        }
        else
        {
            PackageMassInKg = m;
        }
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

    Container container2 = new Container(ContainerType.gazowy, 400, 150, 200, 100);
    Console.WriteLine(container2);

    PlynnyContainer plynnyContainer1 = new PlynnyContainer(PlynnyType.niebezpieczny, 400000, 100, 100, 90);
    Console.WriteLine(plynnyContainer1);
    
    //Console.WriteLine($"maksymalna ladownosc pakunku to {plynnyContainer1.MaximumLoadWeight()} kg");
    //plynnyContainer1.Load(100000000000);
    //Console.WriteLine($"po zaladunku masa calego statku to {plynnyContainer1.PackageMassInKg+plynnyContainer1.OwnMass} kg");

    }
}

    


