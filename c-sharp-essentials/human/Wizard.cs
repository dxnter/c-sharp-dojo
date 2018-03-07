using System;
using System.Collections.Generic;

namespace human {
    public class Wizard : Human {
        private static int instances = 0;
        public new int health { get; set; } = 50;
        public new int intelligence { get; set; } = 25;
        private static string prefix { get; set; } = null;
        public Wizard(string n) : base(n) {
            prefix = "Wizard";
            name = n;
            instances++;
        }

        public void Heal() {
            health += (intelligence * 10);
            System.Console.WriteLine($"\n→ [{health} HP] {name} was healed for {intelligence * 10} points");
        }

        public void Fireball(Human human) {
            Random rand = new Random();
            human.health -= rand.Next(20, 50);
            System.Console.WriteLine($"\n→ [{health} HP] ({name}) attacked {human.name} with a fireball for 10 points");
        }

        public static new int HowMany() {
            System.Console.WriteLine($"\n→ [({prefix}) {instances} in the realm]");
            return instances;
        }

    }
}