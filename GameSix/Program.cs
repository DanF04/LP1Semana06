using System;
using static GameSix.Foe;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Foe loki = new Foe("loki");
            loki.Setname(" Grinddalokki ");
            Console.WriteLine($"Name is {loki.Getname()} and HP is {loki.Gethealth()}");

            Console.WriteLine("Insert number of enemies: ");
            int NrOfEnemies = Convert.ToInt32(Console.ReadLine());
            Foe[] allenemies = new Foe[NrOfEnemies];

            for (int i = 0; i < NrOfEnemies; i++)
            {
                Console.WriteLine($"Enemy {i+1} name: ");
                string foename = Console.ReadLine();
                allenemies[i] = new Foe(foename);
            }

            foreach (var foe in allenemies)
            {
                Console.WriteLine($"name: {foe.Getname()}");
            }

            allenemies[0].TakeDamage(50);
            Console.WriteLine($"Damage taken... current health: {allenemies[0].Gethealth()}");
            allenemies[0].PickupPowerUp(PowerUp.health, 60);
            allenemies[0].PickupPowerUp(PowerUp.shield, 10);
            Console.WriteLine($"Picked up two powerups!!! current health: {allenemies[0].Gethealth()} and current shield: {allenemies[0].Getshield()}");
            Console.WriteLine($"Obtained powers: {Foe.Getpower()}");


<<<<<<< HEAD
            Console.WriteLine("Merci d'utiliser ce programme!");
=======
            Console.WriteLine("Thanks for using this program!");
>>>>>>> fb5d092 (final message)



        }
    }
}
