using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeCommon.Exceptions;

namespace TicTacToeCommon.Game
{
    [Serializable]
    public class Game
    {
        private const int DIMENSION_X = 0;

        private const int DIMENSION_Y = 1;

        public string[,] Board;

        public Player[] Players;

        public Game() { }

        public Game(string player1)
        {
            Board = new string[3, 3];

            Players = new Player[2];
            Players[0] = new Player()
            {
                Name = player1,
                Number = 1,
                HasTurn = true
            };
        }

        public void AddPlayer(string player2)
        {
            Players[1] = new Player()
            {
                Name = player2,
                Number = 2,
                HasTurn = false
            };
        }

        public bool IsFull()
        {
            for (int i = 0; i <= Board.GetUpperBound(DIMENSION_X); i++)
                for (int j = 0; j <= Board.GetUpperBound(DIMENSION_Y); j++)
                    if (string.IsNullOrEmpty(Board[i, j]))
                        return false;

            return true;
        }

        public void ResetBoard()
        {
            for (int i = 0; i <= Board.GetUpperBound(DIMENSION_X); i++)
                for (int j = 0; j <= Board.GetUpperBound(DIMENSION_Y); j++)
                    Board[i, j] = null;
        }

        public void Move(Player player, Movement movement)
        {
            if (player.HasTurn && IsMovementValid(movement))
            {
                this.Board[movement.X, movement.Y] = player.Name;
                player.HasTurn = false;

                var opponentPlayer = this.Players.First(x => x.Name != player.Name);
                opponentPlayer.HasTurn = true;
            }
        }

        private bool IsMovementValid(Movement movement)
        {
            var isInsideBoard = movement.X <= Board.GetUpperBound(DIMENSION_X) || movement.Y <= Board.GetUpperBound(DIMENSION_Y);
            var isEmptyCell = string.IsNullOrEmpty(Board[movement.X, movement.Y]);

            return isInsideBoard && isEmptyCell;
        }

        public bool GameHasWinner()
        {
            for (int i = 0; i < Board.GetUpperBound(DIMENSION_X); i++)
            {
                if (HorizontalMatch(i))
                    return true;
            }

            for (int i = 0; i < Board.GetUpperBound(DIMENSION_Y); i++)
            {
                if (VerticalMatch(i))
                    return true;
            }

            return DiagonalMatch();
        }

        private bool HorizontalMatch(int row)
        {
            return !string.IsNullOrEmpty(Board[row, 0]) && (Board[row, 0] == Board[row, 1]) && (Board[row, 1] == Board[row, 2]);
        }

        private bool VerticalMatch(int column)
        {
            return !string.IsNullOrEmpty(Board[0, column]) && (Board[0, column] == Board[1, column]) && (Board[1, column] == Board[2, column]);
        }

        private bool DiagonalMatch()
        {
            var leftToRight = !string.IsNullOrEmpty(Board[0, 0]) && (Board[0, 0] == Board[1, 1]) && (Board[1, 1] == Board[2, 2]);
            var rightToLeft = !string.IsNullOrEmpty(Board[0, 2]) && (Board[0, 2] == Board[1, 1]) && (Board[1, 1] == Board[2, 0]);

            return leftToRight || rightToLeft;
        }
    }
}
