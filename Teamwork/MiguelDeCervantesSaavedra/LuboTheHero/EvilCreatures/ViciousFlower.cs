namespace LuboTheHero.EvilCreatures
{
    public class ViciousFlower : Monster
    {
        public ViciousFlower(MatrixCoords position, byte attack)
            : base(position, 28, 6, 4, 6, 0)
        {
            this.Attack = attack;            
        }
    }
}
