namespace Latihan13;

public class Cat : IAnimal
{
    public void eat()
    {
        Console.WriteLine("Cat eat()");
    }

    public void walk()
    {
        Console.WriteLine("Cat walk()");
    }

    public void sleep()
    {
        Console.WriteLine("Cat sleep()");
    }
}