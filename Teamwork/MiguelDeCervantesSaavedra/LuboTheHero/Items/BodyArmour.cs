using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    class BodyArmour: Armour
    {
        public BodyArmour(string name, int defence, List<KeyValuePair<string, uint>> requirements)
            : base(name, "bodyArmour", defence, "all", requirements)
        { }
    }
}
