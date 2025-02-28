namespace Latihan6;

public class TestBentuk
{
    public static void Main()
    {
        Bentuk bentuk = new Bentuk();
        Console.WriteLine($"Sisi bentuk = {bentuk.getSisi()}");

        Bentuk segitiga = new Bentuk(3);
        Console.WriteLine($"Segitiga, sisinya = {segitiga.getSisi()}");
        
        Bentuk trapesium = new Bentuk(4);
        Console.WriteLine($"Trapesium, sisinya = {trapesium.getSisi()}");
        
        Bentuk lingkaran = new Bentuk(0);
        Console.WriteLine($"Lingkaran, sisinya = {lingkaran.getSisi()}");

        Persegi persegi = new Persegi(20);
        Console.WriteLine($"Luas Persegi = {persegi.getLuas()}");
    }
}