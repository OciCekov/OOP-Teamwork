namespace LuboTheHero.EvilCreatures
{
    public class BloodHound : Monster
    {
        public BloodHound(MatrixCoords position, byte attack)
            : base(position, 25, 6, 5, 2, 3)
        {
            this.Attack = attack;          
        }
    }
}
