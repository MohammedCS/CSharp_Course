using System;

namespace In_Lap
{
    class CList
    {
        public string[] arr = new string[0];

        public void Insert(string item, int index)
        {
            string[] newArray = new string[arr.Length + 1];

            for (int i = 0; i < index; i++)
                newArray[i] = arr[i];

            newArray[index] = item;

            for (int i = index + 1; i < arr.Length; i++)
                newArray[i] = arr[i];
            
            arr = newArray;

        }

    }
}
