using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._6kyi.ChristmasTree
{
    public static class ChristmasTreeSecondVersion
    {
        public static void Start()
        {
            Console.WriteLine("Press enter to start");
            Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            string tree = "";
            int count = 1; 
            if (n > 0)
            {
                if (n < 101)
                {
                    for (int i = n - 1; i > 0; i--)
                    {
                        tree += new String(' ', i);
                        tree += new String('*', count);
                        tree += new String(' ', i);
                        tree += "\n";
                        count += 2;
                    }
                    tree += new String('*', count);
                }

                if (n > 101)
                {
                    tree = "";
                }
            }

            Console.WriteLine(tree);
            Console.ReadLine();
        }
    }
}
