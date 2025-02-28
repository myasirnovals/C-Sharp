namespace TABangunRuang;

public class Kubus : BangunRuang
{
    private double sisi;

    public Kubus(double sisi)
    {
        this.sisi = sisi;
    }

    public double getSisi()
    {
        return sisi;
    }

    public void setSisi(double sisi)
    {
        this.sisi = sisi;
    }
    
    public override double hitungVolume()
    {
        return Math.Pow(sisi, 3);
    }

    public override double hitungLuas()
    {
        return 6 * Math.Pow(sisi, 2);
    }
}