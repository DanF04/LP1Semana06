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
        }
    }
}
