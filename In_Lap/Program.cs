using System;

namespace In_Lap
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter num : ");
			int num = Convert.ToInt32(Console.ReadLine());
			int count = 1;

			while(num != 0)
			{
				Console.WriteLine((num % 10) * count);
				count *= 10;
				num /= 10;
			}
		}
	}
}
