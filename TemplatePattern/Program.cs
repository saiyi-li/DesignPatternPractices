using System;

namespace TemplatePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new Cricket();
            game.Play();
            Console.WriteLine("");
            game = new Football();
            game.Play();

            Console.Read();
        }
    }
}
