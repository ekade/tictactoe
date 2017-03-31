using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeCommon.Utils
{
    public interface ISerializer
    {
        T Deserialize<T>(string strObj);

        string Serialize<T>(T obj);
    }
}
