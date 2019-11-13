using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._8katas.AdamAndEve.Models
{
    class Woman:Human
    {
        private int WashingDishPerMinute { get; set; }

        public Woman() { WashingDishPerMinute = 10; }

        public Woman(int speed) { WashingDishPerMinute = speed; }



    }
}
