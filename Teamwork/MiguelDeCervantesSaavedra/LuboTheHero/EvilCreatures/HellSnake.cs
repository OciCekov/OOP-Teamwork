namespace LuboTheHero.EvilCreatures
{
    public class HellSnake : Monster
    {
        private const int InitialHealth = 30;
        private const byte InitialPhysicalDamage = 3;
        private const byte InitialSpellDamage = 2;
        private const byte InitialInitiative = 1;
        private const int InitialLineOfSight = 4;

        public HellSnake(MatrixCoords position, byte attack)
            : base(position, InitialHealth, InitialPhysicalDamage, InitialSpellDamage, InitialInitiative, InitialLineOfSight)
        {
            this.Attack = attack;            
        }
    }
}
