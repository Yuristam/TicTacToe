using TicTacToeGame.Menu;

namespace TicTacToeGame
{
    class Program
    {
        public static char[] boardCells = new char[9] { '*', '*', '*', '*', '*', '*', '*', '*', '*' };
        static void Main()
        {
            GameMenu game = new GameMenu();
            game.Menu(); // Меню игры
        }

        public void ExitGame()
        {
                Console.Clear();
                Console.WriteLine("You have quitted the game!");
                Environment.Exit(0);
         }
        public void GameHelp()
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

                GameBoard gameBoard = new GameBoard();
                gameBoard.Board();
            }
        }
    }

