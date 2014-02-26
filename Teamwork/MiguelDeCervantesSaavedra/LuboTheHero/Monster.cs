using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public class Monster : Creature, ICreature
    {
        public Monster(int health, byte phisicalDamage, byte spellDamge, byte initiative, int lineofSight)
        {
            this.Health = health;
            this.PhysicalDamage = phisicalDamage;
            this.SpellDamage = spellDamge;
            this.Initiative = initiative;
            this.LineOfSight = lineofSight;
            this.IsAlive = true;
        }

        public void Fight(Hero hero, Monster monster)
        {
            //if(monster.DistanceTo(hero) <= monster.lineOfSight) -- there will be a method for calculating distances between creatures
            if (monster.IsAlive && hero.IsAlive)
            {
                //dynamic turn = null;

                while (monster.Health > -1 && hero.Health > -1)
                {
                    if (monster.Initiative > hero.Initiative)
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

                if (hero.Health <= -1)
                {
                    hero.IsAlive = false;
                    Console.WriteLine("Monster won the fight.");
                }
                if (monster.Health <= -1)
                {
                    monster.IsAlive = false;
                    Console.WriteLine("{0} won the fight", hero.Name);
                }
            }
        }

        public void Attacking(Hero hero, Monster monster)
        {
            if (monster.IsDefending != true)
            {
                if (monster.Attack + 10 >= hero.Armour)
                    monster.IsAttacking = true;
                while (monster.IsAttacking)
                {
                    hero.IsDefending = true;
                    if (monster.PhysicalDamage - hero.Armour >= 0)
                    {
                        hero.Health -= (monster.PhysicalDamage - hero.Armour);
                        Console.WriteLine("Damage done: {0}", monster.PhysicalDamage - hero.Armour);
                    }
                    else Console.WriteLine("Miss");
                    monster.IsAttacking = false;
                    hero.IsDefending = false;
                }
            }
        }

        public void Defending(Hero hero, Monster monster)
        {
            if (monster.IsAttacking != true)
            {
                if (monster.Armour <= hero.PhysicalDamage + 10)
                    monster.IsDefending = true;
                while (monster.IsDefending)
                {
                    hero.IsAttacking = true;
                    if (hero.PhysicalDamage - monster.Armour > 0)
                    {
                        monster.Health -= (hero.PhysicalDamage - monster.Armour);
                        Console.WriteLine("Mosnter health left: {0}", monster.Health);
                    }
                    //else Console.WriteLine("Miss");
                    monster.IsDefending = false;
                    hero.IsAttacking = false;
                }
            }
        }
    }
}
