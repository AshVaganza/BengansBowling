using BengansBowlingBrawl.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowlingBrawl.Factory
{
    class GameHandler
    {
        public void createGame(Spelare sp1, Spelare sp2)
        {
            var match = new Match(sp1, sp2);
        }
    }
}
