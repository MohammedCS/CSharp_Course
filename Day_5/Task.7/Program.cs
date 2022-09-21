using System;

namespace Task_7
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = 0;
			for (int i = 1; i < 5; i++)
			{
				Console.Write("Enter num_" + i + " : ");
				num += Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("The Result = " + num);
		}
	}
}
