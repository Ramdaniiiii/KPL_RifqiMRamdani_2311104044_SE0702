using System;
using System.IO;
using System.Text.Json;

public class Nama
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

public class DataMahasiswa2311104044
{
    public Nama nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }

    public static void ReadJSON()
    {
        string filePath = "jurnal7_1_2311104044.json"; // ← ini udah disesuaikan

        try
        {
            string jsonData = File.ReadAllText(filePath);
            var data = JsonSerializer.Deserialize<DataMahasiswa2311104044>(jsonData);

            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan NIM {data.nim} dari fakultas {data.fakultas}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Terjadi error:");
            Console.WriteLine(ex.Message);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa2311104044.ReadJSON();
    }
}
