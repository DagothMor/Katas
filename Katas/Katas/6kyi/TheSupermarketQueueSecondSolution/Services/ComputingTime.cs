using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._6kyi.TheSupermarketQueueSecondSolution.Services
{
    public static class ComputingTime
    {
        public static int StartComputing(int[] customers, int tills)
        {
            Console.WriteLine("Full in the queue");

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < customers.Length; i++)
            {
                queue.Enqueue(customers[i]);
            }

            Console.WriteLine("Queue is fulled");

            Console.WriteLine("Starting full in tills");

            List<int> Tills = new List<int>();

            for (int i = 0; i < tills; i++)
            {
                Tills.Add(0);
            }

            Console.WriteLine("Tills are fulled");

            Console.WriteLine("Start the Cycle");

            while (Tills[0] != default)
            {
                for (int i = 0; i < Tills.Count; i++)
                {
                    if (queue != null)
                    {
                        if (Tills[i] == 0)
                        {
                            Tills[i] = queue.Dequeue();
                        }
                    }

                }//full in all tills

                for (int i = 0; i < Tills.Count; i++)
                {
                    
                }
            }






            return 0;
        }
    }
}
