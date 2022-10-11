using System;
using System.Collections.Generic;
using static System.Console;

#nullable disable

namespace Task
{
    class Program
    {
        static string Solve(string txt)
        {
            int len = txt.Length;
            for ( int i = 0; i < len - 1; i++ )
            {
                if (IsPalindrome(SubString(txt, i+1, i+3)));
                {
                    return SubString(txt, i+1, i+3);
                    // return IsPalindrome(SubString(txt, i, i + 2));
                }
            }
            return "No";
        }

        static string SubString(string txt, int start, int end)
        {
            // I know after that there is a Substring method for strings in C#
            string res = "";
            for (int i = start; i < end; i++)
                res += txt[i];
            return res;
        }

        static bool IsPalindrome(string txt)
        {
            int len = txt.Length;
            for ( int i = 0; i < len / 2; i++)
                if ( txt[i] != txt[len - i - 1])
                    return false;
            return true;
        }

        static void Run()
        {
            WriteLine("Enter Your Text : ");
            string text = "urivin";

            WriteLine(SubString(text, 2, text.Length));
            WriteLine(Solve(text));
            // WriteLine(IsPalindrome(Solve(text)));
        }

        static void Main(string[] args)
        {
            Run();
        }
    }
}
