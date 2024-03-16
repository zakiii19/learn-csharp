public abstract class Food
{
    public abstract void Info();
    public abstract double Calculate();
}
public class Burger : Food
{
    public override void Info()
    {
        Console.WriteLine("Burger - 20000");
    }
    public override double Calculate()
    {
        return 20000;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Food burger = new Burger();
        burger.Info();
        Console.WriteLine($"Total Harga: Rp.{burger.Calculate()}");
    }
}
