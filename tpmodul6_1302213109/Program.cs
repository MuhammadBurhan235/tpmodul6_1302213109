using tpmodul6_1302213109;
public class Program
{
    public static void Main(string[] args)
    {


        string videoTitle = "Tutorial Design By Contract - Muhammad Burhan";
        SayaTubeVideo myVideo = new SayaTubeVideo(videoTitle);
        myVideo.IncreasePlayCount(1000);
        for (int i = 0; i < 20000000; i += 10000000)
        {
            try
            {
                myVideo.IncreasePlayCount(10000000);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                break;
            }
        }
        myVideo.PrintVideoDetails();

        Console.ReadLine();
    }
}