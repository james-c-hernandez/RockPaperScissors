using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RockPaperScissors
{
    public enum Choice
    {
        Rock,
        Paper,
        Scissors
    }

    public enum RoundResult
    {
        Player1Win,
        Player2Win,
        Draw
    }

    internal class GameManager
    {
        private IPlayer _player1;
        private IPlayer _player2;

        public GameManager(IPlayer player1, IPlayer player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public RoundResult PlayRound()
        {

            //Player1 (Human)
            Choice p1 = _player1.GetChoice();

            // Player 2 (Computer)
            Choice p2 = _player2.GetChoice();

            Console.WriteLine($"Player 1 picks {p1.ToString()} and Player 2 picks {p2.ToString()}");


            if (p1 == p2)
            {
                return RoundResult.Draw;
            }

            if (p1 == Choice.Rock && p2 == Choice.Scissors ||
                p1 == Choice.Paper && p2 == Choice.Rock ||
                p1 == Choice.Scissors && p2 == Choice.Paper)
            {
                return RoundResult.Player1Win;
            }

            return RoundResult.Player2Win;
        }
    }
}

