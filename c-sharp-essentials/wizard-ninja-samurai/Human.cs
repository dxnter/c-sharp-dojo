using System;

namespace human {
  public class Human {
    private static int instances = 0;
    public string name { get; set; } = null;
    private static string prefix { get; set; } = null;
    public int strength { get; set; } = 3;
    public int intelligence { get; set; } = 3;
    public int dexterity { get; set; } = 3;
    public int health { get; set; } = 100;
    public Human(string n) {
      prefix = "Human";
      name = n;
      instances++;
    }

    public Human(string n, int s, int i, int d, int h) {
      name = n;
      strength = s;
      intelligence = i;
      dexterity = d;
      health = h;
    }

    public void Attack(Human human) {
      if (human == null) {
        Console.WriteLine("Enemy does not exist");
      } else {
        int damage = strength * 5;
        human.health -= damage;
        Console.WriteLine($"\n→ [{health} HP] ({name}) attacked {human.name} for {damage} points");
      }
    }
    public static int HowMany() {
      System.Console.WriteLine($"\n→ [({prefix}) {instances} in the realm]");
      return instances;
    }
  }
}