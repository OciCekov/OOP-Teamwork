namespace LuboTheHero.EvilCreatures
{
    public class HellSnake : Monster // ,IPrint, IMove
    {
        public HellSnake(byte attack) : base(30,3,2,1,4)
        {
            this.Attack = attack;
            // TODO Figure out something interesting to be impement as a special power in this, don't have eyes wright now.
            
        }
    }
}
