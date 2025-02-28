namespace Latihan15;

public class OverloadImpl
{
    public static void Main()
    {
        Hero hero = new Hero();
        hero.fire();
        hero.fire(2);
        hero.fire(2, 1.5f);
    }
}