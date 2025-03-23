public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Ramdan");

        video.PrintVideoDetails();

        video.IncreasePlayCount(10000000);
        video.PrintVideoDetails();

        // Test overflow
        for (int i = 0; i < 3; i++)
        {
            video.IncreasePlayCount(10000000);
        }

        video.PrintVideoDetails();
    }
}
