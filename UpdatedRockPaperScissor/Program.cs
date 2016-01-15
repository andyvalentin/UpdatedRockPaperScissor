using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdatedRockPaperScissor.Models;

namespace UpdatedRockPaperScissor
{

    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();

            for (var i = 0; i < 100; i++)
            {
                game.Fight();
            }

            Console.ReadLine();

        }
    }
}
