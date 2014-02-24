namespace LuboTheHero.EvilCreatures
{
    public class UnicornOfDeath : Monster // ,IPrint, IMove
    {
        public UnicornOfDeath(byte attack) : base(77,3,4,15,8)
        {
            this.Attack = attack;
            // TODO Figure out something interesting to be impement as a special power in this, don't have eyes wright now.
        }
    }
}
