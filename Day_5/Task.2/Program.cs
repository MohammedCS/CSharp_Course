using System;

namespace Task_2 
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter Number : ");
			int num = Convert.ToInt32(Console.ReadLine());

			if (num < 0)
			{
				Console.WriteLine("Negative Number Aborted!!");
			}
			else if (num % 3 == 0 || num % 7 == 0)
			{
				Console.WriteLine(num + " is Multiple of 3 or Multiple of 7 ");
			}
			else
			{
				Console.WriteLine(num + " isn't Multiple of 3 or 7");
			}
		}
	}
}
