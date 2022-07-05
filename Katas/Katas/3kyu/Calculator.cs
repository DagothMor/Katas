using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars.Katas._3kyu
{
	public static class Calculator
	{
		public static void Start()
		{
			Console.WriteLine("Press any key to start");
			Console.ReadLine();
			Console.WriteLine("Enter the expression");
			Console.WriteLine($"The answer is\n{Evaluate(Console.ReadLine())}");
			Console.WriteLine("Press any key to end");
			Console.ReadLine();
		}
		public static double Evaluate(string expression)
		{

			return 0;
		}
		public static string ReturnOperation(string evaluate)
		{
			return "";
		}
	}
}
