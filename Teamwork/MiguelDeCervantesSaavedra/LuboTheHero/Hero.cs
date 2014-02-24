using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public class Hero : Creature, ICreature
    {
        //public Inventory MyInventory { get; set; }

        public Hero()
            : base()
        {
        }

        //a method which determines wheter or not the two oppnents can start a fight
        public void Fight(Hero hero, Monster monster)
        {
            //if(hero.DistanceTo(monster) <= hero.lineOfSight) -- there will be a method for calculating distances between creatures
            //if both oppnents are alive
            if (hero.IsAlive && monster.IsAlive)
            {
                //if both opponets health is still a positive number
                while (hero.Health > -1 && monster.Health > -1)
                {
                    //whomever has the highest initiative can strike first
                    if (hero.Initiative > monster.Initiative)
                    {
                        Attacking(hero, monster);
                        Defending(hero, monster);
                    }
                    else
                    {
                        Defending(hero, monster);
                        Attacking(hero, monster);
                    }

                }

              /*
                if (hero.Health <= -1)
                {
                    hero.IsAlive = false;
                    Console.WriteLine("Monster won the fight.");
                }
                if (monster.Health <= -1)
                {
                    monster.IsAlive = false;
                    Console.WriteLine("{0} won the fight", hero.Name);
                } */
            }
        }


        
        public void Attacking(Hero hero, Monster monster)
        {
            if (hero.IsDefending != true)
            {
                //insert RandomGeneratorVariable 1-10
                if (hero.Attack + 10 >= monster.Armour)
                    hero.IsAttacking = true;
                while (hero.IsAttacking)
                {
                    monster.IsDefending = true;
                    if (hero.PhysicalDamage - monster.Armour > 0)
                    {
                        monster.Health -= (hero.PhysicalDamage - monster.Armour);
                        Console.WriteLine("Damage done {0}", hero.PhysicalDamage - monster.Armour);
                    }
                    else Console.WriteLine("Miss");
                    hero.IsAttacking = false;
                    monster.IsDefending = false;
                }
            }
        }
        public void Defending(Hero hero, Monster monster)
        {
            if (hero.IsAttacking != true)
            {
                //insert RandomGeneratorVariable 1-10
                if (hero.Armour <= monster.Attack + 10)
                    hero.IsDefending = true;
                while (hero.IsDefending)
                {
                    monster.IsAttacking = true;
                    if (monster.PhysicalDamage - hero.Armour > 0)
                    {
                        hero.Health -= (monster.PhysicalDamage - hero.Armour);
                        Console.WriteLine("Hero health left: {0}", hero.Health);
                    }
                    hero.IsDefending = false;
                    monster.IsAttacking = false;
                }
            }
        }

    }
}
