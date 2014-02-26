namespace LuboTheHero.EvilCreatures
{
    public class KillerBiever : Monster
    {
        private const int InitialHealth = 46;
        private const byte InitialPhysicalDamage = 6;
        private const byte InitialSpellDamage = 2;
        private const byte InitialInitiative = 1;
        private const int InitialLineOfSight = 6;

        public KillerBiever(MatrixCoords position, byte attack)
            : base(position, InitialHealth, InitialPhysicalDamage, InitialSpellDamage, InitialInitiative, InitialLineOfSight)
        {
            this.Attack = attack;            
        }
    }
}
