namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    class BodyArmour : Armour
    {
        public const int IMAGE_HEIGHT = 4;
        public const int IMAGE_WIDTH = 7;

        private char[,] imageMatrix = new char[IMAGE_HEIGHT, IMAGE_WIDTH]
            {
                {'_', '_', '/', '=', '\\', '_', '_'},
                {'/','|', 'o', '=', '=', '|', '\\'},
                {' ','|', 'o', '=', '=', '|', ' '},
                {' ','\\', '=', '=', '=', '/', ' '},
            };
        public BodyArmour(string name, int defence, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, ItemType.bodyArmour, defence, UserClassType.Fighter, requirements)
        { }

        public override char[,] GetImage()
        {
            return imageMatrix;
        }
    }
}
