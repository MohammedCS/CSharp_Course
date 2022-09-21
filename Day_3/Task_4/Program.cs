using System;

namespace Task_4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter angle_1 : ");
			int angle_1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter angle_2 : ");
			int angle_2 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter angle_3 : ");
			int angle_3 = Convert.ToInt32(Console.ReadLine());

			bool condition = (angle_1 + angle_2 + angle_3) == 180;

			Console.WriteLine("Does the angles make triangle? " + condition);
		}
	}
}
