namespace Latihan11;

public class HierarchicalInheritance
{
    public static void Main()
    {
        AndroidSystemFont android = new AndroidSystemFont();
        android.reshowText();

        WindowsSystemFont windows = new WindowsSystemFont();
        windows.reshowText();

        GameBitmapFont game = new GameBitmapFont();
        game.reshowText();

        AppsBitmapFont apps = new AppsBitmapFont();
        apps.reshowText();
    }
}