namespace apbd2;

public class PlynnyContainer : Container, IHazardNotifier
{
    public PlynnyType PlynnyType { get; private set; }

   public PlynnyContainer(PlynnyType plynnyType, double packageMassInKg, double ownMass, double height,
        double depth) : base(ContainerType.plynny, packageMassInKg, ownMass, height, depth)
    {
        PlynnyType = plynnyType;
    }

    public void DangerMessage(string NumberContainer)
    {
        Console.WriteLine($"UWAGA!!!!! kontener o numerze {NumberContainer} zawiera niebezpieczne substancje");
    }

    void Load(double m)
    {
        if (PlynnyType==PlynnyType.niebezpieczny && m > MaximumLoadWeight() * 0.5)
        {
            DangerMessage(ShipSerialNumber);
            throw new Exception("za duza waga dla niebezpiecznego plynu");
        }
        else if (m > MaximumLoadWeight() * 0.9)
        {
            throw new Exception("za duza ogolna waga");
        }
        else
        {
            PackageMassInKg = m;
        }
    }
    
    public override string ToString()
    {
        return $"=====================\nnumer seryjny: {ShipSerialNumber}, \ntyp kontenera: {Type}, \nmasa ladunku: {PackageMassInKg} kg, \nwysokosc: {Height} cm, \nwaga wlasna: {OwnMass} kg, \nglebokosc: {Depth} cm\ntyp substancji: {PlynnyType} \n=====================\n";
    }
    
}