namespace Latihan8;

public class SingleInheritance
{
    public static void Main()
    {
        Vehicle vehicle = new Vehicle();
        vehicle.applyBreaks();

        Bus bus = new Bus();
        bus.applyBreaks();
    }
}