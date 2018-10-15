using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowlingBrawl.Models
{
    class Match
    {
        public int Id { get; set; }
        public Spelare Spelare1 { get; set; }
        public Spelare Spelare2 { get; set; }
        public List<Serie> Serier { get; set; }

        public Spelare Vinnare()
        {

            return null;
        }
    }
}
