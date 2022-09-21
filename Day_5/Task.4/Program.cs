using System;

namespace Task_4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the firstr number : ");
			int num_1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the firstr number : ");
			int num_2 = Convert.ToInt32(Console.ReadLine());

			if (Math.Abs(num_2 - 20) > Math.Abs(num_1 - 20))
			{
				Console.WriteLine(num_1 + " is the nearest number to 20");
			}
			else if (Math.Abs(num_2 - 20) < Math.Abs(num_1 - 20))
			{
				Console.WriteLine(num_2 + " is the nearest number to 20");
			}
			else
			{
				Console.WriteLine(0);
			}
		}
	}
}
