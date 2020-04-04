using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Katas._8katas.AdamAndEve.Models
{
    public class Man : Human
    {
        private int DickSize { get; set; }


        public Man()
        {
            DickSize = 12;

        }

        public Man(int dicksize) { DickSize = dicksize; }

    }
}
