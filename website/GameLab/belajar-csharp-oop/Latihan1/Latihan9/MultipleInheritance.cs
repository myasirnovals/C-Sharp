namespace Latihan9;

public class MultipleInheritance
{
    public static void Main()
    {
        Vehicle vehicle = new Vehicle();
        vehicle.fuelAmount();
        vehicle.capacity();
        vehicle.applyBreaks();
        
        Bus bus = new Bus();
        bus.fuelAmount();
        bus.capacity();
        bus.applyBreaks();
        
        Car car = new Car();
        car.fuelAmount();
        car.capacity();
        car.applyBreaks();
        
        Truck truck = new Truck();
        truck.fuelAmount();
        truck.capacity();
        truck.applyBreaks();
    }
}