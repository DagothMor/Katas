using System;
using System.Collections.Generic;
using System.Text;
using Katas.Katas._8katas.GenerateRangeOfIntegers.Services;

namespace Katas.Katas._8katas.GenerateRangeOfIntegers
{
    public static class GenerateRangeOfIntegers
    {
        public static void Start()
        {
            Console.WriteLine("Enter the minimum number");

            int minimumNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the maximum number");

            int maximumNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the step");

            int step = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Making the new array");

            int[] array = RangeArrayMaker.Start(minimumNumber, maximumNumber, step);



        }
    }
}
