﻿using System;

namespace GameSix
{
    public class Foe
    {
        private string name {get ; set;}
        private float health {get ; set;}
        private float shield {get ; set;}
        private static int powercounter {get ; set;}

        public Foe(string name)
        {
            Setname(name);
            health = 100;
            shield = 0;
            powercounter = 0;
        }

        public string Getname()
        {
            return name;
        }
        public float Gethealth()
        {
            return health;
        }
        public float Getshield()
        {
            return shield;
        }

        public static int Getpower()
        {
            return powercounter;
        }

        public void Setname(string newname)
        {
            
            newname = newname.Trim();
            this.name = newname;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public void PickupPowerUp(PowerUp PU, float F)
        {
            powercounter += 1;
            
            if (PU == PowerUp.health)
            {
                health += F;
                if (health > 100)
                {
                    health = 100;
                }
            }

            if (PU == PowerUp.shield)
            {
                shield += F;
                if (shield > 100)
                {
                    shield = 100;
                }
            }
        
        }

    }
   
        
}