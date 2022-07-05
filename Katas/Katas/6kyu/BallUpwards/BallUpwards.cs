using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._6kyu.BallUpwards
{
	public static class BallUpwards
	{
		public static int Start(int v0)
		{
			var speed = (decimal)(v0 /3.6);
			decimal time = 0;
			var arr = new decimal[] { 0, 0 };
			while (arr[1] >= arr[0])
			{
				arr[0] = arr[1];
				arr[1] = GetHeightByTime(time, speed);
				time += 0.1;
				speed = GetSpeedByTime(time, speed);
				Console.WriteLine($"{arr[0]}|"+$"|{arr[1]}");
				Console.WriteLine("___");
			}
			return (int)Math.Floor(time);
		}
		public static decimal GetHeightByTime(decimal time, decimal speed)
		{
			return speed * time - (decimal) (0.5 * 9.81 * (double) time * (double) time);
		}
		public static decimal GetSpeedByTime(decimal time, decimal speed)
		{
			return speed - 9.81 * time;
		}
	}
}
