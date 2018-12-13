using System;

namespace FinalProject
{
    class Program
    {
        public static int PowerLevel { get; private set; }

        static void Main(string[] args)
        {
            Hero myHero = new Hero("Hulk", "Strength", "Speed", "Jump" );
            Hero myOtherHero = new Hero("Flash", "Zoom", "Human", "Speed", true);
            Hero thirdHero = new Hero("Wonder Woman", "All bad people", "Amazonian", "Stength, Speed, Fly");
            myHero.PowerLevel = 50;
            /*
                Problem 7:
                Each Hero must:
                 - ChargePower (as much as you want)
                 - Investigate
                 - FightCrime (at least one must win. at least one must not win)
                 - Fly (at least one superhero should be able to fly)
                 - Climb
            */
    
            myHero.ChargePower(65);
            myHero.Investigate();
            myHero.FightCrime("city hall and won");
            myHero.Fly();
            myHero.Climb(10);
            myOtherHero.ChargePower();
            myOtherHero.Investigate();
            myOtherHero.FightCrime("city hall and lost");
            myOtherHero.Climb(100);
            thirdHero.ChargePower(10);
            thirdHero.Investigate();
            thirdHero.FightCrime("city hall and won");
            thirdHero.Fly();
            thirdHero.Climb(50);
        }
    }
}
