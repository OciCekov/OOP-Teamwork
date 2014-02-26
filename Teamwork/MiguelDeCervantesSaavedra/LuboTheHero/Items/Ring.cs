namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    public class Ring : Armour
    {
        public Ring(string name, int defence, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, ItemType.ring, defence, UserClassType.All, requirements)
        { }
    }
}
