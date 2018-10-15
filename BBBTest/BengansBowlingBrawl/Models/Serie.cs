using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowlingBrawl.Models
{
    class Serie
    {
        public int Id { get; set; }
        public Spelare Spelare1 { get; set; }
        public Spelare Spelare2 { get; set; }
        public Rond Rond1 { get; set; }
        public Rond Rond2 { get; set; }
    }
}
