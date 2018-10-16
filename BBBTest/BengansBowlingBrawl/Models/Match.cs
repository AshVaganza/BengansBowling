using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BengansBowlingBrawl.Models
{
    class Match
    {
        public Match(Spelare playerOne, Spelare playerTwo)
        {
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
        }

        public int Id { get; set; }
        public Spelare PlayerOne { get; set; }
        public Spelare PlayerTwo { get; set; }
        public List<Serie> Series { get; set; }

        public string Winner
        {
            get
            {
                var playerOneTotalScore = Series.Sum(serie => serie.PlayerOneScore);
                var playerTwoTotalScore = Series.Sum(serie => serie.PlayerTwoScore);

                if (playerOneTotalScore == playerTwoTotalScore) return "Draw";
                return playerOneTotalScore > playerTwoTotalScore ? PlayerOne.Name : PlayerTwo.Name;
            }
        }
    }
}
