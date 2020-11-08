using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class ConsolePlayer:AbstractPlayer
    {
        
        private ConsoleKey LastInput;

        public ConsolePlayer(char sign) : base(sign)
        {
        }
        public override void GetInput()
        {
            LastInput = Console.ReadKey().Key;            
        }
        public int LeftRight()
        {
            return (LastInput == ConsoleKey.RightArrow ? 1 : 0) - (LastInput == ConsoleKey.LeftArrow ? 1 : 0);
        }
        public int UpDown()
        {
            return (LastInput == ConsoleKey.DownArrow ? 1 : 0) - (LastInput == ConsoleKey.UpArrow ? 1 : 0);
        }
        public bool Accept()
        {
            return LastInput == ConsoleKey.Enter;
        }

    }
}
