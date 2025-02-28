namespace Latihan15;

public class Hero
{
    public void fire()
    {
        Console.WriteLine("Hero fire!");
    }

    public void fire(int numOfRocket)
    {
        Console.WriteLine($"Hero fire with {numOfRocket} of Rockets");
    }

    public void fire(int numOfRocket, float scale)
    {
        Console.WriteLine($"Hero fire with {numOfRocket} of Rockets and with scale {scale}");
    }
}