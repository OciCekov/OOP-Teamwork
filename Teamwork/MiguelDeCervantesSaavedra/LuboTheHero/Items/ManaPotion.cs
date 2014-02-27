namespace LuboTheHero.Items
{
    public class ManaPotion : Potion
    {
        public const int IMAGE_HEIGHT = 4;
        public const int IMAGE_WIDTH = 5;

        private char[,] imageMatrix = new char[IMAGE_HEIGHT, IMAGE_WIDTH]
            {
                {' ', '\\', '_', '/', ' '},
                {' ', '|', 'M', '|', ' '},
                {'/','M', 'M', 'M', '\\' },
                {'\\','M', 'M', 'M', '/' },
            };
        public ManaPotion(string name, int recoveredMana)
            : base(name, ItemType.manaPotion, recoveredMana)
        { }

        public override char[,] GetImage()
        {
            return imageMatrix;
        }
    }
}
