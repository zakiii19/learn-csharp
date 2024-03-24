//Qolbul Muzaki
//Microsoft Web & Mobile Developer
//ID 7896979
class MainClass
{
    public static void Main(string[] args)
    {
        int[] diceThrows = new int[10];
        Random rand = new Random();

        // Mengisi array dengan lemparan dadu acak
        for (int i = 0; i < diceThrows.Length; i++)
        {
            diceThrows[i] = rand.Next(1, 7);
        }

        Console.WriteLine("Lemparan dadu:");
        
        // Menampilkan lemparan dadu menggunakan foreach
        int throwNumber = 1;
        foreach (int diceThrow in diceThrows)
        {
            Console.WriteLine($"Lemparan dadu {throwNumber}: {diceThrow}");
            throwNumber++;
        }

        Console.WriteLine("\nMenghitung poin:");
        int totalPoints = CalculatePoints(diceThrows);
        Console.WriteLine($"\nJumlah poin yang didapat: {totalPoints}");
    }

    public static int CalculatePoints(int[] throws)
    {
        int totalPoints = 0;
        int totalPointsFromSuccessiveThrows = 0;

        // Loop through each throw using for loop
        for (int index = 2; index < throws.Length; index++)
        {
            int currentThrow = throws[index];
            int previousThrow = throws[index - 1];
            int previousThrow2 = throws[index - 2];

            int currentPoints = currentThrow + previousThrow;

            if (Math.Abs(currentThrow - previousThrow) == 1)
            {
                totalPoints += currentPoints;
                totalPointsFromSuccessiveThrows += currentPoints;

                Console.WriteLine($"Poin tambahan didapat dari lemparan dadu {index + 1} dan {index}: {currentPoints}");
            }

            if (currentThrow == previousThrow && currentThrow == previousThrow2)
            {
                totalPoints += 10;
                Console.WriteLine($"Poin bonus didapat dari poin lemparan dadu {index - 1}, {index}, dan {index + 1}: 10");
            }
        }
        return totalPoints;
    }
}
