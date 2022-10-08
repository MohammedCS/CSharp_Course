using System;
using System.Collections.Generic;
using static System.Console;

#nullable disable

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter the text : ");
            string text = ReadLine();
            Stack<string> res = new Stack<string>();
            bool check = false;
            
            for ( int i = 0; i < text.Length; i++ )
                if (text[i] == '{' || text[i] == '(' || text[i] == '[')
                    res.Push(text[i].ToString());
                else if (check)
                {
                    
                }

            if (res.Count() == 0)
                WriteLine("Valied");
            else
                WriteLine("NotValied");
        }
    }
}
