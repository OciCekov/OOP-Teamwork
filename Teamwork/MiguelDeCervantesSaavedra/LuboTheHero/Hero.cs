using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuboTheHero.Items;

namespace LuboTheHero
{
    public class Hero : Creature, ICreature
    {
        public const int returnInitialStateOfDamage = 5; //added by Ivo
        public const int returnInitialStateOfHealth = 5; //added by ivo
        //public Inventory MyInventory { get; set; }
        public List<Spell> Spells { get; protected set; } //added by Ivo
        public List<Item> equippedInventar;
        public List<Item> backpackInventar;

        public static KeyValuePair<string, uint>[] ItemRestrictions = { 
                                                                                new KeyValuePair<string, uint> ("bodyArmour",1),
                                                                                new KeyValuePair<string, uint> ("helmet",1),
                                                                                new KeyValuePair<string, uint> ("boots",1),
                                                                                new KeyValuePair<string, uint> ("gloves",1),
                                                                                new KeyValuePair<string, uint> ("ring",10),
                                                                                new KeyValuePair<string, uint> ("meleeWeapon",2),
                                                                                new KeyValuePair<string, uint> ("rangedWeapon",1),
                                                                                new KeyValuePair<string, uint> ("staffWeapon",1)
                                                                           };


        public List<Item> BackpackInventar
        {
            get { return backpackInventar; }
            set { backpackInventar = value; }
        }

        public List<Item> EquippedInventar
        {
            get { return equippedInventar; }
            set { equippedInventar = value; }
        }

        public Hero()
            : base()
        {
            this.Spells = new List<Spell>(); //added by Ivo
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
            UpdateHero();//added by ivo
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

        public void Equip(EquippableItem itemToEquip)
        {
            int countItemTypeEquipped = 0;

            foreach (var item in EquippedInventar)
            {
                if (item.Type == itemToEquip.Type)
                {
                    countItemTypeEquipped++;
                }
            }

            uint restriction = TypeAllowedNumber(itemToEquip);
            bool meetsRequirements = CheckItemRequiremets(itemToEquip) && CheckClassConstraints(itemToEquip);

            if (countItemTypeEquipped >= restriction)
            {
                Console.WriteLine("This equipment can not be equiped because maximum allowed number of items from this type is reached.");
            }
            else if (!(meetsRequirements))
            {
                Console.WriteLine("This equipment can not be equiped because you don't meet the item requirements.");
            }
            else
            {
                this.equippedInventar.Add(itemToEquip);
            }
        }

        public uint TypeAllowedNumber(Item item)
        {
            foreach (var pair in ItemRestrictions)
            {
                if (pair.Key == item.Type)
                {
                    return pair.Value;
                }
            }

            return uint.MaxValue;
        }

        public bool CheckItemRequiremets(EquippableItem item)
        {
            foreach (var pair in item.Requirements)
            {
                switch (pair.Key)
                {
                    case "Level":
                        if (this.Level < pair.Value)
                            return false;
                        break;
                    case "Stregth":
                        if (this.Strenght < pair.Value)
                            return false;
                        break;
                    case "Dexterity":
                        if (this.Dexterity < pair.Value)
                            return false;
                        break;
                    case "Inteligence":
                        if (this.Inteligence < pair.Value)
                            return false;
                        break;
                    case "Wisdom":
                        if (this.Wisdom < pair.Value)
                            return false;
                        break;
                    default:
                        break;
                }
            }
            return true;
        }

        public bool CheckClassConstraints(EquippableItem item) //moje i bez reflection ako napravim pole heroType v Hero
        {
            return this.GetType().Name == item.ClassConstraint;
        }

        //Added by Ivo, for magig updates, terminates the duration of magic after the next physical attack
        public void UpdateHero()
        {
            foreach (var spell in Spells)
            {
                if (spell is BashSpell && spell.IsCasted == true)
                {
                    spell.Target.PhysicalDamage -= returnInitialStateOfDamage;
                    spell.IsCasted = false;
                }
                if (spell is BloodBurstSpell && spell.IsCasted == true)
                {
                    spell.Target.Health -= returnInitialStateOfHealth;
                    spell.IsCasted = false;
                }
                if (spell is FreezeSpell && spell.IsCasted == true)
                {
                    spell.Target.PhysicalDamage = (byte)FreezeSpell.initialAttackPoints;
                    FreezeSpell.initialAttackPoints = 0;
                    spell.IsCasted = false;
                }
            }
        }

        //added by ivo - heroes cast spells with it.
        public virtual void CastSpell(Creature fighter, Spell spell)
        {
            spell.CastOn(fighter);
        }

    }
}
