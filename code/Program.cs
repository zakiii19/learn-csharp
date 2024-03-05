//Qolbul Muzaki
//Microsoft Web & Mobile Developer
//ID 7896979

class Program
{
    static void Main(string[] args)
    {
        string namaLengkap = "Qolbul Muzaki";
        string namaPanggilan = "Zaki";
        string programStudi ="Pendidkan Teknik Informatika dan Komputer";
        string fakultas ="Teknik";
        long nim = 5302421021;
        string jenisKelamin = "Laki-laki";
        string asalDaerah = "Kota semarang";
        int semester = 6;
        decimal ipk = 3.71m;
        int usia = 21;

        Console.WriteLine("Nama Lengkap: "+ namaLengkap);
        Console.WriteLine("Nama Panggilan: "+ namaPanggilan);
        Console.WriteLine("Program Studi: "+ programStudi);
        Console.WriteLine("Fakultas: "+ fakultas);
        Console.WriteLine("NIM: "+ nim);
        Console.WriteLine("Jenis Kelamin: "+jenisKelamin);
        Console.WriteLine("Asal daerah: "+ asalDaerah);
        Console.WriteLine("Semester saat ini: " + semester);
        Console.WriteLine("IPK: " + ipk);
        Console.WriteLine("Usia: "+ usia);

        string welcomeMessage = $"\n\nWelcome, {namaLengkap}!\n\n";
        string bodyEmail = $"Selamat datang di Semester {semester}, ini akan menjadi semester yang penting bagimu.\n";
        bodyEmail += "Kami sangat bersemangat untuk terus bersamamu menjadi bagian dari kemajuan kami yang dinamis dan inovatif.\n";
        bodyEmail += "Jika memiliki pertanyaan atau membutuhkan bantuan apa pun, jangan ragu untuk menghubungi kami.\n\n";
        bodyEmail += $"Salam hangat,\nBidang Akademik dan Kemahasiswaan Fakultas {fakultas}";

        string email = welcomeMessage + bodyEmail;
        Console.WriteLine(email);

    }
}
        //*int firstValue = 600;
        //int secondValue = 500;
        //int largerValue;
       // largerValue= Math.Max(firstValue, secondValue);
       // Console.WriteLine(largerValue);