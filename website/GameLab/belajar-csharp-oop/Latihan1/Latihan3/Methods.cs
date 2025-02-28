namespace Latihan2;

public class Methods
{
    static int luasPersegi(int lebar)
    {
        int luas = lebar * lebar;
        return luas;
    }

    public static void Main()
    {
        int luas1 = luasPersegi(10);
        int luas2 = luasPersegi(20);
        int luas3 = luasPersegi(30);
        
        Console.WriteLine("luas = " + luas1);
        Console.WriteLine("luas = " + luas2);
        Console.WriteLine("luas = " + luas3);
    }
}