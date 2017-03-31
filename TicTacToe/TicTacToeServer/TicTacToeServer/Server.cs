using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Net;
using System.Net.Sockets;
using System.Xml.Serialization;
using System.IO;
using Lidgren.Network;
using TicTacToeCommon.Utils;
using TicTacToeCommon.Game;

namespace TicTacToeServer.BL
{
    public class Server
    {
        #region Private Fields

        private int _port;

        private string _appName;

        private NetServer _server;

        private Game _game;

        private const int SEQUENCE_CHANNEL = 0;

        #endregion

        #region Public Methods

        public Server()
        {
            _port = Convert.ToInt32(ConfigurationManager.AppSettings["PORT"]);
            _appName = ConfigurationManager.AppSettings["APPNAME"];

            var config = new NetPeerConfiguration(_appName) { Port = _port, MaximumConnections = 2 };
            _server = new NetServer(config);
            _server.Start(); 
        }

        public void Listen()
        {
            Console.WriteLine("-- Server started --");

            while (true)
            {
                NetIncomingMessage message;
                while ((message = _server.ReadMessage()) != null)
                {
                    switch (message.MessageType)
                    {
                        case NetIncomingMessageType.DebugMessage:
                        case NetIncomingMessageType.ErrorMessage:
                        case NetIncomingMessageType.WarningMessage:
                        case NetIncomingMessageType.VerboseDebugMessage:
                            Console.WriteLine(message.ReadString());
                            break;
                        case NetIncomingMessageType.StatusChanged:
                            HandleStatusChanged(message);
                            break;
                        case NetIncomingMessageType.Data:
                            HandleDataMessage(message);
                            break;
                        default:
                            Console.WriteLine("Unhandled type: " + message.MessageType + " " + message.LengthBytes + " bytes " + message.DeliveryMethod +
                                "|" + message.SequenceChannel);
                            break;
                    }
                }
            }
        }

        #endregion

        #region Private Methods

        private void HandleStatusChanged(NetIncomingMessage message)
        {
            NetConnectionStatus status = (NetConnectionStatus)message.ReadByte();

            Console.WriteLine(NetUtility.ToHexString(message.SenderConnection.RemoteUniqueIdentifier) + " " + status + ": " + message.ReadString());

            if (status == NetConnectionStatus.Connected)
            {
                var numberOfConnections = _server.Connections.Count;
                var playerName = message.SenderConnection.RemoteHailMessage.ReadString();

                if (numberOfConnections == 1)
                {
                    //Create game
                    if (_game == null)
                    {
                        _game = new Game(playerName);
                        Console.WriteLine(playerName + " created a game");
                    }
                }
                else if (numberOfConnections == 2 && _game != null)
                {
                    _game.AddPlayer(playerName);
                    Console.WriteLine(string.Format("Game started! Players: {0}, {1}", _game.Players[0].Name, _game.Players[1].Name));

                    SendGameInfo();
                }
            }
            else if (status == NetConnectionStatus.Disconnected && !_server.Connections.Any())
            {
                Console.WriteLine("Game ended");
                _game = null;
            }
        }

        private void HandleDataMessage(NetIncomingMessage message)
        {
            var updatedGame = GetGame(message.ReadString());
            UpdateGame(updatedGame);

            // broadcast this to all connections, except sender
            List<NetConnection> all = _server.Connections; // get copy
            all.Remove(message.SenderConnection);

            if (all.Any())
                SendGameInfo(all);
        }

        private void UpdateGame(Game updatedGame)
        {
            _game = updatedGame;
        }

        private Game GetGame(string strMessage)
        {
            ISerializer serializer = new JsonSerializer();
            return serializer.Deserialize<Game>(strMessage);
        }

        private void SendGameInfo()
        {
            ISerializer serializer = new JsonSerializer();
            var gameMsg = serializer.Serialize(_game);

            NetOutgoingMessage om = _server.CreateMessage(gameMsg);
            _server.SendMessage(om, _server.Connections, NetDeliveryMethod.ReliableOrdered, SEQUENCE_CHANNEL);
        }

        private void SendGameInfo(List<NetConnection> clients)
        {
            ISerializer serializer = new JsonSerializer();
            var gameMsg = serializer.Serialize(_game);

            NetOutgoingMessage om = _server.CreateMessage(gameMsg);
            _server.SendMessage(om, clients, NetDeliveryMethod.ReliableOrdered, 0);
        }

        private string GetConnectionName(NetConnection connection)
        {
            return NetUtility.ToHexString(connection.RemoteUniqueIdentifier);
        }

        #endregion
    }
}
