using BengansBowlingBrawl.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BengansBowlingBrawl.Facade
{
    public class CupResultData
    {
        private List<Cup> _cup;
        private PersonData _spelare;

        public List<Cup> GetCupResult()
        {
            _spelare = new PersonData();
            _cup = new List<Cup>();

            var players = _spelare.medlemsLista();
            var enCup = new Cup()
            {
                Id = 1,
                CupNamn = "Sommar Cupen",
                StartDatum = new DateTime(2018, 6, 1),
                SlutDatum = new DateTime(2018, 8, 15),
                Vinnare = (from s in players
                           where s.Id == 1
                           select s).FirstOrDefault()
            };
            _cup.Add(enCup);

            enCup = new Cup()
            {
                Id = 2,
                CupNamn = "Vår Cupen",
                StartDatum = new DateTime(2018, 3, 1),
                SlutDatum = new DateTime(2018, 6, 15),
                Vinnare = (from s in players
                           where s.Id == 7
                           select s).FirstOrDefault()
            };
            _cup.Add(enCup);

            enCup = new Cup()
            {
                Id = 3,
                CupNamn = "Höst Cupen",
                StartDatum = new DateTime(2018, 8, 15),
                SlutDatum = new DateTime(2018, 10, 30),
                Vinnare = (from s in players
                           where s.Id == 1
                           select s).FirstOrDefault()
            };
            _cup.Add(enCup);

            return _cup;
        }

        public string GetYearWinner()
        {
            var cupList = GetCupResult();
            List<int> winners = new List<int>();
            

            foreach (var spelare in cupList)
            {
                winners.Add(spelare.Vinnare.Id);
            }

            var query = winners.GroupBy(r => r)
                .Select(grp => new
                {
                    Value = grp.Key,
                    Count = grp.Count()
                });

            int result = (from q in query
                             select q.Value).FirstOrDefault();

            string vinnare = (from v in cupList
                             where v.Vinnare.Id == result
                             select v.Vinnare.Name).FirstOrDefault();

            return vinnare;
        }
    }
}
