using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public class Potion : Item 
    {
        public string SubType { get; set; }
        public int RecoveredValue { get; set; }
        public Potion(string name, int recoveredValue)
            : base(name, "potion")
        {
            this.RecoveredValue = recoveredValue;
        }
    }
}
