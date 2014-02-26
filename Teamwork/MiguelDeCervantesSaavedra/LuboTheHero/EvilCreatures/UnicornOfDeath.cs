namespace LuboTheHero.EvilCreatures
{
    public class UnicornOfDeath : Monster
    {
        private const int InitialHealth = 77;
        private const byte InitialPhysicalDamage = 3;
        private const byte InitialSpellDamage = 4;
        private const byte InitialInitiative = 15;
        private const int InitialLineOfSight = 8;

        public UnicornOfDeath(MatrixCoords position, byte attack)
            : base(position, InitialHealth, InitialPhysicalDamage, InitialSpellDamage, InitialInitiative, InitialLineOfSight)
        {
            this.Attack = attack;            
        }
    }
}
