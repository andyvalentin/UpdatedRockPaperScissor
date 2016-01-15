using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedRockPaperScissor.Models
{
    class Game
    {
        private Player _p1 = new Player();
        private Player _p2 = new Player();

        public void Fight()
        {
            _p1.MakeChoice();
            _p2.MakeChoice();

            var p1 = _p1.Choice;
            var p2 = _p2.Choice;


            Console.WriteLine("Player 1 Choice: {0} || Player 2 Choice: {1}", p1, p2);

            if (p1 == p2)
            {
                Console.WriteLine("It's a tie!");
            }

            else if (p1 == "rock" && p2 == "scissors" || p1 == "paper" && p2 == "rock" || p1 == "scissors" && p2 == "paper")
            {
                _p1.Wins++;
                Console.WriteLine("Player 1 Wins");
            }
            else
            {
                _p2.Wins++;
                Console.WriteLine("Player 2 Wins");
            }
                 
                         
            Console.WriteLine("Player 1 Score: " + _p1.Wins);
            Console.WriteLine("Player 2 Score: " + _p2.Wins);
        }
    }
}

//if (p1 == "rock")
//{
//    if (p2 == "scissors")
//    {
//        _p1.Wins++;
//        Console.WriteLine("Player 1 Wins");

//    }
//    else if (p2 == "paper")
//    {
//        _p2.Wins++;
//        Console.WriteLine("Player 2 Wins");
//    }

//}

//if (p1 == "paper")
//{
//    if (p2 == "rock")
//    {
//        _p1.Wins++;
//        Console.WriteLine("Player 1 Wins");
//    }
//    else if (p2 == "scissors")
//    {
//        _p2.Wins++;
//        Console.WriteLine("Player 2 Wins");
//    }

//}

//if (p1 == "scissors")
//{
//    if (p2 == "paper")
//    {
//        _p1.Wins++;
//        Console.WriteLine("Player 1 Wins");
//    }
//    else if (p2 == "rock")
//    {
//        _p2.Wins++;
//        Console.WriteLine("Player 2 Wins");
//    }

//}


