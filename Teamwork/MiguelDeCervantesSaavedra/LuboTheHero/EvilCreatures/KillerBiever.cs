namespace LuboTheHero.EvilCreatures
{
    public class KillerBiever : Monster // ,IPrint, IMove
    {
        public KillerBiever(byte attack) : base(46,6,2,1,6)
        {
            this.Attack = attack;
            // TODO Figure out something interesting to be impement as a special power in this, don't have eyes wright now.
        }
    }
}
