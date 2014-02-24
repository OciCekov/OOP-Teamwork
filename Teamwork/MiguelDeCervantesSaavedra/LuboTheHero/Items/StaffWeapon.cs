using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public class StaffWeapon: Weapon
    {
        public StaffWeapon(string name, int minDmg, int maxDmg, List<KeyValuePair<string, uint>> requirements)
            : base(name, "staffWeapon", minDmg, maxDmg, "Wizard", requirements)
        { }
    }
}
