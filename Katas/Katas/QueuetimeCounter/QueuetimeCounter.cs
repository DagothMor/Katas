using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Katas.Katas.Remove_All_The_Marked_Elements_of_a_List.Services;

namespace Katas.Katas.QueuetimeCounter
{
    public static class QueuetimeCounter
    {
        public static void Start()
        {
            List<int> A = AddIntegerArray.Add().ToList();

            Console.WriteLine("какой индекс у твоего дружка пирожка");

            int IndexFriend = Convert.ToInt32(Console.ReadLine());

            int n = Queue.Compute(A,IndexFriend);

            Console.WriteLine("обработанный массив");

            for (int i = 0; i < A.Count; i++)
            {
                Console.Write(A[i]);
            }
            Console.WriteLine("Сколько времени потребовалось");

            Console.WriteLine(n);
        }
    }
}
