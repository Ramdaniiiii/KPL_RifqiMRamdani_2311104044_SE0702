using System;

class Program
{
    static void Main()
    {
        // Menjalankan KodePos lebih dulu
        Console.WriteLine("=== KodePos ===");
        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();
        string kodePos = KodePos.GetKodePos(kelurahan);
        Console.WriteLine($"Kode Pos {kelurahan}: {kodePos}");

        // Menjalankan DoorMachine setelah KodePos
        Console.WriteLine("\n=== DoorMachine ===");
        DoorMachine door = new DoorMachine(); // Pintu awal terkunci
        door.Toggle(); // Membuka pintu
        door.Toggle(); // Mengunci kembali
    }
}
