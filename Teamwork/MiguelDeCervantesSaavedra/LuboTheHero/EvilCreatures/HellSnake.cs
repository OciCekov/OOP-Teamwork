namespace LuboTheHero.EvilCreatures
{
    public class HellSnake : Monster
    {
        public HellSnake(MatrixCoords position, byte attack)
            : base(position, 30, 3, 2, 1, 4)
        {
            this.Attack = attack;            
        }
    }
}
