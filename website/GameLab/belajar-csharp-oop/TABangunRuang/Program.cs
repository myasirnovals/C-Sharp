namespace TABangunRuang;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Kerucut ===");
        Console.Write("Masukan radius: ");
        double radius = double.Parse(Console.ReadLine());

        Console.Write("Masukan tinggi: ");
        double tinggiKerucut = double.Parse(Console.ReadLine());

        Kerucut kerucut = new Kerucut(radius, tinggiKerucut);

        Console.WriteLine($"Volume kerucut: {kerucut.hitungVolume()}");
        Console.WriteLine($"Luas kerucut: {kerucut.hitungLuas()}");

        Console.WriteLine("\n=== Kubus ===");
        Console.Write("Masukan sisi: ");
        double sisi = double.Parse(Console.ReadLine());

        Kubus kubus = new Kubus(sisi);

        Console.WriteLine($"Volume kubus: {kubus.hitungVolume()}");
        Console.WriteLine($"Luas kubus: {kubus.hitungLuas()}");

        Console.WriteLine("\n=== Balok ===");
        Console.Write("Masukan panjang: ");
        double panjang = double.Parse(Console.ReadLine());

        Console.Write("Masukan lebar: ");
        double lebar = double.Parse(Console.ReadLine());

        Console.Write("Masukan tinggi: ");
        double tinggiBalok = double.Parse(Console.ReadLine());

        Balok balok = new Balok(panjang, lebar, tinggiBalok);

        Console.WriteLine($"Volume balok: {balok.hitungVolume()}");
        Console.WriteLine($"Luas balok: {balok.hitungLuas()}");
    }
}