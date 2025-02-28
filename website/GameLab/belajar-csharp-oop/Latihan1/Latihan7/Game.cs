namespace Latihan7;

public class Game
{
    private static Game singleton = null;

    /*Constructor*/
    private Game()
    {
    }

    public static Game getInstance()
    {
        if (singleton == null)
        {
            singleton = new Game();
        }

        return singleton;
    }

    public void playGame()
    {
        Console.WriteLine("Game is played");
    }

    public void endGame()
    {
        Console.WriteLine("Game is ended");
    }
}