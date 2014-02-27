namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    public class Boots : Armour
    {
        public const int IMAGE_HEIGHT = 3;
        public const int IMAGE_WIDTH = 7;

        private char[,] imageMatrix = new char[IMAGE_HEIGHT, IMAGE_WIDTH]
            {
                {' ', ' ', ' ', '|', '|', '|', ' ' },
                {' ', '_', '_', '|', '|', '|', ' ' },
                {'/','_', '_', '_', '_', '_', '\\' },
            };
        public Boots(string name, int defence, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, ItemType.boots, defence, UserClassType.All, requirements)
        { }

        public override char[,] GetImage()
        {
            return imageMatrix;
        }
    }
}
