using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame.Menu
{
    internal class GameMenu
    {
        GameBoard gameBoard = new GameBoard();

        public void Menu()
        {
            while (true)
            {
                Program.boardCells[0] = '*';
                Program.boardCells[1] = '*';
                Program.boardCells[2] = '*';
                Program.boardCells[3] = '*';
                Program.boardCells[4] = '*';
                Program.boardCells[5] = '*';
                Program.boardCells[6] = '*';
                Program.boardCells[7] = '*';
                Program.boardCells[8] = '*';
                Console.Clear();
                Console.WriteLine("Welcome to the tic-tac-toe game. Available commands:");
                Console.WriteLine("1. ’start’ (or ‘s’) - start the game.");
                Console.WriteLine("2. ‘help’ (or ‘h’) - show game rules.");
                Console.WriteLine("3. ‘quit’ (or ‘q’) - quit the game.");
                Console.Write('>');
                string userMenuInput = Console.ReadLine().ToLower().Trim();
                if (userMenuInput == "start" || userMenuInput == "s")
                {
                    gameBoard.Board();
                    break;
                }
                else if (userMenuInput == "help" || userMenuInput == "h")
                {
                    Console.Clear();
                    Console.WriteLine("RULES OF THE GAME");
                    Console.WriteLine("The game is played on a grid that's 3 squares by 3 squares.");
                    Console.WriteLine("You are 'X', the computer is 'O'. Players take turns putting their marks in empty squares.");
                    Console.WriteLine("The first player to get 3 of her marks in a row (up, down, across, or diagonally) is the winner.");
                    Console.WriteLine("When all 9 squares are full, the game is over. If no player has 3 marks in a row, the game ends in a tie.");
                    Console.WriteLine("\r\nPress any key get back.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (userMenuInput == "quit" || userMenuInput == "q")
                {

                    Console.WriteLine("You have quitted the game!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("There is no such command, please try another command.");
                }
            }
        }
    }
}
