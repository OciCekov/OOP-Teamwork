namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    public class MeleeWeapon : Weapon
    {
        public MeleeWeapon(string name, int minDmg, int maxDmg, List<KeyValuePair<string, uint>> requirements)
            : base(name, "meleeWeapon", minDmg, maxDmg, "Fighter", requirements)
        { }
    }
}
