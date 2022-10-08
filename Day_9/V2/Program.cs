using System;
using System.Collections.Generic;
using static System.Console;

namespace Zigzag_V2
{
    class Program
    {
        static string MorseCode(string txt)
        {
            txt = txt.ToUpper();

            Dictionary<string, string> morse = new Dictionary<string, string>()
            {
                {"A", ". _ "},
                {"B", "_ ... "},
                {"C", "__ . __ . "},
                {"D", "__ .. "},
                {"E", ". "},
                {"F", ".. __ . "},
                {"G", "__ __ . "},
                {"H", ".... "},
                {"I", ".. "},
                {"J", ". __ __ __ "},
                {"K", "__ . __ "},
                {"L", ". __ .. "},
                {"M", "__ __ "},
                {"N", "__ . "},
                {"O", "__ __ __ "},
                {"P", ". __ __ . "},
                {"Q", "__ __ . __ "},
                {"R", ". __ . "},
                {"S", "... "},
                {"T", "__ "},
                {"U", ".. __ "},
                {"V", "... __ "},
                {"W", ". __ __ "},
                {"X", "__ .. __ "},
                {"Y", "__ . __ __ "},
                {"Z", "__ __ .. "},

                {" ", "  "},
                
                {"1", ". __ __ __ __ "},
                {"2", ".. __ __ __ "},
                {"3", "... __ __ "},
                {"4", ".... __ "},
                {"5", "..... "},
                {"6", "__ .... "},
                {"7", "__ __ ... "},
                {"8", "__ __ __ .. "},
                {"9", "__ __ __ __ . "},
                {"0", ". __ __ __ __ __ "},
            };

            string res = "";
            for (int i = 0; i < txt.Length; i++)
            {
                res += morse[txt[i].ToString()];
            }

            return res;
        }

        static string Zigzag(string txt, int row)
        {
            int next;
            string res = "";

            if ( row == 0)
                return res;
            else if ( row == 1)
                return txt;
            else
                next = ( 2 * row ) - 2;

            for ( int i = 0; i < row; i++)
            {
                for ( int j = i; j < txt.Length; j += next)
                {
                    res += txt[j];
                    if (! ( i == 0 || i == row - 1) && (next - (2 * i)) + j < txt.Length)
                        res += txt[(next - (2 * i)) + j];
                }
            }

            return res;
        }

        static void Run()
        {
            Write("Enter the word : ");
            string input = ReadLine();
            Write("Enter number of rows : ");
            int row = Convert.ToInt32(ReadLine());

            WriteLine(Zigzag(input, row));
            WriteLine(MorseCode(input));
        }

        static void Main(string[] args)
        {
            Run();
        }
    }
}
