using System;

namespace ConsoleRPG {
    public class Player : Entity 
    {
        public Player(string name, int health, int armor, int damage) : base (name, health, armor, damage){
            
        }

        public override void Attack(Entity otherEntity)
        {
            int attackDamage = Damage - otherEntity.Armor;
            if (attackDamage > 0) {
                otherEntity.Health -= attackDamage;
            }
        }
    }
}