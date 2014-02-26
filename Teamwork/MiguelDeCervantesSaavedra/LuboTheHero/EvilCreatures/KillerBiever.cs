namespace LuboTheHero.EvilCreatures
{
    public class KillerBiever : Monster
    {
        public KillerBiever(MatrixCoords position, byte attack)
            : base(position, 46, 6, 2, 1, 6)
        {
            this.Attack = attack;            
        }
    }
}
