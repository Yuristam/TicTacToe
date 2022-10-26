using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame.EndGame
{
    internal class Win
    {

        Menu.GameMenu gameMenu = new Menu.GameMenu();
        public void WinCases()
        {

            if (Program.boardCells[0] == 'X' && Program.boardCells[1] == 'X' && Program.boardCells[2] == 'X')
            {
                Console.WriteLine("You win!");
                Task t = Task.Delay(2000) ;
                t.Wait();

                gameMenu.Menu();

            }
            if (Program.boardCells[3] == 'X' && Program.boardCells[4] == 'X' && Program.boardCells[5] == 'X')
            {
                Console.WriteLine("You win!");
                Task t = Task.Delay(2000);
                t.Wait();
                gameMenu.Menu();
            }
            if (Program.boardCells[6] == 'X' && Program.boardCells[7] == 'X' && Program.boardCells[8] == 'X')
            {
                Console.WriteLine("You win!");
                Task t = Task.Delay(2000);
                t.Wait();
                gameMenu.Menu();
            }
            if (Program.boardCells[0] == 'X' && Program.boardCells[4] == 'X' && Program.boardCells[8] == 'X')
            {
                Console.WriteLine("You win!");
                Task t = Task.Delay(2000);
                t.Wait();

                gameMenu.Menu();
            }
            if (Program.boardCells[2] == 'X' && Program.boardCells[4] == 'X' && Program.boardCells[6] == 'X')
            {
                Console.WriteLine("You win!");
                Task t = Task.Delay(2000);
                t.Wait();

                gameMenu.Menu();
            }

            if (Program.boardCells[0] == 'X' && Program.boardCells[3] == 'X' && Program.boardCells[6] == 'X')
            {
                Console.WriteLine("You win!");
                Task t = Task.Delay(2000);
                t.Wait();

                gameMenu.Menu();
            }
            if (Program.boardCells[1] == 'X' && Program.boardCells[4] == 'X' && Program.boardCells[7] == 'X')
            {
                Console.WriteLine("You win!");
                Task t = Task.Delay(2000);
                t.Wait();

                gameMenu.Menu();
            }
            if (Program.boardCells[2] == 'X' && Program.boardCells[5] == 'X' && Program.boardCells[8] == 'X')
            {
                Console.WriteLine("You win!");
                Task t = Task.Delay(2000);
                t.Wait();

                gameMenu.Menu();
            }

            if (Program.boardCells[0] == '0' && Program.boardCells[1] == '0' && Program.boardCells[2] == '0')
            {
                Console.WriteLine("You lose.");
                Task t = Task.Delay(2000);
                t.Wait();

                gameMenu.Menu();
            }
            if (Program.boardCells[3] == '0' && Program.boardCells[4] == '0' && Program.boardCells[5] == '0')
            {
                Console.WriteLine("You lose.");
                Task t = Task.Delay(2000);
                t.Wait();

                gameMenu.Menu();
            }
            if (Program.boardCells[6] == '0' && Program.boardCells[7] == '0' && Program.boardCells[8] == '0')
            {
                Console.WriteLine("You lose.");
                Task t = Task.Delay(2000);
                t.Wait();

                gameMenu.Menu();
            }


            if (Program.boardCells[0] == '0' && Program.boardCells[4] == '0' && Program.boardCells[8] == '0')
            {
                Console.WriteLine("You lose.");
                Task t = Task.Delay(2000);
                t.Wait();

                gameMenu.Menu();
            }
            if (Program.boardCells[2] == '0' && Program.boardCells[4] == '0' && Program.boardCells[6] == '0')
            {
                Console.WriteLine("You lose.");
                Task t = Task.Delay(2000);
                t.Wait();

                gameMenu.Menu();
            }


            if (Program.boardCells[0] == '0' && Program.boardCells[3] == '0' && Program.boardCells[6] == '0')
            {
                Console.WriteLine("You lose.");
                Task t = Task.Delay(2000);
                t.Wait();

                gameMenu.Menu();
            }
            if (Program.boardCells[1] == '0' && Program.boardCells[4] == '0' && Program.boardCells[7] == '0')
            {
                Console.WriteLine("You lose.");
                Task t = Task.Delay(2000);
                t.Wait();

                gameMenu.Menu();
            }
            if (Program.boardCells[2] == '0' && Program.boardCells[5] == '0' && Program.boardCells[8] == '0')
            {
                Console.WriteLine("You lose.");
                Task t = Task.Delay(2000);
                t.Wait();

                gameMenu.Menu();
            }
            if (Program.boardCells[0] != '*' && Program.boardCells[1] != '*' && Program.boardCells[2] != '*' && Program.boardCells[3] != '*' && Program.boardCells[4] != '*' && Program.boardCells[5] != '*' && Program.boardCells[6] != '*' && Program.boardCells[7] != '*' && Program.boardCells[8] != '*')
            {
                Console.WriteLine("Draw.");
                Task t = Task.Delay(2000);
                t.Wait();

                gameMenu.Menu();
            }
        }
    }
}