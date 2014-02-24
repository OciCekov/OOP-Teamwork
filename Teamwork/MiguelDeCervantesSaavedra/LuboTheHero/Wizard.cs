using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public class Wizard : Hero
    {
        public Wizard(string name)
            : base()
        {
            //abilities
            this.Strenght = 1;
            this.Dexterity = 1;
            this.Inteligence = 3;
            this.Wisdom = 2;

            //stats
            this.Health = 8 + this.Strenght;
            this.Mana = 10 + this.Inteligence;
            this.Attack = (byte)(this.Dexterity + 1);
            this.PhysicalDamage = this.Strenght; //TODO add item damage
            this.SpellDamage = (byte)(1 + this.Inteligence);
            this.ExperiencePoints = 1;

            //reduction
            this.Armour = (byte)(2 + this.Dexterity);
            this.Reflex = this.Dexterity;
            this.Vitality = (byte)(1 + this.Strenght);
            this.WillPower = this.Wisdom;
            this.SkillPoints = 2;
            this.SpellPoints = 1;
            this.Level = 1;
            this.Name = name;
        }
    }
}
