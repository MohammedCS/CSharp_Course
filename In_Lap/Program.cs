using System;
using System.Collections.Generic;
using static System.Console;

namespace In_Lap
{
	class Program
	{
        static int Solve(string txt)
        {
            List<int> lister = new List<int>();
            int res = 0;

            for (int i = 0; i < txt.Length; i++)
            {
                if ( txt[i] == 'I')
                    lister.Add(1);
                else if (txt[i] == 'V')
                    lister.Add(5);
                else if (txt[i] == 'X')
                    lister.Add(10);
                else if (txt[i] == 'L')
                    lister.Add(50);
                else if (txt[i] == 'C')
                    lister.Add(100);
                else if (txt[i] == 'D')
                    lister.Add(500);
                else if (txt[i] == 'M')
                    lister.Add(1000);
            }

            for ( int i = 0; i < lister.Length - 1; i++)
            {
                if ( lister[i] >= lister[i + 1]) 
                {
                    res += lister[i];
                }
                else
                {
                    res += lister.[i + 1] - lister[i];
                }
            }
            return res;
        }

        static void Run()
        {
            Write("Enter the text : ");
            string text = ReadLine();

            WriteLine(Solve(text));
        }
		static void Main(string[] args)
		{
           Run();
		}
	}
}
