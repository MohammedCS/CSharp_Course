using System;

namespace Task_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter num_1 : ");
			int num_1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter num_2 : ");
			int num_2 = Convert.ToInt32(Console.ReadLine());

			int temp = num_1;
			num_1 = num_2;
			num_2 = temp;

			Console.WriteLine();
			Console.WriteLine("num_1 = " + num_1);
			Console.WriteLine("num_2 = " + num_2);

			Console.ReadKey();
		}
	}
}
