using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsolePlayer [] p= {new ConsolePlayer('X') , new ConsolePlayer('O')};
            ConsoleBoard board = new ConsoleBoard();
            int turn = 0;
            while (true)
            {

                int curr_player = turn % 2 != 0 ? 1 : 0;
                DrawBoard(p, board, curr_player);

                p[curr_player].GetInput();
                board.Make_a_move(board.currSelectionX + p[curr_player].LeftRight(), board.currSelectionY + p[curr_player].UpDown());
                if (p[curr_player].Accept())
                {
                    if (board.setValue(p[curr_player].sign))
                    {
                        turn++;
                        if (board.WinCheck(board.currSelectionX, board.currSelectionY))
                        {
                            DrawBoard(p, board, curr_player);
                            Console.WriteLine($"{p[curr_player].sign} je povjedio/la");
                            break;
                        }
                        else if (turn == 9)
                        {
                            DrawBoard(p, board, curr_player);
                            Console.WriteLine("Izjednaceno je");
                            break;
                        }
                    }
                }
            }
        }

        private static void DrawBoard(ConsolePlayer[] p, ConsoleBoard board, int curr_player)
        {
            Console.Clear();
            Console.WriteLine($"Krizic kruzic - Karlo Korbar");
            Console.WriteLine();
            Console.WriteLine($"Kako igrati:");
            Console.WriteLine($"Koristite strelice da odaberete polje \nte enter da stavite svoj znak u odabrano polje");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"igra: {p[curr_player].sign}");
            Console.WriteLine();
            Console.WriteLine(board);
            Console.WriteLine();
        }
    }
}
