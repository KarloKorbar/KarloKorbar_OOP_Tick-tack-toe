using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    abstract class AbstractBoard
    {
        public char[,] Values { get; set; }

        abstract public bool WinCheck(int posx, int posy);
        abstract public void Make_a_move(int x, int y);
    }
}
