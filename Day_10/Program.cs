using System;
using static System.Console;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            CList dream = new CList();

            dream.Add("Ali");
            dream.Add("Mohammed");
            dream.Add("Maged");
            dream.Add("Amr");
            dream.Add("Ahmed");
            dream.Add("Gamal");
            dream.RemoveItem("Maged");

            dream.Print();


        }
    }
}
