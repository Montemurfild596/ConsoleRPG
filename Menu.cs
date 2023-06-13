using System;

namespace ConsoleRPG {
    public static class Menu {
        static string defaultPlayerName = "Player";
        static int defaultPlayerHealth = 100;
        static int defaultPlayerArmor = 5;
        static int defaultPlayerDamage = 10;
        static string[] defaultEnemyNames = new string[] {"Колдун ебучий", "Варвар пендосский", "Чуркоящер"};
        [NonSerialized]
        static Random rnd = new Random();
        public static void Execute() {
            Player player = new Player(defaultPlayerName, defaultPlayerHealth, defaultPlayerArmor, defaultPlayerDamage);
            while (player.Health > 0) {
                int move = rnd.Next(1, 4);
                if (move == 1) {
                    Console.WriteLine("Бой");
                    Enemy enemy = new Enemy(defaultEnemyNames[rnd.Next(0, defaultEnemyNames.Length)], rnd.Next(1, 11) * 10, rnd.Next(0, 8), rnd.Next(1, 10));
                    Console.WriteLine(player.ToString());
                    Console.WriteLine(enemy.ToString());
                    while (enemy.Health > 0 && player.Health > 0) {
                        if (rnd.Next(1, 3) == 1) {
                            player.Attack(enemy);
                        }
                        else {
                            enemy.Attack(player);
                        }
                        Console.WriteLine(player.ToString());
                        Console.WriteLine(enemy.ToString());
                    }
                }
                else {
                    Console.WriteLine("Ничего не произошло");
                }

            }
            Console.WriteLine("Вы проиграли!");
        }
    }
}