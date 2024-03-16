public abstract class BangunRuang{
    public abstract double HitungVolume();
}
public class Balok : BangunRuang{
    private double panjang, lebar;

    public Balok(double panjang, double lebar){
        this.panjang = panjang;
        this.lebar = lebar;
    }
    public override double HitungVolume(){
        return panjang *lebar;
    }
}
public class Kubus : BangunRuang
{
    private double sisi;

    public Kubus(double sisi)
    {
        this.sisi = sisi;
    }

    public override double HitungVolume()
    {
        return Math.Pow(sisi, 3);
    }
}
class Program
{
    static void Main(string[] args)
    {
        BangunRuang balok = new Balok(5,3);
        Console.WriteLine("Volume Balok: " + balok.HitungVolume());
        BangunRuang kubus = new Kubus(5);
        Console.WriteLine("Volume Kubus: " + kubus.HitungVolume());
    }
}
