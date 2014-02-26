namespace LuboTheHero.EvilCreatures
{
    public class UnicornOfDeath : Monster
    {
        public UnicornOfDeath(MatrixCoords position, byte attack)
            : base(position, 77, 3, 4, 15, 8)
        {
            this.Attack = attack;            
        }
    }
}
