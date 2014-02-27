namespace LuboTheHero.Items
{
    public class HealthPotion : Potion
    {
        public const int IMAGE_HEIGHT = 4;
        public const int IMAGE_WIDTH = 5;

        private char[,] imageMatrix = new char[IMAGE_HEIGHT, IMAGE_WIDTH]
            {
                {' ', '\\', '_', '/', ' '},
                {' ', '|', 'H', '|', ' '},
                {'/','H', 'H', 'H', '\\' },
                {'\\','H', 'H', 'H', '/' },
            };

        public HealthPotion(string name, int recoveredHealth)
            : base(name, ItemType.healthPotion, recoveredHealth)
        { }

        public override char[,] GetImage()
        {
            return imageMatrix;
        }
    }
}
