namespace TABangunRuang;

public class Kerucut : BangunRuang
{
    private double radius;
    private double tinggi;

    public Kerucut(double radius, double tinggi)
    {
        this.radius = radius;
        this.tinggi = tinggi;
    }

    public double getRadius()
    {
        return radius;
    }

    public void setRadius(double radius)
    {
        this.radius = radius;
    }
    
    public double getTinggi()
    {
        return radius;
    }

    public void setTinggi(double tinggi)
    {
        this.tinggi = tinggi;
    }

    public override double hitungVolume()
    {
        return (1.0 / 3) * Math.PI * Math.Pow(radius, 2) * tinggi;
    }

    public override double hitungLuas()
    {
        // menghitung garis pelukis
        double pelukis = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(tinggi, 2));

        return Math.PI * radius * (radius + pelukis);
    }
}