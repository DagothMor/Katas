using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.OtherProjects.TrainWithDictionary
{
    public static class TrainWithDictionary
    {
        public static void Start()
        {
            Dictionary<int, string> RatingTable = new Dictionary<int,string>();

            Console.WriteLine("enter the count of champions");

            int Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < Count+1; i++)
            {
                Console.WriteLine($"enter the Champion name what took {i} place ");

                RatingTable.Add(i,Convert.ToString(Console.ReadLine()));

            }

            Console.ReadLine();

            
            bool isfounded =false;
            int times = 0;
            while (isfounded==false||times!=10)
            {
                Console.WriteLine("enter the number of place");

                int FindNameByPlace = Convert.ToInt32(Console.ReadLine());
                if (FindNameByPlace > Count | FindNameByPlace < 1) { Console.WriteLine("UPIKZEWRONGHOUSEFOOL"); }
                else { Console.WriteLine($"name:{RatingTable[FindNameByPlace]}");
                    isfounded = true;
                    times++;
                }
            }
            

            Console.ReadLine();
        }
    }
}
