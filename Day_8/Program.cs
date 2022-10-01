using System;
using static System.Console;

namespace Sudoku_Solver
{
    class Proram
    {
        static void Output(int[,] board)
        {
            WriteLine(" --------------------");
            for (int i = 0; i < 9; i++) 
            {
                for (int j = 0; j < 9; j++)
                {
                    if (j % 3 == 0)
                    {
                        Write('|');
                    }
                    Write(board[i,j] + " ");
                }
                WriteLine('|');
                if ((i + 1) % 3 == 0)
                {
                    WriteLine(" --------------------");
                }
            }

        }

//        static void Input()
//       {
//          WriteLine("Welcome to my Sudoku Solver: ");
//         WriteLine("-----------------------------");
//
//
//       }

        static bool Check(int[,] board, int row, int col, int num)
        {
            // Check row
            for (int i = 0; i < 9; i++)
            {
                if (board[i, col] == num)
                {
                    return false;
                }
            }

            // Check col
            for (int i = 0; i < 9; i++)
            {
                if (board[row, i] == num)
                {
                    return false;
                }
            }

            int firstRow = row - row % 3;
            int firstCol = col - col % 3;
            // Check Box
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[(firstRow + i), (firstCol + j)] == num)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static bool  Solve(int[,] board, int row, int col )
        {
            if (row == 8 && col == 9)
            {
                return true;
            }

            if (col == 9)
            {
                row += 1;
                col = 0;
            }

            if (board[row, col] != 0)
            {
                return Solve(board, row, col + 1);
            }
            else
            {
                for (int i = 1; i < 10; i++)
                {
                    bool isValid = Check(board, row, col, i);
                    
                    if (isValid)
                    {
                        board[row, col] = i;

                        if (Solve(board, row, col + 1))
                        {
                            return true;
                        }
                        else
                        {
                            board[row, col] = 0;
                        }
                    }
                }
            }
            return false;
        }

        static void  Run()
        {
            int[,] board = {  { 8, 6, 0,  0, 9, 1,  0, 0, 0 },
                              { 1, 2, 0,  0, 0, 0,  0, 5, 6 },
                              { 0, 0, 7,  5, 0, 2,  8, 0, 0 },

                              { 0, 5, 8,  0, 2, 6,  0, 7, 9 },
                              { 2, 0, 0,  0, 5, 0,  0, 0, 0 },
                              { 0, 0, 0,  0, 7, 0,  2, 8, 0 },

                              { 0, 0, 0,  2, 3, 7,  0, 0, 0 },
                              { 0, 1, 2,  0, 0, 5,  0, 9, 4 },
                              { 0, 0, 0,  0, 0, 4,  0, 0, 0 }   };


            bool isSolved = Solve(board, 0, 0);

            if (isSolved)
            {
                Output(board);
            }
            else
            {
                WriteLine("This Sudoku doesn't have solution!!");
            }
        }

        static void Main(string[] args)
        {
            Run();
        }
    }
}
