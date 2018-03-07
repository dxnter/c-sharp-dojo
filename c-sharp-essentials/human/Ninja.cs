using System;
using System.Collections.Generic;

namespace human {
    public class Ninja : Human {
        private static int instances = 0;
        public new int dexterity { get; set; } = 175;
        private static string prefix { get; set; } = null;
        public Ninja(string n) : base(n) {
            prefix = "Ninja";
            name = n;
            instances++;
        }

        public void Steal(Human human) {
            if (human == null) {
                Console.WriteLine("→ [!!] Enemy does not exist");
            } else {
                base.Attack(human);
                health += 15;
                System.Console.WriteLine($"\n→ [{health} HP] ({name}) stole 15 HP from {human.name}");
            }
        }

        public void GetAway() {
            health -= 15;
            System.Console.WriteLine($"\n→ [{health} HP] ({name}) escaped and lost 15 HP!");
        }
        public static new int HowMany() {
            System.Console.WriteLine($"\n→ [({prefix}) {instances} in the realm]");
            return instances;
        }
    }
}