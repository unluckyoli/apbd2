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

    Container container3 = new Container(ContainerType.plynny, 300, 100, 250, 200);
    Console.WriteLine(container3);
    
    Container container4 = new Container(ContainerType.chlodniczy, 700, 200, 150, 100);
    Console.WriteLine(container4);
    
    Container container5 = new Container(ContainerType.gazowy, 400, 100, 50, 20);
    Console.WriteLine(container5);

    
    
    
    
    
    
    ChlodniczyContainer chlodniczyContainer = new ChlodniczyContainer(ProductType.Bananas, 15, 50, 100, 20, 30);
    Console.WriteLine(chlodniczyContainer);

    GazContainer gazContainer = new GazContainer(100, 200, 50, 10, 10);
    Console.WriteLine(gazContainer);
    
    PlynnyContainer plynnyContainer1 = new PlynnyContainer(PlynnyType.niebezpieczny, 400000, 100, 100, 90);
    Console.WriteLine(plynnyContainer1);
    
    //Console.WriteLine($"maksymalna ladownosc pakunku to {plynnyContainer1.MaximumLoadWeight()} kg");
    //plynnyContainer1.Load(100000000000);
    //Console.WriteLine($"po zaladunku masa calego statku to {plynnyContainer1.PackageMassInKg+plynnyContainer1.OwnMass} kg");

    Ship ship1 = new Ship(10000000, 20, 5, 25000000);
    
    ship1.LoadContainer(container1);
    ship1.LoadContainer(container3);

    ship1.PrintShipInfo();


    Ship ship2 = new Ship(20000, 40, 10, 250000);
    ship2.LoadContainer(container2);
    ship2.LoadContainer(container4);
    
    ship2.PrintShipInfo();
    
    
    ship1.zastap(ship1,"KON-C-0", container5);
    
    ship2.przenies(ship1,container1,ship2);
    
    
    
    ship1.PrintShipInfo();
    ship2.PrintShipInfo();

    }
}

    


