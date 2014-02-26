namespace LuboTheHero.Items
{
    using System.Collections.Generic;

    public class StaffWeapon : Weapon
    {
        public StaffWeapon(string name, int minDmg, int maxDmg, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, ItemType.staffWeapon, minDmg, maxDmg, UserClassType.Wizard, requirements)
        { }
    }
}
