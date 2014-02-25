namespace LuboTheHero.Items
{
    using System.Collections.Generic;

    public abstract class Weapon : EquippableItem
    {
        private int minDamage; // v to string 6te se izpisva Damag: 1-4
        private int maxDamage;

        public Weapon(string name, string type, int minDmg, int maxDmg, string classConstr, List<KeyValuePair<string, uint>> requirements)
            : base(name, "weapon", classConstr, requirements)
        {
            this.minDamage = minDmg;
            this.maxDamage = maxDmg;
            this.Type = type;
        }
    }
}
