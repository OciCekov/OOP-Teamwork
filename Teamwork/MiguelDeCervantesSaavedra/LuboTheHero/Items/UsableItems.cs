using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public class UsableItems : Item
    {
        public UsableItems(string name) //za questove
            :base(name, "usableItem")
        { }
    }
}
