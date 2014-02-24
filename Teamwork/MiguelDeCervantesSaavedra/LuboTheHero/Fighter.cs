using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public class Fighter : Hero
    {
        public Fighter(string name)
            : base()
        {
            //abilities
            this.Strenght = 3;
            this.Dexterity = 2;
            this.Inteligence = 1;
            this.Wisdom = 1;

            //stats
            this.Health = 10 + this.Strenght;
            this.Mana = 8 + this.Inteligence;
            this.Attack = (byte)(this.Strenght + 3);
            this.PhysicalDamage = (byte)(1 + this.Strenght); //TODO add item damage
            this.SpellDamage = 0;
            this.ExperiencePoints = 1;
            this.initiative = (byte)(2 + this.Dexterity);
            this.LineOfSight = 2;

            //reduction
            this.Armour = (byte)(2 + this.Dexterity); //plus items worn
            this.Reflex = this.Dexterity;
            this.Vitality = (byte)(1 + this.Strenght);
            this.WillPower = this.Wisdom;
            this.SkillPoints = 2;
            this.SpellPoints = 1;
            this.Level = 1;
            this.Name = name;

            //this.MyInventory = new Inventory();
            //state
            this.IsAlive = true;
        }
    }
}
