namespace LuboTheHero.Items
{
    using System.Collections.Generic;

    public class RangedWeapon : Weapon
    {
        public RangedWeapon(string name, int minDmg, int maxDmg, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, ItemType.rangedWeapon, minDmg, maxDmg, UserClassType.Ranger, requirements)
        { }
    }
}
