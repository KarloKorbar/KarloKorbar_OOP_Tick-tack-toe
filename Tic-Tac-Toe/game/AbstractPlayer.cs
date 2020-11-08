using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    abstract class AbstractPlayer
    {
        public AbstractPlayer(char sign)
        {
            this.sign = sign;
        }

        public char sign { get; set; }

        abstract public void GetInput();
    }
}
