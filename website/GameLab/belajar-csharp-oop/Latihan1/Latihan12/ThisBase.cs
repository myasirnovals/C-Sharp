namespace Latihan12;

public class ThisBase
{
    public static void Main()
    {
        ShooterGame game = new ShooterGame();
        game.setTimer(10);
        game.setBaseTimer(20);
        
        Console.WriteLine($"this timer = {game.getTimer()}");
        Console.WriteLine($"base timer = {game.getBaseTimer()}");
    }
}