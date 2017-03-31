using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeCommon.Game
{
    [Serializable]
    public class Player
    {
        public string Name;

        public int Number; // Player1 or Player 2

        public bool HasTurn;

        public Player() { }
    }
}
