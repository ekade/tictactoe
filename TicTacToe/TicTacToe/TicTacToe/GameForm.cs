using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeCommon.Game;
using TicTacToeCommon.Utils;

namespace TicTacToe
{
    public partial class GameForm : Form
    {
        #region Private Fields

        private int _port = Convert.ToInt32(ConfigurationManager.AppSettings["PORT"]);

        private string _appName = ConfigurationManager.AppSettings["APPNAME"];

        private string _serverHost = ConfigurationManager.AppSettings["SERVERHOST"];

        private NetClient _client;

        private Game _game;

        private string _baseDir = Path.GetDirectoryName(Application.ExecutablePath);

        #endregion

        #region Public Methods

        public GameForm(string player)
        {
            try
            {
                InitializeComponent();
                InitializeGame(player);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Events

        private void pb00_Click(object sender, EventArgs e)
        {
            try
            {
                var movement = GetMovement(pb00);
                MakeMovement(movement);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb01_Click(object sender, EventArgs e)
        {
            try
            {
                var movement = GetMovement(pb01);
                MakeMovement(movement);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb02_Click(object sender, EventArgs e)
        {
            try
            {
                var movement = GetMovement(pb02);
                MakeMovement(movement);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            try
            {
                var movement = GetMovement(pb10);
                MakeMovement(movement);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            try
            {
                var movement = GetMovement(pb11);
                MakeMovement(movement);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            try
            {
                var movement = GetMovement(pb12);
                MakeMovement(movement);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb20_Click(object sender, EventArgs e)
        {
            try
            {
                var movement = GetMovement(pb20);
                MakeMovement(movement);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb21_Click(object sender, EventArgs e)
        {
            try
            {
                var movement = GetMovement(pb21);
                MakeMovement(movement);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb22_Click(object sender, EventArgs e)
        {
            try
            {
                var movement = GetMovement(pb22);
                MakeMovement(movement);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GameForm_FormClosed(object sender, EventArgs e)
        {
            _client.Disconnect("Bye");
            Application.Exit();
        }

        #endregion

        #region Private Methods

        private void InitializeGame(string player)
        {
            lblPlayer.Text = player;
            ToggleGame(false);

            StartClient(player);
        }

        private void StartClient(string player)
        {
            var config = new NetPeerConfiguration(_appName);
            _client = new NetClient(config);
            _client.RegisterReceivedCallback(new System.Threading.SendOrPostCallback(GetServerInfo));
            _client.Start();

            System.Threading.Thread.Sleep(1000);

            var hailMsg = _client.CreateMessage(player);
            _client.Connect(host: _serverHost, port: _port, hailMessage: hailMsg);
        }

        private void GetServerInfo(object peer)
        {
            try
            {
                NetIncomingMessage im;
                while ((im = _client.ReadMessage()) != null)
                {
                    switch (im.MessageType)
                    {
                        case NetIncomingMessageType.Data:
                            HandleDataMessage(im);
                            break;
                        default:
                            break;
                    }
                    _client.Recycle(im);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleDataMessage(NetIncomingMessage im)
        {
            var updatedGame = GetGame(im.ReadString());
            UpdateGame(updatedGame);

            var playerWithTurn = _game.Players.First(x => x.HasTurn == true);

            if (playerWithTurn.Name == lblPlayer.Text)
            {
                var opponentPlayer = _game.Players.First(x => x != playerWithTurn);
                lblInfo.Text = string.Format("Playing vs {0}", opponentPlayer.Name);

                var gameHasWinner = _game.GameHasWinner();
                if (gameHasWinner || _game.IsFull())
                {
                    if (gameHasWinner)
                        MessageBox.Show("You lost!", "Loser");

                    var dialogResult = MessageBox.Show("Create a new game?", "New game", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                        _game.ResetBoard();
                }

                PaintTurnImage(playerWithTurn);
                PaintGame();
                ToggleGame(true);
            }
        }
        
        private void PaintTurnImage(Player player)
        {
            if (pbTurn.Image == null)
            {
                var image = player.Number == 1 ? "X" : "O";
                SetImage(pbTurn, image);
            }
        }

        private void PaintGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var control = tblLayout.GetControlFromPosition(j, i) as PictureBox;
                    var cell = _game.Board[i, j];

                    if (cell == null)
                        control.Image = null;
                    else
                    {
                        var image = cell == _game.Players[0].Name ? "X" : "O";
                        SetImage(control, image);
                    }
                }
            }
        }

        private void SetImage(PictureBox pb, string image)
        {
            var filename = Path.Combine(_baseDir, string.Format("Images\\img{0}.png", image));
            pb.Image = Image.FromFile(filename);
        }

        private Game GetGame(string strMessage)
        {
            ISerializer serializer = new JsonSerializer();
            return serializer.Deserialize<Game>(strMessage);
        }

        private void UpdateGame(Game updatedGame)
        {
            _game = updatedGame;
        }

        private void MakeMovement(Movement movement)
        {
            var player = _game.Players.First(x => x.Name == lblPlayer.Text);
            _game.Move(player, movement);

            PaintGame();
            ToggleGame(false);

            if (_game.GameHasWinner())
            {
                MessageBox.Show("You won!", "Congratulations");
                lblInfo.Text = "Waiting for new game...";
            }

            SendGameInfo();
        }

        private Movement GetMovement(PictureBox control)
        {
            var pos = tblLayout.GetCellPosition(control);

            return new Movement()
            {
                X = pos.Row,
                Y = pos.Column
            };
        }

        private void SendGameInfo()
        {
            ISerializer serializer = new JsonSerializer();
            var gameMsg = serializer.Serialize(_game);

            NetOutgoingMessage om = _client.CreateMessage(gameMsg);
            _client.SendMessage(om, NetDeliveryMethod.ReliableOrdered);
        }

        private void ToggleGame(bool isEnabled)
        {
            pnlTurn.Visible = isEnabled;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    tblLayout.GetControlFromPosition(i, j).Enabled = isEnabled;
        }

        #endregion
    }
}
