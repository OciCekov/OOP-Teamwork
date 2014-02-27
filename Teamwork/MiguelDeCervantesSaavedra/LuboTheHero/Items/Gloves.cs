namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    public class Gloves : Armour
    {
        public const int IMAGE_HEIGHT = 3;
        public const int IMAGE_WIDTH = 5;

        private char[,] imageMatrix = new char[IMAGE_HEIGHT, IMAGE_WIDTH]
            {
                {' ', '|', '|', '|', '|'},
                {'|', '|', '|', '|', '|'},
                {'\\','_', '_', '_', '/' },
            };
        public Gloves(string name, int defence, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, ItemType.gloves, defence, UserClassType.Ranger, requirements)
        { }

        public override char[,] GetImage()
        {
            return imageMatrix;
        }
    }
}
