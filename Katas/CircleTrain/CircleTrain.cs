using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace Katas.CircleTrain
{
    public static class CircleTrain
    {
        public static void Start()
        {
            Console.WriteLine("Press any key to start");
            Console.ReadLine();
            bool[] train = RandomlyGeneratedArray
                (RandomGeneratedCountOfCarriages());
            int Count = CountOfCarriages(train);
            Console.WriteLine(Count);
            Console.WriteLine("Press any key to end");
            Console.ReadLine();

        }

        public static int RandomGeneratedCountOfCarriages()=>new Random().Next(10);
        public static bool[] RandomlyGeneratedArray(int Count)
        {
            List<bool> train = new List<bool>();
            Random random = new Random();
            for (int i = 0; i < Count; i++)
            {
                train.Add(random.Next(100) < 50?true:false);
            }
            return train.ToArray();
        }
        public static void DisplayTrainAndMap(bool[] train,List<bool> map) {
            foreach (var light in train)
            {
                Console.Write("["+light+"]-");
            }
            Console.WriteLine("");
            Console.WriteLine(new string('_',train.Length));
            foreach (var carriage in map)
            {
                Console.Write("[" + carriage + "]-");
            }
            Console.WriteLine(new string('_', train.Length));
            Console.WriteLine("");
        }
        public static int CountOfCarriages(bool[] train)
        {
            bool flag = false;
            int Count = 0;
            int step = 0;   
            List<bool> map = new List<bool>(1){false};
            while (flag == false)
            {
                DisplayTrainAndMap(train, map);
                TurnSwitchOnTrainAndMap(train,map, Count,true);
                DisplayTrainAndMap(train, map);
                Count++;
                map.Add(NextCarriage(Count,train));
                if (map[Count] == true)
                {
                    TurnSwitchOnTrainAndMap( train, map, Count,false);
                    DisplayTrainAndMap(train, map);
                    if (train[0] == false)
                    {
                        flag = true;
                        break;
                    }
                }
            }
            return map.Count-1;
        }
        public static bool NextCarriage(int Count, bool[] train)
        {
            if (Count == train.Length)
            {
                return train[0];

            }
            if (Count > train.Length)
            {
                return train[Count%train.Length];
            }

            return train[Count];
        }
        public static void TurnSwitchOnTrainAndMap(bool[] train,List<bool> map,int index,bool inputbool)
        {
            map[index] = inputbool;
            if (index == train.Length)
            {
                index = 0;
            }

            if (index > train.Length)
            {
                index %= train.Length;
            }
            train[index] = inputbool;
        } }
}
