using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace TicTacToeCommon.Utils
{
    public class JsonSerializer : ISerializer
    {
        public T Deserialize<T>(string rawData)
        {
            return JsonConvert.DeserializeObject<T>(rawData);
        }

        public string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
