using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public class MeleeWeapon : Weapon
    {
        public MeleeWeapon(string name, int minDmg, int maxDmg, List<KeyValuePair<string, uint>> requirements)
            : base(name, "meleeWeapon", minDmg, maxDmg, "Fighter", requirements)
        { }
    }
}
