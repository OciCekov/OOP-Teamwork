namespace LuboTheHero.EvilCreatures
{
    public class MudShark : Monster // ,IPrint, IMove
    {
        public MudShark(byte attack) : base(40,2,6,4,1)
        {
            this.Attack = attack;
            // TODO Figure out something interesting to be impement as a special power in this, don't have eyes wright now.
        }
    }
}
