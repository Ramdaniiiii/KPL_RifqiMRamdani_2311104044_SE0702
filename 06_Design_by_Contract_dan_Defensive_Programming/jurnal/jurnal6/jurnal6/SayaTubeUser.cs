using System;
using System.Collections.Generic;

public class SayaTubeUser
{
    private int id;
    private string username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        if (string.IsNullOrEmpty(username) || username.Length > 100)
            throw new ArgumentException("Username tidak boleh kosong dan maksimal 100 karakter.");

        this.id = new Random().Next(10000, 99999); // ID random 5 digit
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null)
            throw new ArgumentNullException("Video yang ditambahkan tidak boleh null.");

        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.GetPlayCount();
        }
        return total;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {username}");
        int count = 0;
        foreach (var video in uploadedVideos)
        {
            if (count >= 8) break; // Maksimal 8 video ditampilkan
            Console.WriteLine($"Video {count + 1} judul: {video.GetTitle()}");
            count++;
        }
    }
}
