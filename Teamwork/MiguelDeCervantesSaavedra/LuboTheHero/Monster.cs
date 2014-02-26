using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public class Monster : Creature, ICreature
    {
        public Monster(MatrixCoords position, int health, byte physicalDamage, byte spellDamge, byte initiative, int lineofSight)
            : base(position, health, physicalDamage, spellDamge, initiative, lineofSight)
        {
            this.LineOfSight = lineofSight;
            this.IsAlive = true;
        }

        public int LineOfSight { get; protected set; } //distance at which a creature can start a fight        

        public override char[,] GetImage()
        {
            throw new NotImplementedException();
        }
    }
}
