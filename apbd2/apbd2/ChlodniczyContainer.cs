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
    
    
    public override string ToString()
    {
        return $"=====================\nnumer seryjny: {ShipSerialNumber}, \ntyp kontenera: {Type}, \nmasa ladunku: {PackageMassInKg} kg, \nwysokosc: {Height} cm, \nwaga wlasna: {OwnMass} kg, \nglebokosc: {Depth} cm\nprodukt: {ProductType}\ntemperatura: {Temperature}\n=====================\n";
    }
}