namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    public class Boots : Armour
    {
        public Boots(string name, int defence, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, ItemType.boots, defence, UserClassType.All, requirements)
        { }
    }
}
