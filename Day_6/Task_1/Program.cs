using System;

namespace Task_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter Your Number : ");
			int num = Convert.ToInt32(Console.ReadLine());

			while(num != 0)
			{
				Console.WriteLine(num % 10);
				num /= 10;
			}
		}
	}
}
