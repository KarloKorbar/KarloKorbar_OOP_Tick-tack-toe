using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class ConsoleBoard : BoardLogic
    {
        public int currSelectionX { get; set; }
        public int currSelectionY { get; set; }

        public override void Make_a_move(int x, int y)
        {
            if (x <= this.Values.GetUpperBound(1) && x >= this.Values.GetLowerBound(1))
            {
                currSelectionX = x;
            }
            if (y <= this.Values.GetUpperBound(0) && y >= this.Values.GetLowerBound(0))
            {
                currSelectionY = y;
            }
        }

        public bool setValue(char v)
        {
            if (this.Values[currSelectionY,currSelectionX] == default(char))
            {
                this.Values.SetValue(v, currSelectionY, currSelectionX);
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < Values.GetLength(0); i++)
            {
                for (int j = 0; j < Values.GetLength(1); j++)
                {
                    s += $"{(currSelectionX == j && currSelectionY == i ? "[" : " ")}{Values[i, j]}{(currSelectionX == j && currSelectionY == i ? "]" : " ")}{(j < Values.GetLength(1) - 1 ? "|" : "")}";
                    
                }
                s += ("\n");
                if (i < Values.GetLength(0) - 1)
                {
                    for (int j = 0; j < Values.GetLength(1); j++)
                    {
                        s += $"---{(j < Values.GetLength(1) - 1 ? "+" : "")}";
                    }
                    s += ("\n");
                }
            }

            return s;
        }

    }
}
