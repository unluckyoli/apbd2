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

public enum ProductType
{
    Bananas,
    Chocolate,
    Fish,
    Meat,
    IceCream,
    FrozenPizza,
    Cheese,
    Sausages,
    Butter,
    Eggs
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

    


