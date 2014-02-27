namespace LuboTheHero.Items
{
    public class UsableItems : Item
    {
        public const int IMAGE_HEIGHT = 1;
        public const int IMAGE_WIDTH = 1;

        private char[,] imageMatrix = new char[IMAGE_HEIGHT, IMAGE_WIDTH]
            {
                {'Q'}
            };
        public UsableItems(string name)
            : base(name, ItemType.usableItem)
        { }

        public override char[,] GetImage()
        {
            return imageMatrix;
        }
    }
}
