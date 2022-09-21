using System;

namespace Task_6
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Input number of terms: ");
			int num = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= num; i++)
			{
				int res = i * i * i; 
				Console.WriteLine("Number is : " + i + " and cube of the " + i + " is : " + res);
			}
		}
	}
}
