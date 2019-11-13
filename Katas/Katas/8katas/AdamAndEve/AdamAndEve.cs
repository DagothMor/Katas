using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._8katas.AdamAndEve
{
    public static class AdamAndEve
    {
        
            public class God
        {
            public static Human[] Create()
            {
                Human[] ArrayOfHumans = new Human[2];

                ArrayOfHumans[0] = new Man();
                ArrayOfHumans[1] = new Woman();
                return ArrayOfHumans;
            }

        }
        public class Human
        {
            public string name;
            public Human() { }
        }
        public class Man : Human { public Man() { } }
        public class Woman : Human { public Woman() { } }


    }
}
