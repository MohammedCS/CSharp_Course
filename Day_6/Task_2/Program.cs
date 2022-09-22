using System;

namespace Task_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter Your Num : ");
			int num = Convert.ToInt32(Console.ReadLine());

			int temp = 1;
			while(num != 0)
			{
				Console.WriteLine((num % 10) * temp);
				num /= 10;
				temp *= 10;
			}
		}
	}
}
