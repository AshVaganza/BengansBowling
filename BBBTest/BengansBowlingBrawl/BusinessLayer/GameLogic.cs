using BengansBowlingBrawl.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowlingBrawl.BusinessLayer
{
    class GameLogic
    {
        public void newOpponentCheck()
        {
            var playerOne = new Spelare();
            var playerTwo = new Spelare();

            var match = new Match(playerOne,playerTwo);
        }

        public void ruleCheck() { }
    }
}
