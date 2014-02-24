using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public class Boots : Armour
    {
        public Boots(string name, int defence, List<KeyValuePair<string, uint>> requirements)
            : base(name, "boots", defence, "all", requirements)
        { }
    }
}
