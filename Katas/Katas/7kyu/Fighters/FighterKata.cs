using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.Service
{
    public static class FightersKata
    {
        public static void Start()
        {
            string FirstAttacker;

            string Winner;

            Fighter fighter1 = CreateFighter.Createfighter();

            Fighter fighter2 = CreateFighter.Createfighter();

            Console.WriteLine("Кто первый атакует? введи 1 или 2");

            FirstAttacker = Convert.ToString(Console.ReadLine());

            Winner = StartFight.DeclareWinner(fighter1, fighter2, FirstAttacker);

            Console.WriteLine("Победил" + Winner);
        }
    }
}
