using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Network;
using System.Configuration;
using System.Threading.Tasks;
using TicTacToeCommon.Utils;
using TicTacToeCommon.Game;
using System.Threading;

namespace TicTacToe.BL
{
    public class Client
    {
        private int _port;

        private string _appName;

        private string _serverHost;

        private NetClient _client;

        public Client()
        {
            _port = Convert.ToInt32(ConfigurationManager.AppSettings["PORT"]);
            _appName = ConfigurationManager.AppSettings["APPNAME"];
            _serverHost = ConfigurationManager.AppSettings["SERVERHOST"];

            StartClient();
        }

        public void RegisterCallback(SendOrPostCallback callback)
        {
            _client.RegisterReceivedCallback(callback); 
        }

        public void End()
        {
            _client.Disconnect("End game");
        }

        private void StartClient()
        {
            var config = new NetPeerConfiguration(_appName);
            _client = new NetClient(config);
            _client.Start();

            var hailMsg = _client.CreateMessage("This is the hail message");
            _client.Connect(host: _serverHost, port: _port, hailMessage: hailMsg);

            StartListening();
        }

        private async void StartListening()
        {
            await Task.Run(() => Listen());
        }

        private void Listen()
        {
            while (true)
            {
                NetIncomingMessage im;
                while ((im = _client.ReadMessage()) != null)
                {
                    // handle incoming message
                    switch (im.MessageType)
                    {
                        case NetIncomingMessageType.DebugMessage:
                        case NetIncomingMessageType.ErrorMessage:
                        case NetIncomingMessageType.WarningMessage:
                        case NetIncomingMessageType.VerboseDebugMessage:
                            string text = im.ReadString();
                            Console.WriteLine(text);
                            break;
                        case NetIncomingMessageType.StatusChanged:
                            NetConnectionStatus status = (NetConnectionStatus)im.ReadByte();
                            Console.WriteLine(status.ToString() + ": " + im.ReadString());

                            break;
                        case NetIncomingMessageType.Data:
                            var game = GetGame(im.ReadString());
                            break;
                        default:
                            Console.WriteLine("Unhandled type: " + im.MessageType + " " + im.LengthBytes + " bytes");
                            break;
                    }
                    _client.Recycle(im);
                }
            }
        }

        public Game GetGame(string strMessage)
        {
            ISerializer serializer = new JsonSerializer();
            return serializer.Deserialize<Game>(strMessage);
        }

        public void SendMessage(string words)
        {
            var message = _client.CreateMessage(words);

            _client.SendMessage(message, NetDeliveryMethod.ReliableOrdered);
            _client.FlushSendQueue();
        }
    }
}
