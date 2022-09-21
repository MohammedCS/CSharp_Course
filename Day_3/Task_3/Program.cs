using System;

namespace Task_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter num_1 : ");
			int num_1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter num_2 : ");
			int num_2 = Convert.ToInt32(Console.ReadLine());

			int temp = 20;
			int near = Convert.ToInt32(Math.Abs(temp - num_1) > Math.Abs(temp - num_2));

			Console.WriteLine("num_" + ((near % 2) + 1) + " is the nearest number to 20");
		}
	}
}
