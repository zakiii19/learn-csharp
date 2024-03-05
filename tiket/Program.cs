//Qolbul Muzaki
//Microsoft Web & Mobile Developer
//ID 7896979
class Program
{
    static void Main(string[] args)
    {
        // Data tiket
        string nama = "Dono Kasino";
        string id = "32901270950002";
        string noKursi = "2/7A";
        string stasiun = "STASIUN AMBAR";
        DateTime waktuBerangkat = new DateTime(2023, 3, 8, 10, 0, 0);
        DateTime waktuTiba = waktuBerangkat.AddMinutes(30); // menambah 30 menit dari berangkat

        // Cetak tiket 
        Console.WriteLine("BOARDING PASS WISATA KERETA\n");
        Console.WriteLine($"Nama/name : {nama}");
        Console.WriteLine($"Nomor Identitas :  id}");
        Console.WriteLine($"Nomor Kursi : {noKursi}\n");
        Console.WriteLine("Berangkat");
        Console.WriteLine($"{stasiun} / {waktuBerangkat.ToString("dd MMM yyyy HH:mm")} WIB\n");
        Console.WriteLine("Perkiraan Tiba");
        Console.WriteLine($"{stasiun} / {waktuTiba.ToString("dd MMM yyyy HH:mm")} WIB\n");
        Console.WriteLine("Wajib menunjukkan bukti identitas asli pada saat boarding dan pemeriksaan di kereta api.");
    }
}
