class Program
{
    static void Main()
    {
        // Menampilkan kode buah
        Console.WriteLine("Kode buah Apel: " + KodeBuah.GetKodeBuah("Apel"));
        Console.WriteLine("Kode buah Melon: " + KodeBuah.GetKodeBuah("Melon"));

        // Simulasi perubahan posisi karakter
        PosisiKarakterGame karakter = new PosisiKarakterGame();
        karakter.TombolW(); // Take Off jika awalnya berdiri
        karakter.TombolS(); // Landing jika sedang terbang
    }
}
