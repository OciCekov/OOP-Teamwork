using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public class Gloves : Armour
    {
        public Gloves(string name, int defence, List<KeyValuePair<string, uint>> requirements)
            : base(name, "gloves", defence, "all", requirements)
        { }
    }
}
