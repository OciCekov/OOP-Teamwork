namespace LuboTheHero.Items
{
    using System.Collections.Generic;

    public class StaffWeapon: Weapon
    {
        public StaffWeapon(string name, int minDmg, int maxDmg, List<KeyValuePair<string, uint>> requirements)
            : base(name, "staffWeapon", minDmg, maxDmg, "Wizard", requirements)
        { }
    }
}
