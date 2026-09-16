using System;

namespace ConditionalsHUD
{
    internal class Program
    {
        static int health;

        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;

            health = 100;

            Console.WriteLine("Conditionals");
            HUD();
            TakeDamage(20);
            HUD();
            TakeDamage(40);
            HUD();
            Heal(10);
            HUD();
            Heal(20);
            HUD();
            Heal(40);
            HUD();
            TakeDamage(60);
            HUD();
            TakeDamage(50);
            HUD();
            Console.ReadKey();
        }

        static void TakeDamage(int dmg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYou Took " + dmg + " damage");
            health = health - dmg;

            Console.ForegroundColor = ConsoleColor.White;
            if (health <= 0)
            {
                health = 0;

                Console.WriteLine("\nYou Died!");
                Console.WriteLine("Game Over");
            }
        }

        static void Heal(int hp)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nYou healed " + hp + " health");
            health = health + hp;

            Console.ForegroundColor = ConsoleColor.White;
            if (health >= 100)
            {
                health = 100;

                Console.WriteLine("\nYour health is full.");
            }
        }

        static void HUD()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n----HUD------");
            Console.WriteLine("Health: " + health);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
