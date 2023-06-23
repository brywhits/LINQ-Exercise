using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGameNames = new List<string>()
            {
                "Zelda",
                "Mario",
                "Avengers",
                "SpiderMan",
                "Batman",
                "Joker"
            };

            var gameList = videoGameNames.OrderBy(game => game.Length).ToList();

            gameList.ForEach(game => Console.WriteLine(game));
        }
    }
}
