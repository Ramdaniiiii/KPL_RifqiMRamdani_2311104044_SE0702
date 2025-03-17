using System;

namespace tpmodul5_2311104044
{
    class HaloGeneric
    {
        // Method generic yang menerima parameter tipe T
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }

    class DataGeneric<T>
    {
        private T data;

        // Konstruktor menerima parameter generic
        public DataGeneric(T data)
        {
            this.data = data;
        }

        // Method untuk mencetak data
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {data}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Pemanggilan method generic dengan nama panggilan Ramdan
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser("Ramdan");

            // Penggunaan class generic dengan NIM 2311104044
            DataGeneric<string> dataNIM = new DataGeneric<string>("2311104044");
            dataNIM.PrintData();

            Console.ReadLine();
        }
    }
}
