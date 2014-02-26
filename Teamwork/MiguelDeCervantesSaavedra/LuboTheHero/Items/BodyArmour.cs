namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    class BodyArmour : Armour
    {
        public BodyArmour(string name, int defence, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, ItemType.bodyArmour, defence, UserClassType.Fighter, requirements)
        { }
    }
}
