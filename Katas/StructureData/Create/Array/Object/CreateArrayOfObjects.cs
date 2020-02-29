using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.StructureData.Create.Array.Object
{
    public static class CreateArrayOfObjects
    {
        public static object[] Create()
        {

            List<object> list = new List<object>();

            string answer = "";

            Console.WriteLine("enter the count of objects");

            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                answer = "";
                Console.WriteLine("Is it string?Press y-yes/n-no");
                answer = Convert.ToString(Console.ReadLine());
                if (answer == "y" || answer == "Y")
                {
                    list.Add(Convert.ToString(Console.ReadLine()));
                }
                else
                {
                    list.Add(Convert.ToInt32(Console.ReadLine()));
                }
            }
            return list.ToArray();
        }
    }
}
