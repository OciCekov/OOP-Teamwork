namespace LuboTheHero.EvilCreatures
{
    public class SpikedTurtle : Monster
    {
        public SpikedTurtle(MatrixCoords position, byte attack)
            : base(position, 68, 5, 9, 3, 1)
        {
            this.Attack = attack;
        }
    }
}
