namespace LuboTheHero.EvilCreatures
{
    public class ViciousFlower : Monster
    {
        private const int InitialHealth = 28;
        private const byte InitialPhysicalDamage = 6;
        private const byte InitialSpellDamage = 4;
        private const byte InitialInitiative = 6;
        private const int InitialLineOfSight = 0;

        public ViciousFlower(MatrixCoords position, byte attack)
            : base(position, InitialHealth, InitialPhysicalDamage, InitialSpellDamage, InitialInitiative, InitialLineOfSight)
        {
            this.Attack = attack;            
        }
    }
}
