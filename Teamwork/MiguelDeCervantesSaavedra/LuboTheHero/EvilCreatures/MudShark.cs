namespace LuboTheHero.EvilCreatures
{
    public class MudShark : Monster
    {
        private const int InitialHealth = 40;
        private const byte InitialPhysicalDamage = 2;
        private const byte InitialSpellDamage = 6;
        private const byte InitialInitiative = 4;
        private const int InitialLineOfSight = 1;

        public MudShark(MatrixCoords position, byte attack)
            : base(position, InitialHealth, InitialPhysicalDamage, InitialSpellDamage, InitialInitiative, InitialLineOfSight)
        {
            this.Attack = attack;            
        }
    }
}
