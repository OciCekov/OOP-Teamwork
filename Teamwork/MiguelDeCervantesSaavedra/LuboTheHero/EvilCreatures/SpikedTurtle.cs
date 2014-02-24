namespace LuboTheHero.EvilCreatures
{
    public class SpikedTurtle : Monster  // ,IPrint, IMove
    {
        public SpikedTurtle(byte attack) : base(68,5,9,3,1)
        {
            this.Attack = attack;
            // TODO Figure out something interesting to be impement as a special power in this, don't have eyes wright now.
        }
    }
}
