using BengansBowlingBrawl.Facade;
using BengansBowlingBrawl.Models;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace BBBTest
{
    public class UnitTest1
    {
        private PersonData _personBank;
        private CupResultData _cupResultData;
        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void ListPlayers()
        {
            _personBank = new PersonData();

            foreach (var item in _personBank.medlemsLista())
            {
                output.WriteLine($"Id: {item.Id}, Namn: {item.Name}");
            }
        }

        //[Fact]
        //public void StartaCup()
        //{
        //    _personBank = new PersonData();
        //    int count = 1;
        //    var grupp1 = new List<Spelare>();
        //    var grupp2 = new List<Spelare>();

        //    foreach (var spelare in _personBank.medlemsLista())
        //    {
        //        if (spelare.Id % 2 == 0)
        //        {
        //            grupp1.Add(spelare);
        //        }
        //        else
        //        {
        //            grupp2.Add(spelare);
        //        }
        //    }

        //    var sp1 = new Spelare();
        //    var sp2 = new Spelare();

        //    foreach (var item in grupp1)
        //    {
        //        if (count == 1)
        //        {
        //            sp1 = item;
        //        }
        //        else
        //        {
        //            sp2 = item;
        //            var match = new Match(sp1, sp2);
        //        }

        //        count++;
        //        if (count == 2)
        //        {
        //            count = 0;
        //        }
        //    }
        //    //Varje två personer i en lista ska hamna i en match, via en count.

        //}

        [Fact]
        public void WinnerOfTheYear()
        {
            _cupResultData = new CupResultData();
            var winner = _cupResultData.GetYearWinner();
            output.WriteLine($"Årets champion är: {winner}");
        }
    }
}
