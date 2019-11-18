using System;
using System.Collections.Generic;
using System.Text;
using Katas.Katas.PaginationTest.Model;

namespace Katas.Katas.PaginationTest
{
    public static class PaginationTestStart
    {
        public static void Start()
        {
            var p = new Pagination<int>(
                new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 }
            );
            Console.ReadLine();
        }
    }
}
