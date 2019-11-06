using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    public static class StartFight
    {
        public static string DeclareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            string Winner;
            if (firstAttacker == fighter1.Name)
            {
                Winner = Fight(fighter1, fighter2);
            }
            else
            {
                Winner = Fight(fighter2, fighter1);
            }
            return Winner;
        }
        public static string Fight(Fighter Attacker, Fighter Defender)
        {
            do
            {
                Defender.Health -= Attacker.DamagePerAttack;
                if (Defender.Health <= 0) { return Attacker.Name; }
                Attacker.Health -= Defender.DamagePerAttack;
                if (Attacker.Health <= 0) { return Defender.Name; }
            }
            while (Attacker.Health > 0 || Defender.Health > 0);
            if (Attacker.Health <= 0)
            {
                return Defender.Name;
            }
            else { return Attacker.Name; }
        }
    }
}
