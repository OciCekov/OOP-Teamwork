using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public class Helmet: Armour
    {
        public Helmet(string name, int defence, List<KeyValuePair<string, uint>> requirements)
            : base(name, "helmet", defence, "all", requirements)
        { }
    }
}
