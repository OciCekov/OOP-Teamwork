using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public class RangedWeapon : Weapon
    {
        public RangedWeapon(string name, int minDmg, int maxDmg, List<KeyValuePair<string, uint>> requirements)
            : base(name, "rangedWeapon", minDmg, maxDmg, "Ranger", requirements)
        { }
    }
}
