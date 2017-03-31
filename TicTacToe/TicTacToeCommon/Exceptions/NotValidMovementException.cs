using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCommon.Exceptions
{
    public class NotValidMovementException : Exception
    {
        public NotValidMovementException()
        {
        }

        public NotValidMovementException(string message)
            : base(message)
        {
        }

        public NotValidMovementException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
