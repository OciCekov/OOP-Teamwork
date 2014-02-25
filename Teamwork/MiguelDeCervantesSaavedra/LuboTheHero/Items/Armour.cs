namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    public abstract class Armour : EquippableItem
    {       
        public int Defence { get; set; } 

        public Armour(string name, string type, int defence, string classConstr, List<KeyValuePair<string, uint>> requirements) 
            : base(name, "armour", classConstr, requirements)
        {
            this.Defence = defence;
            this.Type = type;
        }
    }
}
