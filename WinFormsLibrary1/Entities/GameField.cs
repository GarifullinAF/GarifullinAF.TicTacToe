using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary1
{
    public class GameField
    {
        public GameSymbols[,] GameResult = new GameSymbols[3, 3];        

        public GameField()
        {
            RefreshGameResult();
        }

        /// <summary>
        /// Переводит все значения массива результатов игры в значение Empty
        /// </summary>
        public void RefreshGameResult()
        {
            int rows = GameResult.GetUpperBound(0) + 1;
            int columns = GameResult.Length / rows;
            for (int x = 0; x < rows; x++)
                for (int y = 0; y < columns; y++)
                    GameResult[x, y] = GameSymbols.Empty;
        }

        /// <summary>
        /// Проверяет игровое поле на наличие победных комбинаций
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public bool CheckWinningCombinationcs()
        {
            WinningCombination winningCombination = new WinningCombination();
            bool winningCombinationExist = false;
            
            int rows = winningCombination.combinations.GetUpperBound(0) + 1;
            int columns = winningCombination.combinations.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int i2 = 1; i2 < columns; i2++)
                {
                    GameSymbols previousValue = GameResult[winningCombination.combinations[i, i2 - 1].X, winningCombination.combinations[i, i2 - 1].Y];
                    GameSymbols selectedValue = GameResult[winningCombination.combinations[i, i2].X, winningCombination.combinations[i, i2].Y];
                    if (selectedValue != previousValue || selectedValue == GameSymbols.Empty)
                    {
                        winningCombinationExist = false;
                        break;
                    }
                    winningCombinationExist = true;
                }
                if (winningCombinationExist) break;
            }
            return winningCombinationExist;
        }

        /// <summary>
        /// Проверяет установлено ли значение в точку игрового поля
        /// </summary>
        /// <param name="point"></param>
        /// <returns>true - символ пуст, false - символ уже установлен</returns>
        public bool CheckSymbolEmpty(GamePoint point)
        {
            if (GameResult[point.X, point.Y] == GameSymbols.Empty) return true;
            else return false;
        }
    }
}
