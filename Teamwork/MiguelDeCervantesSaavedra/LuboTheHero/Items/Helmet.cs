namespace LuboTheHero.Items
{
    using System.Collections.Generic;

    public class Helmet : Armour
    {
        public Helmet(string name, int defence, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, ItemType.helmet, defence, UserClassType.Fighter, requirements)
        { }
    }
}
