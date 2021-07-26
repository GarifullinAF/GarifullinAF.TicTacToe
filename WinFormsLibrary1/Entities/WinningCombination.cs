using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary1
{
    class WinningCombination
    {
        /// <summary>
        /// Массив содержит все выигрышные строки крестиков-коликов
        /// </summary>
        public GamePoint[,] combinations = new GamePoint[8, 3]
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
    }
}
