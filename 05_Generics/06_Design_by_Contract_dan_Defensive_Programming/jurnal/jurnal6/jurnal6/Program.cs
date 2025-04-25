using System;

class Program
{
    static void Main()
    {
        try
        {
            SayaTubeUser user = new SayaTubeUser("Ramdani");

            SayaTubeVideo video1 = new SayaTubeVideo("Review Film Interstellar oleh Ramdani");
            SayaTubeVideo video2 = new SayaTubeVideo("Review Film Inception oleh Ramdani");

            video1.IncreasePlayCount(1000);
            video2.IncreasePlayCount(2000);

            user.AddVideo(video1);
            user.AddVideo(video2);

            user.PrintAllVideoPlaycount();
            Console.WriteLine($"Total Play Count: {user.GetTotalVideoPlayCount()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
