class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] hasilLemparan = new int[3];
        int lemparanKe = 0;
        foreach (int nilai in hasilLemparan)
        {
            int dadu1 = random.Next(1, 7); 
            int dadu2 = random.Next(1, 7);
            int dadu3 = random.Next(1, 7);
            Console.WriteLine($"Lemparan {lemparanKe + 1}: Dadu pertama = {dadu1}, Dadu kedua = {dadu2}, Dadu ketiga = {dadu3}");
            hasilLemparan[lemparanKe] = dadu1 + dadu2 + dadu3;
            lemparanKe++;
        }
        int totalNilai = 0;
        foreach (int nilai in hasilLemparan)
        {
            totalNilai += nilai;
        }
        Console.WriteLine($"Total Nilai: {totalNilai}");
    }
}
