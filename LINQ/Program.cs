namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>();

            videoGames.Add("Fallout");
            videoGames.Add("Skyrim");
            videoGames.Add("Call of Duty");
            videoGames.Add("The Witcher");
            videoGames.Add("The Last of Us");
            videoGames.Add("God of War");

           videoGames.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            
        }
    }
}
