class PosisiKarakterGame
{
    public enum Posisi { Berdiri, Jongkok, Tengkurap, Terbang }
    private Posisi posisiSaatIni;

    public PosisiKarakterGame()
    {
        posisiSaatIni = Posisi.Berdiri;
    }

    public void TombolW()
    {
        if (posisiSaatIni == Posisi.Berdiri)
        {
            posisiSaatIni = Posisi.Terbang;
            Console.WriteLine("Posisi Take Off");
        }
        else if (posisiSaatIni == Posisi.Jongkok)
        {
            posisiSaatIni = Posisi.Berdiri;
            Console.WriteLine("Posisi Standby");
        }
    }

    public void TombolS()
    {
        if (posisiSaatIni == Posisi.Terbang)
        {
            posisiSaatIni = Posisi.Jongkok;
            Console.WriteLine("Posisi Landing");
        }
        else if (posisiSaatIni == Posisi.Berdiri)
        {
            posisiSaatIni = Posisi.Jongkok;
            Console.WriteLine("Posisi Istirahat");
        }
    }
}

// Program Utama
