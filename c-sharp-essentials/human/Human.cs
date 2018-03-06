using System;

namespace human {
  public class Human {
    public string name;
    public int strength = 3;
    public int intelligence = 3;
    public int dexterity = 3;
    public int health = 100;
    public Human(string inputName) {
      name = inputName;
    }

    public Human(string inputName, int inputStrength, int inputIntelligence, int inputDexterity, int inputHealth) {
      name = inputName;
      strength = inputStrength;
      intelligence = inputIntelligence;
      dexterity = inputDexterity;
      health = inputHealth;
    }

    public void Attack(object target) {
      Human enemy = target as Human;
      if (enemy == null) {
        Console.WriteLine("Enemy does not exist");
      } else {
        int damage = strength * 5;
        enemy.health -= damage;
        Console.WriteLine("Attacked {0} for {1} damage", enemy.name, damage);
      }
    }
  }
}