using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public class Ring : Armour
    {
        public Ring(string name, int defence, List<KeyValuePair<string, uint>> requirements)
            : base(name, "ring", defence, "all", requirements)
        { }
    }
}
