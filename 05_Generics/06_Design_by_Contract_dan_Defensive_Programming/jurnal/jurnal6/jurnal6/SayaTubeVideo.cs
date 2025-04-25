using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 200)
            throw new ArgumentException("Judul video tidak boleh kosong dan maksimal 200 karakter.");

        this.id = new Random().Next(10000, 99999); // ID random 5 digit
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0 || count > 25000000)
            throw new ArgumentOutOfRangeException("Play count harus antara 0 hingga 25 juta.");

        if (this.playCount + count > int.MaxValue)
            throw new OverflowException("Total play count melebihi batas integer.");

        this.playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }

    public int GetPlayCount()
    {
        return this.playCount;
    }

    public string GetTitle()
    {
        return this.title;
    }
}
