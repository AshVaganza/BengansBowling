using BengansBowlingBrawl.Models;
using System;

namespace BengansBowlingBrawl.Facade
{
    public class GameLogic
    {
        public void newOpponentCheck()
        {
            var playerOne = new Spelare();
            var playerTwo = new Spelare();

            var match = new Match(playerOne,playerTwo);
        }

        public void ruleCheck()
        {
            var p1 = new Spelare();

            //Antalet matcher spelade
            if (p1.Id >= 10)
            {
                Console.WriteLine("Inte kvalificerad");
            }
        }

        public void getCupWinner()
        {

        }
    }
}
