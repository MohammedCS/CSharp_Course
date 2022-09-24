using System;

namespace Play_Ground
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter you name : ");
			string name = Console.ReadLine();
			
			Console.Write("Enter your degree in arabic : ");
			int arabic = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter your degree in English : ");
			int English = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter your degree in math : ");
			int math = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter your degree in science : ");
			int science = Convert.ToInt32(Console.ReadLine());

			int total = arabic + English + math + science;
			
			if (total < 50 && total >= 0)
			{
				Console.WriteLine(name + "'s degree is F");
			}
			else if (total >= 50 && total < 65)
			{
				Console.WriteLine(name + "'s degree is D");
			}
			else if (total >= 65 && total < 75)
			{
				Console.WriteLine(name + "'s degree is B");
			}
			else if (total >= 75 && total < 85)
			{
				Console.WriteLine(name + "'s degree is B+");
			}
			else if (total >= 85 && total <= 100)
			{
				Console.WriteLine(name + "'s degree is A");
			}
			else
			{
				Console.WriteLine("Wrong Number");
			}
			Console.ReadKey();
		}
	}
}
