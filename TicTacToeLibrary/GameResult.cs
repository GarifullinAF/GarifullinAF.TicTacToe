using System;
using System.Collections.Generic;
using System.Text;


namespace TicTacToeLibrary
{
    public enum GameSymbols
    {
        Empty,
        Cross,
        Circle
    }
    class GameResult
    {
        public GameSymbols[,] gameResult = new GameSymbols[3, 3];
        public GameResult()
        {
            RefreshGameResult();
        }

        public void RefreshGameResult()
        {
            int rows = gameResult.GetUpperBound(0) + 1;
            int columns = gameResult.Length / rows;
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    gameResult[x, y] = GameSymbols.Empty;
                }
            }
        }
    }
}
