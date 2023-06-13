using System;

namespace ConsoleRPG {
    public static class Program {
        static void Main(string[] args) {
            Random rnd = new Random();
            int health = 100;
            int armor = rnd.Next(0, 10);
            int damage = rnd.Next(1, 15);
            while (health > 0) {
                int move = rnd.Next(1, 4);
                if (move == 1) {
                    Console.WriteLine("Бой");
                    Console.WriteLine($"Hp : {health}, Armor : {armor}, Damage : {damage}");
                    int enemyHealth = rnd.Next(1, 11) * 10;
                    int enemyArmor = rnd.Next(0, 8);
                    int enemyDamage = rnd.Next(1, 10);
                    while (enemyHealth > 0 && health > 0) {

                        if (rnd.Next(1, 3) == 1) {
                            enemyHealth -= (damage - enemyArmor > 0 ? damage - enemyArmor : 0);
                        }
                        else 
                        {
                            health -= (enemyDamage - armor > 0 ? enemyDamage - armor : 0);
                        }
                        Console.WriteLine($"Player Hp : {health}, Armor : {armor}, Damage : {damage}");
                        Console.WriteLine($"Enemy1 Hp : {enemyHealth}, Armor : {enemyArmor}, Damage : {enemyDamage}");                    
                    }
                }
                else 
                {
                    Console.WriteLine("Ничего не произошло");
                }
                
            }
        }
    }
}

