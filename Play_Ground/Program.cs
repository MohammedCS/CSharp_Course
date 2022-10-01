using System;
using static System.Console;
using static System.Convert;
// #error version
/*  */

namespace Task_1
{
	class Program
	{
		static void Main(string[] args)
		{
            int[,] board = new int[9,9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    board[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                        if (j % 3 == 0)
                        {
                            Write('|');
                        }
                       WriteLine(board[i, j] + " ");
                }
                WriteLine('|');
                if ((i + 1) % 3 == 0)
                {
                    WriteLine("___________________");
                }
            }

            
		}
	}
}
