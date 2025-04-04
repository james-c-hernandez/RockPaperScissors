using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class PlayerComputer : IPlayer
    {
        Random _rng = new Random();
        public Choice GetChoice()
        {
            Choice p2 = (Choice)_rng.Next(0, 3);
            return p2;
            //Console.WriteLine($"Player 2 picked {p2.ToString()}");
        }
    }
}
