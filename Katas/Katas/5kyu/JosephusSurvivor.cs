using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Codewars.Katas._5kyu
{
    public static class JosephusSurvivor
    {
        public static void Start()
        {
            Console.WriteLine("Press any key to start");
            Console.ReadLine();
            //Do Something
            Console.WriteLine("Enter the count of elements");
            int CountOfElements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the step");
            int step = Convert.ToInt32(Console.ReadLine());
            int answer = JosSurvivor(CountOfElements, step);
            Console.WriteLine("Press any key to end");
            Console.ReadLine();
        }
        public static int JosSurvivor(int n, int k)
        {
            // your code
            List<int> listOfElements = ListGenerator(n);
            int point = k;
            while (listOfElements.Count > 1)
            {
                DisplayList(ref listOfElements);
                DeleteElementFromListOnPoint(ref listOfElements,point);
                BackPoint(ref listOfElements,ref point);
                ShiftPoint(ref listOfElements,ref point,k);
            }
            return listOfElements[0];

        }

        public static List<int> ListGenerator(int number)
        {
            List<int> listout = new List<int>();
            for (int i = 0; i < number; i++)
            {
                listout.Add(i + 1);

            }
            return listout;
        }

        public static void DeleteElementFromListOnPoint(ref List<int> listin, int point)
        {
            while (point > listin.Count)
            {
                point -= listin.Count;
            }
            listin.RemoveAt(point);

        }

        public static void BackPoint(ref List<int> listin,ref int point)
        {
            if (point == 0)
            {
                point = listin.Count - 1;
            }
            else
            {
                point--;
            }
        }

        public static void ShiftPoint(ref List<int> Listin,ref int point,int step)
        {
            point += step;
            while (point>=Listin.Count)
            {
                point -= Listin.Count;
            }
        }

        public static void DisplayList(ref List<int> listin)
        {
            for (int i = 0; i < listin.Count; i++)
            {
                Console.WriteLine(listin[i]);
            }
        }
    }
}
