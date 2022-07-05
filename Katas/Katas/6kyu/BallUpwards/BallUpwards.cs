using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._6kyu.BallUpwards
{
	public static class BallUpwards
	{
        private const double GRAVITATIONAL_EARTH_ACCELERATION = 9.81;
        private const double KILOMETERS_PER_HOUR = 3.6;

        public static int Start(int v0)
		{
			var speed = (double)(v0 / KILOMETERS_PER_HOUR);
			double time = 0;
			var arr = new double[] { 0, 0 };
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
		public static double GetHeightByTime(double time, double speed)
		{
			return speed * time - (double) (0.5 * GRAVITATIONAL_EARTH_ACCELERATION * (double) time * (double) time);
		}
		public static double GetSpeedByTime(double time, double speed)
		{
			return speed - GRAVITATIONAL_EARTH_ACCELERATION * time;
		}
	}
}
