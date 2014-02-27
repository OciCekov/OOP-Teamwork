namespace LuboTheHero.Items
{
    using System.Collections.Generic;

    public class RangedWeapon : Weapon
    {
        public const int IMAGE_HEIGHT = 3;
        public const int IMAGE_WIDTH = 5;

        private char[,] imageMatrix = new char[IMAGE_HEIGHT, IMAGE_WIDTH]
            {
                {' ', ' ', ')', ' ', ' '},
                {'-', '-', '-', '-', '>'},
                {' ',' ', ')', ' ', ' ' },
            };

        public RangedWeapon(string name, int minDmg, int maxDmg, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, ItemType.rangedWeapon, minDmg, maxDmg, UserClassType.Ranger, requirements)
        { }

        public override char[,] GetImage()
        {
            return imageMatrix;
        }
    }
}
