using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    interface ICreature
    {
        void Fight(Hero opponent1, Monster opponent2);
        void Attacking(Hero opponent1, Monster opponent2);
        void Defending(Hero opponent1, Monster opponent2);
    }
}
