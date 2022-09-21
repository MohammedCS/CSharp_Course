using System;

namespace Task_3
{
	class Program 
	{
		static void Main(string[] args)
		{
			int largest = 0, lowest = 0;

			for (int i = 1; i < 4; i++)
			{
				Console.Write("Enter num_" + i + " : ");
				int num = Convert.ToInt32(Console.ReadLine());

				if (i == 1)
				{
					largest = num;
					lowest = num;
				}
				else if (num > largest)
				{
					largest = num;
				}
				else if (num < lowest ) 
				{
					lowest = num;
				}
			}
			Console.WriteLine("\nThe Largest is " + largest);
			Console.WriteLine("The Lowest is " + lowest);
		}
	}
}
