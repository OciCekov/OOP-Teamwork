namespace LuboTheHero.EvilCreatures
{
   
    public class ViciousFlower : Monster
    {
        private const int ImageHeight = 4;
        private const int ImageWidth = 7;
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

        #region ViciousFlower image

        private new char[,] ImageMatrix = new char[ImageHeight, ImageWidth]
        {
            {' ', ' ', ' ', '_', ' ', ' ', ' '},
            {' ', '_', '(', ' ', ')', '_', ' '},
            {'(', '_', '(', '%', ')', '_', ')'},
            {' ', ' ', '(', '_', ')', ' ', ' '}

        };

        #endregion
    }
}
