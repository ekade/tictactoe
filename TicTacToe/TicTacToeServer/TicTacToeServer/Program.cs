using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToeServer.BL;

namespace TicTacToeServer
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Server server = new Server();
                server.Listen();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();
        }
    }
}
