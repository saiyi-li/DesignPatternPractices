using System;

namespace TemplatePattern
{
    public class Cricket: Game
    {
        public override void Initialize()
        {
            Console.WriteLine("Cricket Game Finished");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Cricket Game Initialized! Start Playing. ");
        }

        public override void EndPlay()
        {
            Console.WriteLine("Cricket Game Started. Enjoy the game!");
        }
    }
}
