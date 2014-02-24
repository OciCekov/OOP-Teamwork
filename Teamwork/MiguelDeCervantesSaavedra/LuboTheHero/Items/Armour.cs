using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public abstract class Armour : EquippableItem
    {       
        public int defence { get; set; } 

        public Armour(string name, string type, int defence, string classConstr, List<KeyValuePair<string, uint>> requirements) 
            : base(name, "armour", classConstr, requirements)
        {
            this.defence = defence;
            this.Type = type;
        }
    }
}
