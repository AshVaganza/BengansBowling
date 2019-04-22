using BengansBowlingBrawl.Models;
using System.Collections.Generic;

namespace BengansBowlingBrawl.Facade
{
    public class PersonData
    {
        public List<Spelare> DeltagarLista = new List<Spelare>();

        public void AddPerson(string name)
        {
            var nyPerson = new Spelare()
            {
                Id = (medlemsLista().Count + 1),
                Name = name
            };

            medlemsLista();

            DeltagarLista.Add(nyPerson);
        }

        public List<Spelare> medlemsLista()
        {
            var spelare = new Spelare
            {
                Id = 1,
                Name = "Ahmad"
            };
            DeltagarLista.Add(spelare);

            spelare = new Spelare
            {
                Id = 2,
                Name = "Marcus"
            };
            DeltagarLista.Add(spelare);

            spelare = new Spelare
            {
                Id = 3,
                Name = "Kerstin"
            };
            DeltagarLista.Add(spelare);

            spelare = new Spelare
            {
                Id = 4,
                Name = "Peter"
            };
            DeltagarLista.Add(spelare);

            spelare = new Spelare
            {
                Id = 5,
                Name = "Petra"
            };
            DeltagarLista.Add(spelare);

            spelare = new Spelare
            {
                Id = 6,
                Name = "Cornelia"
            };
            DeltagarLista.Add(spelare);

            spelare = new Spelare
            {
                Id = 7,
                Name = "Arthur"
            };
            DeltagarLista.Add(spelare);

            spelare = new Spelare
            {
                Id = 8,
                Name = "Marvel"
            };
            DeltagarLista.Add(spelare);

            return DeltagarLista;
        }
    }
}
