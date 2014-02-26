namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    public class MeleeWeapon : Weapon
    {
        public MeleeWeapon(string name, int minDmg, int maxDmg, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, ItemType.meleeWeapon, minDmg, maxDmg, UserClassType.Fighter, requirements)
        { }
    }
}
