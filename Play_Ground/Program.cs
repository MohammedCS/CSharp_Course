using System;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;

namespace Task_1
{
	class Program
	{
		static void Main(string[] args)
		{
            Write("Enter the text : ");
            string text = ReadLine();
            int count = 0;

            for ( int i = 0; i < text.Length; i++ )
                if ( text[i] == '{' || text[i] == '(' || text[i] == '[')
                    count++;
                else
                    count--;
            
            if (count == 0) 
                WriteLine("Yes");
            else
                WriteLine("No");

		}
	}
}
