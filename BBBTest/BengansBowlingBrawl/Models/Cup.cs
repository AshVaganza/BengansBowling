using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowlingBrawl.Models
{
    class Cup
    {
        public int Id { get; set; }
        public List<Spelare> Spelare { get; set; }
        public List<Match> Matches { get; set; }
        public string CupNamn { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime SlutDatum { get; set; }
        public Spelare Vinnare { get; set; }
    }
}
