namespace LuboTheHero.EvilCreatures
{
    public class SpikedTurtle : Monster
    {
        private const int InitialHealth = 68;
        private const byte InitialPhysicalDamage = 5;
        private const byte InitialSpellDamage = 9;
        private const byte InitialInitiative = 3;
        private const int InitialLineOfSight = 1;

        public SpikedTurtle(MatrixCoords position, byte attack)
            : base(position, InitialHealth, InitialPhysicalDamage, InitialSpellDamage, InitialInitiative, InitialLineOfSight)
        {
            this.Attack = attack;
        }
    }
}
