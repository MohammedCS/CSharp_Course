using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
	internal class Program
	{
		static void Main(string[] args)
		{
	        int [] array = new int[5];
            Console.WriteLine("Please Enter 5 numbers");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter num_" + (i + 1) + " : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++) 
            {
                double cubed = Math.Pow(array[i], 3);
                Console.WriteLine("Number is : " + array[i] + " and cube of it is : " + cubed);
            }

            Console.ReadKey();
		}
	}
}
