using System;
using System.Collections.Generic;
using System.Text;
using Katas.Katas.QueuetimeCounter.Service;

namespace Katas.Katas.QueuetimeCounter
{
    public static class Queue
    {
        public static int Compute(List<int> l,int friendindex)
        {
            bool flag = false;
            int n=0;
            Console.WriteLine("проверяем нужны ли билеты другу вообще");
            if (l[friendindex] == 0)
            {
                flag = true;
                Console.WriteLine("нет не нужны");
            }
            Console.WriteLine("нужны,чекаем есть ли в очереди нули");
            if (flag == false)
            {
                for (int i = 0; i < l.Count; i++)
                {
                    if (l[i] == 0)
                    {
                        Console.WriteLine("есть прохожий,удаляем его");
                        l.RemoveAt(i);
                        if (i < friendindex)
                        {
                            friendindex--;
                        }
                        i--;
                        Console.WriteLine("Индекс друга"+friendindex);
                    }
                }

                Console.WriteLine("Нулей нет");

                while (l[0] != 1 | friendindex != 0)
                {
                    if (l[0] == 1)
                    {
                        l.RemoveAt(0);
                        friendindex--;
                        n++;
                        WriteList.Write(l);
                    }
                    else
                    {
                        if (friendindex == 0)
                        {
                            l = ShiftingList.ShiftList(l);
                            l[l.Count - 1] -= 1;
                            friendindex = l.Count - 1;
                            n++;
                            WriteList.Write(l);
                        }
                        else
                        {
                            l = ShiftingList.ShiftList(l);
                            l[l.Count - 1] -= 1;
                            friendindex--;
                            n++;
                            WriteList.Write(l);
                        }
                    }
                }

            }


            return n+1;
        }
    }
}
