using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame.Inputs
{
    internal class Inputs
    {

        Program program = new Program();
        public void UserInputs()
        {
            while (true)
            {
                string userInput = Console.ReadLine().ToLower().Trim().Replace(" ", "");

                if (userInput == "11")
                {
                    if (Program.boardCells[0] == '*')
                    {
                        Program.boardCells[0] = 'X';

                        break;
                    }
                    else if (Program.boardCells[0] != '*')
                    {
                        Console.WriteLine("You can't put X here, please choose another cell.");
                        Console.Write('>');
                    }
                }
                else if (userInput == "12")
                {
                    if (Program.boardCells[1] == '*')
                    {
                        Program.boardCells[1] = 'X';
                        break;
                    }
                    else if (Program.boardCells[1] != '*')
                    {
                        Console.WriteLine("You can't put X here, please choose another cell.");
                        Console.Write('>');
                    }
                }
                else if (userInput == "13")
                {
                    if (Program.boardCells[2] == '*')
                    {
                        Program.boardCells[2] = 'X';
                        break;
                    }
                    else if (Program.boardCells[2] != '*')
                    {
                        Console.WriteLine("You can't put X here, please choose another cell.");
                        Console.Write('>');
                    }
                }
                else if (userInput == "21")
                {
                    if (Program.boardCells[3] == '*')
                    {
                        Program.boardCells[3] = 'X';
                        break;
                    }
                    else if (Program.boardCells[3] != '*')
                    {
                        Console.WriteLine("You can't put X here, please choose another cell.");
                        Console.Write('>');
                    }
                }
                else if (userInput == "22")
                {
                    if (Program.boardCells[4] == '*')
                    {
                        Program.boardCells[4] = 'X';
                        break;
                    }
                    else if (Program.boardCells[4] != '*')
                    {
                        Console.WriteLine("You can't put X here, please choose another cell.");
                        Console.Write('>');
                    }
                }
                else if (userInput == "23")
                {
                    if (Program.boardCells[5] == '*')
                    {
                        Program.boardCells[5] = 'X';
                        break;
                    }
                    else if (Program.boardCells[5] != '*')
                    {
                        Console.WriteLine("You can't put X here, please choose another cell.");
                        Console.Write('>');
                    }
                }
                else if (userInput == "31")
                {
                    if (Program.boardCells[6] == '*')
                    {
                        Program.boardCells[6] = 'X';
                        break;
                    }
                    else if (Program.boardCells[6] != '*')
                    {
                        Console.WriteLine("You can't put X here, please choose another cell.");
                        Console.Write('>');
                    }
                }
                else if (userInput == "32")
                {
                    if (Program.boardCells[7] == '*')
                    {
                        Program.boardCells[7] = 'X';
                        break;
                    }
                    else if (Program.boardCells[7] != '*')
                    {
                        Console.WriteLine("You can't put X here, please choose another cell.");
                        Console.Write('>');
                    }
                }
                else if (userInput == "33")
                {
                    if (Program.boardCells[8] == '*')
                    {
                        Program.boardCells[8] = 'X';
                        break;
                    }
                    else if (Program.boardCells[8] != '*')
                    {
                        Console.WriteLine("You can't put X here, please choose another cell.");
                        Console.Write('>');
                    }
                }

                else if (userInput == "help" || userInput == "h")
                {
                    program.GameHelp();
                }
                else if (userInput == "quit" || userInput == "q")
                {
                    program.ExitGame();
                }
                else
                {
                    Console.WriteLine("There is no such command, please try another command.");
                    Console.Write('>');
                }

            }
        }
        public void ComputerInputs()
        {
            int computerInput;
            Random random = new Random();
            int newRandom;
            int newRandom2;


            Random rnd = new Random();                // Начало рандома для Таска      
            int randomTaskTime = rnd.Next(500, 2000); // Рандомные секунды для Таска


            computerInput = random.Next(0, 9);
            {
                Task t2 = Task.Delay(randomTaskTime);
                Console.WriteLine("Now it is the computer's turn…");
                t2.Wait();



                while (true)
                {



                    if (computerInput == 0)
                    {
                        if (Program.boardCells[0] == '*')
                        {
                            Program.boardCells[0] = '0';
                            Console.WriteLine("Computer decided to go with the cell 1 1");
                            break;
                        }
                        else if (Program.boardCells[0] != '*')
                        {
                            computerInput = random.Next(1, 9);
                        }
                    }
                    else if (computerInput == 1)
                    {
                        if (Program.boardCells[1] == '*')
                        {
                            Program.boardCells[1] = '0';
                            Console.WriteLine("Computer decided to go with the cell 1 2");
                            break;
                        }
                        else if (Program.boardCells[1] != '*')
                        {
                            newRandom = random.Next(2, 9);               // для того, чтобы исключить число из рандома
                            computerInput = random.Next(0, newRandom);
                        }
                    }
                    else if (computerInput == 2)
                    {
                        if (Program.boardCells[2] == '*')
                        {
                            Program.boardCells[2] = '0';
                            Console.WriteLine("Computer decided to go with the cell 1 3");
                            break;
                        }
                        else if (Program.boardCells[2] != '*')
                        {
                            newRandom = random.Next(3, 9);    // для того, чтобы исключить число из рандома
                            newRandom2 = random.Next(0, 2);    // для того, чтобы исключить число из рандома
                            computerInput = random.Next(newRandom2, newRandom);
                        }
                    }
                    else if (computerInput == 3)
                    {
                        if (Program.boardCells[3] == '*')
                        {
                            Program.boardCells[3] = '0';
                            Console.WriteLine("Computer decided to go with the cell 2 1");
                            break;
                        }
                        else if (Program.boardCells[3] != '*')
                        {
                            newRandom = random.Next(4, 9);
                            newRandom2 = random.Next(0, 3);
                            computerInput = random.Next(newRandom2, newRandom);
                        }
                    }
                    else if (computerInput == 4)
                    {
                        if (Program.boardCells[4] == '*')
                        {
                            Program.boardCells[4] = '0';
                            Console.WriteLine("Computer decided to go with the cell 2 2");
                            break;
                        }
                        else if (Program.boardCells[4] != '*')
                        {
                            newRandom = random.Next(5, 9);
                            newRandom2 = random.Next(0, 4);
                            computerInput = random.Next(newRandom2, newRandom);
                        }
                    }
                    else if (computerInput == 5)
                    {
                        if (Program.boardCells[5] == '*')
                        {
                            Program.boardCells[5] = '0';
                            Console.WriteLine("Computer decided to go with the cell 2 3");
                            break;
                        }
                        else if (Program.boardCells[5] != '*')
                        {
                            newRandom = random.Next(6, 9);
                            newRandom2 = random.Next(0, 5);
                            computerInput = random.Next(newRandom2, newRandom);
                        }
                    }

                    else if (computerInput == 6)
                    {
                        if (Program.boardCells[6] == '*')
                        {
                            Program.boardCells[6] = '0';
                            Console.WriteLine("Computer decided to go with the cell 3 1");
                            break;
                        }
                        else if (Program.boardCells[6] != '*')
                        {
                            newRandom = random.Next(7, 9);
                            newRandom2 = random.Next(0, 6);
                            computerInput = random.Next(newRandom2, newRandom);
                        }
                    }
                    else if (computerInput == 7)
                    {
                        if (Program.boardCells[7] == '*')
                        {
                            Program.boardCells[7] = '0';
                            Console.WriteLine("Computer decided to go with the cell 3 2");
                            break;
                        }
                        else if (Program.boardCells[7] != '*')
                        {
                            newRandom = random.Next(8, 9);
                            newRandom2 = random.Next(0, 7);
                            computerInput = random.Next(newRandom2, newRandom);
                        }
                    }
                    else if (computerInput == 8)
                    {
                        if (Program.boardCells[8] == '*')
                        {
                            Program.boardCells[8] = '0';
                            Console.WriteLine("Computer decided to go with the cell 3 3");
                            break;
                        }
                        else if (Program.boardCells[8] != '*')
                        {
                            computerInput = random.Next(0, 8);
                        }
                    }
                }
            }
        }
    }
}