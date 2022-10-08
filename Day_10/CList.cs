using System;
using static System.Console;

namespace OOP
{
    class CList
    {
        public string[] array = new string[0];

        public void Add(string item)
        {
            string[] newArray = new string[array.Length + 1];

            for ( int i = 0; i < array.Length; i++)
                newArray[i] = array[i];
            
            newArray[newArray.Length - 1] = item;
            array = newArray;
        }

        public void Insert(string item, int index)
        {
            string[] newArray = new string[array.Length + 1];
            int n = 0;
            bool check = true;

            for ( int i = 0; i < array.Length; i++)
            {
                if (i == index && check)
                {
                    newArray[i] = item;
                    n = 1;
                    i--;
                    check = false;
                    continue;
                }
                newArray[n + i] = array[i];
            }

            array = newArray;
        }

        public void Remove()
        {
            string[] newArray = new string[array.Length - 1];

            for ( int i = 0; i < array.Length - 1; i++)
                newArray[i] = array[i];
            array = newArray;
        }

        public void RemoveAt(int index)
        {
            string[] newArray = new string[array.Length - 1];
            int n = 0;
            bool check = true;

            for ( int i = 0; i < array.Length; i++)
            {
                if (i == index && check)
                {
                    n = 1;
                    i--;
                    check = false;
                    continue;
                }
                newArray[i] = array[i + n];
            }
            array = newArray;
        }

        public void RemoveItem(string item)
        {
            string[] newArray = new string[array.Length - 1];
            int n = 0;
            bool check = true;

            for ( int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == item && check)
                {
                    n = 1;
                    i--;
                    check = false;
                    continue;
                }
                newArray[i] = array[i + n];
            }
            array = newArray;
        }

        public void Print()
        {
            for ( int i = 0; i < array.Length; i++ )
                WriteLine(array[i]);
        }
    }
}
