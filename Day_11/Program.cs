using System;
using System.Collections.Generic;
using static System.Console;

#nullable disable

namespace Task
{
    class Program
    {
        static bool MyCompiler(string text)
        {
            Stack<string> res = new Stack<string>();

            for ( int i = 0; i < text.Length; i++ )
            {
                if ( text[i] == '{' || text[i] == '[' || text[i] == '(')
                {
                    res.Push(text[i].ToString());
                }
                else
                {
                    if ( res.Count != 0)
                    {
                        if (text[i] == '}' && res.Peek() == "{")
                            res.Pop();
                        else if (text[i] == ')' && res.Peek() == "(")
                            res.Pop();
                        else if (text[i] == ']' && res.Peek() == "[")
                            res.Pop();
                        else
                            return false;
                    }
                    else
                        return false;
                }

            }

            if ( text.Length == 0 || res.Count != 0)
                return false;
            else
                return true;
        }

        static void Run()
        {
            while (true)
            {
                Write("Enter the text : ");
                string text = ReadLine();

                if (MyCompiler(text))
                    WriteLine("Valied");
                else
                    WriteLine("Not_Valied");
            }
        }

        static void Main(string[] args)
        {
            Run();
        }
    }
}

