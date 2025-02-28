namespace Latihan7;

public class TestLatihan7
{
    public static void Main()
    {
        Console.WriteLine(Orang.nama);

        Mobil.roda = 4;
        Console.WriteLine(Mobil.roda);
        
        Game.getInstance().playGame();
        Game.getInstance().endGame();
    }
}