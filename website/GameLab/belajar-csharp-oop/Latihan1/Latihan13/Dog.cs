namespace Latihan13;

public class Dog : IAnimal
{
    public void eat()
    {
        Console.WriteLine("Dog eat()");
    }

    public void walk()
    {
        Console.WriteLine("Dog walk()");
    }

    public void sleep()
    {
        Console.WriteLine("Dog sleep()");
    }
}