namespace apbd2;

public class ChlodniczyContainer : Container, IHazardNotifier
{
    public ProductType ProductType { get; set; } 
    public double Temperature { get; set; }


    public ChlodniczyContainer(ProductType productType, double temperature, double packageMassInKg, double ownMass,
        double height, double depth) : base(ContainerType.gazowy, packageMassInKg, ownMass, height, depth)
    {
        ProductType = productType;
        Temperature = temperature;
    }
    
    
    public void DangerMessage(string NumberContainer)
    {
        Console.WriteLine($"UWAGA!!!!! kontener o numerze {NumberContainer} za malo temperatury");
    }
    
    
    public void Load(ProductType productTypee, double temperature, double m)
    {
        if (productTypee!= ProductType || temperature<Temperature || m > MaximumLoadWeight())
        {
            throw new Exception("jakies parametry sa nieprawidlowe:(");
        }
        else
        {
            PackageMassInKg = m;
        }
    }
    
}