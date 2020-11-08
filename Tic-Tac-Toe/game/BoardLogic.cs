using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    abstract class BoardLogic : AbstractBoard
    {
        public BoardLogic() => this.Values = new char[3, 3];

        public override bool WinCheck(int posx,int posy)
        {
            for (int y = -1; y <= 1; y++)
            {
                for (int x = -1; x <= 1; x++)
                {
                    IEnumerable<char> check = GetCharInLine(posx, posy, x, y);
                    if (check.Count() != 3 ? false : check.Distinct().Count() == 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private IEnumerable<char> GetCharInLine(int startX = 0, int startY = 0, int dirX = 0, int dirY = 0)
        {
            IList<char> forward = GetCharInDirection(startX, startY, dirX, dirY);
            IList<char> back = GetCharInDirection(startX, startY, -dirX, -dirY);
            back.RemoveAt(0);
            return forward.Concat(back);
        }

        private  IList<char> GetCharInDirection(int startX = 0, int startY = 0, int dirX = 0, int dirY = 0)
        {
            IList<char> z = new List<char> {};
            if (dirX == 0 && dirY == 0)
            {
                z.Add((char)Values.GetValue(startY, startX));
                return z;
            }
            while (true)
            {
                try
                {
                    z.Add((char)Values.GetValue(startY, startX));
                }
                catch (System.IndexOutOfRangeException)
                {
                    break;
                }
                startX += dirX;
                startY += dirY;
            }
            return z;
        }        
    }
}
