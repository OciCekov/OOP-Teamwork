namespace LuboTheHero.EvilCreatures
{
    public class HellSnake : Monster
    {
        private const int ImageWidth = 8;
        private const int ImageHeight = 3;
        
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
        #region HellSnake image

        private char[,] rightMatrix = new char[ImageHeight, ImageWidth]
        {
            {' ', ' ',  ' ', '_', '_', ' ', ' ', ' '},
            {' ', '_',  '/', 'o', ' ', '\\', '_', '/'},
            {'<', '_',  '_', '_', '_', '/', ' ', '\\'}
        };

        private char[,] leftMatrix = new char[ImageHeight, ImageWidth]
        {
            {' ', ' ', ' ', '_', '_', ' ', ' ', ' '},
            {'\\', '_', '/', ' ', 'o', '\\', '_', '_',},
            {'/', ' ', '\\', '_', '_', '_', '_', '_'}

        };

        #endregion
    }
}
