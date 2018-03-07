using System;
using System.Collections.Generic;

namespace human {
    public class Samurai : Human {
        private static int instances = 0;
        public new int health = 200;
        private static string prefix { get; set; } = null;
        public Samurai(string n) : base(n) {
            prefix = "Samurai";
            name = n;
            instances++;
        }

        public void DeathBlow(Human human) {
            if (human == null) {
                Console.WriteLine("\n→ [!!] Enemy does not exist");
            } else {
                if (human.health < 50) {
                    human.health = 0;
                    Console.WriteLine($"\n→ {human.name} is weak! {name} released a Death Blow to end his life!");
                } else {
                    base.Attack(human);
                }
            }
        }

        public void Meditate() {
            health = 200;
            Console.WriteLine($"\n→ [{health} HP] {name} chilled out to full health");
        }
        public static new int HowMany() {
            System.Console.WriteLine($"\n→ [({prefix}) {instances} in the realm]");
            return instances;
        }
    }
}