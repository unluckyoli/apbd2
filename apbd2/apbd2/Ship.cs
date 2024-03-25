namespace apbd2;

public class Ship
{
    private List<Container> ALLContainers = new List<Container>();
    
    public double MaximumLoadWeight { get; private set; }
    public double MaximumSpeed { get; private set; }
    public int MaximumContainersCount { get; private set; }
    public double MaximumTotalContainersWeight { get; private set; }

    public Ship(double maximumLoadWeight, double maximumSpeed, int maximumContainersCount, double maximumTotalContainersWeight)
    {
        MaximumLoadWeight = maximumLoadWeight;
        MaximumSpeed = maximumSpeed;
        MaximumContainersCount = maximumContainersCount;
        MaximumTotalContainersWeight = maximumTotalContainersWeight;
    }
    
    
    
    
    public void LoadContainer(Container container)
    {
        if (ALLContainers.Count >= MaximumContainersCount)
        {
            throw new Exception("za duzo konteneroiw na statku");
        }

        double totalContainersWeight = ALLContainers.Count == 0 ? 0 : ALLContainers.Sum(c => c.PackageMassInKg + c.OwnMass);
        if (totalContainersWeight + container.PackageMassInKg + container.OwnMass > MaximumTotalContainersWeight)
        {
            throw new Exception("za duza waga na statku");
        }

        ALLContainers.Add(container);
    }
    
    public void UnloadContainer(Container container)
    {
        ALLContainers.Remove(container);
    }


    public void PrintShipInfo()
    {
        Console.WriteLine("");
        Console.WriteLine($"==================OGOLNE INFO O STATKU==================");
        Console.WriteLine($"max predkosc: {MaximumSpeed} wezlow");
        Console.WriteLine($"max liczba kontenerow: {MaximumContainersCount}");
        Console.WriteLine($"max laczna masa kontenerow: {MaximumTotalContainersWeight} ton");
        Console.WriteLine($"liczba kontenerow na statku: {ALLContainers.Count}");
        Console.WriteLine(
            $";laczna masa kontenerow na statku: {ALLContainers.Sum(c => c.PackageMassInKg + c.OwnMass)} ton");
        Console.WriteLine("=========================================================");
        
        Console.WriteLine("lista kontenerow na statku:");
        foreach (var container in ALLContainers)
        {
            Console.WriteLine(container.ToString());
        }
    }

    public void przenies(Ship ship1, Container container, Ship ship2)
    {
        ship1.ALLContainers.Remove(container);
        ship2.LoadContainer(container);
    }

    public void zastap(Ship ship, string serialNumber1, Container container)
    {
        var containerToReplace = ALLContainers.FirstOrDefault(c => c.ShipSerialNumber == serialNumber1);
        if (containerToReplace == null)
        {
            throw new Exception($"kontener o numerze {serialNumber1} nie istnieje");
        }

        ALLContainers.Remove(containerToReplace);
        LoadContainer(container);
    }
    
    
}