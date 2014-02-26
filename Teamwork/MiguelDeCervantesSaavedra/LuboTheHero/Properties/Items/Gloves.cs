namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    public class Gloves : Armour
    {
        public Gloves(string name, int defence, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, ItemType.gloves, defence, UserClassType.Ranger, requirements)
        { }
    }
}
