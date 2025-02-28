namespace Latihan5;

public class CarTest
{
    public static void Main()
    {
        MobilSedan mobilSedan = new MobilSedan();
        mobilSedan.jalanMaju();
        mobilSedan.jalanMundur();

        Engine engine = new Engine();
        // engine.gearBox = 10;    // akan error karena variable bersifat private

        Mesin mesin = new Mesin();
        // mesin.rodaGigi = 10;    // akan error karen variable bersifat protected

        MesinBox mesinBox = new MesinBox();
        mesinBox.setRodaGigi(10);
    }
}