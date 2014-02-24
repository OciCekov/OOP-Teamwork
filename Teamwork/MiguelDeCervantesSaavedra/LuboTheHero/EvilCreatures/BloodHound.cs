using System.Runtime.InteropServices;

namespace LuboTheHero.EvilCreatures
{
    public class BloodHound : Monster // ,IPrint, IMove
    {
        public BloodHound(byte attack):base(25,6,5,2,3)
        {
            this.Attack = attack;
          // TODO Figure out something interesting to be impement as a special power in this, don't have eyes wright now.
        }
    }
}
