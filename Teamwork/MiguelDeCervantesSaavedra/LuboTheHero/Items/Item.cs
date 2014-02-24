using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public abstract class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }

        //owner po princip e null no ako nqkoi go digne ownera stava geroq koito go e dignal
        //eventualno price

        public Item(string name, string type)
        {
            this.Name = name;
        }
    }
}
