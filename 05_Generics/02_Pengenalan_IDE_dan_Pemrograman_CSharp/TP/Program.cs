using System;

class Program
{
    static void Main()
    {
        // 1. Input satu karakter
        Console.Write("Masukkan satu huruf: ");
        char huruf = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();  // Pindah ke baris baru

        // Cek apakah vokal atau konsonan
        if ("AIUEO".Contains(huruf))
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf vokal.");
        }
        else
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf konsonan.");
        }

        Console.WriteLine(); // Spasi antar output

        // 2. Array Bilangan Genap
        int[] bilanganGenap = { 2, 4, 6, 8, 10 };

        Console.WriteLine("Bilangan genap:");
        for (int i = 0; i < bilanganGenap.Length; i++)
        {
            Console.WriteLine($"Angka genap {i + 1} : {bilanganGenap[i]}");
        }
    }
}
