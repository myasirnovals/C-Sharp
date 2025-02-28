namespace Latihan14;

public class AbstractImpl
{
    public static void Main()
    {
        Shape rectangle = new Rectangle();
        rectangle.setWidth(20);
        rectangle.setHeight(30);

        Shape triangle = new Triangle();
        triangle.setWidth(20);
        triangle.setHeight(20);
        
        Console.WriteLine($"Reactangle area = {rectangle.getArea()}");
        Console.WriteLine($"Triangle area = {triangle.getArea()}");
    }
}