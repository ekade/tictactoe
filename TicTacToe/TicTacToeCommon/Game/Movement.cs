using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeCommon.Game
{
    [Serializable]
    public class Movement
    {
        public int X;

        public int Y;

        public Movement() { }

        public override string ToString()
        {
            return string.Format("Player moves (x,y): {0}, {1}", X, Y);
        }
    }
}
