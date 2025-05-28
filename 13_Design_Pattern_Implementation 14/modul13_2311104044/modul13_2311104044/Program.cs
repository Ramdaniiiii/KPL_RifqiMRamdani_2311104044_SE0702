using System;
using System.Collections.Generic;

public class PusatDataSingleton
{
    private static PusatDataSingleton _instance;
    public List<string> DataTersimpan;

    private PusatDataSingleton()
    {
        DataTersimpan = new List<string>();
    }

    public static PusatDataSingleton GetDataSingleton()
    {
        if (_instance == null)
        {
            _instance = new PusatDataSingleton();
        }
        return _instance;
    }

    public List<string> GetSemuaData()
    {
        return DataTersimpan;
    }

    public void PrintSemuaData()
    {
        foreach (var data in DataTersimpan)
        {
            Console.WriteLine(data);
        }
    }

    public void AddSebuahData(string input)
    {
        DataTersimpan.Add(input);
    }

    public void HapusSebuahData(int index)
    {
        if (index >= 0 && index < DataTersimpan.Count)
        {
            DataTersimpan.RemoveAt(index);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Inisialisasi Singleton
        var data1 = PusatDataSingleton.GetDataSingleton();
        var data2 = PusatDataSingleton.GetDataSingleton();

        // Tambah data anggota dan asprak
        data1.AddSebuahData("Ramdani");
        data1.AddSebuahData("Gideon");
        data1.AddSebuahData("Devrin");

        Console.WriteLine("Data2 sebelum penghapusan:");
        data2.PrintSemuaData(); // Menampilkan semua data

        // Hapus data asisten (misalnya hapus 'Gideon')
        data2.HapusSebuahData(1); // Gideon ada di index ke-1

        Console.WriteLine("\nData1 setelah penghapusan:");
        data1.PrintSemuaData(); // Gideon sudah tidak ada

        // Tampilkan jumlah data
        Console.WriteLine($"\nJumlah data di data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah data di data2: {data2.GetSemuaData().Count}");
    }
}
