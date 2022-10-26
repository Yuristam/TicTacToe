using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame.EndGame;

namespace TicTacToeGame.Menu
{
    internal class GameBoard
    {
        public void Board()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Current field state:");
                Console.WriteLine("     |     |      ");
                Console.WriteLine($"  {Program.boardCells[0]}  |  {Program.boardCells[1]}  |  {Program.boardCells[2]}");
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine($"  {Program.boardCells[3]}  |  {Program.boardCells[4]}  |  {Program.boardCells[5]}");
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine($"  {Program.boardCells[6]}  |  {Program.boardCells[7]}  |  {Program.boardCells[8]}");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("\r\nPlease enter index of the cell you’d like to put the cross in:");
                Console.Write('>');

                Win win = new Win();


                Inputs.Inputs userInputs = new Inputs.Inputs(); // создание экземпляра Ввода игрока
                Inputs.Inputs computerInputs = new Inputs.Inputs(); //  создание экземпляра Ввода компьютера

                userInputs.UserInputs();// Ввод игрока

                win.WinCases(); // Кейсы победы, ничьи и поражения
                computerInputs.ComputerInputs();// Ввод компьютера
                win.WinCases(); // Кейсы победы, ничьи и поражения

            }
        }

    }
}
