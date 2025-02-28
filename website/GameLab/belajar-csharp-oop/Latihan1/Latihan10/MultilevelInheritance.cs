namespace Latihan10;

public class MultilevelInheritance
{
    public static void Main()
    {
        Vehicle vehicle = new Vehicle();
        vehicle.applyBrakes();

        Bus bus = new Bus();
        bus.applyBrakes();
        bus.applyHorn();

        LongBus longBus = new LongBus();
        longBus.applyBrakes();
        longBus.applyHorn();
        longBus.applyDrift();
    }
}