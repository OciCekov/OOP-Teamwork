namespace LuboTheHero.EvilCreatures
{
    public class MudShark : Monster
    {
        public MudShark(MatrixCoords position, byte attack)
            : base(position, 40, 2, 6, 4, 1)
        {
            this.Attack = attack;            
        }
    }
}
