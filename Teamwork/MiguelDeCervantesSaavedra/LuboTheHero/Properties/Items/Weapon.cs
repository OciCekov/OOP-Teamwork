namespace LuboTheHero.Items
{
    using System.Collections.Generic;

    public abstract class Weapon : EquippableItem
    {
        public int MinDamage { get; protected set; }
        public int MaxDamage { get; protected set; }

        public Weapon(string name, ItemType type, int minDmg, int maxDmg, UserClassType classConstr, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, type, classConstr, requirements)
        {
            this.MinDamage = minDmg;
            this.MaxDamage = maxDmg;
        }
    }
}
