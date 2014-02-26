namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    public abstract class Armour : EquippableItem
    {
        public int Defence { get; set; }

        public Armour(string name, ItemType type, int defence, UserClassType classConstr, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, type, classConstr, requirements)
        {
            this.Defence = defence;
        }
    }
}
