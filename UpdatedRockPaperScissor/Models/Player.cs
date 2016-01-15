using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedRockPaperScissor.Models
{
    class Player
    {

        public string Choice { get; set; }
        public int Wins { get; set; }

        private static Random _rndIn = new Random();

        private string[] _possibleChoices = new string[] { "rock", "paper", "scissors" };

        public void MakeChoice()
        {
            var rnd = _rndIn.Next(3);

            var finalChoice = _possibleChoices[rnd];

            this.Choice = finalChoice;

        }
    }
}

