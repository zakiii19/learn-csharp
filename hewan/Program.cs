class Hewan
{
    public string Makanan { get; set; }
    public int JumlahKaki { get; set; }

    public Hewan(string makanan, int jumlahKaki)
    {
        Makanan = makanan;
        JumlahKaki = jumlahKaki;
    }

    public virtual void Bersuara()
    {
        Console.WriteLine("Hewan ini bersuara.");
    }
}

class Kucing : Hewan
{
    public Kucing(string makanan, int jumlahKaki) : base(makanan, jumlahKaki)
    {
    }

    public override void Bersuara()
    {
        Console.WriteLine("Meow!");
    }
}

class Anjing : Hewan
{
    public Anjing(string makanan, int jumlahKaki) : base(makanan, jumlahKaki)
    {
    }
    public override void Bersuara()
    {
        Console.WriteLine("Woof!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Kucing kucing = new Kucing("ikan", 4);
        Console.WriteLine("Makanan Kucing: " + kucing.Makanan);
        Console.WriteLine("Berkaki: " + kucing.JumlahKaki);
        kucing.Bersuara();
        Console.WriteLine();
        Anjing anjing = new Anjing("Daging", 4);
        Console.WriteLine("Makanan Anjing: " + anjing.Makanan);
        Console.WriteLine("Berkaki: " + anjing.JumlahKaki);
        anjing.Bersuara();
    }
}
