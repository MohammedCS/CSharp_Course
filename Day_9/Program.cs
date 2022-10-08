using System;
using static System.Console;

namespace Zigzag_V1
{
    class Program
    {
        static string Zigzag(string txt, int row)
        {
            int next;
            string res = "";

            if (row == 0)
                return res;
            else if (row == 1)
                return txt;
            else
                next = (2 * row) - 2;
            int temp = next;
            int nexter = temp;

            for (int i = 0; i < row; i++)
            {
                if ( i == 0 || i == row - 1)
                {
                    next = temp;
                    res += txt[i];
                    for (int j = next; j < txt.Length; j += next)
                    {
                        res += txt[i + j];
                    }
                }

                else
                {
                    next -= 1;
                    res += txt[i];
                    for (int j = next; j < txt.Length; j += next)
                    {
                        res += txt[j + i];
                        if ( i + nexter < txt.Length)
                        {
                            res += txt[i + nexter];
                            j = nexter;
                            nexter *= 2;
                        }
                    }
                }
                return res;
            }
        }

        static void Run()
        {
            WriteLine("Enter the string : ");
            string input = ReadLine();
            WriteLine("Enter numbers of rows : ");
            int row = Convert.ToInt32(ReadLine());

            WriteLine(Zigzag(input, row));
        }

        static void Main(string[] args)
        {
            Run();
        }
    }
}

