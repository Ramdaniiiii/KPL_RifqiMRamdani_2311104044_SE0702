using System;
using System.Collections.Generic;

namespace modul5_2311104044
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menjalankan Generic Method (Penjumlahan)
            Penjumlahan<double> penjumlahan = new Penjumlahan<double>();
            double hasil = penjumlahan.JumlahTigaAngka(23, 11, 10);
            Console.WriteLine($"Hasil penjumlahan: {hasil}");

            Console.WriteLine(); // Spasi antar output

            // Menjalankan Generic Class (SimpleDataBase)
            SimpleDataBase<int> database = new SimpleDataBase<int>();
            database.AddNewData(23);
            database.AddNewData(11);
            database.AddNewData(10);
            database.PrintAllData();

            Console.ReadLine();
        }
    }
}
