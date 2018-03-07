using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human danny = new Human("Danny");
            Human robert = new Human("Robert");

            Wizard charles = new Wizard("Charles");

            Ninja cindy = new Ninja("Cindy");

            Samurai sammy = new Samurai("Sammy");

            charles.Heal();
            charles.Fireball(danny);
            danny.Attack(robert);

            cindy.Steal(charles);
            cindy.GetAway();

            sammy.DeathBlow(charles);
            sammy.DeathBlow(charles);
            sammy.DeathBlow(charles);
            sammy.DeathBlow(charles);

            sammy.Meditate();

            Ninja.HowMany();
        }
    }
}
