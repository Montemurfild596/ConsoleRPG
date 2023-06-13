using System;

namespace ConsoleRPG {
    public abstract class Entity {
        public string Name {get; set; } = "";
        public int Health { get; set; } = 0;
        public int Armor { get; set; } = 0;
        public int Damage { get; set; } = 0;

        public Entity(string name, int health, int armor, int damage) {
            Name = name;
            Health = health;
            Armor = armor;
            Damage = damage;
        }
        public virtual void Attack(Entity otherEntity) {}

    }
}