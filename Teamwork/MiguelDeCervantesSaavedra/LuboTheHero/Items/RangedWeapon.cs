namespace LuboTheHero.Items
{
    using System.Collections.Generic;

    public class RangedWeapon : Weapon
    {
        public RangedWeapon(string name, int minDmg, int maxDmg, List<KeyValuePair<string, uint>> requirements)
            : base(name, "rangedWeapon", minDmg, maxDmg, "Ranger", requirements)
        { }
    }
}
