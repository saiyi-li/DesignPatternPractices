using System;

namespace TemplatePattern
{
    public class Football: Game
    {
        public override void Initialize()
        {
            Console.WriteLine("Football Game Finished");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Football Game Initialized! Start Playing. ");
        }

        public override void EndPlay()
        {
            Console.WriteLine("Football Game Started. Enjoy the game!");
        }
    }
}
