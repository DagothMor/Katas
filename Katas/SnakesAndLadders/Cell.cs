using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.SnakesAndLadders
{
    public class Cell
    {
        public Cell(char symbol)
        {
            Symbol = symbol;
        }

        private char Symbol { get; }
    }
}
