using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    interface ISkillsFighter
    {
        //state properties
        bool UseHeavyArmour { get; set; }
        bool UseOneHanded { get; set; }
        bool UseTwoHanded { get; set; }
        bool UseMediumArmour { get; set; }
        bool UseLightArmour { get; set; }

        //fighter
        byte HeavyArmour { get; set; }
        byte OneHanded { get; set; }
        byte TwoHanded { get; set; }
    }
}
