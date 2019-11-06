using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    public static class CreateFighter
    {
        public static Fighter Createfighter()
        {
            string EName;

            Int32 EHealth, EDPA;

            Console.WriteLine("creating Fighter");

            Console.WriteLine("Enter his Name ");

            EName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter his health ");

            EHealth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter his DamagePerAttack");

            EDPA = Convert.ToInt32(Console.ReadLine());

            Fighter fighter = new Fighter(EName, EHealth, EDPA);

            return (fighter);

        }
    }
}
