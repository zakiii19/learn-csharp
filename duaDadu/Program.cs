//Qolbul Muzaki
//Microsoft Web & Mobile Developer
//ID 7896979
public abstract class Dadu
{
    public abstract int LemparDadu();
}
public class DaduStandar : Dadu
{
    private Random _random = new Random();

    public override int LemparDadu()
    {
        return _random.Next(1, 7);
    }
}
public class PermainanDadu
{
    private Dadu _dadu1;
    private Dadu _dadu2;
    private Dadu _dadu3;
    private Dadu _dadu4;

    public PermainanDadu()
    {
        _dadu1 = new DaduStandar();
        _dadu2 = new DaduStandar();
        _dadu3 = new DaduStandar();
        _dadu4 = new DaduStandar();
    }

    public void Mainkan()
    {
        int totalPoin = 0;

        // Lempar dadu dan hitung total poin
        for (int i = 1; i <= 4; i++)
        {
            int hasilLemparan = LemparDadu(i);
            totalPoin += hasilLemparan;

            Console.WriteLine($"Lemparan dadu {i} :{hasilLemparan}");
        }

        // Hitung bonus
        int bonus12 = HitungBonus12();
        int bonus34 = HitungBonus34();
        int bonusSelisih = HitungBonusSelisih();
        int bonusSisaBagi = HitungBonusSisaBagi();

        totalPoin += bonus12 + bonus34 + bonusSelisih + bonusSisaBagi;

        // Tampilkan hasil
        Console.WriteLine();
        Console.WriteLine($"Jumlah poin yang didapat :{totalPoin}");
        Console.WriteLine($"{bonus12} poin dari bonus lemparan dadu 1 dan 2");
        Console.WriteLine($"{bonus34} poin dari bonus lemparan dadu 3 dan 4");
        Console.WriteLine($"{bonusSelisih} poin dari bonus lemparan dadu 1 dan 3");
        Console.WriteLine($"{bonusSisaBagi} poin dari bonus lemparan dadu 2 dan 4");
    }

    private int LemparDadu(int nomorDadu)
    {
        switch (nomorDadu)
        {
            case 1:
                return _dadu1.LemparDadu();
            case 2:
                return _dadu2.LemparDadu();
            case 3:
                return _dadu3.LemparDadu();
            case 4:
                return _dadu4.LemparDadu();
            default:
                return 0;
        }
    }

    private int HitungBonus12()
    {
        int hasilDadu1 = _dadu1.LemparDadu();
        int hasilDadu2 = _dadu2.LemparDadu();

        return (hasilDadu1 + hasilDadu2) == 12 ? 2 : 0;
    }
    private int HitungBonus34()
    {
        int hasilDadu3 = _dadu3.LemparDadu();
        int hasilDadu4 = _dadu4.LemparDadu();

        return (hasilDadu3 + hasilDadu4) == 12 ? 2 : 0;
    }

    private int HitungBonusSelisih()
    {
        int hasilDadu1 = _dadu1.LemparDadu();
        int hasilDadu3 = _dadu3.LemparDadu();

        return Math.Abs(hasilDadu1 - hasilDadu3) == 2 ? 1 : 0;
    }

    private int HitungBonusSisaBagi()
    {
        int hasilDadu2 = _dadu2.LemparDadu();
        int hasilDadu4 = _dadu4.LemparDadu();

        return hasilDadu2 % hasilDadu4 == 0 ? 1 : 0;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        PermainanDadu permainan = new PermainanDadu();
        permainan.Mainkan();
    }
}
