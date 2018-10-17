using BengansBowlingBrawl.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowlingBrawl.Facade
{
    class PersonData
    {
        public List<Spelare> DeltagarLista = new List<Spelare>();

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
