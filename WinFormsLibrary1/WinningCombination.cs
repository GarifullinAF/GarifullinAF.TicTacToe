using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary1
{
    class WinningCombination
    {
        GamePoint[,] combinations = new GamePoint[8, 3]
            {
            {new GamePoint(0,0), new GamePoint(0,1), new GamePoint(0,2)},
            {new GamePoint(1,0), new GamePoint(1,1), new GamePoint(1,2)},
            {new GamePoint(2,0), new GamePoint(2,1), new GamePoint(2,2)},
            {new GamePoint(0,0), new GamePoint(1,0), new GamePoint(2,0)},
            {new GamePoint(0,1), new GamePoint(1,1), new GamePoint(2,1)},
            {new GamePoint(0,2), new GamePoint(1,2), new GamePoint(2,2)},
            {new GamePoint(0,0), new GamePoint(1,1), new GamePoint(2,2)},
            {new GamePoint(0,2), new GamePoint(1,1), new GamePoint(2,0)},
        };

        public bool CheckWinningCombinationcs(GameSymbols[,] array)
        {
            bool WinningCombinationExist = false;
            int rows = combinations.GetUpperBound(0) + 1;
            int columns = combinations.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                if (WinningCombinationExist) break;
                for (int i2 = 1; i2 < columns; i2++)
                {
                    GameSymbols previousValue = array[combinations[i, i2 - 1].X, combinations[i, i2 - 1].Y];
                    GameSymbols selectedValue = array[combinations[i, i2].X, combinations[i, i2].Y];
                    if (selectedValue != previousValue || selectedValue == GameSymbols.Empty)
                    {
                        WinningCombinationExist = false;
                        break;
                    }
                    WinningCombinationExist = true;
                }
            }
            return WinningCombinationExist;
        }
    }
}
