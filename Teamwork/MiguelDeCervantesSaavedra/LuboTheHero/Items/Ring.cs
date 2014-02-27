namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    public class Ring : Armour
    {
        public const int IMAGE_HEIGHT = 1;
        public const int IMAGE_WIDTH = 1;

        private char[,] imageMatrix = new char[IMAGE_HEIGHT, IMAGE_WIDTH]
            {
                {'o'}
            };

        public Ring(string name, int defence, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, ItemType.ring, defence, UserClassType.All, requirements)
        { }

        public override char[,] GetImage()
        {
            return imageMatrix;
        }
    }
}
